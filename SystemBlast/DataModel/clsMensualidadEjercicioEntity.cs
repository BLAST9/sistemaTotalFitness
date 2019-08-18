using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsMensualidadEjercicioEntity
    {
        public Guid idMensualidadEjercicio { get; set; }
        public DateTime fechaPagoMensualidad { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
        public DateTime fechInicio { get; set; }
        public DateTime fechaCierre { get; set; }
        public Guid idMensualidad { get; set; }
        public Guid idTipoEjercicio { get; set; }
    }

    public partial class clsMensualidadEjercicioEntity
    {
        public virtual clsMensualidadEntity mensualidadEjerciciosEntities { get; set; }
        public virtual clsTipoEjercicioEntity tipoEjerciciosEntities { get; set; }
    }

    public class clsMensualidadEjercicioEntityMapping : EntityTypeConfiguration<clsMensualidadEjercicioEntity>
    {
        public clsMensualidadEjercicioEntityMapping()
        {
            ToTable("tblMensualidadEjercicios");
            HasKey(c => c.idMensualidadEjercicio);
            Property(c => c.fechaPagoMensualidad)
               .IsRequired();
            Property(c => c.cantidad)
                .IsRequired()
                .HasColumnType("int");
            Property(c => c.precio)
               .IsRequired()
               .HasColumnType("int");
            Property(c => c.fechInicio)
                .IsRequired();
            Property(c => c.fechaCierre)
               .IsRequired();
        }
    }
}
