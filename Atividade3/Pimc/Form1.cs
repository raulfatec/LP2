using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        double peso, altura;
        public Form1()
        {
            InitializeComponent();
        }

        private void mskbxPeso_Validating(object sender, CancelEventArgs e)
        {
            if(!double.TryParse(mskbxPeso.Text, out peso))
            {
                errP.SetError(mskbxPeso, "Peso invalido");
                //e.Cancel = true;
            }
           
        }

        private void mskbxAltura_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(mskbxAltura.Text, out altura))
            {
                errP.SetError(mskbxAltura, "Altura invalida");
                //e.Cancel = true;
            }
        }

        private void txtImc_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxPeso.Text, out peso))
            {
                MessageBox.Show("Peso invalido");
                mskbxPeso.Text = "";
                mskbxPeso.Focus();
                return;
            }
            if (!double.TryParse(mskbxAltura.Text, out altura))
            {
                MessageBox.Show("Altura invalida");
                mskbxAltura.Text = "";
                mskbxAltura.Focus();
                return;
            }
            if (altura == 0)
            {
                MessageBox.Show("Altura 0 é invalida");
                mskbxAltura.Text = "";
                mskbxAltura.Focus();
                return;
            }
            if (peso == 0)
            {
                MessageBox.Show("Peso 0 é invalido");
                mskbxPeso.Text = "";
                mskbxPeso.Focus();
                return;
            }
            double value = Math.Round((peso / (altura * altura)), 1);
            txtImc.Text = value.ToString();

            if(value < 18.5)
            {
                MessageBox.Show("Magreza");
                return;
            }
            if (value < 25)
            {
                MessageBox.Show("Normal");
                return;
            }
            if (value < 30)
            {
                MessageBox.Show("Sobrepeso");
                return;
            }
            if (value < 40)
            {
                MessageBox.Show("Obesidade");
                return;
            }
            MessageBox.Show("Obesidade Grave");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxAltura.Text = "";
            mskbxPeso.Text = "";
            txtImc.Text = "";
        }

        private void mskbxPeso_Click(object sender, EventArgs e)
        {
            mskbxPeso.Text = "";
        }

        private void mskbxAltura_Click(object sender, EventArgs e)
        {
            mskbxAltura.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
