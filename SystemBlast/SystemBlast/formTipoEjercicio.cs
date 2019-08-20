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
    public partial class formTipoEjercicio : Form
    {
        private personRule _personRule;
        private clsTipoEjercicioEntity _ejercicios;

        public formTipoEjercicio()
        {
            InitializeComponent();

            _personRule = new personRule();
            _ejercicios = new clsTipoEjercicioEntity();
        }

        private void formTipoEjercicio_Load(object sender, EventArgs e)
        {
            this.List();
        }

        private void txtTipoEjercicio_TextChanged(object sender, EventArgs e)
        {
            _ejercicios.tipoEjercicio = txtTipoEjercicio.Text;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrecio.Text) || !string.IsNullOrEmpty(txtPrecio.Text))
                this._ejercicios.Precio = Convert.ToInt32(txtPrecio.Text);
            else
                this._ejercicios.Precio = 0;
            
        }

        private Guid idTipoEjercicio = Guid.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this._personRule.IsValidTipoEjercicioGuardar(this._ejercicios);

                _personRule.GuardarTipoEjercicio(this._ejercicios);
                MessageBox.Show("Guardado");
                txtPrecio.Text = "";
                txtTipoEjercicio.Text = "";
                txtTipoEjercicio.Focus();
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
                this._ejercicios.idTipoEjercicio = this.idTipoEjercicio;
                this._personRule.IsValidTipoEjercicioGuardar(this._ejercicios);

                this._personRule.ActualizarTipoEjercicio(this._ejercicios);
                MessageBox.Show("Actualizado Correctamente");

                txtPrecio.Text = "";
                txtTipoEjercicio.Text = "";
                txtTipoEjercicio.Focus();
                this.List();

                btnGuardar.Enabled = false;
            }

            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtPrecio.Text = "";
                    txtTipoEjercicio.Text = "";
                    txtTipoEjercicio.Focus();
                    this.List();
                    btnGuardar.Enabled = true;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecio.Text = "";
            txtTipoEjercicio.Text = "";
            txtTipoEjercicio.Focus();
            this.List();
            btnGuardar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Seguro desea eliminar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._ejercicios.idTipoEjercicio = this.idTipoEjercicio;
                //this._personRule.IsValidClienteActualizar(this._clsCliente);

                this._personRule.EliminarTipoEjercicio(this._ejercicios);
                MessageBox.Show("Eliminado Correctamente");

                txtPrecio.Text = "";
                txtTipoEjercicio.Text = "";
                txtTipoEjercicio.Focus();
                this.List();

                btnGuardar.Enabled = true;
            }

            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtPrecio.Text = "";
                    txtTipoEjercicio.Text = "";
                    txtTipoEjercicio.Focus();
                    this.List();
                    btnGuardar.Enabled = true;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgLlenardatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.llenarDatos();
            btnGuardar.Enabled = false;
        }

        public void llenarDatos()
        {
            this.idTipoEjercicio = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            txtTipoEjercicio.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
         
        }

        private void List()
        {
            try
            {
               dtgLlenardatos.DataSource = (from c in _personRule.ListaTipoEjercicio() select new { c.idTipoEjercicio, c.tipoEjercicio, c.Precio}).ToList();
               dtgLlenardatos.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void txtTipoEjercicio_KeyPress(object sender, KeyPressEventArgs e)
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


            if (txtTipoEjercicio.Text.Length == 15)
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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


            if (txtPrecio.Text.Length == 5)
            {
                e.Handled = true;
            }
        }
    }
}
