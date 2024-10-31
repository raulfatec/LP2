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
    public partial class exe5 : Form
    {
        public exe5()
        {
            InitializeComponent();
        }

        private void btnExeList5_Click(object sender, EventArgs e)
        {
            const int RA = 2;
            char[] gabarito = new char[10] { 'a', 'b', 'c', 'e', 'a', 'b', 'a', 'b', 'c', 'a' };
            string[,] alunos = new string[RA, 10];

            for (int i = 0; i < alunos.Length/10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    alunos[i,j] = Interaction.InputBox($"Digite a resposta do aluno {i+1} na questão {j+1}", "respostas");
                    if (alunos[i,j] == "")
                    {
                        MessageBox.Show("Cancelado");
                        return;
                    }
                    if (alunos[i,j] != "a" && alunos[i, j] != "b" && alunos[i,j] != "c" && alunos[i, j] != "d" &&
                        alunos[i, j] != "e")
                    {
                        MessageBox.Show("Nota invalidade, digite novamente");
                        j--;
                        continue;
                    }
                    string acerto = alunos[i, j][0] == gabarito[j] ? " acertou " : " errou ";
                    alunos[i, j] = "O aluno:" + (i + 1) + acerto + "questão:"+(j+1)+" era " + gabarito[j]+ " escolheu "+ alunos[i, j];
                    listBoxAlunos.Items.Add(alunos[i,j]);
                }
    
            }
            


        }
    }
}
