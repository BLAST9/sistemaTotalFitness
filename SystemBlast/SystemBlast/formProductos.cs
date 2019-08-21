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
        private string sumaExistencia = "Abierto";

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
            this.List();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            _productos.nombre = txtNombre.Text;
            this.List();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) || !string.IsNullOrEmpty(txtCantidad.Text))
            {
                _productos.cantidadTotal = Convert.ToInt32(txtCantidad.Text);
            }
            else
            {

                this._productos.cantidadTotal = 0;
            }

            if (sumaExistencia.Equals("Abierto"))
            {
                if (!string.IsNullOrWhiteSpace(txtCantidad.Text) || !string.IsNullOrEmpty(txtCantidad.Text))
                    _productos.cantidadExistencia = Convert.ToInt32(txtCantidad.Text);
                else
                    this._productos.cantidadExistencia = 0;
            }

            else
            {
                if (!string.IsNullOrWhiteSpace(txtCantidadExistencia.Text) || !string.IsNullOrEmpty(txtCantidadExistencia.Text))
                    _productos.cantidadExistencia = int.Parse(txtCantidadExistencia.Text);
                else
                    this._productos.cantidadExistencia = 0;
            }

          
        }
        private void txtCantidadExistencia_TextChanged(object sender, EventArgs e)
        {
            
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
                this._personRule.IsValidProductoGuardar(_productos);

                _personRule.GuardarProducto(this._productos);
                MessageBox.Show("Guardado");

                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtCantidadExistencia.Text = "";
                txtDescripcion.Text = "";
                txtPrecio.Text = "";
                txtNombre.Focus();


                this.List();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            sumaExistencia = "Cerrado";

            DialogResult R = MessageBox.Show("Seguro desea actualizar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._productos.idProducto = this.idProducto;
                this._personRule.IsValidProductoGuardar(_productos);
                this._personRule.sumaActualizarProducto(_productos);
                this._personRule.ActualizarProducto(this._productos);
                MessageBox.Show("Actualizado Correctamente");

                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtDescripcion.Text = "";
                txtCantidadExistencia.Text = "";
                txtPrecio.Text = "";
                txtNombre.Focus();
                this.List();

                btnGuardar.Enabled = true;
            }

            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtNombre.Text = "";
                    txtCantidad.Text = "";
                    txtDescripcion.Text = "";
                    txtCantidadExistencia.Text = "";
                    txtPrecio.Text = "";
                    txtNombre.Focus();
                    this.List();

                    btnGuardar.Enabled = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Seguro desea eliminar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._productos.idProducto = this.idProducto;

                this._personRule.EliminarProducto(this._productos);
                MessageBox.Show("eliminado Correctamente");

                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtDescripcion.Text = "";
                txtCantidadExistencia.Text = "";
                txtPrecio.Text = "";
                txtNombre.Focus();
                this.List();
            }

            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtNombre.Text = "";
                    txtCantidad.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtCantidadExistencia.Text = "";
                    txtNombre.Focus();
                    this.List();

                    btnGuardar.Enabled = true;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtCantidadExistencia.Text = "";
            txtPrecio.Text = "";
            txtNombre.Focus();
            this.List();

            btnGuardar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgLlenardatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sumaExistencia = "Cerrado";
            this.llenarDatos();
            btnGuardar.Enabled = false;
            
        }

        public void llenarDatos()
        {
            this.idProducto = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
            txtCantidad.Text = dtgLlenardatos.CurrentRow.Cells[3].Value.ToString();
            txtCantidadExistencia.Text = dtgLlenardatos.CurrentRow.Cells[4].Value.ToString();
            txtPrecio.Text = dtgLlenardatos.CurrentRow.Cells[5].Value.ToString();
        }

        private void List()
        {
            try
            {
                dtgLlenardatos.DataSource = (from c in _personRule.ListaProducto(txtNombre.Text) select new { c.idProducto, c.nombre, c.descripcion, c.cantidadTotal, c.cantidadExistencia, c.Precio}).ToList();
                dtgLlenardatos.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else e.Handled = true; ;


            if (txtNombre.Text.Length == 15)
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else e.Handled = true; ;


            if (txtCantidad.Text.Length == 5)
            {
                e.Handled = true;
            }
        }

        private void txtCantidadExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else e.Handled = true; ;


            if (txtCantidadExistencia.Text.Length == 5)
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else e.Handled = true; ;


            if (txtDescripcion.Text.Length == 40)
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) || !string.IsNullOrEmpty(txtCantidad.Text))
                _productos.Precio = Convert.ToInt32(txtPrecio.Text);
            else
                this._productos.Precio = 0;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else e.Handled = true; ;


            if (txtPrecio.Text.Length == 5)
            {
                e.Handled = true;
            }
        }
    }
}
