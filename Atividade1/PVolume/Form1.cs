namespace test
{
    public partial class Form1 : Form
    {
        double raio, altura, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if (txtRaio.Text == "")
            {
                raio = 0;
            }
            else
            if (!Double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("raio invalido");
                //txtRaio.Focus();
            }
            else if (raio <= 0)
            {
                MessageBox.Show("raio deve ser maior que zero");
                //txtRaio.Focus();
            }
        }

        private void txtAltura_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            {
                if (txtAltura.Text == "")
                {
                    altura = 0;
                }
                else
                if (!Double.TryParse(txtAltura.Text, out altura))
                {
                    MessageBox.Show("altura invalido");
                    //e.Cancel = true;
                }
                else if (altura <= 0)
                {
                    MessageBox.Show("altura deve ser maior que zero");
                    //e.Cancel = true;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtRaio.Text, out raio) ||
                !Double.TryParse(txtAltura.Text, out altura) ||
                raio == 0 ||
                altura ==0)
            {
                MessageBox.Show("numero invalido");
                txtRaio.Focus();
            }

                txtResultado.Text = (altura * Math.PI * raio * raio).ToString("N2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtAltura.Clear();
            txtRaio.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
