using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoPreguica
{
    public partial class Form1 : Form
    {
        int somatorio;
        int grav;
        int urgent;
        int tendencies;
        public Form1()
        {
            InitializeComponent();

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow linha = new DataGridViewRow();
            linha.CreateCells(dataGridView1);

            linha.Cells[0].Value = txtaTarefa.Text;
            linha.Cells[1].Value = numGrav.Value;
            linha.Cells[2].Value = numUrg.Value;
            linha.Cells[3].Value = numTend.Value;
            grav = Convert.ToInt32(numGrav.Value);
            urgent = Convert.ToInt32(numUrg.Value);
            tendencies = Convert.ToInt32(numTend.Value);
            int soma = grav * urgent * tendencies;
            somatorio = soma;
            linha.Cells[4].Value = somatorio;
            if (somatorio <= 50)
            {
                linha.Cells[5].Value = "Baixa";
            }
            else if (somatorio > 50 && somatorio <= 99)
            {
                linha.Cells[5].Value = "Média";
            }
            else
            {
                linha.Cells[5].Value = "Alta";
                
            }
            dataGridView1.Rows.Add(linha);
            somatorio = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa foi criado para auxiliar \n na escolha de 20% de ações que trazem 80% de resultado, para isso utilizamos o conceito de matriz GUT\n para que você identifique o que é prioridade e execute.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
