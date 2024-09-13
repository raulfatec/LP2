using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double n1, n2;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero3.Text = "";
            txtNumero2.Text = "";
            txtNumero1.Text = "";
            errorProvider1.SetError(txtNumero2, "");
            errorProvider1.SetError(txtNumero1, "");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero1.Text, out n1)) {
                errorProvider1.SetError(txtNumero1, "numero invalido");
            }
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero2.Text, out n2))
            {
                errorProvider1.SetError(txtNumero2, "numero invalido");
            }

        }

        private void txtNumero3_Validated(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool valid = double.TryParse(txtNumero1.Text, out n1) && 
                double.TryParse(txtNumero2.Text, out n2);
            if (valid) txtNumero3.Text = (n1 + n2).ToString();
            else txtNumero3.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            bool valid = double.TryParse(txtNumero1.Text, out n1) &&
                double.TryParse(txtNumero2.Text, out n2);
            if (valid) txtNumero3.Text = (n1 - n2).ToString();
            else txtNumero3.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            bool valid = double.TryParse(txtNumero1.Text, out n1) &&
                double.TryParse(txtNumero2.Text, out n2);
            if (valid) txtNumero3.Text = (n1 * n2).ToString();
            else txtNumero3.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            bool valid = double.TryParse(txtNumero1.Text, out n1) &&
                double.TryParse(txtNumero2.Text, out n2);
            if (n2 == 0)
            {
                errorProvider1.SetError(txtNumero2, "Divisao por Zero");
                valid = false;
            }
            if (valid) txtNumero3.Text = (n1 / n2).ToString();
            else txtNumero3.Text = "";
        }
    }
}
