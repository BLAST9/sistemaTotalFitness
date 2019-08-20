using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsEmpleadoEntity
    {
        public Guid idEmpleado { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string edad { get; set; }
        public string telefono { get; set; }
        public string cargo { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string turno { get; set; }
    }

    public partial class clsEmpleadoEntity
    {
        public clsEmpleadoEntity()
        {
            this.horarioEmpleadoEntities = new HashSet<clsHorarioEmpleadoEntity>();
        }
        public virtual ICollection<clsHorarioEmpleadoEntity> horarioEmpleadoEntities { get; set; }

    }

    public class clsEmpleadoEntityMapping : EntityTypeConfiguration<clsEmpleadoEntity>
    {
        public clsEmpleadoEntityMapping()
        {
            ToTable("tblEmpleados");
            HasKey(c => c.idEmpleado);
            Property(c => c.cedula)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(16);
            Property(c => c.nombres)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);
            Property(c => c.apellidos)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);
            Property(c => c.edad)
                .HasColumnType("varchar")
                .HasMaxLength(10);
            Property(c => c.telefono)
                .HasColumnType("varchar")
                .HasMaxLength(10);
            Property(c => c.cargo)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(15);
            Property(c => c.nombreUsuario)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(10);
            Property(c => c.contraseña)
                .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(8); 
            Property(c => c.turno)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(10)
               .HasMaxLength(10);
        }
    }
}
