using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SystemBlast
{
    public partial class formMenu : Form
    {
        private string estadoCliente;
        private string estadoEmpleado;

        public formMenu()
        {
            InitializeComponent();
            FechaHora.Enabled = true;
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            estadoCliente = "Cerrado";
            estadoEmpleado = "Cerrado";

            btnRegistarCliente.Visible = false;
            btnHorarioCliente.Visible = false;
            btnRegistroEmpleado.Visible = false;
            btnHorarioEmpleado.Visible = false;
            
            btnClientes.Top = 125;
            btnEmpleados.Top = 160;
            btnProductos.Top = 195;
            btnFacturas.Top = 230;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {
                panel1.Visible = false;
                panel1.Width = 200;
                panelAnimator2.ShowSync(panel1);
                logoAnimator.ShowSync(Logo);
                btnMenu.Left = 158;
            }
            else
            {
                logoAnimator.HideSync(Logo);
                panel1.Visible = false;
                panel1.Width = 50;
                panelAnimator.ShowSync(panel1);
                btnMenu.Left = 6;
            }
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            btnControlPrincipal.Visible = true;
        }

        private void lblHora_Click(object sender, EventArgs e) { }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (estadoCliente.Equals("Cerrado"))
            {
                btnRegistarCliente.Visible = true;
                btnHorarioCliente.Visible = true;

                btnClientes.Top = 125;
                btnRegistarCliente.Top = 160;
                btnHorarioCliente.Top = 195;
                btnEmpleados.Top = 230;
                btnProductos.Top = 265;
                btnFacturas.Top = 300;

                if (estadoCliente.Equals("Cerrado") && estadoEmpleado.Equals("Abierto"))
                {
                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnProductos.Top = 335;
                    btnFacturas.Top = 370;
                }
            }

            estadoCliente = "Abierto";
        }

        private void btnClientes_DoubleClick(object sender, EventArgs e)
        {

            if (estadoCliente.Equals("Abierto"))
            {
                btnRegistarCliente.Visible = false;
                btnHorarioCliente.Visible = false;

                btnClientes.Top = 125;
                btnEmpleados.Top = 160;
                btnProductos.Top = 195;
                btnFacturas.Top = 230;

                if (estadoCliente.Equals("Abierto") && estadoEmpleado.Equals("Abierto"))
                {
                    btnRegistarCliente.Visible = false;
                    btnHorarioCliente.Visible = false;

                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnClientes.Top = 125;
                    btnEmpleados.Top = 160;
                    btnRegistroEmpleado.Top = 195; 
                    btnHorarioEmpleado.Top = 230;
                    btnProductos.Top = 265;
                    btnFacturas.Top = 300;
                }
            }

            estadoCliente = "Cerrado";
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            btnControlPrincipal.Visible = false;
            formClientes x = new formClientes();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();

            x.Left = 0;
        }

        private void btnHorarioCliente_Click(object sender, EventArgs e)
        {
            btnControlPrincipal.Visible = false;
            formHorarioCliente x = new formHorarioCliente();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();

            x.Left = 0;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (estadoEmpleado.Equals("Cerrado"))
            {
                btnRegistroEmpleado.Visible = true;
                btnHorarioEmpleado.Visible = true;

                btnClientes.Top = 125;
                btnEmpleados.Top = 160;
                btnRegistroEmpleado.Top = 195;
                btnHorarioEmpleado.Top = 230;
                btnProductos.Top = 265;
                btnFacturas.Top = 300;

                if (estadoEmpleado.Equals("Cerrado") && estadoCliente.Equals("Abierto"))
                {
                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnProductos.Top = 335;
                    btnFacturas.Top = 370;
                }
            }

            estadoEmpleado = "Abierto";
        }

        private void btnEmpleados_DoubleClick(object sender, EventArgs e)
        {

            if (estadoEmpleado.Equals("Abierto"))
            {
                btnRegistroEmpleado.Visible = false;
                btnHorarioEmpleado.Visible = false;

                btnClientes.Top = 125;
                btnEmpleados.Top = 160;
                btnProductos.Top = 195;
                btnFacturas.Top = 230;

                if (estadoEmpleado.Equals("Abierto") && estadoCliente.Equals("Abierto"))
                {
                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroEmpleado.Visible = false;
                    btnHorarioEmpleado.Visible = false;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnProductos.Top = 265;
                    btnFacturas.Top = 300;
                }
            }

            estadoEmpleado = "Cerrado";
        }
    
        private void btnRegistroEmpleado_Click(object sender, EventArgs e)
        {
            btnControlPrincipal.Visible = false;
            formEmpleado x = new formEmpleado();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();

            x.Left = 0;
        }

        private void btnHorarioEmpleado_Click(object sender, EventArgs e)
        {
            btnControlPrincipal.Visible = false;
            formHorarioEmpleado x = new formHorarioEmpleado();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();

            x.Left = 0;
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            btnControlPrincipal.Visible = false;
            formProductos x = new formProductos();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();

            x.Left = 0;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            btnControlPrincipal.Visible = false;
            formFactura x = new formFactura();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();

            x.Left = 0;
        }
    }
}
