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
    public partial class FrmTP82 : Form
    {
        public FrmTP82()
        {
            InitializeComponent();
        }

        private void limpiarControles(Control _control)
        {
            foreach (Control control in _control.Controls)
            {
                if (control is GroupBox grp) limpiarControles(grp); 
                if (control is TextBox txt) txt.Clear();
                if (control is NumericUpDown nud) nud.Value = 0;
                if (control is ComboBox cmb) cmb.SelectedIndex = 0;
                if (control is DateTimePicker dtp) dtp.Value = DateTime.Now.Date;
            }
        }

        private double calculoSueldoBase(int horasNormales, int horasExtras, string categoria)
        {
            double valorHora = 0;

            switch (categoria.ToLower())
            {
                case "operario":
                    valorHora = 400;
                    break;
                case "administrativo":
                    valorHora = 500;
                    break;
                case "técnico":
                    valorHora = 700;
                    break;
                case "profesional":
                    valorHora = 1200;
                    break;
            }
            return (valorHora * horasNormales) + (valorHora * horasExtras * 2);
        }

        private double calculoAntiguedad(double sueldoBase, int añosTrabajados)
        {
            double porcentajeAntiguedad = 0.0;
            if (añosTrabajados > 0 && añosTrabajados < 4) porcentajeAntiguedad = 0.05;
            else if (añosTrabajados > 3 && añosTrabajados < 7) porcentajeAntiguedad = 0.1;
            else if (añosTrabajados > 6 && añosTrabajados < 11) porcentajeAntiguedad = 0.2;
            else if (añosTrabajados > 10 && añosTrabajados < 16) porcentajeAntiguedad = 0.5;
            else if (añosTrabajados > 15) porcentajeAntiguedad = 1;
            return sueldoBase * porcentajeAntiguedad;
        }

        private double descuentoObraSocial (double sueldoBase)
        {
            return sueldoBase * 0.03;
        }

        private double descuentoJubilacion(double sueldoBase)
        {
            return sueldoBase * 0.10;
        }

        private double sueldoTotal (double sueldoBase, double antiguedad, double obraSocial, double jubilacion)
        {
            return sueldoBase + antiguedad - obraSocial - jubilacion;
        }

        
        private void FrmTP82_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Seleccione una categoria");
            cmbCategoria.Items.Add("Administrativo");
            cmbCategoria.Items.Add("Operario");
            cmbCategoria.Items.Add("Técnico");
            cmbCategoria.Items.Add("Profesional");
            cmbCategoria.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles(this);
            txtNombre.Focus();
            lblTotal.Text = "$ 0";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex < 1)
            {
                MessageBox.Show("Debe seleccionar una categoria de empleado","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Antiguedad = DateTime.Today - dtpFechaIngreso.Value;
            int añosAntiguedad = Convert.ToInt32((decimal)Math.Floor((decimal)Antiguedad.TotalDays / 365));

            int horas_mes = Convert.ToInt32(nudHoraMes.Value);
            int horas_extra = Convert.ToInt32(nudHoraExtra.Value);

            double sueldoBase = calculoSueldoBase(horas_mes,horas_extra,cmbCategoria.SelectedItem.ToString());
            double montoAntiguedad = calculoAntiguedad(sueldoBase, añosAntiguedad);
            double descObraSocial = descuentoObraSocial(sueldoBase);
            double descJubilacion = descuentoJubilacion(sueldoBase);
            double total = sueldoTotal(sueldoBase,montoAntiguedad,descObraSocial,descJubilacion);

            lblTotal.Text = $"$ {total}";
        }
    }
}
