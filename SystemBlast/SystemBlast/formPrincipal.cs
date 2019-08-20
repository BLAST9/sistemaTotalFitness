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
    public partial class formPrincipal : Form
    {
        private personRule _personRule;
        private clsEmpleadoEntity _empleado;

        public formPrincipal()
        {
            InitializeComponent();

            _personRule = new personRule();
            _empleado = new clsEmpleadoEntity();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            this.ValidarUsuario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }

            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.ValidarUsuario();
                txtUsuario.Focus();
            }
        }

        public void ValidarUsuario()
        {
           /* var x = _personRule.ValidacionUsuario(txtUsuario.Text, txtContraseña.Text);

             if (x != null)
             {
                */this.Visible = false;
                formMenu y = new formMenu();
                y.ShowDialog();
                this.Visible = true;
             /*}

             else
             {
                 MessageBox.Show("Usuario o contraseña incorrecto");
             }
             */
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtUsuario.Focus();
        }

    }
}
