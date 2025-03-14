namespace _5_RegistroUsuario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe completar el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Debe completar el apellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }
            if (!mskTelefono.MaskCompleted)
            {
                MessageBox.Show("Debe completar el telefono", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskTelefono.Focus();
                return;
            }
            if (cmbProvincias.SelectedIndex < 1)
            {
                MessageBox.Show("Debe seleccionar una provincia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProvincias.Focus();
                return;
            }
            if (cmbLocalidades.SelectedIndex < 1)
            {
                MessageBox.Show("Debe seleccionar una localidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbLocalidades.Focus();
                return;
            }
            if (!chkTerminos.Checked)
            {
                MessageBox.Show("Debe aceptar los terminos y condiciones", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkTerminos.Focus();
                return;
            }
            if (!rdbHombre.Checked && !rdbMujer.Checked && !rdbOtro.Checked)
            {
                MessageBox.Show("Debe seleccionar un genero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rdbHombre.Focus();
                return;
            }

            MessageBox.Show("Registro exitoso", "Registracion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtApellido.Clear();
            txtNombre.Clear();
            mskTelefono.Clear();
            cmbProvincias.SelectedIndex = 0;
            cmbLocalidades.SelectedIndex = 0;
            rdbHombre.Checked = false;
            rdbMujer.Checked = false;
            rdbOtro.Checked = false;
            chkTerminos.Checked = false;
            chkTerminos.Enabled = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbProvincias.Items.Add("Seleccione una Provincia");
            cmbProvincias.Items.Add("Buenos Aires");
            cmbProvincias.Items.Add("Entre Rios");
            cmbProvincias.Items.Add("Misiones");
            cmbProvincias.Items.Add("Catamarca");
            cmbProvincias.SelectedIndex = 0;
        }

        private void lnkTerminos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTerminos form = new frmTerminos();
            form.ShowDialog();
            chkTerminos.Enabled = true;
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLocalidades.Items.Clear();
            cmbLocalidades.Items.Add("Seleccione una Localidad");
            switch (cmbProvincias.SelectedIndex)
            {
                case 1:
                    cmbLocalidades.Items.Add("Avellaneda");
                    cmbLocalidades.Items.Add("Lomas de Zamora");
                    cmbLocalidades.Items.Add("Banfield");
                    break;
                default:
                    break;
            }
            cmbLocalidades.SelectedIndex = 0;
        }
    }
}
