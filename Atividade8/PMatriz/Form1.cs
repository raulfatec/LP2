using Microsoft.VisualBasic;
using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string saida = "";
            for (int i = 0; i < 20; i++)
            {
                string aux = Interaction.InputBox($"Digite o {i+1}º número", "Entrada de dados");
                if(aux == "")
                {
                    MessageBox.Show("Cancelado");
                    return;
                }
                if (!int.TryParse(aux, out _))
                {
                    MessageBox.Show("Numero invalido digite novamente");
                    i--;
                    continue;
                }
                saida = aux + saida + "\n";
            }
            MessageBox.Show(saida);
        }
        private void btnExe2_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();

            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fátima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thais");

            alunos.RemoveAt(alunos.IndexOf("Otávio"));

            string saida = "";
            foreach (string aluno in alunos)
            {
                saida += aluno + "\n";
            }
            MessageBox.Show(saida);

        }

        private void btnExe3_Click(object sender, EventArgs e)
        {
            int[,] notas = new int[20,3];
            string saida = "";

            for (int i = 0; i < notas.GetLength(0); i++)
            {

                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    string aux = Interaction.InputBox($"Digite a nota {j + 1} do aluno {i + 1}", "Entrada de nome");
                    if (aux == "")
                    {
                        MessageBox.Show("Cancelado");
                        return;
                    }
                    if((!int.TryParse(aux, out notas[i, j])) || (notas[i,j] < 0 || notas[i,j] > 10))
                    {
                        MessageBox.Show("Numero Invalido, Digite novamente");
                        j--;
                        continue;
                    }
                }
                saida += $"Aluno {i + 1}: média: {(notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3}" + "\n";
            }
            MessageBox.Show(saida);
        }

        private void btnExe4_Click(object sender, EventArgs e)
        {
            exe4 formExe4 = new exe4();
            formExe4.Show();
        }

        private void btnExe5_Click(object sender, EventArgs e)
        {
            exe5 formExe5 = new exe5();
            formExe5.Show();
        }
    }
}
