using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsTipoEjercicioEntity
    {
        public Guid idTipoEjercicio { get; set; }
        public string tipoEjercicio { get; set; }
        public int Precio { get; set; }

    }

    public partial class clsTipoEjercicioEntity
    {
        public clsTipoEjercicioEntity()
        {
            this.tipoEjerciciosEntities = new HashSet<clsMensualidadEjercicioEntity>();
        }

        public virtual ICollection<clsMensualidadEjercicioEntity> tipoEjerciciosEntities { get; set; }
    }

    public class clsTipoEjercicioEntityMapping : EntityTypeConfiguration<clsTipoEjercicioEntity>
    {
        public clsTipoEjercicioEntityMapping()
        {
            ToTable("tblTiposEjercicios");
            HasKey(c => c.idTipoEjercicio);
            Property(c => c.tipoEjercicio)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);
            Property(c => c.Precio)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
