using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acopio.Repository.Entities
{

    public class Acopio
    {

        public Guid AcopioId { get; set; }

        [Key(), Column(Order = 1), ForeignKey("Finca")]
        public Guid FincaId { get; set; }

        public DateTime AcopioFecha { get; set; }

        public decimal CantidadLitros { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal CantidadVacasOrdeñadas { get; set; }


        public virtual Finca Finca { get; set; }

    }

    public class AcopioConfig : EntityTypeConfiguration<Acopio>
    {

        public AcopioConfig()
        {

            this.ToTable("tblAcopios");

            this.HasKey(c => c.AcopioId);

            this.Property(c => c.AcopioFecha)
                .HasColumnType("datetime");

            this.Property(c => c.CantidadLitros)
                .HasColumnType("decimal")
                .HasPrecision(3, 2);

            this.Property(c => c.PrecioUnitario)
                .HasColumnType("decimal")
                .HasPrecision(6, 2);

            this.Property(c => c.CantidadVacasOrdeñadas)
                .HasColumnType("int");

        }

    }

}
