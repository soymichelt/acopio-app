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

        private Boolean formIsLoaded;

        public FincaView()
        {
            InitializeComponent();
        }

        #region Para las Transacciones
        private Boolean FincaForEdit = false;
        Finca finca = new Finca();

        private Boolean Validar(Finca finca)
        {

            return true;

        }
        private void Guardar(Finca finca)
        {

            if (Validar(finca))
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
        private void GuardarCambios()
        {

            if (!this.FincaForEdit)
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

        private void ComarcaToList()
        {

            using (var db = new AcopioDb())
            {

                var comarcaBusiness = new ComarcaBusiness(db);

                comarcaComboBox.DataSource = comarcaBusiness.ToList();

                comarcaComboBox.ValueMember = "ComarcaId";

                comarcaComboBox.DisplayMember = "ComarcaNombre";

                comarcaComboBox.SelectedIndex = -1;

            }

        }

        private void ProductorToList()
        {

            using (var db = new AcopioDb())
            {

                var productorBusiness = new ProductorBusiness(db);

                productorComboBox.DataSource = (from p in productorBusiness.ToList() select new { p.ProductorId, ProductorNombre = $"{ p.ProductorNombres } { p.ProductorApellidos }" }).ToList();

                productorComboBox.ValueMember = "ProductorId";

                productorComboBox.DisplayMember = "ProductorNombre";

                productorComboBox.SelectedIndex = -1;

            }

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

            ComarcaToList();

            ProductorToList();

            this.formIsLoaded = true;

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!nombreTextBox.Text.Equals(this.finca.FincaNombre))
            {

                this.finca.FincaNombre = nombreTextBox.Text;

            }

        }

        private void cantidadNumeric_ValueChanged(object sender, EventArgs e)
        {

            if (!cantidadNumeric.Value.Equals(this.finca.CantidadVacas))
            {

                this.finca.CantidadVacas = int.Parse(cantidadNumeric.Value.ToString());

            }

        }

        private void productorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.formIsLoaded)
            {

                if (productorComboBox.SelectedIndex != -1)
                {

                    Guid productorId = Guid.Parse(productorComboBox.SelectedValue.ToString());

                    if (!productorId.Equals(this.finca.ProductorId))
                    {

                        this.finca.ProductorId = productorId;

                    }

                }

            }

        }

        private void comarcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.formIsLoaded)
            {

                if (comarcaComboBox.SelectedIndex != -1)
                {

                    int comarcaId = int.Parse(comarcaComboBox.SelectedValue.ToString());

                    if (!comarcaId.Equals(this.finca.ComarcaId))
                    {

                        this.finca.ComarcaId = comarcaId;

                    }

                }

            }

        }

    }

}