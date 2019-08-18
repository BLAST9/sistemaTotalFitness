using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsProductoFacturaEntity
    {
        public Guid idProductoFactura { get; set; }
        public Guid idFactura { get; set; }
        public Guid idProducto { get; set; }
    }

    public partial class clsProductoFacturaEntity
    {
        public virtual clsFacturaEntity productoFacturaEntities { get; set; }
        public virtual clsProductoEntity productoEntities { get; set; }
    }

    public class clsProductoFacturaEntityMapping : EntityTypeConfiguration<clsProductoFacturaEntity>
    {
        public clsProductoFacturaEntityMapping()
        {
            ToTable("tblProductosFacturas");
            HasKey(c => c.idProductoFactura);
        }

    }
}
