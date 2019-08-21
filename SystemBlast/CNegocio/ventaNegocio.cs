using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataModel;

namespace CNegocio
{
    public class ventaNegocio
    {

        private clsFacturaEntity _factura;

        public void DatosFactura(clsFacturaEntity factura)
        {
            _factura = factura;
            if (detalles.Count > 0)
            {
                detalles.ForEach(e =>
                    {
                        e.idFactura = factura.idFactura;
                    }
                );
            }
        }

        private List<clsProductoFacturaEntity> detalles = new List<clsProductoFacturaEntity>();

        public void AgregarDetalle(clsProductoFacturaEntity detalle)
        {
            var detalleActual = this.detalles.Where(c => c.idProducto == detalle.idProducto).FirstOrDefault();
            if (detalleActual == null)
            {
                detalleActual = new clsProductoFacturaEntity();
                detalles.Add(detalleActual);
            }
            detalleActual.idProductoFactura = Guid.NewGuid();
            detalleActual.idFactura = _factura.idFactura;
            detalleActual.idProducto = detalle.idProducto;
            detalleActual.cantidad = detalle.cantidad;
            detalleActual.precio = detalle.precio;
        }

        public void Guardar()
        {
            var db = new BDModel();

            db.facturassEntities.Add(_factura);
            db.productosFacturasEntities.AddRange(detalles);
            detalles.ForEach(item =>
            {
                var producto = db.productosEntities.Where(c => c.idProducto == item.idProducto).FirstOrDefault();
                producto.cantidadExistencia = producto.cantidadExistencia - item.cantidad;
                db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
            });
            db.SaveChanges();
            _factura = null;
            detalles = new List<clsProductoFacturaEntity>();
        }

    }
}
