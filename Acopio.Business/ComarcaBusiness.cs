using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

using Acopio.Repository;
using Acopio.Repository.Entities;

namespace Acopio.Business
{

    public class ComarcaBusiness
    {

        private AcopioDb db;

        public AcopioDb Db { set => db = value; }

        public ComarcaBusiness(AcopioDb db)
        {

            this.db = db;

        }

        public List<Comarca> ToList(Expression<Func<Comarca, bool>> where = null)
        {
            if (where != null)
            {
                return db.Comarcas
                    .Where(where)
                    .Select(c => c)
                    .ToList();
            }
            else
            {

                return db.Comarcas
                    .Select(c => c)
                    .ToList();
            }

        }

    }

}
