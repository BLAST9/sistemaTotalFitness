using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataModel;

namespace CNegocio
{
    public class clienteNegocio
    {

        public clsClienteEntity ObtenerClientePorId(Guid clienteId)
        {

            var db = new BDModel();

            return db.clientesEntities.Where(c => c.idCliente == clienteId).FirstOrDefault();

        }

        public List<clsClienteEntity> ObtenerClientes()
        {

            var db = new BDModel();

            return db.clientesEntities.ToList();

        }


    }
}
