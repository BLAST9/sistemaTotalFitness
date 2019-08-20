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
    public partial class formHorarioCliente : Form
    {
        private personRule _personRule;
        private clsClienteEntity _clientes;
        private clsHorarioClienteEntity _horarioClientes;
        private clsClienteHorarioEntity _clientesHorarios;

        public formHorarioCliente()
        {
            InitializeComponent();

            _personRule = new personRule();
            _clientes = new clsClienteEntity();
            _horarioClientes = new clsHorarioClienteEntity();
            _clientesHorarios = new clsClienteHorarioEntity();
        }

        Boolean FormLoad = false;

        private void formHorarioCliente_Load(object sender, EventArgs e)
        {
            this.List();
            this.FormLoad = true;
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FormLoad)
            {
                this._clientesHorarios.idCliente = Guid.Parse(cbClientes.SelectedValue.ToString());
            }
        }

        private void txtHoraEntrada_TextChanged(object sender, EventArgs e)
        {
            this._horarioClientes.horarioEntrada = txtHoraEntrada.Text;

        }

        private void dtFecha_onValueChanged(object sender, EventArgs e)
        {
            this._horarioClientes.fecha = dtFecha.Value;
        }
       
        private void txtHoraSalida_TextChanged(object sender, EventArgs e)
        {
            this._horarioClientes.horarioSalida = txtHoraSalida.Text;
        }

        private Guid idHorarioCliente = Guid.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _personRule.GuardarHorariosClientes(this._horarioClientes);

            this._clientesHorarios.idCliente = this._clientesHorarios.idCliente;
            this._clientesHorarios.idHorarioCliente = this._horarioClientes.idHorarioCliente;

            _personRule.GuardarClientesHorarios(this._clientesHorarios);

            MessageBox.Show("Se guardo correctamente");

            cbClientes.Text = "";
            txtHoraEntrada.Text = "";
            txtHoraSalida.Text = "";
            dtFecha.Text = "";

            cbClientes.Focus();

            this.List();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbClientes.Text = "";
            txtHoraEntrada.Text = "";
            txtHoraSalida.Text = "";
            dtFecha.Text = "";

            cbClientes.Focus();

            this.List();
        }

        private void dtgLlenardatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.LlenarDatos();
        }

        private void LlenarDatos()
        {
            this.idHorarioCliente = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            dtFecha.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            txtHoraEntrada.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
            txtHoraSalida.Text = dtgLlenardatos.CurrentRow.Cells[3].Value.ToString();
            cbClientes.Text = dtgLlenardatos.CurrentRow.Cells[4].Value.ToString();
           
            btnGuardar.Enabled = false;
        }

        private void List()
        {
            try
            {

                dtgLlenardatos.DataSource = (from c in _personRule.ListaHorariosClientes() select new { c.idHorarioCliente, c.fecha, c.horaEntrada, c.horaSalida, c.nombres, c.apellidos }).ToList();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
