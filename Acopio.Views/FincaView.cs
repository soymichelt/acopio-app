using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Acopio.Repository;
using Acopio.Repository.Entities;
using Acopio.Business;

namespace Acopio.Views
{
    public partial class FincaView : Form
    {
        public FincaView()
        {
            InitializeComponent();
        }

        #region Para las Transacciones
        private Boolean FincaForEdit = false;
        Finca finca;

        private void Nuevo()
        {

            nombreTextBox.Clear();

            cantidadNumeric.Value = 0;

            productorComboBox.SelectedIndex = -1;

            comarcaComboBox.SelectedIndex = -1;

            this.finca = new Finca();

            this.FincaForEdit = false;

            EliminarButton.Enabled = false;
            
        }
        private Boolean Validar(Finca finca)
        {

            return true;

        }
        private void Guardar(Finca finca)
        {

            if (!Validar(finca))
            {

                using (var db = new AcopioDb())
                {

                    var fincaBusiness = new FincaBusiness(db);

                    fincaBusiness.Create(finca);

                    db.SaveChanges();

                }

            }

        }
        private void Editar(Finca finca)
        {

            if (Validar(finca))
            {

                using (var db = new AcopioDb())
                {

                    var fincaBusiness = new FincaBusiness(db);

                    fincaBusiness.Edit(finca);

                    db.SaveChanges();

                }

            }

        }
        private void GuardarCambios()
        {

            if (this.FincaForEdit)
            {
                this.Guardar(this.finca);
            }
            else
            {
                this.Editar(this.finca);
            }

            this.Nuevo();

        }

        private void Eliminar()
        {

            using (var db = new AcopioDb())
            {

                var fincaBusiness = new FincaBusiness(db);

                fincaBusiness.Delete(finca.FincaId);

                db.SaveChanges();

            }

            this.Nuevo();

        }
        #endregion

        private void NuevoButton_Click(object sender, EventArgs e)
        {

            this.Nuevo();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            this.GuardarCambios();

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

            this.Eliminar();

        }

        private void FincaView_Load(object sender, EventArgs e)
        {

            using (var db = new AcopioDb())
            {

                db.Database.CreateIfNotExists();

            }

        }

    }

}
