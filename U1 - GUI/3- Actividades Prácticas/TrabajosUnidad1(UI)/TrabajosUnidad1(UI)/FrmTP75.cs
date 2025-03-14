using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosUnidad1_UI_
{
    public partial class FrmTP75 : Form
    {
        public FrmTP75()
        {
            InitializeComponent();
        }

        private void soloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtVentas.Text.Length==0 || txtPrecio.Text.Length==0)
            {
                MessageBox.Show("Debe ingresar el precio unitario y cantidad vendida", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int cantidad = Convert.ToInt32(txtVentas.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);
            double total = cantidad * precio;
            if (chkIVA.Checked) total *= 1.21;
            lblRes.Text = total.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtVentas.Clear();
            lblRes.ResetText();
            chkIVA.Checked = false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
