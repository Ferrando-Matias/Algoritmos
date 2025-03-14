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
    public partial class FrmTP80 : Form
    {
        public FrmTP80()
        {
            InitializeComponent();
        }     

        private void FrmTP80_Load(object sender, EventArgs e)
        {
            cmbPizzaT.Items.Add("Seleccione un tamaño");
            cmbPizzaT.Items.Add("Chica");
            cmbPizzaT.Items.Add("Mediana");
            cmbPizzaT.Items.Add("Grande");
            cmbPizzaT.Items.Add("Familiar");
            cmbPizzaT.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbPizzaT.SelectedIndex < 1 || txtUsuario.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tamaño de pizza y poner el nombre del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tamaño = cmbPizzaT.SelectedItem.ToString();
            int cantExtras = 0;
            bool horaPico = false;
            if ((DateTime.Now.Hour > 11 && DateTime.Now.Hour < 15) || (DateTime.Now.Hour > 19 && DateTime.Now.Hour < 23)) horaPico = true;
            foreach (var item in grbIngredientes.Controls)
            {
                if (item is CheckBox chk)
                {
                    if (chk.Checked) cantExtras++; 
                }
            }
            int tiempo = calcularTiempo(tamaño, cantExtras, horaPico);
            double costo = calcularCosto(tamaño, cantExtras);
            MessageBox.Show($"El costo del pedido es de {costo}. \n" +
                $"El tiempo de entrega sera de {tiempo} minutos.", "Pedido Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int calcularTiempo (string tamaño, int extras, bool horaPico)
        {
            int tiempo = 0;
            if (horaPico)
            {
                tiempo = 45;
            }
            else
            {
                tiempo = 20;
            }
            if (extras > 2 || tamaño.ToLower() == "familiar") tiempo += 5;
            return tiempo;
        }

        private double calcularCosto(string tamaño, int extras)
        {
            double costo = 0;
            switch (tamaño.ToLower())
            {
                case "chica":
                    costo = 1100;
                    break;
                case "mediana":
                    costo = 1300;
                    break;
                case "grande":
                    costo = 1800;
                    break;
                case "familiar":
                    costo = 2100;
                    break;
                default:
                    break;
            }
            costo += 250 * extras;
            return costo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbPizzaT.SelectedIndex = 0;
            txtUsuario.Clear();
            foreach (var item in grbIngredientes.Controls)
            {
                if (item is CheckBox chk) chk.Checked = false;
            }
        }
    }
}
