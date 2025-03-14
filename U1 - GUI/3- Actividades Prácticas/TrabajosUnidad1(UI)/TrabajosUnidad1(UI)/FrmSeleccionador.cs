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
    public partial class FrmSeleccionador : Form
    {
        public FrmSeleccionador()
        {
            InitializeComponent();
        }

        private void FrmSeleccionador_Load(object sender, EventArgs e)
        {
            for (int i = 68; i <= 83; i++)
            {
                cmbTrabajos.Items.Add($"Trabajo {i}");
            }
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            switch (cmbTrabajos.SelectedIndex)
            {
                case 0:
                    cargarFormulario(new FrmTP68());
                    break;
                case 1:
                    cargarFormulario(new FrmTP69());
                    break;
                case 2:
                    cargarFormulario(new FrmTP70());
                    break;
                case 3:
                    cargarFormulario(new FrmTP71());
                    break;
                case 4:
                    cargarFormulario(new FrmTP72());
                    break;
                case 5:
                    cargarFormulario(new FrmTP73());
                    break;
                case 6:
                    cargarFormulario(new FrmTP74());
                    break;
                case 7:
                    cargarFormulario(new FrmTP75());
                    break;
                case 8:
                    cargarFormulario(new FrmTP76());
                    break;
                case 9:
                    cargarFormulario(new FrmTP77());
                    break;
                case 10:
                    cargarFormulario(new FrmTP78());
                    break;
                case 11:
                    cargarFormulario(new FrmTP79());
                    break;
                case 12:
                    cargarFormulario(new FrmTP80());
                    break;
                case 13:
                    cargarFormulario(new FrmTP81());
                    break;
                case 14:
                    cargarFormulario(new FrmTP82());
                    break;
                case 15:
                    cargarFormulario(new FrmTP83());
                    break;                
            }
        }

        private void cargarFormulario(Form miform)
        {
            if (miform != null)
            {
                miform.FormBorderStyle = FormBorderStyle.Fixed3D;
                miform.StartPosition = FormStartPosition.CenterScreen;
                miform.MaximizeBox = false;
                miform.StartPosition = FormStartPosition.CenterParent;
                miform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Formulario Inexistente.");
            }
        }
    }
}
