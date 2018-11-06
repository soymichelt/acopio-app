using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity.ModelConfiguration;

namespace Acopio.Repository.Entities
{

    public class Productor
    {

        public Guid ProductorId { get; set; }

        public string ProductorCedula { get; set; }

        public string ProductorNombres { get; set; }

        public string ProductorApellidos { get; set; }

        public Productor()
        {

            this.Fincas = new HashSet<Finca>();

        }

        public virtual ICollection<Finca> Fincas { get; set; }

    }

    public class ProductorConfig : EntityTypeConfiguration<Productor>
    {

        public ProductorConfig()
        {

            this.ToTable("tblProductores");

            this.HasKey(c => c.ProductorId);

            this.Property(c => c.ProductorCedula)
                .HasColumnType("varchar")
                .HasMaxLength(16);

            this.Property(c => c.ProductorNombres)
                .HasColumnType("varchar")
                .HasMaxLength(35);

            this.Property(c => c.ProductorApellidos)
                .HasColumnType("varchar")
                .HasMaxLength(35);

        }

    }

}