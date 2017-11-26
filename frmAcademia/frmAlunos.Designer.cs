namespace frmAcademia
{
	partial class frmAlunos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlunos));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPesquisaAluno = new System.Windows.Forms.TextBox();
			this.dgvAlunos = new System.Windows.Forms.DataGridView();
			this.ID_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOME_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ENDERECO_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BAIRRO_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CIDADE_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CEP_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPF_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONE_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CELULAR_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rbnNome = new System.Windows.Forms.RadioButton();
			this.rbnCpf = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(90, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(314, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "Alunos Cadastrados";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(4, 72);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(404, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Para Editar as informações do Aluno, dê duplo clique sobre ele";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(92, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Pesquisar";
			// 
			// txtPesquisaAluno
			// 
			this.txtPesquisaAluno.Location = new System.Drawing.Point(158, 48);
			this.txtPesquisaAluno.Margin = new System.Windows.Forms.Padding(2);
			this.txtPesquisaAluno.Name = "txtPesquisaAluno";
			this.txtPesquisaAluno.Size = new System.Drawing.Size(387, 22);
			this.txtPesquisaAluno.TabIndex = 4;
			this.txtPesquisaAluno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// dgvAlunos
			// 
			this.dgvAlunos.AllowUserToAddRows = false;
			this.dgvAlunos.AllowUserToDeleteRows = false;
			this.dgvAlunos.AllowUserToResizeColumns = false;
			this.dgvAlunos.AllowUserToResizeRows = false;
			this.dgvAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Aluno,
            this.NOME_Aluno,
            this.ENDERECO_Aluno,
            this.BAIRRO_Aluno,
            this.CIDADE_Aluno,
            this.CEP_Aluno,
            this.CPF_Aluno,
            this.TELEFONE_Aluno,
            this.CELULAR_Aluno,
            this.OBSERVACAO,
            this.SEXO});
			this.dgvAlunos.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvAlunos.Location = new System.Drawing.Point(0, 125);
			this.dgvAlunos.Margin = new System.Windows.Forms.Padding(2);
			this.dgvAlunos.Name = "dgvAlunos";
			this.dgvAlunos.ReadOnly = true;
			this.dgvAlunos.RowHeadersVisible = false;
			this.dgvAlunos.Size = new System.Drawing.Size(668, 266);
			this.dgvAlunos.TabIndex = 5;
			this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
			this.dgvAlunos.DoubleClick += new System.EventHandler(this.dgvAlunos_DoubleClick);
			this.dgvAlunos.Enter += new System.EventHandler(this.dgvAlunos_Enter);
			// 
			// ID_Aluno
			// 
			this.ID_Aluno.DataPropertyName = "ID_Aluno";
			this.ID_Aluno.HeaderText = "Codigo";
			this.ID_Aluno.Name = "ID_Aluno";
			this.ID_Aluno.ReadOnly = true;
			this.ID_Aluno.Visible = false;
			// 
			// NOME_Aluno
			// 
			this.NOME_Aluno.DataPropertyName = "NOME_Aluno";
			this.NOME_Aluno.HeaderText = "Nome";
			this.NOME_Aluno.Name = "NOME_Aluno";
			this.NOME_Aluno.ReadOnly = true;
			this.NOME_Aluno.Width = 190;
			// 
			// ENDERECO_Aluno
			// 
			this.ENDERECO_Aluno.DataPropertyName = "ENDERECO_Aluno";
			this.ENDERECO_Aluno.HeaderText = "Endereço";
			this.ENDERECO_Aluno.Name = "ENDERECO_Aluno";
			this.ENDERECO_Aluno.ReadOnly = true;
			this.ENDERECO_Aluno.Width = 250;
			// 
			// BAIRRO_Aluno
			// 
			this.BAIRRO_Aluno.DataPropertyName = "BAIRRO_Aluno";
			this.BAIRRO_Aluno.HeaderText = "Bairro";
			this.BAIRRO_Aluno.Name = "BAIRRO_Aluno";
			this.BAIRRO_Aluno.ReadOnly = true;
			this.BAIRRO_Aluno.Visible = false;
			// 
			// CIDADE_Aluno
			// 
			this.CIDADE_Aluno.DataPropertyName = "CIDADE_Aluno";
			this.CIDADE_Aluno.HeaderText = "Cidade";
			this.CIDADE_Aluno.Name = "CIDADE_Aluno";
			this.CIDADE_Aluno.ReadOnly = true;
			this.CIDADE_Aluno.Visible = false;
			// 
			// CEP_Aluno
			// 
			this.CEP_Aluno.DataPropertyName = "CEP_Aluno";
			this.CEP_Aluno.HeaderText = "CEP";
			this.CEP_Aluno.Name = "CEP_Aluno";
			this.CEP_Aluno.ReadOnly = true;
			this.CEP_Aluno.Visible = false;
			this.CEP_Aluno.Width = 125;
			// 
			// CPF_Aluno
			// 
			this.CPF_Aluno.DataPropertyName = "CPF_Aluno";
			this.CPF_Aluno.HeaderText = "CPF";
			this.CPF_Aluno.Name = "CPF_Aluno";
			this.CPF_Aluno.ReadOnly = true;
			this.CPF_Aluno.Width = 125;
			// 
			// TELEFONE_Aluno
			// 
			this.TELEFONE_Aluno.DataPropertyName = "TELEFONE_Aluno";
			this.TELEFONE_Aluno.HeaderText = "Telefone";
			this.TELEFONE_Aluno.Name = "TELEFONE_Aluno";
			this.TELEFONE_Aluno.ReadOnly = true;
			// 
			// CELULAR_Aluno
			// 
			this.CELULAR_Aluno.DataPropertyName = "CELULAR_Aluno";
			this.CELULAR_Aluno.HeaderText = "Celular";
			this.CELULAR_Aluno.Name = "CELULAR_Aluno";
			this.CELULAR_Aluno.ReadOnly = true;
			this.CELULAR_Aluno.Visible = false;
			// 
			// OBSERVACAO
			// 
			this.OBSERVACAO.DataPropertyName = "OBSERVACAO";
			this.OBSERVACAO.HeaderText = "Observação";
			this.OBSERVACAO.Name = "OBSERVACAO";
			this.OBSERVACAO.ReadOnly = true;
			this.OBSERVACAO.Visible = false;
			// 
			// SEXO
			// 
			this.SEXO.DataPropertyName = "Sexo";
			this.SEXO.HeaderText = "Sexo";
			this.SEXO.Name = "SEXO";
			this.SEXO.ReadOnly = true;
			this.SEXO.Visible = false;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdicionar.Image = global::frmAcademia.Properties.Resources.if_clients_43573;
			this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAdicionar.Location = new System.Drawing.Point(549, 27);
			this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(108, 67);
			this.btnAdicionar.TabIndex = 6;
			this.btnAdicionar.Text = "ADICIONAR ALUNO";
			this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::frmAcademia.Properties.Resources.if_personal_6628;
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(78, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// rbnNome
			// 
			this.rbnNome.AutoSize = true;
			this.rbnNome.Checked = true;
			this.rbnNome.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbnNome.Location = new System.Drawing.Point(22, 97);
			this.rbnNome.Name = "rbnNome";
			this.rbnNome.Size = new System.Drawing.Size(56, 20);
			this.rbnNome.TabIndex = 7;
			this.rbnNome.TabStop = true;
			this.rbnNome.Text = "Nome";
			this.rbnNome.UseVisualStyleBackColor = true;
			// 
			// rbnCpf
			// 
			this.rbnCpf.AutoSize = true;
			this.rbnCpf.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbnCpf.Location = new System.Drawing.Point(124, 97);
			this.rbnCpf.Name = "rbnCpf";
			this.rbnCpf.Size = new System.Drawing.Size(45, 20);
			this.rbnCpf.TabIndex = 8;
			this.rbnCpf.Text = "Cpf";
			this.rbnCpf.UseVisualStyleBackColor = true;
			// 
			// frmAlunos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 391);
			this.Controls.Add(this.rbnCpf);
			this.Controls.Add(this.rbnNome);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.dgvAlunos);
			this.Controls.Add(this.txtPesquisaAluno);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmAlunos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LCA - ALUNOS CADASTRADOS";
			this.Load += new System.EventHandler(this.frmAlunos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPesquisaAluno;
		private System.Windows.Forms.DataGridView dgvAlunos;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOME_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn CEP_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPF_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR_Aluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACAO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
		private System.Windows.Forms.RadioButton rbnNome;
		private System.Windows.Forms.RadioButton rbnCpf;
	}
}