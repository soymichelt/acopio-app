using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;

using Acopio.Repository.Entities;

namespace Acopio.Repository
{

    public class AcopioDb : DbContext
    {

        public AcopioDb() :
            base ("")
        { }

        public DbSet<Acopio.Repository.Entities.Acopio> Acopios { get; set; }

        public DbSet<Comarca> Comarcas { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Finca> Fincas { get; set; }

        public DbSet<Municipio> Municipios { get; set; }

        public DbSet<Productor> Productores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new AcopioConfig());

            modelBuilder.Configurations.Add(new ComarcaConfig());

            modelBuilder.Configurations.Add(new DepartamentoConfig());

            modelBuilder.Configurations.Add(new FincaConfig());

            modelBuilder.Configurations.Add(new MunicipioConfig());

            modelBuilder.Configurations.Add(new ProductorConfig());

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);

        }

    }

}
