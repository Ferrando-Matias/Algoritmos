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
    public partial class FrmTP70 : Form
    {
        public FrmTP70()
        {
            InitializeComponent();
        }

        public bool EsNumerico(string entrada)
        {
            try
            {
                double num = Convert.ToDouble(entrada);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (EsNumerico(txtNum.Text))
            {
                MessageBox.Show("El valor ingresado es un numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El valor ingresado NO es un numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
