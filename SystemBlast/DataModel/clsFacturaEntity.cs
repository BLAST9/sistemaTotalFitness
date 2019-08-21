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
        public DateTime fechaInicio { get; set; }
        public DateTime fechaCierre { get; set; }
        public Guid idCliente { get; set; }
    }

    public partial class clsFacturaEntity
    {
        public clsFacturaEntity()
        {
            this.productoFacturaEntities = new HashSet<clsProductoFacturaEntity>();
        }
        // Se establece relacion de la tabla unica
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
            Property(c => c.fechaInicio)
                .IsRequired();
            Property(c => c.fechaCierre)
                .IsRequired();
        }
    }
}
