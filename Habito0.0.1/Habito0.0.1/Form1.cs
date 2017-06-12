using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habito0._0._1
{
    public partial class Form1 : Form
    {
       // private DateTime dtFim;
        public Form1()
        {
            InitializeComponent();

           // dtFim = dateTimePicker1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Escolha uma data futura", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                timer1.Start();
                lblTarefa.Text = txtTarefa.Text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                MessageBox.Show("Hora de executar a Tarefa", "Conclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = false;
            }
            else
            {
                TimeSpan tsTempoFaltante = new TimeSpan();
                tsTempoFaltante = dateTimePicker1.Value - DateTime.Now;
                lblDias.Text = tsTempoFaltante.Days.ToString();
                lblHoras.Text = tsTempoFaltante.Hours.ToString();
                lblMin.Text = tsTempoFaltante.Minutes.ToString();
                lblSeg.Text = tsTempoFaltante.Seconds.ToString();

            }
        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }
    }
}
