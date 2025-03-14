namespace DateTimePicker_NumericUpDown
{
    public partial class frmDateTime_Numeric : Form
    {
        public frmDateTime_Numeric()
        {
            InitializeComponent();
        }

        private void btnVerFecha_Click(object sender, EventArgs e)
        {
            int año = dtpFecha.Value.Year;
            int mes = dtpFecha.Value.Month;
            int dia = dtpFecha.Value.Day;

            nupAño.Value = año;
            nupMes.Value = mes;
            nupDia.Value = dia;
        }

        private void btnCambiarFecha_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(nupAño.Value);
            int mes = Convert.ToInt32(nupMes.Value);
            int dia = Convert.ToInt32(nupDia.Value);

            dtpFecha.Value = new DateTime(año, mes, dia);
        }

        private void frmDateTime_Numeric_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            // dtpFecha.MinDate = DateTime.Now;

            DateTime primerDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            DateTime ultimoDiaMes = primerDiaMes.AddMonths(1).AddDays(-1);

            // dtpFecha.MaxDate = ultimoDiaMes;

            nupAño.Minimum = 0;
            nupMes.Minimum = 1;
            nupDia.Minimum = 1;

            nupAño.Maximum = 3000;
            nupMes.Maximum = 12;
            nupDia.Maximum = 31;

        }
    }
}
