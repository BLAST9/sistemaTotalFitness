using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataModel;

namespace CNegocio
{

    public class productoNegocio
    {

        public clsProductoEntity ObtenerProductoPorId(Guid productoId)
        {

            var db = new BDModel();

            return db.productosEntities.Where(c => c.idProducto == productoId).FirstOrDefault();

        }

        public List<clsProductoEntity> ObtenerProductos()
        {

            var db = new BDModel();

            return db.productosEntities.ToList();

        }
        

    }

}
