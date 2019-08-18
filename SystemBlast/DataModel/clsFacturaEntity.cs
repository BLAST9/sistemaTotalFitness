using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsFacturaEntity
    {
        public Guid idFactura { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
        public Guid idCliente { get; set; }
    }

    public partial class clsFacturaEntity
    {
        public clsFacturaEntity()
        {
            this.productoFacturaEntities = new HashSet<clsProductoFacturaEntity>();
        }
        public virtual clsClienteEntity clienteFacturaEntities { get; set; }
        public virtual ICollection<clsProductoFacturaEntity> productoFacturaEntities { get; set; }
    }

    public class clsFacturaEntityMapping : EntityTypeConfiguration<clsFacturaEntity>
    {
        public clsFacturaEntityMapping()
        {
            ToTable("tblFacturas");
            HasKey(c => c.idFactura);
            Property(c => c.fecha)
               .IsRequired();
            Property(c => c.cantidad)
                .IsRequired()
                .HasColumnType("int");
            Property(c => c.precio)
               .IsRequired()
               .HasColumnType("int");
        }
    }
}
