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
    public partial class FrmTP83 : Form
    {
        private List <Notas> notas = new List <Notas> ();
        public FrmTP83()
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

        private void actualizarGrilla()
        {
            dtgEstudiantes.DataSource = null;
            dtgEstudiantes.DataSource = notas;
        }
        private void limpiarControles(Control _control)
        {
            foreach (Control control in _control.Controls)
            {
                if (control is GroupBox grp) limpiarControles(grp);
                if (control is TextBox txt) txt.Clear();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe completar el apellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTP.Text))
            {
                MessageBox.Show("Debe completar la nota del trabajo practico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEvaluacion.Text))
            {
                MessageBox.Show("Debe completar la nota de evaluacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEvaluacion.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDesGlob.Text))
            {
                MessageBox.Show("Debe completar la nota del desempeño global", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesGlob.Focus();
                return;
            }
            notas.Add(new Notas
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                TP = Convert.ToInt32 (txtTP.Text),
                Evaluacion = Convert.ToInt32(txtEvaluacion.Text),
                DG = Convert.ToInt32(txtDesGlob.Text)
            });
            actualizarGrilla();
            limpiarControles(this);
        }

        private void txtTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtEvaluacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtDesGlob_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void FrmTP83_Load(object sender, EventArgs e)
        {
            // Comportamiento
            dtgEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer click en alguna celda
            dtgEstudiantes.MultiSelect = false; // Que no pueda seleccionar multiples filas
            dtgEstudiantes.ReadOnly = true; // Hace que la grilla no se pueda editar
            dtgEstudiantes.AllowUserToAddRows = false; // Desactiva  la ultima fila 
            dtgEstudiantes.RowHeadersVisible = false; // Oculto los encabezados de filas
            dtgEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            // Grafica
            dtgEstudiantes.EnableHeadersVisualStyles = false; // Para poder modificar estilos en la cabecera
            dtgEstudiantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Quito los bordes de la cabecera
            dtgEstudiantes.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue; // Color de fondo de la cabecera
            dtgEstudiantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de texto de la cabecera
            dtgEstudiantes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue; // Color de fondo de la celda del encabezado seleccionada
            dtgEstudiantes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// Centro el texto de las cabeceras

        }
    }

    public class Notas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TP { get; set; }
        public int Evaluacion { get; set; }
        public int DG{ get; set; }
        public int Trimestre { get; set; }
    }
}
