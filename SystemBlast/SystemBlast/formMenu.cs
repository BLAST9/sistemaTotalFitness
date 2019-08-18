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
        private string estadoMensualidad;

        public formMenu()
        {
            InitializeComponent();
            FechaHora.Enabled = true;
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            estadoCliente = "Cerrado";
            estadoEmpleado = "Cerrado";
            estadoMensualidad = "Cerrado";

            btnRegistarCliente.Visible = false;
            btnHorarioCliente.Visible = false;
            btnRegistroEmpleado.Visible = false;
            btnHorarioEmpleado.Visible = false;
            btnRegistroMensualidad.Visible = false;
            btnMensualidadEjercicio.Visible = false;
            btnTipoEjercicio.Visible = false;
            
            btnClientes.Top = 125;
            btnEmpleados.Top = 160;
            btnMensualidad.Top = 195;
            btnProductos.Top = 230;
            btnFacturas.Top = 265;
            btnExtras.Top = 300;
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
                btnMensualidad.Top = 265;
                btnProductos.Top = 300;
                btnFacturas.Top = 335;
                btnExtras.Top = 370;

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
                    btnMensualidad.Top = 335;
                    btnProductos.Top = 370;
                    btnFacturas.Top = 405;
                    btnExtras.Top = 440;
                }

                if (estadoCliente.Equals("Cerrado") && estadoEmpleado.Equals("Cerrado") && estadoMensualidad.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = false;
                    btnHorarioEmpleado.Visible = false;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnMensualidad.Top = 265;
                    btnRegistroMensualidad.Top = 300;
                    btnMensualidadEjercicio.Top = 335;
                    btnTipoEjercicio.Top = 370;
                    btnProductos.Top = 405;
                    btnFacturas.Top = 440;
                    btnExtras.Top = 475;
                }

                if (estadoCliente.Equals("Cerrado") && estadoEmpleado.Equals("Abierto") && estadoMensualidad.Equals("Cerrado"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = false;
                    btnMensualidadEjercicio.Visible = false;
                    btnTipoEjercicio.Visible = false;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnProductos.Top = 370;
                    btnFacturas.Top = 405;
                    btnExtras.Top = 440;
                }

                if (estadoCliente.Equals("Cerrado") && estadoEmpleado.Equals("Abierto") && estadoMensualidad.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnRegistroMensualidad.Top = 370;
                    btnMensualidadEjercicio.Top = 405;
                    btnTipoEjercicio.Top = 440;
                    btnProductos.Top = 475;
                    btnFacturas.Top = 510;
                    btnExtras.Top = 545;
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
                btnMensualidad.Top = 195;
                btnProductos.Top = 230;
                btnFacturas.Top = 265;
                btnExtras.Top = 300;

                if (estadoCliente.Equals("Abierto") && estadoEmpleado.Equals("Cerrado") && estadoMensualidad.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = false;
                    btnHorarioEmpleado.Visible = false;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnMensualidad.Top = 265;
                    btnRegistroMensualidad.Top = 300;
                    btnMensualidadEjercicio.Top = 335;
                    btnTipoEjercicio.Top = 370;
                    btnProductos.Top = 405;
                    btnFacturas.Top = 440;
                    btnExtras.Top = 475;
                }

                if (estadoCliente.Equals("Abierto") && estadoEmpleado.Equals("Abierto") && estadoMensualidad.Equals("Cerrado"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = false;
                    btnMensualidadEjercicio.Visible = false;
                    btnTipoEjercicio.Visible = false;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnProductos.Top = 370;
                    btnFacturas.Top = 405;
                    btnExtras.Top = 440;
                }

                if (estadoCliente.Equals("Abierto") && estadoEmpleado.Equals("Abierto") && estadoMensualidad.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnRegistroMensualidad.Top = 370;
                    btnMensualidadEjercicio.Top = 405;
                    btnTipoEjercicio.Top = 440;
                    btnProductos.Top = 475;
                    btnFacturas.Top = 510;
                    btnExtras.Top = 545;
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
                btnMensualidad.Top = 265;
                btnProductos.Top = 300;
                btnFacturas.Top = 335;
                btnExtras.Top = 370;

                if (estadoEmpleado.Equals("Cerrado") && estadoCliente.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnProductos.Top = 370;
                    btnFacturas.Top = 405;
                    btnExtras.Top = 440;

                    
                }

                if (estadoEmpleado.Equals("Cerrado") && estadoCliente.Equals("Cerrado") && estadoMensualidad.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = false;
                    btnHorarioCliente.Visible = false;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnEmpleados.Top = 160;
                    btnRegistroEmpleado.Top = 195;
                    btnHorarioEmpleado.Top = 230;
                    btnMensualidad.Top = 265;
                    btnRegistroMensualidad.Top = 300;
                    btnMensualidadEjercicio.Top = 335;
                    btnTipoEjercicio.Top = 370;
                    btnProductos.Top = 405;
                    btnFacturas.Top = 440;
                    btnExtras.Top = 475;
                }

                if (estadoEmpleado.Equals("Cerrado") && estadoCliente.Equals("Abierto") && estadoMensualidad.Equals("Cerrado"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = false;
                    btnMensualidadEjercicio.Visible = false;
                    btnTipoEjercicio.Visible = false;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnProductos.Top = 370;
                    btnFacturas.Top = 405;
                    btnExtras.Top = 440;
                }

                if (estadoEmpleado.Equals("Cerrado") && estadoCliente.Equals("Abierto") && estadoMensualidad.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnRegistroMensualidad.Top = 370;
                    btnMensualidadEjercicio.Top = 405;
                    btnTipoEjercicio.Top = 440;
                    btnProductos.Top = 475;
                    btnFacturas.Top = 510;
                    btnExtras.Top = 545;
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
                btnMensualidad.Top = 195;
                btnProductos.Top = 230;
                btnFacturas.Top = 265;
                btnExtras.Top = 300;

                if (estadoCliente.Equals("Abierto") && estadoEmpleado.Equals("Abierto"))
                {
                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroEmpleado.Visible = false;
                    btnHorarioEmpleado.Visible = false;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnMensualidad.Top = 265;
                    btnProductos.Top = 295;
                    btnFacturas.Top = 320;
                    btnExtras.Top = 365;
                }
            }

            estadoEmpleado = "Cerrado";
        }
    
        private void btnRegistroEmpleado_Click(object sender, EventArgs e)
        {
            btnControlPrincipal.Visible = false;
            formHorarioEmpleado x = new formHorarioEmpleado();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();

            x.Left = 0;
        }

        private void btnHorarioEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnMensualidad_Click(object sender, EventArgs e)
        {
            if (estadoMensualidad.Equals("Cerrado"))
            {
                btnRegistroMensualidad.Visible = true;
                btnMensualidadEjercicio.Visible = true;
                btnTipoEjercicio.Visible = true;

                btnClientes.Top = 125;
                btnEmpleados.Top = 160;
                btnMensualidad.Top = 195;
                btnRegistroMensualidad.Top = 230;
                btnMensualidadEjercicio.Top = 265;
                btnTipoEjercicio.Top = 300;
                btnProductos.Top = 335;
                btnFacturas.Top = 370;
                btnExtras.Top = 405;

                if (estadoMensualidad.Equals("Cerrado") && estadoCliente.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnProductos.Top = 370;
                    btnFacturas.Top = 405;
                    btnExtras.Top = 440;


                }

                if (estadoMensualidad.Equals("Cerrado") && estadoCliente.Equals("Cerrado") && estadoEmpleado.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = false;
                    btnHorarioCliente.Visible = false;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnEmpleados.Top = 160;
                    btnRegistroEmpleado.Top = 195;
                    btnHorarioEmpleado.Top = 230;
                    btnMensualidad.Top = 265;
                    btnRegistroMensualidad.Top = 300;
                    btnMensualidadEjercicio.Top = 335;
                    btnTipoEjercicio.Top = 370;
                    btnProductos.Top = 405;
                    btnFacturas.Top = 440;
                    btnExtras.Top = 475;
                }

                if (estadoMensualidad.Equals("Cerrado") && estadoCliente.Equals("Abierto") && estadoEmpleado.Equals("Cerrado"))
                {
                    btnRegistroEmpleado.Visible = false;
                    btnHorarioEmpleado.Visible = false;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnMensualidad.Top = 265;
                    btnRegistroMensualidad.Top = 300;
                    btnMensualidadEjercicio.Top = 335;
                    btnTipoEjercicio.Top = 370;
                    btnProductos.Top = 405;
                    btnFacturas.Top = 440;
                    btnExtras.Top = 475;
                }

                if (estadoMensualidad.Equals("Cerrado") && estadoCliente.Equals("Abierto") && estadoEmpleado.Equals("Abierto"))
                {
                    btnRegistroEmpleado.Visible = true;
                    btnHorarioEmpleado.Visible = true;

                    btnRegistarCliente.Visible = true;
                    btnHorarioCliente.Visible = true;

                    btnRegistroMensualidad.Visible = true;
                    btnMensualidadEjercicio.Visible = true;
                    btnTipoEjercicio.Visible = true;

                    btnClientes.Top = 125;
                    btnRegistarCliente.Top = 160;
                    btnHorarioCliente.Top = 195;
                    btnEmpleados.Top = 230;
                    btnRegistroEmpleado.Top = 265;
                    btnHorarioEmpleado.Top = 300;
                    btnMensualidad.Top = 335;
                    btnRegistroMensualidad.Top = 370;
                    btnMensualidadEjercicio.Top = 405;
                    btnTipoEjercicio.Top = 440;
                    btnProductos.Top = 475;
                    btnFacturas.Top = 510;
                    btnExtras.Top = 545;
                }
            }

            estadoMensualidad = "Abierto";
        }

        private void btnMensualidad_DoubleClick(object sender, EventArgs e)
        {
            if (estadoMensualidad.Equals("Abierto"))
            {
                btnRegistroMensualidad.Visible = false;
                btnMensualidadEjercicio.Visible = false;
                btnTipoEjercicio.Visible = false;

                btnClientes.Top = 125;
                btnEmpleados.Top = 160;
                btnMensualidad.Top = 195;
                btnProductos.Top = 230;
                btnFacturas.Top = 265;
                btnExtras.Top = 300;
            }

            estadoMensualidad = "Abierto";
        }

        private void btnRegistroMensualidad_Click(object sender, EventArgs e)
        {

        }

        private void btnMensualidadEjercicio_Click(object sender, EventArgs e)
        {

        }

        private void btnTipoEjercicio_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {

        }

        private void btnExtras_Click(object sender, EventArgs e)
        {

        }
    }
}
