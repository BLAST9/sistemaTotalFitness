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
    public partial class formHorarioEmpleado : Form
    {
        private personRule _personRule;
        private clsHorarioEmpleadoEntity _horariosEmpleados;

        public formHorarioEmpleado()
        {
            InitializeComponent();

            _personRule = new personRule();
            _horariosEmpleados = new clsHorarioEmpleadoEntity();
        }

        Boolean FormLoad = false;

        private void formHorarioEmpleado_Load(object sender, EventArgs e)
        {
            this.List();
            cbEmpleado.Text = "";
            this.FormLoad = true;
            
        }
        // Seleccionar el ID de empleado
        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FormLoad)
            {
                _horariosEmpleados.idEmpleado = Guid.Parse(cbEmpleado.SelectedValue.ToString());
            }
           
        }
        private void dtFecha_onValueChanged(object sender, EventArgs e)
        {
            _horariosEmpleados.fecha = dtFecha.Value;
        }

        private void txtHoraEntrada_TextChanged(object sender, EventArgs e)
        {
            _horariosEmpleados.horarioEntrada = txtHoraEntrada.Text;
        }

        private void txtHoraSalida_TextChanged(object sender, EventArgs e)
        {
            _horariosEmpleados.horarioSalida = txtHoraSalida.Text;
        }

        private Guid idHorarioEmpleado = Guid.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbEmpleado.Text == "")
            {
                MessageBox.Show("Es necesario ingresar un empleado");
            }

            else
            {
                try
                {
                    _personRule.IsValidHorarioEmpleadoGuardar(this._horariosEmpleados);
                    _personRule.GuardarHorariosEmpleado(this._horariosEmpleados);

                    MessageBox.Show("Se guardo correctamente");

                    txtHoraEntrada.Text = "";
                    txtHoraSalida.Text = "";
                    dtFecha.Text = "";

                    cbEmpleado.Focus();

                    this.List();
                    cbEmpleado.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Seguro desea eliminar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._horariosEmpleados.idHorarioEmpleado = this.idHorarioEmpleado;

                this._personRule.EliminarHorariosEmpleados(this._horariosEmpleados);
                MessageBox.Show("Eliminado Correctamente");

                txtHoraEntrada.Text = "";
                txtHoraSalida.Text = "";
                dtFecha.Text = "";

                cbEmpleado.Focus();

                cbEmpleado.Text = "";

                this.List();
                btnGuardar.Enabled = true;

            }

            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtHoraEntrada.Text = "";
                    txtHoraSalida.Text = "";
                    dtFecha.Text = "";

                    cbEmpleado.Focus();

                    this.List();
                    cbEmpleado.Text = "";
                    btnGuardar.Enabled = true;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHoraEntrada.Text = "";
            txtHoraSalida.Text = "";
            dtFecha.Text = "";

            cbEmpleado.Focus();

            this.List();
            cbEmpleado.Text = "";
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
            this.idHorarioEmpleado = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            dtFecha.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            txtHoraEntrada.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
            txtHoraSalida.Text = dtgLlenardatos.CurrentRow.Cells[3].Value.ToString();
            cbEmpleado.Text = dtgLlenardatos.CurrentRow.Cells[4].Value.ToString();

            btnGuardar.Enabled = false;
        }

        private void List()
        { 
            try
            {

                dtgLlenardatos.DataSource = (from c in _personRule.ListaHorariosEmpleado() select new { c.idHorarioEmpleado, c.fecha, c.horaEntrada, c.horaSalida, c.nombres, c.apellidos}).ToList();
                dtgLlenardatos.Columns[0].Visible = false;
                //Mostrar nombre y guarde el ID
                cbEmpleado.DataSource = (from c in _personRule.ListaEmpleados("", "", "", "") select new { Id = c.idEmpleado, Nombres = c.nombres + " " + c.apellidos }).ToList();
                cbEmpleado.ValueMember = "Id";
                cbEmpleado.DisplayMember = "Nombres";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void txtHoraEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else e.Handled = true; ;


            if (txtHoraEntrada.Text.Length == 8)
            {
                e.Handled = true;
            }
        }

        private void txtHoraSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else e.Handled = true; ;


            if (txtHoraSalida.Text.Length == 8)
            {
                e.Handled = true;
            }
        }
    }
}
