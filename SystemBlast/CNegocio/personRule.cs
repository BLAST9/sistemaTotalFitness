using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace CNegocio
{
    public class personRule
    {
        public clsEmpleadoEntity ValidacionUsuario(string Usuario, string Contraseña)
        {
            using (var db = new BDModel())
            {
                var x = db.empleadosEntities.Where(c => c.nombreUsuario.Equals(Usuario) && c.contraseña.Equals(Contraseña)).FirstOrDefault();

                return x;
            }
        }

        //Consultas de la tabla de cliente

        public void IsValidClienteGuardar(clsClienteEntity cliente)
        {

            if (cliente == null)
            {

                throw new Exception("es necesario ingresar los datos de uncliente");

            }

            if (string.IsNullOrWhiteSpace(cliente.cedula) || string.IsNullOrEmpty(cliente.cedula))
            {

                throw new Exception(" es necesario ingresar cédula");

            }
            if (string.IsNullOrWhiteSpace(cliente.nombres) || string.IsNullOrEmpty(cliente.nombres))
            {

                throw new Exception("es necesario ingresar nombres");

            }
            if (string.IsNullOrWhiteSpace(cliente.apellidos) || string.IsNullOrEmpty(cliente.apellidos))
            {

                throw new Exception("es necesario ingresar apellidos");

            }

            if (string.IsNullOrWhiteSpace(cliente.edad) || string.IsNullOrEmpty(cliente.edad))
            {
                cliente.edad = "--";
            }

            if (string.IsNullOrWhiteSpace(cliente.telefono) || string.IsNullOrEmpty(cliente.telefono))
            {
                cliente.telefono = "---------";
            }
        }
       
        public Guid GuardarClientes(clsClienteEntity Clientes)
        {
            using (var db = new BDModel()) //Creamos un objeto de BDModel para acceder a los atributos de la clase clsClientesEntity 
            {
                try
                {
                    Clientes.idCliente = Guid.NewGuid(); //Agregamos un identigicador guid es un tipo de dato cadena compuesto por numeros y texto
                    db.clientesEntities.Add(Clientes); //A la entidad en si le estamos pasando o agregando por parametros todos los datos en uno es como una agrupacion de datos
                    db.SaveChanges(); //Guardamos los cambios
                }
                catch (Exception e)
                {
                    e.ToString(); //Muestra un mensaje si ocurre un error
                }
                return Clientes.idCliente; //Retornamos un nuevo dato agregado a la BD
            }

        }

        public List<clsClienteEntity> ListaClientes(string Nombres, string Apellidos)
        {
            using (var db = new BDModel())
            {
                //Las dos opciones cumplen con la misma funcion lo unico que cambia es la sintaxis de la consulta

                //Forma numero 1
                //var Clientes = db.ClientesEntities.Where(c => /*Aqui va una expresión bool*/ (c.PrimerNombre + " " + c.SegundoNombre).StartsWith(nombres)).ToList();


                //Forma numero2
                var Clientes = (from c in db.clientesEntities //Seleccionamo la tabla
                                where (c.nombres).StartsWith(Nombres) && (c.apellidos).StartsWith(Apellidos) //Le decimos que nos filte por nombre y apellido de un orden izquierda a derecha de las letras que se vallan escribiendo
                                select c).ToList(); //Creamos la lista

                return Clientes;

            }
        }

        public void IsValidClienteActualizar(clsClienteEntity cliente)
        {

            if (cliente == null)
            {
                throw new Exception("es necesario ingresar los datos de uncliente");
            }

            if (string.IsNullOrWhiteSpace(cliente.nombres) || string.IsNullOrEmpty(cliente.nombres))
            {
                throw new Exception("es necesario ingresar nombres");
            }

            if (string.IsNullOrWhiteSpace(cliente.apellidos) || string.IsNullOrEmpty(cliente.apellidos))
            {
                throw new Exception("es necesario ingresar apellidos");
            }

            if (string.IsNullOrWhiteSpace(cliente.edad) || string.IsNullOrEmpty(cliente.edad))
            {
                cliente.edad = "--";
            }

            if (string.IsNullOrWhiteSpace(cliente.telefono) || string.IsNullOrEmpty(cliente.telefono))
            {
                cliente.telefono = "---------";
            }
        }

        public void ActualizarClientes(clsClienteEntity Clientes)
        {
            using (var db = new BDModel())
            {
                var p = db.clientesEntities.Where(c => c.idCliente == Clientes.idCliente).FirstOrDefault(); //Recorremos la BD si el dato existe

                if (p != null)
                {
                    p.nombres = Clientes.nombres; //Indicamos que al nombre de la BD lo reemplace por el que le estoy pasando por parametro
                    p.apellidos = Clientes.apellidos;
                    p.edad = Clientes.edad;
                    p.telefono = Clientes.telefono;
                   

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified; //Decimos que la consulta de tipo modificacion
                    db.SaveChanges(); //Guardamos los cambios
                }
            }
        }

        public void EliminarClientes(clsClienteEntity Clientes)
        {
            using (var db = new BDModel())
            {
                var p = db.clientesEntities.Where(c => c.idCliente == Clientes.idCliente).FirstOrDefault(); //Creamos una consulta para comparar si el dato existe que lo elimine

                if (p != null) //Verificamos si es diferente de null existe un dato en la bd
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted; //Definimos una consulta de tipo remover para elimninar los datos
                    db.SaveChanges(); //Guardamos los cambios
                }
            }
        }

        //Consultas cliente horarios
        public Guid GuardarClientesHorarios(clsClienteHorarioEntity ClientesH)
        {
            using (var db = new BDModel()) 
            {
                try
                {
                    ClientesH.idClienteHorario = Guid.NewGuid(); 
                    db.clientesHorariosEntities.Add(ClientesH);
                    db.SaveChanges(); 
                }
                catch (Exception e)
                {
                    e.ToString(); 
                }
                return ClientesH.idClienteHorario;
            }

        }

        public void ActualizarClientesHorarios(clsClienteHorarioEntity ClientesH)
        {
            using (var db = new BDModel())
            {
                var p = db.clientesHorariosEntities.Where(c => c.idClienteHorario == ClientesH.idClienteHorario).FirstOrDefault(); 

                if (p != null)
                {
                    p.idHorarioCliente = ClientesH.idClienteHorario; 
                    p.idCliente = ClientesH.idCliente;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified; 
                    db.SaveChanges();
                }
            }
        }

        public void EliminarClientesHorario(clsClienteHorarioEntity ClientesH)
        {
            using (var db = new BDModel())
            {
                var p = db.clientesHorariosEntities.Where(c => c.idClienteHorario == ClientesH.idClienteHorario).FirstOrDefault(); 

                if (p != null) 
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted; 
                    db.SaveChanges(); 
                }
            }
        }

        //Consulta Empleados

        public void IsValidEmpleadoGuardar(clsEmpleadoEntity empleado)
        {

            if (empleado == null)
            {

                throw new Exception("es necesario ingresar los datos de uncliente");

            }

            if (string.IsNullOrWhiteSpace(empleado.cedula) || string.IsNullOrEmpty(empleado.cedula))
            {

                throw new Exception(" es necesario ingresar cédula");

            }

            if (string.IsNullOrWhiteSpace(empleado.nombres) || string.IsNullOrEmpty(empleado.nombres))
            {

                throw new Exception("es necesario ingresar nombres");

            }

            if (string.IsNullOrWhiteSpace(empleado.apellidos) || string.IsNullOrEmpty(empleado.apellidos))
            {

                throw new Exception("es necesario ingresar apellidos");

            }

            if (string.IsNullOrWhiteSpace(empleado.cargo) || string.IsNullOrEmpty(empleado.cargo))
            {

                throw new Exception("es necesario ingresar cargo");

            }

            if (string.IsNullOrWhiteSpace(empleado.turno) || string.IsNullOrEmpty(empleado.turno))
            {

                throw new Exception("es necesario ingresar turno");

            }

            if (string.IsNullOrWhiteSpace(empleado.nombreUsuario) || string.IsNullOrEmpty(empleado.nombreUsuario))
            {

                throw new Exception("es necesario ingresar nombre de usuario");

            }

            if (string.IsNullOrWhiteSpace(empleado.contraseña) || string.IsNullOrEmpty(empleado.contraseña))
            {

                throw new Exception("es necesario ingresar contraseña");

            }

            if (string.IsNullOrWhiteSpace(empleado.edad) || string.IsNullOrEmpty(empleado.edad))
            {
                empleado.edad = "--";
            }

            if (string.IsNullOrWhiteSpace(empleado.telefono) || string.IsNullOrEmpty(empleado.telefono))
            {
                empleado.telefono = "---------";
            }
        }

        public Guid GuardarEmpleado(clsEmpleadoEntity Empleado)
        {
            using (var db = new BDModel())
            {
                try
                {
                    Empleado.idEmpleado = Guid.NewGuid();
                    db.empleadosEntities.Add(Empleado);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                return Empleado.idEmpleado;
            }

        }
        public List<clsEmpleadoEntity> ListaEmpleados(string Nombres, string Apellidos, string Cargo, string Turno)
        {
            using (var db = new BDModel())
            {
              
                var Empleados = (from c in db.empleadosEntities 
                                where (c.nombres).StartsWith(Nombres) && (c.apellidos).StartsWith(Apellidos) && (c.cargo).StartsWith(Cargo) && (c.turno).StartsWith(Turno)
                                 select c).ToList(); 

                return Empleados;

            }
        }

        public void IsValidEmpleadoActualizar(clsEmpleadoEntity empleado)
        {

            if (empleado == null)
            {

                throw new Exception("es necesario ingresar los datos de uncliente");

            }

            if (string.IsNullOrWhiteSpace(empleado.nombres) || string.IsNullOrEmpty(empleado.nombres))
            {

                throw new Exception("es necesario ingresar nombres");

            }

            if (string.IsNullOrWhiteSpace(empleado.apellidos) || string.IsNullOrEmpty(empleado.apellidos))
            {

                throw new Exception("es necesario ingresar apellidos");

            }

            if (string.IsNullOrWhiteSpace(empleado.cargo) || string.IsNullOrEmpty(empleado.cargo))
            {

                throw new Exception("es necesario ingresar cargo");

            }

            if (string.IsNullOrWhiteSpace(empleado.turno) || string.IsNullOrEmpty(empleado.turno))
            {

                throw new Exception("es necesario ingresar turno");

            }

            if (string.IsNullOrWhiteSpace(empleado.nombreUsuario) || string.IsNullOrEmpty(empleado.nombreUsuario))
            {

                throw new Exception("es necesario ingresar nombre de usuario");

            }

            if (string.IsNullOrWhiteSpace(empleado.contraseña) || string.IsNullOrEmpty(empleado.contraseña))
            {

                throw new Exception("es necesario ingresar contraseña");

            }

            if (string.IsNullOrWhiteSpace(empleado.edad) || string.IsNullOrEmpty(empleado.edad))
            {
                empleado.edad = "--";
            }

            if (string.IsNullOrWhiteSpace(empleado.telefono) || string.IsNullOrEmpty(empleado.telefono))
            {
                empleado.telefono = "---------";
            }
        }

        public void ActualizarEmpleados(clsEmpleadoEntity Empleados)
        {
            using (var db = new BDModel())
            {
                var p = db.empleadosEntities.Where(c => c.idEmpleado == Empleados.idEmpleado).FirstOrDefault();

                if (p != null)
                {
                    p.nombres = Empleados.nombres;
                    p.apellidos = Empleados.apellidos;
                    p.telefono = Empleados.telefono;
                    p.edad = Empleados.edad;
                    p.cargo = Empleados.cargo;
                    p.nombreUsuario = Empleados.nombreUsuario;
                    p.contraseña = Empleados.contraseña;
                    p.turno = Empleados.turno;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarEmpelados(clsEmpleadoEntity Empleados)
        {
            using (var db = new BDModel())
            {
                var p = db.empleadosEntities.Where(c => c.idEmpleado == Empleados.idEmpleado).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

        //Consulta Factura

        public Guid GuardarFactura(clsFacturaEntity Factura)
        {
            using (var db = new BDModel())
            {
                try
                {
                    Factura.idFactura = Guid.NewGuid();
                    db.facturassEntities.Add(Factura);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                return Factura.idFactura;
            }

        }
        public List<clsFacturaEntity> ListaFactura(DateTime Fecha)
        {
            using (var db = new BDModel())
            {

                var Factura = (from c in db.facturassEntities
                                 where (c.fecha == Fecha)
                                 select c).ToList();

                return Factura;

            }
        }

        public void ActualizarFactura(clsFacturaEntity Factura)
        {
            using (var db = new BDModel())
            {
                var p = db.facturassEntities.Where(c => c.idFactura == Factura.idFactura).FirstOrDefault();

                if (p != null)
                {
                    p.cantidad = Factura.cantidad;
                    p.precio = Factura.precio;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarFactura(clsFacturaEntity Factura)
        {
            using (var db = new BDModel())
            {
                var p = db.facturassEntities.Where(c => c.idFactura == Factura.idFactura).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

        //Consulta HorariosClientes

        public Guid GuardarHorariosClientes(clsHorarioClienteEntity Horario)
        {
            using (var db = new BDModel())
            {
                try
                {
                    Horario.idHorarioCliente = Guid.NewGuid();
                    db.horariosClientesEntities.Add(Horario);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                return Horario.idHorarioCliente;
            }

        }
        public List<clsHorarioClienteEntity > ListaHorariosClientes(DateTime Fecha)
        {
            using (var db = new BDModel())
            {

                var Horariocliente = (from c in db.horariosClientesEntities
                               where (c.fecha == Fecha)
                               select c).ToList();

                return Horariocliente;

            }
        }

        public void ActualizarHorariosClientes(clsHorarioClienteEntity Horario)
        {
            using (var db = new BDModel())
            {
                var p = db.horariosClientesEntities.Where(c => c.idHorarioCliente == Horario.idHorarioCliente).FirstOrDefault();

                if (p != null)
                {
                    p.horarioSalida = Horario.horarioSalida;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarHorariosClientes(clsHorarioClienteEntity Horario)
        {
            using (var db = new BDModel())
            {
                var p = db.horariosClientesEntities.Where(c => c.idHorarioCliente == Horario.idHorarioCliente).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

        //Consulta HorariosEmpleado

        public Guid GuardarHorariosEmpleado(clsHorarioEmpleadoEntity Horario)
        {
            using (var db = new BDModel())
            {
                try
                {
                    Horario.idHorarioEmpleado = Guid.NewGuid();
                    db.horariosEmpleadosEntities.Add(Horario);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                return Horario.idHorarioEmpleado;
            }

        }
        public List<clsHorarioEmpleadoEntity> ListaHorariosEmpleado(DateTime Fecha)
        {
            using (var db = new BDModel())
            {

                var Horarioempleado = (from c in db.horariosEmpleadosEntities
                                      where (c.fecha == Fecha)
                                      select c).ToList();

                return Horarioempleado;

            }
        }

        public void ActualizarHorariosEmpleado(clsHorarioEmpleadoEntity Horario)
        {
            using (var db = new BDModel())
            {
                var p = db.horariosEmpleadosEntities.Where(c => c.idHorarioEmpleado == Horario.idHorarioEmpleado).FirstOrDefault();

                if (p != null)
                {
                    p.horarioEntrada = Horario.horarioEntrada;
                    p.horarioSalida = Horario.horarioSalida;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarHorariosEmpleados(clsHorarioEmpleadoEntity Horario)
        {
            using (var db = new BDModel())
            {
                var p = db.horariosEmpleadosEntities.Where(c => c.idHorarioEmpleado == Horario.idHorarioEmpleado).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

        //Consulta Mensualidad

        public Guid GuardarMensualidad(clsMensualidadEntity Men)
        {
            using (var db = new BDModel())
            {
                try
                {
                    Men.idMensualidad = Guid.NewGuid();
                    db.mensualidadesEntities.Add(Men);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                return Men.idMensualidad;
            }

        }

        public void ActualizarMensualidad(clsMensualidadEntity Men)
        {
            using (var db = new BDModel())
            {
                var p = db.mensualidadesEntities.Where(c => c.idMensualidad == Men.idMensualidad).FirstOrDefault();

                if (p != null)
                {
                    p.fechaInicio = Men.fechaInicio;
                    p.fechaCierre = Men.fechaCierre;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarMensualidad(clsMensualidadEntity Men)
        {
            using (var db = new BDModel())
            {
                var p = db.mensualidadesEntities.Where(c => c.idMensualidad == Men.idMensualidad).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

        //Consulta Producto

        public Guid GuardarProducto(clsProductoEntity Producto)
        {
            using (var db = new BDModel())
            {
                try
                {
                    Producto.idProducto = Guid.NewGuid();
                    db.productosEntities.Add(Producto);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                return Producto.idProducto;
            }

        }
        public List<clsProductoEntity> ListaProducto(string Nombre)
        {
            using (var db = new BDModel())
            {

                var Producto = (from c in db.productosEntities
                                 where (c.nombre).StartsWith(Nombre) 
                                 select c).ToList();

                return Producto;

            }
        }

        public void ActualizarProducto(clsProductoEntity Producto)
        {
            using (var db = new BDModel())
            {
                var p = db.productosEntities.Where(c => c.idProducto == Producto.idProducto).FirstOrDefault();

                if (p != null)
                {
                    p.nombre = Producto.nombre;
                    p.descripcion = Producto.descripcion;
                    p.cantidadTotal = Producto.cantidadTotal;
                    p.cantidadExistencia = Producto.cantidadExistencia;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarProducto(clsProductoEntity Producto)
        {
            using (var db = new BDModel())
            {
                var p = db.productosEntities.Where(c => c.idProducto == Producto.idProducto).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }


        //Consulta ProductoFacturas

        public Guid GuardarProductoFacturas(clsProductoFacturaEntity ProductoFac)
        {
            using (var db = new BDModel())
            {
                try
                {
                    ProductoFac.idProductoFactura = Guid.NewGuid();
                    db.productosFacturasEntities.Add(ProductoFac);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                return ProductoFac.idProductoFactura;
            }

        }

        public void ActualizarProductoFacturas(clsProductoFacturaEntity ProductoFac)
        {
            using (var db = new BDModel())
            {
                var p = db.productosFacturasEntities.Where(c => c.idProductoFactura == ProductoFac.idProductoFactura).FirstOrDefault();

                if (p != null)
                {
                    p.idFactura = ProductoFac.idFactura;
                    p.idProducto = ProductoFac.idProducto;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarProductoFacturas(clsProductoFacturaEntity ProductoFac)
        {
            using (var db = new BDModel())
            {
                var p = db.productosFacturasEntities.Where(c => c.idProductoFactura == ProductoFac.idProductoFactura).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

        //Consulta TipoEjercicio

        public Guid GuardarTipoEjercicio(clsTipoEjercicioEntity tipoejer)
        {
            using (var db = new BDModel())
            {
                try
                {
                    tipoejer.idTipoEjercicio = Guid.NewGuid();
                    db.tiposEjerciciosEntities.Add(tipoejer);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                return tipoejer.idTipoEjercicio;
            }

        }
        public List<clsTipoEjercicioEntity> ListaTipoEjercicio(string Ejercicio)
        {
            using (var db = new BDModel())
            {

                var Tipoe = (from c in db.tiposEjerciciosEntities
                                where (c.tipoEjercicio).StartsWith(Ejercicio)
                                select c).ToList();

                return Tipoe;

            }
        }

        public void ActualizarTipoEjercicio(clsTipoEjercicioEntity tipoejer)
        {
            using (var db = new BDModel())
            {
                var p = db.tiposEjerciciosEntities.Where(c => c.idTipoEjercicio == tipoejer.idTipoEjercicio).FirstOrDefault();

                if (p != null)
                {
                    p.tipoEjercicio = tipoejer.tipoEjercicio;
                    p.Precio = tipoejer.Precio;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarTipoEjercicio(clsTipoEjercicioEntity tipoejer)
        {
            using (var db = new BDModel())
            {
                var p = db.tiposEjerciciosEntities.Where(c => c.idTipoEjercicio == tipoejer.idTipoEjercicio).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

    }
}
