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
    public partial class formProductos : Form
    {
        private personRule _personRule;
        private clsProductoEntity _productos;

        public formProductos()
        {
            InitializeComponent();

            _personRule = new personRule();
            _productos = new clsProductoEntity();
        }

        private void formProductos_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            _productos.nombre = txtNombre.Text;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) || !string.IsNullOrEmpty(txtCantidad.Text))
                _productos.cantidadTotal = Convert.ToInt32(txtCantidad.Text);
            else
                this._productos.cantidadTotal = 0;

            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) || !string.IsNullOrEmpty(txtCantidad.Text))
                _productos.cantidadExistencia = Convert.ToInt32(txtCantidad.Text);
            else
                this._productos.cantidadExistencia = 0;
        }

        private void txtCantidadExistencia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) || !string.IsNullOrEmpty(txtCantidad.Text))
                _productos.cantidadExistencia =+ Convert.ToInt32(txtCantidad.Text);
            else
                this._productos.cantidadExistencia = 0;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            _productos.descripcion = txtDescripcion.Text;
        }

        private Guid idProducto = Guid.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //this._personRule.IsValidEmpleadoGuardar(this._Empleados);

                _personRule.GuardarProducto(this._productos);
                MessageBox.Show("Guardado");

                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtCantidadExistencia.Text = "";
                txtDescripcion.Text = "";

                txtNombre.Focus();


                //this.List();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
