using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double a, b, c;
        bool parse;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_Validating(object sender, CancelEventArgs e)
        {
            err.SetError(txtA, "");
            parse = double.TryParse(txtA.Text, out a);
            if (!parse)
            {
                err.SetError(txtA, "O valor deve ser um numero");
            }
            else if (a < 1)
            {
                err.SetError(txtA, "O valor deve ser maior que 0");
            }
        }

        private void txtB_Validating(object sender, CancelEventArgs e)
        {
            err.SetError(txtB, "");
            parse = double.TryParse(txtB.Text, out b);
            if (!parse)
            {
                err.SetError(txtB, "O valor deve ser um numero");
            }
            else if (b < 1)
            {
                err.SetError(txtB, "O valor deve ser maior que 0");
            }
        }

        private void txtC_Validating(object sender, CancelEventArgs e)
        {
            err.SetError(txtB, "");
            parse = double.TryParse(txtC.Text, out c);
            if (!parse)
            {
                err.SetError(txtC, "O valor deve ser um numero");
            }
            else if (c < 1)
            {
                err.SetError(txtC, "O valor deve ser maior que 0");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            err.SetError(txtA, "");
            err.SetError(txtB, "");
            err.SetError(txtC, "");
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            parse = double.TryParse(txtA.Text, out a) &&
                    double.TryParse(txtB.Text, out b) &&
                    double.TryParse(txtC.Text, out c);
            if(!parse || a < 1 || b < 1 || c < a)
            {
                MessageBox.Show("Um dos valores inseridos e invalido");
                return;
            }

            if (a + b <= c || b + c <= a || a + c <= b)
            {
                MessageBox.Show("Nao forma um triangulo");
                return;
            }

            if (a == b && b == c)
            {
                MessageBox.Show("Triangulo equilatero");
                return;
            }
         
            if(a != b && b != c && a != c)
            {
                MessageBox.Show("Triangulo escaleno");
                return;
            }

            MessageBox.Show("Triangulo isosceles");
            return;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
