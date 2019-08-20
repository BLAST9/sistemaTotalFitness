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
    public partial class formMensualidad : Form
    {
        private personRule _personRule;
        private clsMensualidadEntity _mensualidad;

        public formMensualidad()
        {
            InitializeComponent();

            _personRule = new personRule();
            _mensualidad = new clsMensualidadEntity();
        }

        Boolean FormLoad = false;

        private void formMensualidad_Load(object sender, EventArgs e)
        {

            this.List();
            cbClientes.Text = "";
            this.FormLoad = true;
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FormLoad)
            {
                _mensualidad.idCliente = Guid.Parse(cbClientes.SelectedValue.ToString());
            }
        }

        private void dtFechaInicio_onValueChanged(object sender, EventArgs e)
        {
            _mensualidad.fechaInicio = dtFechaInicio.Value;
        }

        private void dtFechaCierre_onValueChanged(object sender, EventArgs e)
        {
            _mensualidad.fechaCierre = dtFechaCierre.Value;
        }

        private Guid idMensualidad = Guid.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbClientes.Text == "")
            {
                MessageBox.Show("Es necesario ingresar un cliente");
            }

            else
            {
                try
                {
                   // _personRule.IsValidHorarioEmpleadoGuardar(this._horariosEmpleados);
                    _personRule.GuardarMensualidad(this._mensualidad);

                    MessageBox.Show("Se guardo correctamente");

                    cbClientes.Text = "";
                    cbClientes.Focus();

                    this.List();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbClientes.Text = "";
            cbClientes.Focus();

            this.List();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgLlenardatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.LlenarDatos();
        }

        private void LlenarDatos()
        {
            this.idMensualidad = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            cbClientes.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            dtFechaInicio.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
            dtFechaCierre.Text = dtgLlenardatos.CurrentRow.Cells[3].Value.ToString();
            btnGuardar.Enabled = false;
        }

        private void List()
        {
            try
            {

                dtgLlenardatos.DataSource = (from c in _personRule.ListaMensualidad() select new { c.idMensualidad, c.Nombres, c.Apellidos, c.fechaInicio, c.fechaCierre }).ToList();
                dtgLlenardatos.Columns[0].Visible = false;

                cbClientes.DataSource = (from c in _personRule.ListaClientes("", "") select new { Id = c.idCliente, Nombres = c.nombres + " " + c.apellidos }).ToList();
                cbClientes.ValueMember = "Id";
                cbClientes.DisplayMember = "Nombres";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
