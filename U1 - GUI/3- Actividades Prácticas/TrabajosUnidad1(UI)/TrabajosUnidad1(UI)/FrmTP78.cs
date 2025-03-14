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
    public partial class FrmTP78 : Form
    {
        public FrmTP78()
        {
            InitializeComponent();
        }

        private void FrmTP78_Load(object sender, EventArgs e)
        {
            cmbModelo.Items.Add("Seleccione un modelo");
            cmbModelo.Items.Add("Ejecutivo");
            cmbModelo.Items.Add("Premier");
            cmbModelo.Items.Add("Standar");
            cmbModelo.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ejecutivo = 500d;
            double premier = 300d;
            double standar = 100d;

            double factorAjuste = 1.0;

            if (nudTalle.Value > 6 && nudTalle.Value < 13)
            {
                if (nudTalle.Value == 11) factorAjuste = 1.1;
                else if (nudTalle.Value == 12) factorAjuste = 1.2;

                switch (cmbModelo.SelectedIndex)
                {
                    case 1:
                        lblTotal.Text = (ejecutivo * factorAjuste).ToString();
                        break;
                    case 2:
                        lblTotal.Text = (premier * factorAjuste).ToString();
                        break;
                    case 3:
                        lblTotal.Text = (standar * factorAjuste).ToString();
                        break;
                    default:
                        MessageBox.Show("Debe seleccionar un modelo de zapato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("El valor del talle debe estar entre 7 y 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbModelo.SelectedIndex = 0;
            nudTalle.Value = 7;
            lblTotal.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
