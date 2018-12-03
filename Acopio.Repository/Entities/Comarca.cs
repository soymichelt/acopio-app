using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity.ModelConfiguration;

namespace Acopio.Repository.Entities
{

    public class Comarca
    {

        public int ComarcaId { get; set; }

        public string ComarcaNombre { get; set; }

        public byte MunicipioId { get; set; }

        public Comarca()
        {

            this.Acopios = new HashSet<Acopio>();

        }

        public virtual ICollection<Acopio> Acopios { get; set; }

        public virtual Municipio Municipio { get; set; }


    }

    public class ComarcaConfig : EntityTypeConfiguration<Comarca>
    {

        public ComarcaConfig()
        {

            this.ToTable("tblComarcas");

            this.HasKey(c => c.ComarcaId);

            this.Property(c => c.ComarcaNombre)
                .HasColumnType("varchar")
                .HasMaxLength(35);

        }

    }

}