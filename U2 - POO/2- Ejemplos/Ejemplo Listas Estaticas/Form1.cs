using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_con_Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstaPersonas.lPersonas.Add(new Persona(){
                    Nombre = "Eduardo",
                    Apellido= "Ferrando",
                    DNI= 111111,
                    estado= true
            });
            LstaPersonas.lPersonas.Add(new Persona()
            {
                Nombre = "Daniel",
                Apellido = "Gonzalez",
                DNI = 22222,
                estado = true
            });
            ActualizarGrilla();
        }

        private void ActualizarGrilla() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LstaPersonas.lPersonas ;
        }

        private void btnAbrirForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            ActualizarGrilla();
        }
    }
}
