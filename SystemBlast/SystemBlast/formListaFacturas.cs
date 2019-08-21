using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace SystemBlast
{
    public partial class formListaFacturas : Form
    {
        private personRule _personRule;

        public formListaFacturas()
        {
            InitializeComponent();
            _personRule = new personRule();
            this.List();
        }

        private void formListaFacturas_Load(object sender, EventArgs e)
        {
            this.List();
        }

        private void List()
        {
            try
            {
                dtgLlenardatos.DataSource = (from c in _personRule.listarFactura() select new { c.idFactura, c.Nombres, c.apellidos, c.fechaFactura, c.fechaInicio, c.fechaCierre, c.Producto, c.cantidad, c.precio }).ToList();
                dtgLlenardatos.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
