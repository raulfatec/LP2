using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMatriz
{
    public partial class exe4 : Form
    {
        public exe4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            for (int i = 0; i < 10; i ++)
            {
                nomes[i] = Interaction.InputBox("Digite seu nome completo", "nomes");
                if(nomes[i] == "")
                {
                    MessageBox.Show("Cancelado");
                    return;
                }
            }
            for (int i = 0;i < 10;i++)
            {
                int chrs = 0;
                for (int j = 0;j < nomes[i].Length; j++)
                {
                    if (nomes[i][j] != ' ') chrs++;
                }
                nomes[i] = "o nome:" + nomes[i] + " tem " + chrs + " caracteres";
            }
            listBoxNomes.Items.AddRange(nomes);
        }
    }
}
