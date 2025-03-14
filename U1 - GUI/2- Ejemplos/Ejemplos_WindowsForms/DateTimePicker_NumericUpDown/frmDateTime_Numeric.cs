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
            int a�o = dtpFecha.Value.Year;
            int mes = dtpFecha.Value.Month;
            int dia = dtpFecha.Value.Day;

            nupA�o.Value = a�o;
            nupMes.Value = mes;
            nupDia.Value = dia;
        }

        private void btnCambiarFecha_Click(object sender, EventArgs e)
        {
            int a�o = Convert.ToInt32(nupA�o.Value);
            int mes = Convert.ToInt32(nupMes.Value);
            int dia = Convert.ToInt32(nupDia.Value);

            dtpFecha.Value = new DateTime(a�o, mes, dia);
        }

        private void frmDateTime_Numeric_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            // dtpFecha.MinDate = DateTime.Now;

            DateTime primerDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            DateTime ultimoDiaMes = primerDiaMes.AddMonths(1).AddDays(-1);

            // dtpFecha.MaxDate = ultimoDiaMes;

            nupA�o.Minimum = 0;
            nupMes.Minimum = 1;
            nupDia.Minimum = 1;

            nupA�o.Maximum = 3000;
            nupMes.Maximum = 12;
            nupDia.Maximum = 31;

        }
    }
}
