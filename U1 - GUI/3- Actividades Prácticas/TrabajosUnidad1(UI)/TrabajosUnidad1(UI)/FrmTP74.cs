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
    public partial class FrmTP74 : Form
    {
        public FrmTP74()
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
        private void FrmTP74_Load(object sender, EventArgs e)
        {
            cmbOperaciones.Items.Add("Seleccione una opcion");
            cmbOperaciones.Items.Add("Suma");
            cmbOperaciones.Items.Add("Resta");
            cmbOperaciones.Items.Add("Multiplicación");
            cmbOperaciones.Items.Add("División");
            cmbOperaciones.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double resultado = 0;
            switch (cmbOperaciones.SelectedItem)
            {
                case "Suma":
                    resultado = n1 + n2;
                    break;
                case "Resta":
                    resultado = n1 - n2;
                    break;
                case "Multiplicación":
                    resultado = n1 * n2;
                    break;
                case "División":
                    resultado = n1 / n2;
                    break;
                default:
                    MessageBox.Show("Debe seleccionar una operacion valida","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            lblRes.Text = resultado.ToString("F2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblRes.ResetText();
        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
