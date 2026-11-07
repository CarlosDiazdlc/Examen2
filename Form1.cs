namespace Examen2
{
    public partial class Form1 : Form
    {
        frmSeleccion ventanaSeleccion = new frmSeleccion();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMoneda.Items.Add("USD - Dolar Estadounidense");
            cmbMoneda.Items.Add("MXN - Peso Mexicano");
            cmbMoneda.Items.Add("CAD - Dolar Canadiense");
            cmbMoneda.Items.Add("EUR - Euro");
            cmbMoneda.Items.Add("JPY - Yen Japonés");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbMoneda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una moneda");
                return;
            }
            frmSeleccion seleccion = new frmSeleccion();

            seleccion.MonedaInicial = cmbMoneda.SelectedItem.ToString();
            seleccion.ShowDialog();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblUSD_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
