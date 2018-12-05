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
    public partial class FincaListView : Form
    {
        public FincaListView()
        {
            InitializeComponent();
        }

        private void FincaToList(string filtro = "")
        {

            using (var db = new AcopioDb())
            {

                var fincaBusiness = new FincaBusiness(db);

                fincasDataGridView.DataSource = fincaBusiness
                    .GetList(filtro)
                    .Select(c => new {
                        c.FincaId,
                        c.FincaNombre,
                        c.Comarca.ComarcaNombre,
                        c.Productor.ProductorCedula,
                        ProductorNombre = c.Productor.ProductorNombres + " " + c.Productor.ProductorApellidos
                    })
                    .ToList();

            }

        }

        private void FincaListView_Load(object sender, EventArgs e)
        {

            this.FincaToList();

        }

        private void edicionFincaButton_Click(object sender, EventArgs e)
        {

            var FincaView = new FincaView();

            FincaView.ShowDialog();

        }

    }

}