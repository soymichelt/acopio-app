using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Acopio.Repository.Entities;
using Acopio.Repository;

namespace Acopio.Business
{

    public class FincaBusiness
    {

        private AcopioDb db;

        public AcopioDb Db { set => db = value; }

        public FincaBusiness(AcopioDb db)
        {

            this.db = db;

        }

        public Finca Create(Finca finca)
        {

            finca.FincaId = Guid.NewGuid();

            db.Fincas.Add(finca);

            return finca;

        }

        public Finca GetById(Guid fincaId) => db.Fincas.Find(fincaId);

        public void Edit(Finca finca)
        {

            var fincaToEdit = this.GetById(finca.FincaId);

            if (fincaToEdit != null)
            {

                fincaToEdit.FincaNombre = finca.FincaNombre;

                fincaToEdit.CantidadVacas = finca.CantidadVacas;

                fincaToEdit.ProductorId = finca.ProductorId;

                fincaToEdit.ComarcaId = finca.ComarcaId;

                this.db.Entry(fincaToEdit).State = System.Data.Entity.EntityState.Modified;

            }

        }

        public void Delete(Guid fincaId)
        {

            var fincaToDelete = this.GetById(fincaId);

            if (fincaToDelete != null)
            {

                this.db.Fincas.Remove(fincaToDelete);

            }

        }

    }

}
