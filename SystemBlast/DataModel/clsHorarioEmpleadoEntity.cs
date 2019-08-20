using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsHorarioEmpleadoEntity
    {
        public Guid idHorarioEmpleado { get; set; }
        public DateTime fecha { get; set; }
        public string horarioEntrada { get; set; }
        public string horarioSalida { get; set; }
        public Guid idEmpleado { get; set; }

    }

    public partial class clsHorarioEmpleadoEntity
    {
        public virtual clsEmpleadoEntity horarioEmpleadoEntities { get; set; }
    }

    public class clsHorarioEmpleadoEntityMapping : EntityTypeConfiguration<clsHorarioEmpleadoEntity>
    {
        public clsHorarioEmpleadoEntityMapping()
        {
            ToTable("tblHorariosEmpleados");
            HasKey(c => c.idHorarioEmpleado);
            Property(c => c.fecha)
                .IsRequired();
            Property(c => c.horarioEntrada)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(8);
            Property(c => c.horarioSalida)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(8);
        }

    }
}
