namespace PomodoroTarget_0._0._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComplete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddFutura = new System.Windows.Forms.Button();
            this.btnAddDia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ckdFutura = new System.Windows.Forms.CheckedListBox();
            this.ckdDia = new System.Windows.Forms.CheckedListBox();
            this.btnMoveDia = new System.Windows.Forms.Button();
            this.btnMoveFutura = new System.Windows.Forms.Button();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.lblSeg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomodoros Completados:";
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(215, 27);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(31, 33);
            this.lblComplete.TabIndex = 1;
            this.lblComplete.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(121, 81);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(82, 65);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "00";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.BackColor = System.Drawing.Color.Red;
            this.lblAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAtivo.Location = new System.Drawing.Point(299, 89);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(65, 25);
            this.lblAtivo.TabIndex = 4;
            this.lblAtivo.Text = "Ativo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDesc.Location = new System.Drawing.Point(285, 121);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(116, 25);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Descanso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tarefa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddFutura
            // 
            this.btnAddFutura.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddFutura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFutura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFutura.Location = new System.Drawing.Point(355, 185);
            this.btnAddFutura.Name = "btnAddFutura";
            this.btnAddFutura.Size = new System.Drawing.Size(123, 52);
            this.btnAddFutura.TabIndex = 8;
            this.btnAddFutura.Text = "Adicionar para as Tarefas Futuras";
            this.btnAddFutura.UseVisualStyleBackColor = false;
            this.btnAddFutura.Click += new System.EventHandler(this.btnAddFutura_Click);
            // 
            // btnAddDia
            // 
            this.btnAddDia.BackColor = System.Drawing.Color.Yellow;
            this.btnAddDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDia.Location = new System.Drawing.Point(484, 185);
            this.btnAddDia.Name = "btnAddDia";
            this.btnAddDia.Size = new System.Drawing.Size(122, 52);
            this.btnAddDia.TabIndex = 9;
            this.btnAddDia.Text = "Adicionar para as tarefas do dia";
            this.btnAddDia.UseVisualStyleBackColor = false;
            this.btnAddDia.Click += new System.EventHandler(this.btnAddDia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tarefas Futuras:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tarefas do Dia:";
            // 
            // ckdFutura
            // 
            this.ckdFutura.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ckdFutura.ForeColor = System.Drawing.SystemColors.Info;
            this.ckdFutura.FormattingEnabled = true;
            this.ckdFutura.Location = new System.Drawing.Point(36, 289);
            this.ckdFutura.Name = "ckdFutura";
            this.ckdFutura.Size = new System.Drawing.Size(262, 184);
            this.ckdFutura.TabIndex = 12;
            this.ckdFutura.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckdFutura_ItemCheck);
            // 
            // ckdDia
            // 
            this.ckdDia.BackColor = System.Drawing.Color.Yellow;
            this.ckdDia.FormattingEnabled = true;
            this.ckdDia.Location = new System.Drawing.Point(304, 289);
            this.ckdDia.Name = "ckdDia";
            this.ckdDia.Size = new System.Drawing.Size(271, 184);
            this.ckdDia.TabIndex = 13;
            this.ckdDia.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckdDia_ItemCheck);
            // 
            // btnMoveDia
            // 
            this.btnMoveDia.BackColor = System.Drawing.Color.Yellow;
            this.btnMoveDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDia.Location = new System.Drawing.Point(36, 480);
            this.btnMoveDia.Name = "btnMoveDia";
            this.btnMoveDia.Size = new System.Drawing.Size(130, 46);
            this.btnMoveDia.TabIndex = 14;
            this.btnMoveDia.Text = "Mover para as tarefas do dia";
            this.btnMoveDia.UseVisualStyleBackColor = false;
            this.btnMoveDia.Click += new System.EventHandler(this.btnMoveDia_Click);
            // 
            // btnMoveFutura
            // 
            this.btnMoveFutura.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMoveFutura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFutura.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMoveFutura.Location = new System.Drawing.Point(430, 479);
            this.btnMoveFutura.Name = "btnMoveFutura";
            this.btnMoveFutura.Size = new System.Drawing.Size(145, 47);
            this.btnMoveFutura.TabIndex = 15;
            this.btnMoveFutura.Text = "Mover para as tarefas futuras";
            this.btnMoveFutura.UseVisualStyleBackColor = false;
            this.btnMoveFutura.Click += new System.EventHandler(this.btnMoveFutura_Click);
            // 
            // btnArquivar
            // 
            this.btnArquivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivar.Location = new System.Drawing.Point(262, 503);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(75, 23);
            this.btnArquivar.TabIndex = 16;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(484, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 41);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Iniciar Atividade";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(484, 137);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 25);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRest.Location = new System.Drawing.Point(484, 39);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(105, 45);
            this.btnRest.TabIndex = 19;
            this.btnRest.Text = "Iniciar Descanso";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeg.Location = new System.Drawing.Point(199, 98);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(47, 33);
            this.lblSeg.TabIndex = 20;
            this.lblSeg.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 547);
            this.Controls.Add(this.lblSeg);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.btnMoveFutura);
            this.Controls.Add(this.btnMoveDia);
            this.Controls.Add(this.ckdDia);
            this.Controls.Add(this.ckdFutura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddDia);
            this.Controls.Add(this.btnAddFutura);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pomodoro Target";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddFutura;
        private System.Windows.Forms.Button btnAddDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox ckdFutura;
        private System.Windows.Forms.CheckedListBox ckdDia;
        private System.Windows.Forms.Button btnMoveDia;
        private System.Windows.Forms.Button btnMoveFutura;
        private System.Windows.Forms.Button btnArquivar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Label lblSeg;
    }
}

