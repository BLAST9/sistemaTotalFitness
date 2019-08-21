using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataModel;
using CNegocio;

namespace SystemBlast
{
    public partial class formFactura : Form
    {

        clienteNegocio clienteNegocio = new clienteNegocio();

        productoNegocio productoNegocio = new productoNegocio();

        ventaNegocio ventaNegocio = new ventaNegocio();

        public formFactura()
        {
            InitializeComponent();
        }

        private bool isLoaded = false;

        private void formFactura_Load(object sender, EventArgs e)
        {

            try
            {
                this.CargarDatosEnGrid();

                cbCliente.DataSource = (from cliente in clienteNegocio.ObtenerClientes() select new { cliente.idCliente, nombre = $"{cliente.nombres} {cliente.apellidos}" }).ToList();
                cbCliente.ValueMember = "idCliente";
                cbCliente.DisplayMember = "nombre";

                cbProductos.DataSource = (from producto in productoNegocio.ObtenerProductos() select new { producto.idProducto, producto.nombre }).ToList();
                cbProductos.ValueMember = "idProducto";
                cbProductos.DisplayMember = "nombre";

                isLoaded = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private Nullable<Guid> productoId = null;

        class DetalleFactura
        {

            public Guid ProductoId { get; set; }

            public string Nombre { get; set; }

            public int Precio { get; set; }

            public int Cantidad { get; set; }

            public int Total
            {
                get
                {
                    return Precio * Cantidad;
                }
            }

        }

        private List<DetalleFactura> detalles = new List<DetalleFactura>();

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isLoaded)
            {
                try
                {

                    if (cbProductos.SelectedValue != null && cbProductos.SelectedIndex != -1)
                    {
                        productoId = Guid.Parse(cbProductos.SelectedValue.ToString());
                        var producto = productoNegocio.ObtenerProductoPorId(productoId.Value);
                        txtPrecio.Text = producto.Precio.ToString("#, ##0.00");
                        txtCantidad.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void AgregarDetalle()
        {

            try
            {

                var producto = productoNegocio.ObtenerProductoPorId(productoId.Value);

                if (producto != null)
                {

                    var detalleActual = detalles.Where(c => c.ProductoId == productoId.Value).FirstOrDefault();

                    if (detalleActual == null)
                    {
                        detalleActual = new DetalleFactura();
                        detalles.Add(detalleActual);
                    }

                    detalleActual.ProductoId = producto.idProducto;
                    detalleActual.Nombre = producto.nombre;
                    detalleActual.Precio = producto.Precio;
                    detalleActual.Cantidad = int.Parse(txtCantidad.Text);

                    CargarDatosEnGrid();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void CargarDatosEnGrid()
        {
            dtgLlenardatos.DataSource = detalles.ToList();
            dtgLlenardatos.Columns[0].Visible = false;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCantidad.Text.Trim() != "")
                {
                    this.AgregarDetalle();
                    txtCantidad.Clear();
                    txtPrecio.Clear();
                    cbProductos.SelectedIndex = -1;
                    cbProductos.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                var factura = new clsFacturaEntity();
                factura.idFactura = Guid.NewGuid();
                factura.fecha = dtFecha.Value;
                factura.fechaInicio = dtFechaInicio.Value;
                factura.fechaCierre = dtFechaCierre.Value;
                factura.idCliente = Guid.Parse(cbCliente.SelectedValue.ToString());

                ventaNegocio.DatosFactura(factura);

                this.detalles.ForEach(
                    item => {
                        var det = new clsProductoFacturaEntity();
                        det.idProducto = item.ProductoId;
                        det.cantidad = item.Cantidad;
                        det.precio = item.Precio;
                        ventaNegocio.AgregarDetalle(det);
                    }
                );

                ventaNegocio.Guardar();

                //limpiar
                dtFecha.Value = DateTime.Now;
                dtFechaInicio.Value = DateTime.Now;
                dtFechaCierre.Value = DateTime.Now;
                detalles = new List<DetalleFactura>();
                CargarDatosEnGrid();

                MessageBox.Show("Facturado correctamente!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
