using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsHorarioClienteEntity
    {
        public Guid idHorarioCliente { get; set; }
        public DateTime fecha { get; set; }
        public string horarioEntrada { get; set; }
        public string horarioSalida { get; set; }
    }


    public partial class clsHorarioClienteEntity
    {
        public clsHorarioClienteEntity()
        {
            this.horarioClienteEntities = new HashSet<clsClienteHorarioEntity>();
        }
        public virtual ICollection<clsClienteHorarioEntity> horarioClienteEntities { get; set; }
    }

    public class clsHorarioClienteEntityMapping : EntityTypeConfiguration<clsHorarioClienteEntity>
    {
        public clsHorarioClienteEntityMapping()
        {
            ToTable("tblHorariosClientes");
            HasKey(c => c.idHorarioCliente);
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
