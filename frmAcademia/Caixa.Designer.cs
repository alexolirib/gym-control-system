namespace frmAcademia
{
	partial class Caixa
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxMovimentação = new System.Windows.Forms.ComboBox();
			this.cbxPagamento = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Movimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::frmAcademia.Properties.Resources.if_Cashier_2_379354;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(104, 63);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpPagamento);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbxPagamento);
			this.groupBox1.Controls.Add(this.cbxMovimentação);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.groupBox1.Location = new System.Drawing.Point(122, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(459, 77);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Movimentação";
			// 
			// cbxMovimentação
			// 
			this.cbxMovimentação.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxMovimentação.FormattingEnabled = true;
			this.cbxMovimentação.Items.AddRange(new object[] {
            "Todos",
            "Suprimento",
            "Retirada"});
			this.cbxMovimentação.Location = new System.Drawing.Point(9, 39);
			this.cbxMovimentação.Name = "cbxMovimentação";
			this.cbxMovimentação.Size = new System.Drawing.Size(125, 24);
			this.cbxMovimentação.TabIndex = 1;
			// 
			// cbxPagamento
			// 
			this.cbxPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxPagamento.FormattingEnabled = true;
			this.cbxPagamento.Items.AddRange(new object[] {
            "Todos",
            "Cheque",
            "Dinheiro"});
			this.cbxPagamento.Location = new System.Drawing.Point(140, 39);
			this.cbxPagamento.Name = "cbxPagamento";
			this.cbxPagamento.Size = new System.Drawing.Size(156, 24);
			this.cbxPagamento.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(137, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Forma de pagamento";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(299, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Forma de pagamento";
			// 
			// dtpPagamento
			// 
			this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpPagamento.Location = new System.Drawing.Point(302, 41);
			this.dtpPagamento.Name = "dtpPagamento";
			this.dtpPagamento.Size = new System.Drawing.Size(104, 22);
			this.dtpPagamento.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.groupBox2.Location = new System.Drawing.Point(598, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(181, 418);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Informações";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Inicial";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(9, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(166, 22);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 141);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(166, 22);
			this.textBox2.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Retirada";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 185);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(166, 22);
			this.textBox3.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 166);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Saldo";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(6, 95);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(166, 22);
			this.textBox4.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 16);
			this.label7.TabIndex = 10;
			this.label7.Text = "Entrada";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "Lançamento";
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Green;
			this.button1.Location = new System.Drawing.Point(6, 250);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "/\\ Suprimento";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.DarkRed;
			this.button2.Location = new System.Drawing.Point(6, 279);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(169, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "\\/ Retirada";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(6, 333);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(169, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "Abra Caixa";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(6, 362);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(169, 23);
			this.button4.TabIndex = 14;
			this.button4.Text = "Fecha Caixa";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movimento,
            this.Data,
            this.Forma,
            this.Valor});
			this.dataGridView1.Location = new System.Drawing.Point(12, 95);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(580, 335);
			this.dataGridView1.TabIndex = 7;
			// 
			// Movimento
			// 
			this.Movimento.HeaderText = "Movimento";
			this.Movimento.Name = "Movimento";
			this.Movimento.Width = 162;
			// 
			// Data
			// 
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.Data.DefaultCellStyle = dataGridViewCellStyle3;
			this.Data.HeaderText = "Data";
			this.Data.Name = "Data";
			this.Data.Width = 135;
			// 
			// Forma
			// 
			this.Forma.HeaderText = "Forma";
			this.Forma.Name = "Forma";
			this.Forma.Width = 140;
			// 
			// Valor
			// 
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = null;
			this.Valor.DefaultCellStyle = dataGridViewCellStyle4;
			this.Valor.HeaderText = "Valor";
			this.Valor.Name = "Valor";
			this.Valor.Width = 140;
			// 
			// button5
			// 
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Location = new System.Drawing.Point(55, 391);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(74, 23);
			this.button5.TabIndex = 15;
			this.button5.Text = "Sair";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// Caixa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 442);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Caixa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Caixa";
			this.Load += new System.EventHandler(this.Caixa_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbxMovimentação;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpPagamento;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxPagamento;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Movimento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data;
		private System.Windows.Forms.DataGridViewTextBoxColumn Forma;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
		private System.Windows.Forms.Button button5;
	}
}