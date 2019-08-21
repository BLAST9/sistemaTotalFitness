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
    public partial class formClientes : Form
    {
        private string Temp = "Guardar";

        private personRule _personRule;
        private clsClienteEntity _clsCliente;
        public formClientes()
        {
            InitializeComponent();
            this._personRule = new personRule();
            this._clsCliente = new clsClienteEntity();
        }

        private void txtCedula_OnValueChanged(object sender, EventArgs e)
        {
           
            if (Temp.Equals("Guardar"))
            {

                using (var db = new BDModel())
                {
                    var Cedl = db.clientesEntities.Where(c => c.cedula == txtCedula.Text).FirstOrDefault();

                    if (Cedl != null)
                    {
                        MessageBox.Show("Existe un registro con este cedula");
                        btnGuardar.Enabled = false;
                        Temp = "null";
                    }

                    else
                    {
                        if (txtCedula.Text.Length <= 16)
                        {
                            this._clsCliente.cedula = txtCedula.Text;
                        }
                    }
                }

            }

            if (Temp.Equals("Actualizar"))
            {
                txtCedula.Enabled = false;
            }
        }

        private void txtNombres_OnValueChanged(object sender, EventArgs e)
        {
            _clsCliente.nombres = txtNombres.Text;
            this.List();
        }

        private void txtApellidos_OnValueChanged(object sender, EventArgs e)
        {
            _clsCliente.apellidos = txtApellidos.Text;
            this.List();
        }

        private void txtEdad_OnValueChanged(object sender, EventArgs e)
        {
            _clsCliente.edad = txtEdad.Text;
        }

        private void txtTelefono_OnValueChanged(object sender, EventArgs e)
        {
            _clsCliente.telefono = txtTelefono.Text; 
        }

        private Guid idCliente = Guid.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this._personRule.IsValidClienteGuardar(this._clsCliente);

                _personRule.GuardarClientes(this._clsCliente);
                MessageBox.Show("Guardado");
                txtCedula.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";

                txtNombres.Focus();

                lblCedulaError.Text = "";
                lblNombresError.Text = "";
                lblApellidosError.Text = "";

                txtCedula.LineIdleColor = Color.Maroon;
                txtNombres.LineIdleColor = Color.Maroon;
                txtApellidos.LineIdleColor = Color.Maroon;

                this.List();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            DialogResult R = MessageBox.Show("Seguro desea actualizar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._clsCliente.idCliente = this.idCliente;
                txtCedula.Enabled = true;
                this._personRule.IsValidClienteActualizar(this._clsCliente);

                this._personRule.ActualizarClientes(this._clsCliente);
                MessageBox.Show("Actualizado Correctamente");

                txtCedula.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";

                txtNombres.Focus();

                this.List();
                btnGuardar.Enabled = false;
                txtCedula.Enabled = true;
                Temp = "Guardar";

                lblCedulaError.Text = "";
                lblNombresError.Text = "";
                lblApellidosError.Text = "";

                txtCedula.LineIdleColor = Color.Maroon;
                txtNombres.LineIdleColor = Color.Maroon;
                txtApellidos.LineIdleColor = Color.Maroon;
            }

            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtCedula.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtEdad.Text = "";
                    txtTelefono.Text = "";

                    txtNombres.Focus();

                    lblCedulaError.Text = "";
                    lblNombresError.Text = "";
                    lblApellidosError.Text = "";

                    txtCedula.LineIdleColor = Color.Maroon;
                    txtNombres.LineIdleColor = Color.Maroon;
                    txtApellidos.LineIdleColor = Color.Maroon;

                    btnGuardar.Enabled = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Seguro desea eliminar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._clsCliente.idCliente = this.idCliente;

                this._personRule.EliminarClientes(this._clsCliente);
                MessageBox.Show("Eliminado Correctamente");

                txtCedula.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";

                txtNombres.Focus();

                this.List();
                btnGuardar.Enabled = false;
                txtCedula.Enabled = true;
                Temp = "Guardar";

                lblCedulaError.Text = "";
                lblNombresError.Text = "";
                lblApellidosError.Text = "";

                txtCedula.LineIdleColor = Color.Maroon;
                txtNombres.LineIdleColor = Color.Maroon;
                txtApellidos.LineIdleColor = Color.Maroon;
            }

            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtCedula.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtEdad.Text = "";
                    txtTelefono.Text = "";

                    txtNombres.Focus();

                    lblCedulaError.Text = "";
                    lblNombresError.Text = "";
                    lblApellidosError.Text = "";

                    txtCedula.LineIdleColor = Color.Maroon;
                    txtNombres.LineIdleColor = Color.Maroon;
                    txtApellidos.LineIdleColor = Color.Maroon;

                    btnGuardar.Enabled = true;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";

            txtNombres.Focus();

            lblCedulaError.Text = "";
            lblNombresError.Text = "";
            lblApellidosError.Text = "";

            txtCedula.LineIdleColor = Color.Maroon;
            txtNombres.LineIdleColor = Color.Maroon;
            txtApellidos.LineIdleColor = Color.Maroon;

            btnGuardar.Enabled = true;
            txtCedula.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            this.List();
        }
        //llenar datagreetview de clientes
        private void List()
        {
            try
            {
                dtgLlenardatos.DataSource = (from c in _personRule.ListaClientes(txtNombres.Text, txtApellidos.Text) select new { c.idCliente, c.cedula, c.nombres, c.apellidos, c.edad, c.telefono}).ToList();
                dtgLlenardatos.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //Llena caja de texto con informacion de filas del datagreat
        public void llenarDatos()
        {
            this.idCliente = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            txtCedula.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            txtNombres.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
            txtApellidos.Text = dtgLlenardatos.CurrentRow.Cells[3].Value.ToString();
            txtEdad.Text = dtgLlenardatos.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dtgLlenardatos.CurrentRow.Cells[5].Value.ToString();
        }

        private void dtgLlenardatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Temp = "Actualizar";
            this.llenarDatos();
            btnGuardar.Enabled = false;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else e.Handled = true; ;


            if (txtCedula.Text.Length == 16)
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
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


            if (txtNombres.Text.Length == 20)
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
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


            if (txtApellidos.Text.Length == 20)
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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


            if (txtEdad.Text.Length == 2)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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


            if (txtTelefono.Text.Length == 8)
            {
                e.Handled = true;
            }
        }

        private void validarCedula(string cedula)
        {

            if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrEmpty(cedula))
            {
                //Hubo un error en la validación
                txtCedula.LineIdleColor = Color.Black;
                lblCedulaError.Text = "Es necesario insertar cédula";
            }
            else
            {
                //Todo está correcto
                txtCedula.LineIdleColor = Color.Maroon;
                lblCedulaError.Text = "";
            }

        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            this.validarCedula(txtCedula.Text);
        }

        private void validarNombres(string nombres)
        {
            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrEmpty(nombres))
            {
                txtNombres.LineIdleColor = Color.Black;
                lblNombresError.Text = "Es necesario insertar nombres";
            }

            else
            {
                txtNombres.LineIdleColor = Color.Maroon;
                lblNombresError.Text = "";
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            this.validarNombres(txtNombres.Text);
        }

        private void validarApellidos(string apellidos)
        {
            if (string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrEmpty(apellidos))
            {
                txtApellidos.LineIdleColor = Color.Black;
                lblApellidosError.Text = "Es necesario insertar apellidos";
            }

            else
            {
                txtApellidos.LineIdleColor = Color.Maroon;
                lblApellidosError.Text = "";
            }
        }
        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            this.validarApellidos(txtApellidos.Text);
        }
    }
}
