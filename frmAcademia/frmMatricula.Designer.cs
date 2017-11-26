namespace frmAcademia
{
	partial class frmMatricula
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatricula));
			this.label19 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNomeAluno = new System.Windows.Forms.TextBox();
			this.txtModalidade = new System.Windows.Forms.TextBox();
			this.txtVencimento = new System.Windows.Forms.ComboBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTurma = new System.Windows.Forms.TextBox();
			this.txtMensalidade = new System.Windows.Forms.TextBox();
			this.txtVagas = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label19.Location = new System.Drawing.Point(48, 22);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(45, 20);
			this.label19.TabIndex = 13;
			this.label19.Text = "Nome";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "Modalidade";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(61, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "Turma";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(95, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "Vencimento";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(169, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 20);
			this.label4.TabIndex = 17;
			this.label4.Text = "Mensalidade";
			// 
			// txtNomeAluno
			// 
			this.txtNomeAluno.Enabled = false;
			this.txtNomeAluno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeAluno.Location = new System.Drawing.Point(99, 22);
			this.txtNomeAluno.Name = "txtNomeAluno";
			this.txtNomeAluno.ReadOnly = true;
			this.txtNomeAluno.Size = new System.Drawing.Size(349, 22);
			this.txtNomeAluno.TabIndex = 18;
			// 
			// txtModalidade
			// 
			this.txtModalidade.Enabled = false;
			this.txtModalidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModalidade.Location = new System.Drawing.Point(99, 54);
			this.txtModalidade.Name = "txtModalidade";
			this.txtModalidade.ReadOnly = true;
			this.txtModalidade.Size = new System.Drawing.Size(349, 22);
			this.txtModalidade.TabIndex = 19;
			// 
			// txtVencimento
			// 
			this.txtVencimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtVencimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVencimento.FormattingEnabled = true;
			this.txtVencimento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
			this.txtVencimento.Location = new System.Drawing.Point(76, 155);
			this.txtVencimento.Name = "txtVencimento";
			this.txtVencimento.Size = new System.Drawing.Size(126, 24);
			this.txtVencimento.TabIndex = 20;
			this.txtVencimento.SelectedIndexChanged += new System.EventHandler(this.txtVencimento_SelectedIndexChanged);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Image = global::frmAcademia.Properties.Resources.if_save_173091;
			this.btnSalvar.Location = new System.Drawing.Point(360, 135);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(86, 50);
			this.btnSalvar.TabIndex = 21;
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(298, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 20);
			this.label5.TabIndex = 22;
			this.label5.Text = "Vagas";
			// 
			// txtTurma
			// 
			this.txtTurma.Enabled = false;
			this.txtTurma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTurma.Location = new System.Drawing.Point(52, 109);
			this.txtTurma.Name = "txtTurma";
			this.txtTurma.Size = new System.Drawing.Size(72, 22);
			this.txtTurma.TabIndex = 25;
			// 
			// txtMensalidade
			// 
			this.txtMensalidade.Enabled = false;
			this.txtMensalidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensalidade.Location = new System.Drawing.Point(173, 109);
			this.txtMensalidade.Name = "txtMensalidade";
			this.txtMensalidade.Size = new System.Drawing.Size(83, 22);
			this.txtMensalidade.TabIndex = 26;
			// 
			// txtVagas
			// 
			this.txtVagas.Enabled = false;
			this.txtVagas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVagas.Location = new System.Drawing.Point(287, 109);
			this.txtVagas.Name = "txtVagas";
			this.txtVagas.Size = new System.Drawing.Size(72, 22);
			this.txtVagas.TabIndex = 27;
			// 
			// frmMatricula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 197);
			this.Controls.Add(this.txtVagas);
			this.Controls.Add(this.txtMensalidade);
			this.Controls.Add(this.txtTurma);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtVencimento);
			this.Controls.Add(this.txtModalidade);
			this.Controls.Add(this.txtNomeAluno);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label19);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMatricula";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMatricula_FormClosed);
			this.Load += new System.EventHandler(this.frmMatricula_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNomeAluno;
		private System.Windows.Forms.TextBox txtModalidade;
		private System.Windows.Forms.ComboBox txtVencimento;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTurma;
		private System.Windows.Forms.TextBox txtMensalidade;
		private System.Windows.Forms.TextBox txtVagas;

	}
}