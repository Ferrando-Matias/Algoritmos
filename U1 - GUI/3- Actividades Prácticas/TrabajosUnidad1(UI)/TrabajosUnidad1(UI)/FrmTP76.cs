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
    public partial class FrmTP76 : Form
    {
        public FrmTP76()
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

        public decimal ConversionMedidas(string medi1, decimal cantidad, string medi2)
        {
            decimal valorfinal = cantidad; 
            medi1 = medi1.ToLower(); 
            medi2 = medi2.ToLower();

            if (medi1 == "metro")
            {
                if (medi2 == "kilometro")
                    valorfinal = cantidad / 1000m;
                if (medi2 == "milla")
                    valorfinal = cantidad / 1609m;
                if (medi2 == "pulgada")
                    valorfinal = cantidad * 39.37m;
                return valorfinal;
            }
            if (medi1 == "kilometro") 
            {
                if (medi2 == "metro")
                    valorfinal = cantidad * 1000m;
                if (medi2 == "milla")
                    valorfinal = cantidad / 1.609m;
                if (medi2 == "pulgada")
                    valorfinal = cantidad * 39370m;
                return valorfinal;
            }
            if (medi1 == "milla") 
            {
                if (medi2 == "metro")
                    valorfinal = cantidad / 1609m;
                if (medi2 == "kilometro")
                    valorfinal = cantidad * 1.609m;
                if (medi2 == "pulgada")
                    valorfinal = cantidad * 63360m;
                return valorfinal;
            }
            if (medi1 == "pulgada") 
            {
                if (medi2 == "metro")
                    valorfinal = cantidad / 39.37m;
                if (medi2 == "kilometro")
                    valorfinal = cantidad / 39370m;
                if (medi2 == "milla")
                    valorfinal = cantidad * 63360;
                return valorfinal;
            }
            return valorfinal;
        }


        private void FrmTP76_Load(object sender, EventArgs e)
        {
            cmbUnidad1.Items.Add("Metro");
            cmbUnidad1.Items.Add("Kilometro");
            cmbUnidad1.Items.Add("Milla");
            cmbUnidad1.Items.Add("Pulgada");
            cmbUnidad1.SelectedIndex = 0;

            cmbUnidad2.Items.Add("Metro");
            cmbUnidad2.Items.Add("Kilometro");
            cmbUnidad2.Items.Add("Milla");
            cmbUnidad2.Items.Add("Pulgada");
            cmbUnidad2.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbUnidad1.SelectedIndex = 0;
            cmbUnidad2.SelectedIndex = 0;
            txtCant.Clear();
            txtCant.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblRes.Text = ConversionMedidas(cmbUnidad1.SelectedItem.ToString(), Convert.ToDecimal(txtCant.Text), cmbUnidad2.SelectedItem.ToString()).ToString("F2");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
