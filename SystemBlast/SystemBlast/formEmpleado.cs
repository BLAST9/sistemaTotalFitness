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
    public partial class formEmpleado : Form
    {
        private string Temp = "Guardar";

        private personRule _personRule;
        private clsEmpleadoEntity _Empleados;

        public formEmpleado()
        {
            InitializeComponent();

            _personRule = new personRule();
            _Empleados = new clsEmpleadoEntity();
        }

        private void formEmpleado_Load(object sender, EventArgs e)
        {
            this.List();
        }

        private void txtCedula_OnValueChanged(object sender, EventArgs e)
        {

            if (Temp.Equals("Guardar"))
            {

                using (var db = new BDModel())
                {
                    var Cedl = db.empleadosEntities.Where(c => c.cedula == txtCedula.Text).FirstOrDefault();

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
                            this._Empleados.cedula = txtCedula.Text;
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
            _Empleados.nombres = txtNombres.Text;
            this.List();
        }

        private void txtApellidos_OnValueChanged(object sender, EventArgs e)
        {
            _Empleados.apellidos = txtApellidos.Text;
            this.List();
        }

        private void txtEdad_OnValueChanged(object sender, EventArgs e)
        {
            _Empleados.edad = txtEdad.Text;
        }

        private void txtTelefono_OnValueChanged(object sender, EventArgs e)
        {
            _Empleados.telefono = txtTelefono.Text;
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Empleados.cargo = cbCargo.Text;
            this.List();
        }

        private void cbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Empleados.turno = cbTurno.Text;
            this.List();
        }

        private void txtUsuario_OnValueChanged(object sender, EventArgs e)
        {
            _Empleados.nombreUsuario = txtUsuario.Text;
        }

        private void txtContraseña_OnValueChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length <= 8)
            {
                _Empleados.contraseña = txtContraseña.Text;
            }
        
        }

        private Guid idEmpleado = Guid.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this._personRule.IsValidEmpleadoGuardar(this._Empleados);

                _personRule.GuardarEmpleado(this._Empleados);
                MessageBox.Show("Guardado");
                txtCedula.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
                cbCargo.Text = "";
                cbTurno.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Text = "";

                txtNombres.Focus();

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
                this._Empleados.idEmpleado = this.idEmpleado;
                txtCedula.Enabled = true;
                this._personRule.IsValidEmpleadoActualizar(this._Empleados);

                this._personRule.ActualizarEmpleados(this._Empleados);
                MessageBox.Show("Actualizado Correctamente");

                txtCedula.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
                cbCargo.Text = "";
                cbTurno.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Text = "";

                txtNombres.Focus();

                this.List();
                btnGuardar.Enabled = false;
                txtCedula.Enabled = true;
                Temp = "Guardar";

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
                    cbCargo.Text = "";
                    cbTurno.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Text = "";

                    txtNombres.Focus();
                    btnGuardar.Enabled = true;

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Seguro desea eliminar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._Empleados.idEmpleado = this.idEmpleado;
                txtCedula.Enabled = true;
                this._personRule.IsValidEmpleadoActualizar(this._Empleados);

                this._personRule.EliminarEmpelados(this._Empleados);
                MessageBox.Show("Eliminado Correctamente");

                txtCedula.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
                cbCargo.Text = "";
                cbTurno.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Text = "";

                txtNombres.Focus();

                this.List();
                btnGuardar.Enabled = true;
                txtCedula.Enabled = true;
                Temp = "Guardar";

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
                    cbCargo.Text = "";
                    cbTurno.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Text = "";

                    txtNombres.Focus();
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
            cbCargo.Text = "";
            cbTurno.Text = "";
            txtContraseña.Text = "";
            txtUsuario.Text = "";

            txtNombres.Focus();

            btnGuardar.Enabled = true;
            txtCedula.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void List()
        {
            try
            {
                dtgLlenardatos.DataSource = (from c in _personRule.ListaEmpleados(txtNombres.Text, txtApellidos.Text, cbCargo.Text, cbTurno.Text) select new { c.idEmpleado, c.cedula, c.nombres, c.apellidos, c.edad, c.telefono, c.cargo, c.turno, c.nombreUsuario, c.contraseña }).ToList();
                dtgLlenardatos.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void llenarDatos()
        {
           this.idEmpleado = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            txtCedula.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            txtNombres.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
            txtApellidos.Text = dtgLlenardatos.CurrentRow.Cells[3].Value.ToString();
            txtEdad.Text = dtgLlenardatos.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dtgLlenardatos.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = dtgLlenardatos.CurrentRow.Cells[6].Value.ToString();
            cbTurno.Text = dtgLlenardatos.CurrentRow.Cells[7].Value.ToString();
            txtUsuario.Text = dtgLlenardatos.CurrentRow.Cells[8].Value.ToString();
            txtContraseña.Text = dtgLlenardatos.CurrentRow.Cells[9].Value.ToString();
        }


        private void dtgLlenardatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Temp = "Actualizar";
            this.llenarDatos();
            btnGuardar.Enabled = false;
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


            if (txtTelefono.Text.Length == 9)
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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


            if (txtUsuario.Text.Length == 20)
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtContraseña.Text.Length == 8)
            {
                e.Handled = true;
            }
        }

        
    }
}
