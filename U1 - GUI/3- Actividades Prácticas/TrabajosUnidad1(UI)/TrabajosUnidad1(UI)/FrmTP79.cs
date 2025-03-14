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
    public partial class FrmTP79 : Form
    {
        public FrmTP79()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTP79_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Seleccione una categoria");
            cmbCategoria.Items.Add("Categoria 1");
            cmbCategoria.Items.Add("Categoria 2");
            cmbCategoria.Items.Add("Categoria 3");
            cmbCategoria.SelectedIndex = 0;
            txtNombre.Focus();
        }       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldo = 0;
            double presentismo = 0;
            double descuento = 0;
            double total = 0;
            if (txtNombre.Text == "" || cmbCategoria.SelectedIndex < 1)
            {
                MessageBox.Show("Debe completar el nombre y seleccionar la categoria", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            switch (cmbCategoria.SelectedIndex)
            {
                case 1:
                    sueldo = 800;
                    break;
                case 2:
                    sueldo = 1500;
                    break;
                case 3:
                    sueldo = 4000;
                    break;
                default:
                    break;
            }
            if (chkPresentismo.Checked) presentismo = sueldo * 0.30;
            if (sueldo + presentismo >= 1700) descuento = sueldo * 0.15;
            total = sueldo + presentismo - descuento;

            txtSueldo.Text = sueldo.ToString();
            txtPresen.Text = presentismo.ToString();
            txtDesc.Text = descuento.ToString();
            txtSueldof.Text = total.ToString();
            lblNombreEmp.Text = txtNombre.Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDesc.Clear();
            txtNombre.Clear();
            txtPresen.Clear();
            txtSueldo.Clear();
            txtSueldof.Clear();
            cmbCategoria.SelectedIndex = 0;
            chkPresentismo.Checked = false;
            lblNombreEmp.Text = "Nombre";
        }
    }
}
