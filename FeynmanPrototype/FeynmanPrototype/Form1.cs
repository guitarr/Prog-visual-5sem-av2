using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace FeynmanPrototype
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string Comando, String Retorno, int RetornoLen, int CallBack);

        string Musica = "";

        public Form1()
        {
            InitializeComponent();
        }
        //Métodos para os objetos do programa
        private void ChamarSalvarArquivo()
        {
            if(!String.IsNullOrEmpty(rtxb1.Text))
            {
                if (MessageBox.Show("Deseja Salvar o arquivo?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //chamando o arquivo para salvar mas perguntado se realmente quer salvar
                    Salvar_Arquivo();
                }
            }
        }
        private void Salvar_Arquivo()
        {
            try
            {
                //Pegar o nome do arquivo como salvar
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Abrir um stream para escrita e cria a um StreamWriter para implementar o stream
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();
                    //Escrever para o arquivo usando a classe StreamWriter
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    //Escrever o ocontrole RichTextBox
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirArquivo()
        {
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Selecionar Arquivo";
            openFileDialog1.InitialDirectory = @"c:\Documentos\";
            //Filtra para exibir somente arquivos]
            openFileDialog1.Filter = "Images (*TXT)|*.TXT" + "All files(*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr==System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_sttreamReader = new StreamReader(fs);
                    //Deve ler o arquivo usnado a classe stream
                    m_sttreamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    //Lerá cada linha do stream e faz o parse até a última linha
                    this.rtxb1.Text = "";
                    string strLine = m_sttreamReader.ReadLine();
                    while (strLine != null)
                    {
                        this.rtxb1.Text += strLine + "\n";
                        strLine = m_sttreamReader.ReadLine();
                    }
                    //Fecra o stream
                    m_sttreamReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Copiar()
        {
            if(rtxb1.SelectionLength > 0)
            {
                rtxb1.Copy();
            }
        }

        private void Colar()
        {
            rtxb1.Paste();
        }

        private void negrito()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool negrito = false;
            nome_fonte = rtxb1.Font.Name;
            tamanho_fonte = rtxb1.Font.Size;
            negrito = rtxb1.Font.Bold;
            if (negrito == false)
            {
                rtxb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
            }
            else
            {
                rtxb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
            }
        }
        private void italico()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool italico = false;
            nome_fonte = rtxb1.Font.Name;
            tamanho_fonte = rtxb1.Font.Size;
            italico = rtxb1.Font.Italic;

            if (italico == false)
            {
                rtxb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
            else
            {
                rtxb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }

        }

        private void sublinhado()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool sublinha = false;
            nome_fonte = rtxb1.Font.Name;
            tamanho_fonte = rtxb1.Font.Size;
            sublinha = rtxb1.Font.Underline;

            if (sublinha == false)
            {
                rtxb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
            }
            else
            {
                rtxb1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
            }
        }

        private void alterarFonte()
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result ==DialogResult.OK)
            {
                if (rtxb1.SelectionFont != null)
                {
                    rtxb1.SelectionFont = fontDialog1.Font;
                }
            }
        }

        private void configuracoesImpressora()
        {
            try
            {
                this.printDialog1.Document = this.printDocument1;
                printDialog1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void visualizaImpressao()
        {
            //Visualizar impressão
            try
            {
                string strTexto = this.rtxb1.Text;
                var leitor = new StreamReader(strTexto);
                PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();
                var prn = printPreviewDialog1;
                prn.Document = this.printDocument1;
                prn.Text = "Feeyman Prototype - Visualizando a Impressão";
                prn.WindowState = FormWindowState.Maximized;
                prn.PrintPreviewControl.Zoom = 1;
                prn.FormBorderStyle = FormBorderStyle.Fixed3D;
                prn.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimir()
        {
            printDialog1.Document = printDocument1;

            string strTexto = this.rtxb1.Text;
            var leitor = new StringReader(strTexto);
            if (printDialog1.ShowDialog()== DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void sobre()
        {
            try
            {
                frmSobre frm2 = new frmSobre();
                frm2.ShowDialog();
                if (frm2.DialogResult == DialogResult.OK)
                {
                    frm2.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void sair()
        {
            if (MessageBox.Show("Deseja sair da aplicação?","Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Métodos do controle de Audio
        private void gravarAudio()
        {
            mciSendString("open a new type waveaudio alias Som", null, 0, 0);
            mciSendString("record Som", null, 0, 0);
            lbl_status.Text = "GRAVANDO!";
        }

        private void salvarAudio()
        {
            mciSendString("pause Som", null, 0, 0);
            lbl_status.Text = "Pausado!";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave|*.wav";
            save.ShowDialog();

            mciSendString("save Som " + save.FileName, null, 0, 0);
            mciSendString("close Som", null, 0, 0);
            lbl_status.Text = "SALVO!";
           
        }
        private void tocarAudio()
        {
            if (Musica == "")
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Wave|*.wav";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Musica = open.FileName;
                }
            }
            mciSendString("play " + Musica, null, 0, 0);
            lbl_status.Text = "Reproduzindo...";
        }
        private void pararAudio()
        {
            mciSendString("stop " + Musica, null, 0, 0);
            lbl_status.Text = "Parado!";
            Musica = "";
        }

        private void pausarAudio()
        {
            mciSendString("pause " + Musica, null, 0, 0);
            lbl_status.Text = "Pausado!";
        }
            
          private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamarSalvarArquivo();
            rtxb1.Clear();
            rtxb1.Focus();
        }

        private void toolStripNovo_Click(object sender, EventArgs e)
        {
            ChamarSalvarArquivo();
            rtxb1.Clear();
            rtxb1.Focus();
        }

        private void salvarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamarSalvarArquivo();
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            ChamarSalvarArquivo();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxb1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxb1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxb1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripAbrir_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void abrirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void toolStripCopiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void toolStripColar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void toolStripNegrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void toolStripItalico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void toolStripSublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void toolStripFonte_Click(object sender, EventArgs e)
        {
            alterarFonte();
        }

        private void alterarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterarFonte();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPorPaginas = 0;
            float Posicao_Y = 0;
            int contador = 0;

            //defina as margens e o valor minimo
            float MargemEsquerda = e.MarginBounds.Left - 50;
            float MargemSuperior = e.MarginBounds.Top - 50;

            if (MargemEsquerda< 5)
            {
                MargemEsquerda = 20;
            }

            if (MargemSuperior < 5)
                MargemSuperior = 20;

            //Define a fonte
            string linha = null;
            Font FonteDeImpressao = this.rtxb1.Font;
            SolidBrush meupincel = new SolidBrush(Color.Black);
            StreamReader leitor = null;
            //Calcula o número e linhas por página usando as medidas das margens
            linhasPorPaginas = e.MarginBounds.Height / FonteDeImpressao.GetHeight(e.Graphics);

            //Vai imprimir cada linha implementadno o StringReadeer
            linha = leitor.ReadLine();

            while (contador < linhasPorPaginas)
            {
                //calcula a posicao da proxima linha baseado na altura da fonte de acordo com o dispositivo de impressao
                Posicao_Y = (MargemSuperior + (contador * FonteDeImpressao.GetHeight(e.Graphics)));
                //desenha a proxima linha no richtextbox
                e.Graphics.DrawString(linha, FonteDeImpressao, meupincel, MargemEsquerda, Posicao_Y, new StringFormat());
                //conta a linha implementa uma unidade
                contador += 1;
                linha = leitor.ReadLine();
            }

            //se existir mais linhas imprime outra página

            if ((linha!=null))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            meupincel.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void toolStripAjuda_Click(object sender, EventArgs e)
        {
            sobre();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void toolStripImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void toolStripVisualizar_Click(object sender, EventArgs e)
        {
            visualizaImpressao();
        }

        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizaImpressao();
        }

        private void configuraçõesDeImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuracoesImpressora();
        }

        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gravarAudio();
        }

        private void toolStripGravar_Click(object sender, EventArgs e)
        {
            gravarAudio();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tocarAudio();
        }

        private void toolStripTocar_Click(object sender, EventArgs e)
        {
            tocarAudio();
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pausarAudio();
        }

        private void toolStripPausar_Click(object sender, EventArgs e)
        {
            pausarAudio();
        }

        private void pararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pararAudio();
        }

        private void toolStripParar_Click(object sender, EventArgs e)
        {
            pararAudio();
        }

        private void toolStripSalvarAudio_Click(object sender, EventArgs e)
        {
            salvarAudio();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            salvarAudio();
        }
    }
}
