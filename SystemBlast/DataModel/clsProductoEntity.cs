using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class clsProductoEntity
    {
        public Guid idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int cantidadTotal { get; set; }
        public int cantidadExistencia { get; set; }
        public int Precio { get; set; }
    }
    public partial class clsProductoEntity
    {
        public clsProductoEntity()
        {
            this.productoEntities = new HashSet<clsProductoFacturaEntity>();
        }
        public virtual ICollection<clsProductoFacturaEntity> productoEntities { get; set; }
    }

    public class clsProductoEntityMapping : EntityTypeConfiguration<clsProductoEntity>
    {
        public clsProductoEntityMapping()
        {
            ToTable("tblProductos");
            HasKey(c => c.idProducto);
            Property(c => c.nombre)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(15); 
            Property(c => c.descripcion)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(40);
            Property(c => c.cantidadTotal)
                .IsRequired()
                .HasColumnType("int");
            Property(c => c.cantidadExistencia)
               .IsRequired()
               .HasColumnType("int");
            Property(c => c.cantidadExistencia)
               .IsRequired()
               .HasColumnType("int");
        }
    }
}
