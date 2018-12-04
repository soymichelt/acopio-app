using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

using Acopio.Repository;
using Acopio.Repository.Entities;

namespace Acopio.Business
{
    public class ProductorBusiness
    {

        private AcopioDb db;

        public AcopioDb Db { set => db = value; }

        public ProductorBusiness(AcopioDb db)
        {

            this.db = db;

        }

        public List<Productor> ToList(Expression<Func<Productor, bool>> where = null)
        {
            if (where != null)
            {
                return db.Productores
                    .Where(where)
                    .Select(c => c)
                    .ToList();
            }
            else
            {

                return db.Productores
                    .Select(c => c)
                    .ToList();
            }

        }

    }
}
