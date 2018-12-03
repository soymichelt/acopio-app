using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity.ModelConfiguration;

namespace Acopio.Repository.Entities
{

    public class Municipio
    {

        public byte MunicipioId { get; set; }

        public string MunicipioNombre { get; set; }

        public byte DepartamentoId { get; set; }

        public Municipio()
        {

            this.Comarcas = new HashSet<Comarca>();

        }

        public virtual ICollection<Comarca> Comarcas { get; set; }

        public virtual Departamento Departamento { get; set; }

    }

    public class MunicipioConfig : EntityTypeConfiguration<Municipio>
    {

        public MunicipioConfig()
        {

            this.ToTable("tblMunicipios");

            this.HasKey(c => c.MunicipioId);

            this.Property(c => c.MunicipioNombre)
                .HasColumnType("varchar")
                .HasMaxLength(35);

        }

    }

}
