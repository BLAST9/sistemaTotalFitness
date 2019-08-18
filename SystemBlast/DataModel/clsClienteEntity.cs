using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsClienteEntity
    {
        public Guid idCliente { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string edad { get; set; }
        public string telefono { get; set; }
    }

    public partial class clsClienteEntity
    {
        public clsClienteEntity()
        {
            this.clienteHorarioentities = new HashSet<clsClienteHorarioEntity>();
            this.clienteMensualidadEntities = new HashSet<clsMensualidadEntity>();
            this.clienteFacturaEntities = new HashSet<clsFacturaEntity>();
        }
        public virtual ICollection<clsClienteHorarioEntity> clienteHorarioentities { get; set; }
        public virtual ICollection<clsMensualidadEntity> clienteMensualidadEntities { get; set; }
        public virtual ICollection<clsFacturaEntity> clienteFacturaEntities { get; set; }
    }

    public class clsClienteEntityMapping : EntityTypeConfiguration<clsClienteEntity>
    {
        public clsClienteEntityMapping()
        {
            ToTable("tblClientes");
            HasKey(c => c.idCliente);
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
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2);
            Property(c => c.telefono)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(9);
        }
    }
}
