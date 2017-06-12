using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTarget_0._0._1
{
    public partial class Form1 : Form
    {
        int mins, secs;
        int pomCompleto = 0;
        
        public Form1()
        {
            InitializeComponent();
            //Mudar o modo de seleção de clique duplo apra clique simples
            ckdFutura.CheckOnClick = true;
            ckdDia.CheckOnClick = true;
        }
        //Adicionar tarefas na lista de atividades futuras 
        private void btnAddFutura_Click(object sender, EventArgs e)
        {
            //fazendo o teste se o textbox está vazio
            if (textBox1.Text != "")
            {
                //verificando se a lista futura não tem o texto do textbox
                if (ckdFutura.CheckedItems.Contains(textBox1.Text)==false)
                {
                    //fazendo a adição do item
                    ckdFutura.Items.Add(textBox1.Text, CheckState.Checked);
                    //limpando o dado da textbox
                    textBox1.Text = "";
                }
            }
        }

        private void btnAddDia_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                if (ckdDia.CheckedItems.Contains(textBox1.Text)==false)
                {
                    ckdDia.Items.Add(textBox1.Text, CheckState.Checked);
                    textBox1.Text = "";
                }
            }
        }

        //ativando os botoes de adicionar tarefas nas listas somente quando há algo digitado na textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                btnAddDia.Enabled = false;
                btnAddFutura.Enabled = false;
            }
            else
            {
                btnAddDia.Enabled = true;
                btnAddFutura.Enabled = true;
            }
        }
        //mover os itens da lista de tarefas futuras para as do dia
        private void btnMoveDia_Click(object sender, EventArgs e)
        {
            //percorrendo a lista de atividades futuras e adicionando
            
            
            for (int i = 0; i < ckdFutura.CheckedItems.Count; i++)
            {
                //os itens para a lista de atividades futura que estão ticados
                ckdDia.Items.Add(ckdFutura.CheckedItems[i]);
                
            }
            //habilitando o botão para mover somente se tiver algum item na lista de tarefas futura
            if (ckdFutura.Items.Count > 0)
            {
                btnMoveDia.Enabled = true;
            }
            else 
            {
                btnMoveDia.Enabled = false;
            }
            //travando o botão de mover para a lista de tarefas do dia quando
            //ele tiver 3 tarefas para serem executadas
            if (ckdDia.Items.Count > 4)
            {
                btnMoveDia.Enabled = false;
            }
                
        }

        private void btnMoveFutura_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ckdDia.CheckedItems.Count; i++)
            {
                ckdFutura.Items.Add(ckdDia.CheckedItems[i]);
            }
            if (ckdDia.Items.Count > 0)
            {
                btnMoveFutura.Enabled = true;
            }
            else
            {
                btnMoveFutura.Enabled = false;
            }
            if (ckdDia.Items.Count < 4)
            {
                btnMoveFutura.Enabled = true;
            }
        }

        private void ckdFutura_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                if (ckdFutura.CheckedItems.Count==1)
                {
                    btnMoveDia.Enabled = false;
                }
                else
                {
                    btnMoveDia.Enabled = true;
                }
            }
        }

        private void ckdDia_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                if (ckdDia.CheckedItems.Count==1)
                {
                    btnMoveFutura.Enabled = false;
                }
            }
            else
            {
                btnMoveFutura.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secs -= 1;
            if (secs ==-1)
            {
                mins -= 1;
                secs = 59;
            }

            if (mins == 0 && secs ==0)
            {
                timer1.Stop();
                MessageBox.Show("Hora do descanso, tire uma pausa", "Time");
            }
            lblMin.Text = Convert.ToString(mins);
            lblSeg.Text = Convert.ToString(secs);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mins = 24;
            secs = 59;
            timer1.Start();
            lblDesc.Visible = false;
                
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            mins = 4;
            secs = 59;
            timer1.Start();
            lblAtivo.Visible = false;
            pomCompleto += 1;
            if (pomCompleto > 3)
            {
                mins = 14;
                secs = 59;
                timer1.Start();
                lblAtivo.Visible = false;
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblDesc.Visible = true;
            lblAtivo.Visible = true;
        }
    }
}
