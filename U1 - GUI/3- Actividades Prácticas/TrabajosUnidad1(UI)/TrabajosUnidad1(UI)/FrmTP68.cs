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
    public partial class FrmTP68 : Form
    {
        private int votosA=0;
        private int votosB=0;
        private int votosC=0;

        public FrmTP68()
        {
            InitializeComponent();
        }

        private void btnVotoA_Click(object sender, EventArgs e)
        {
            votosA++;
            actualizarResultado();
        }

        private void btnVotoB_Click(object sender, EventArgs e)
        {
            votosB++;
            actualizarResultado();
        }

        private void btnVotoC_Click(object sender, EventArgs e)
        {
            votosC++;
            actualizarResultado();
        }

        private void actualizarResultado()
        {
            lblResultado.Text = $"Votos A: {votosA} - Votos B: {votosB} - Votos C: {votosC}";
            
        }
    }
}
