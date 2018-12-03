using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity.ModelConfiguration;

namespace Acopio.Repository.Entities
{

    public class Finca
    {

        public Guid FincaId { get; set; }

        public string FincaNombre { get; set; }

        public int CantidadVacas { get; set; }

        public Guid ProductorId { get; set; }

        public int ComarcaId { get; set; }

        public Finca()
        {

            this.Acopios = new HashSet<Acopio>();

        }

        public virtual ICollection<Acopio> Acopios { get; set; }

        public virtual Comarca Comarca { get; set; }

        public virtual Productor Productor { get; set; }

    }

    public class FincaConfig : EntityTypeConfiguration<Finca>
    {

        public FincaConfig()
        {

            this.ToTable("tblFincas");

            this.HasKey(c => c.FincaId);

            this.Property(c => c.FincaNombre)
                .HasColumnType("varchar")
                .HasMaxLength(35);

            this.Property(c => c.CantidadVacas)
                .HasColumnType("int");

        }

    }

}