using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity.ModelConfiguration;

namespace Acopio.Repository.Entities
{

    public class Departamento
    {
        
        public byte DepartamentoId { get; set; }
        
        public string DepartamentoNombre { get; set; }

        public Departamento()
        {

            this.Municipios = new HashSet<Municipio>();

        }

        public virtual ICollection<Municipio> Municipios { get; set; }

    }

    public class DepartamentoConfig : EntityTypeConfiguration<Departamento>
    {

        public DepartamentoConfig()
        {

            this.ToTable("tblDepartamentos");

            this.HasKey(c => c.DepartamentoId);

            this.Property(c => c.DepartamentoNombre)
                .HasColumnType("varchar")
                .HasMaxLength(35);

        }

    }

}