namespace NoPreguica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numGrav = new System.Windows.Forms.NumericUpDown();
            this.numUrg = new System.Windows.Forms.NumericUpDown();
            this.numTend = new System.Windows.Forms.NumericUpDown();
            this.txtaTarefa = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gravidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.somatotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGrav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarefa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gravidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urgência:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tendência:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lista de Tarefas na Matriz GUT:";
            // 
            // numGrav
            // 
            this.numGrav.Location = new System.Drawing.Point(146, 69);
            this.numGrav.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGrav.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrav.Name = "numGrav";
            this.numGrav.Size = new System.Drawing.Size(120, 20);
            this.numGrav.TabIndex = 5;
            this.numGrav.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUrg
            // 
            this.numUrg.Location = new System.Drawing.Point(146, 102);
            this.numUrg.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUrg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUrg.Name = "numUrg";
            this.numUrg.Size = new System.Drawing.Size(120, 20);
            this.numUrg.TabIndex = 6;
            this.numUrg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTend
            // 
            this.numTend.Location = new System.Drawing.Point(146, 133);
            this.numTend.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTend.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTend.Name = "numTend";
            this.numTend.Size = new System.Drawing.Size(120, 20);
            this.numTend.TabIndex = 7;
            this.numTend.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtaTarefa
            // 
            this.txtaTarefa.Location = new System.Drawing.Point(146, 36);
            this.txtaTarefa.Name = "txtaTarefa";
            this.txtaTarefa.Size = new System.Drawing.Size(211, 20);
            this.txtaTarefa.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(375, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarefa,
            this.gravidade,
            this.urgencia,
            this.tendencia,
            this.somatotal,
            this.prioridade});
            this.dataGridView1.Location = new System.Drawing.Point(67, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Tarefa
            // 
            this.Tarefa.HeaderText = "tarefa";
            this.Tarefa.Name = "Tarefa";
            // 
            // gravidade
            // 
            this.gravidade.HeaderText = "Gravidade";
            this.gravidade.Name = "gravidade";
            // 
            // urgencia
            // 
            this.urgencia.HeaderText = "Urgência";
            this.urgencia.Name = "urgencia";
            // 
            // tendencia
            // 
            this.tendencia.HeaderText = "Tendência";
            this.tendencia.Name = "tendencia";
            // 
            // somatotal
            // 
            this.somatotal.HeaderText = "Soma Total";
            this.somatotal.Name = "somatotal";
            // 
            // prioridade
            // 
            this.prioridade.HeaderText = "Prioridade";
            this.prioridade.Name = "prioridade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 466);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(161, 162);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(63, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(534, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Os itens de prioridade alta devem ser executados Imediatamente.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 674);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtaTarefa);
            this.Controls.Add(this.numTend);
            this.Controls.Add(this.numUrg);
            this.Controls.Add(this.numGrav);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NoPreguica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGrav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numGrav;
        private System.Windows.Forms.NumericUpDown numUrg;
        private System.Windows.Forms.NumericUpDown numTend;
        private System.Windows.Forms.TextBox txtaTarefa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn somatotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

