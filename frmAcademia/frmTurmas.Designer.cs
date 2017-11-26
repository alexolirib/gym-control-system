namespace frmAcademia
{
	partial class frmTurmas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurmas));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnNovo = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTurma = new System.Windows.Forms.TextBox();
			this.txtAluno = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxModalidade = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvTurma = new System.Windows.Forms.DataGridView();
			this.MAXIMO_ALUNOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOME_MODALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_MODADELIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnHorario = new System.Windows.Forms.DataGridViewImageColumn();
			this.dgvHorario = new System.Windows.Forms.DataGridView();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
			this.lblHorarios = new System.Windows.Forms.Label();
			this.lblHorarios2 = new System.Windows.Forms.Label();
			this.DIA_SEMANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CODIGO_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(689, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnNovo
			// 
			this.btnNovo.Image = global::frmAcademia.Properties.Resources.if_new_24_103173;
			this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(45, 35);
			this.btnNovo.Text = "NOVO";
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.toolStripButton1.Image = global::frmAcademia.Properties.Resources.if_save_173091;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(51, 35);
			this.toolStripButton1.Text = "SALVAR";
			this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.txtTurma);
			this.panel1.Controls.Add(this.txtAluno);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cbxModalidade);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtCodigo);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(18, 50);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(367, 206);
			this.panel1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPesquisa);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(5, 122);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(335, 66);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PESQUISAR";
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(6, 38);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(323, 22);
			this.txtPesquisa.TabIndex = 0;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(37, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(224, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "Digite o nome da modalidade desejada";
			// 
			// txtTurma
			// 
			this.txtTurma.Location = new System.Drawing.Point(91, 94);
			this.txtTurma.Name = "txtTurma";
			this.txtTurma.Size = new System.Drawing.Size(88, 22);
			this.txtTurma.TabIndex = 1;
			// 
			// txtAluno
			// 
			this.txtAluno.Location = new System.Drawing.Point(252, 94);
			this.txtAluno.Name = "txtAluno";
			this.txtAluno.Size = new System.Drawing.Size(88, 22);
			this.txtAluno.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(186, 97);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "ALUNO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 97);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "TURMA";
			// 
			// cbxModalidade
			// 
			this.cbxModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxModalidade.FormattingEnabled = true;
			this.cbxModalidade.Location = new System.Drawing.Point(115, 54);
			this.cbxModalidade.Name = "cbxModalidade";
			this.cbxModalidade.Size = new System.Drawing.Size(225, 24);
			this.cbxModalidade.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 57);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "MODALIDADE";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(115, 25);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = true;
			this.txtCodigo.Size = new System.Drawing.Size(112, 22);
			this.txtCodigo.TabIndex = 1;
			this.txtCodigo.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "CODIGO";
			// 
			// dgvTurma
			// 
			this.dgvTurma.AllowUserToAddRows = false;
			this.dgvTurma.AllowUserToDeleteRows = false;
			this.dgvTurma.AllowUserToResizeColumns = false;
			this.dgvTurma.AllowUserToResizeRows = false;
			this.dgvTurma.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAXIMO_ALUNOS,
            this.NUMERO_TURMA,
            this.NOME_MODALIDADE,
            this.ID_TURMA,
            this.ID_MODADELIDADE,
            this.btnEditar,
            this.btnExcluir,
            this.btnHorario});
			this.dgvTurma.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvTurma.Location = new System.Drawing.Point(0, 263);
			this.dgvTurma.Name = "dgvTurma";
			this.dgvTurma.ReadOnly = true;
			this.dgvTurma.RowHeadersVisible = false;
			this.dgvTurma.Size = new System.Drawing.Size(689, 201);
			this.dgvTurma.TabIndex = 2;
			this.dgvTurma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellContentClick);
			this.dgvTurma.DoubleClick += new System.EventHandler(this.dgvTurma_DoubleClick);
			// 
			// MAXIMO_ALUNOS
			// 
			this.MAXIMO_ALUNOS.DataPropertyName = "MAXIMO_ALUNOS";
			this.MAXIMO_ALUNOS.HeaderText = "MAXIMO ALUNO";
			this.MAXIMO_ALUNOS.Name = "MAXIMO_ALUNOS";
			this.MAXIMO_ALUNOS.ReadOnly = true;
			this.MAXIMO_ALUNOS.Width = 184;
			// 
			// NUMERO_TURMA
			// 
			this.NUMERO_TURMA.DataPropertyName = "NUMERO_TURMA";
			this.NUMERO_TURMA.HeaderText = "TURMA";
			this.NUMERO_TURMA.Name = "NUMERO_TURMA";
			this.NUMERO_TURMA.ReadOnly = true;
			this.NUMERO_TURMA.Width = 125;
			// 
			// NOME_MODALIDADE
			// 
			this.NOME_MODALIDADE.DataPropertyName = "NOME_MODALIDADE";
			this.NOME_MODALIDADE.HeaderText = "MODALIDADE";
			this.NOME_MODALIDADE.Name = "NOME_MODALIDADE";
			this.NOME_MODALIDADE.ReadOnly = true;
			this.NOME_MODALIDADE.Width = 280;
			// 
			// ID_TURMA
			// 
			this.ID_TURMA.DataPropertyName = "ID_TURMA";
			this.ID_TURMA.HeaderText = "ID_TURMA";
			this.ID_TURMA.Name = "ID_TURMA";
			this.ID_TURMA.ReadOnly = true;
			this.ID_TURMA.Visible = false;
			// 
			// ID_MODADELIDADE
			// 
			this.ID_MODADELIDADE.DataPropertyName = "ID_MODALIDADE";
			this.ID_MODADELIDADE.HeaderText = "ID_MODALIDADE";
			this.ID_MODADELIDADE.Name = "ID_MODADELIDADE";
			this.ID_MODADELIDADE.ReadOnly = true;
			this.ID_MODADELIDADE.Visible = false;
			// 
			// btnEditar
			// 
			this.btnEditar.HeaderText = "";
			this.btnEditar.Image = global::frmAcademia.Properties.Resources.if_edit_173002;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.ReadOnly = true;
			this.btnEditar.Width = 32;
			// 
			// btnExcluir
			// 
			this.btnExcluir.HeaderText = "";
			this.btnExcluir.Image = global::frmAcademia.Properties.Resources.if_cross_24_1031811;
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.ReadOnly = true;
			this.btnExcluir.Width = 32;
			// 
			// btnHorario
			// 
			this.btnHorario.HeaderText = "";
			this.btnHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnHorario.Image")));
			this.btnHorario.Name = "btnHorario";
			this.btnHorario.ReadOnly = true;
			this.btnHorario.Width = 32;
			// 
			// dgvHorario
			// 
			this.dgvHorario.AllowUserToAddRows = false;
			this.dgvHorario.AllowUserToDeleteRows = false;
			this.dgvHorario.AllowUserToResizeColumns = false;
			this.dgvHorario.AllowUserToResizeRows = false;
			this.dgvHorario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DIA_SEMANA,
            this.INICIO,
            this.FIM,
            this.ID_HORARIO,
            this.CODIGO_TURMA});
			this.dgvHorario.Location = new System.Drawing.Point(392, 50);
			this.dgvHorario.Name = "dgvHorario";
			this.dgvHorario.ReadOnly = true;
			this.dgvHorario.RowHeadersVisible = false;
			this.dgvHorario.Size = new System.Drawing.Size(285, 206);
			this.dgvHorario.TabIndex = 3;
			this.dgvHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellContentClick);
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::frmAcademia.Properties.Resources.if_edit_173002;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.ReadOnly = true;
			this.dataGridViewImageColumn1.Width = 32;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::frmAcademia.Properties.Resources.if_close_4763231;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.ReadOnly = true;
			this.dataGridViewImageColumn2.Width = 32;
			// 
			// dataGridViewImageColumn3
			// 
			this.dataGridViewImageColumn3.HeaderText = "";
			this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
			this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
			this.dataGridViewImageColumn3.ReadOnly = true;
			this.dataGridViewImageColumn3.Width = 32;
			// 
			// lblHorarios
			// 
			this.lblHorarios.AutoSize = true;
			this.lblHorarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblHorarios.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblHorarios.Location = new System.Drawing.Point(490, 113);
			this.lblHorarios.Name = "lblHorarios";
			this.lblHorarios.Size = new System.Drawing.Size(87, 16);
			this.lblHorarios.TabIndex = 4;
			this.lblHorarios.Text = "HORÁRIOS";
			// 
			// lblHorarios2
			// 
			this.lblHorarios2.AutoSize = true;
			this.lblHorarios2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblHorarios2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHorarios2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblHorarios2.Location = new System.Drawing.Point(428, 145);
			this.lblHorarios2.Name = "lblHorarios2";
			this.lblHorarios2.Size = new System.Drawing.Size(225, 13);
			this.lblHorarios2.TabIndex = 5;
			this.lblHorarios2.Text = "Dê um duplo Clique na turma desejada";
			// 
			// DIA_SEMANA
			// 
			this.DIA_SEMANA.DataPropertyName = "DIA_SEMANA";
			this.DIA_SEMANA.HeaderText = "DIA DA SEMANA";
			this.DIA_SEMANA.Name = "DIA_SEMANA";
			this.DIA_SEMANA.ReadOnly = true;
			this.DIA_SEMANA.Width = 162;
			// 
			// INICIO
			// 
			this.INICIO.DataPropertyName = "INICIO";
			this.INICIO.HeaderText = "INICIO";
			this.INICIO.Name = "INICIO";
			this.INICIO.ReadOnly = true;
			this.INICIO.Width = 60;
			// 
			// FIM
			// 
			this.FIM.DataPropertyName = "FIM";
			this.FIM.HeaderText = "FIM";
			this.FIM.Name = "FIM";
			this.FIM.ReadOnly = true;
			this.FIM.Width = 60;
			// 
			// ID_HORARIO
			// 
			this.ID_HORARIO.DataPropertyName = "ID_HORARIO";
			this.ID_HORARIO.HeaderText = "ID_HORARIO";
			this.ID_HORARIO.Name = "ID_HORARIO";
			this.ID_HORARIO.ReadOnly = true;
			this.ID_HORARIO.Visible = false;
			// 
			// CODIGO_TURMA
			// 
			this.CODIGO_TURMA.DataPropertyName = "ID_TURMA";
			this.CODIGO_TURMA.HeaderText = "ID_TURMA";
			this.CODIGO_TURMA.Name = "CODIGO_TURMA";
			this.CODIGO_TURMA.ReadOnly = true;
			this.CODIGO_TURMA.Visible = false;
			// 
			// frmTurmas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 464);
			this.Controls.Add(this.lblHorarios2);
			this.Controls.Add(this.lblHorarios);
			this.Controls.Add(this.dgvHorario);
			this.Controls.Add(this.dgvTurma);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmTurmas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SCA - Controle de turmas";
			this.Load += new System.EventHandler(this.frmTurmas_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnNovo;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxModalidade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTurma;
		private System.Windows.Forms.TextBox txtAluno;
		private System.Windows.Forms.DataGridView dgvTurma;
		private System.Windows.Forms.DataGridView dgvHorario;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn MAXIMO_ALUNOS;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_TURMA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MODALIDADE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_TURMA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODADELIDADE;
		private System.Windows.Forms.DataGridViewImageColumn btnEditar;
		private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
		private System.Windows.Forms.DataGridViewImageColumn btnHorario;
		private System.Windows.Forms.Label lblHorarios;
		private System.Windows.Forms.Label lblHorarios2;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA;
		private System.Windows.Forms.DataGridViewTextBoxColumn INICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FIM;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_HORARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA;
	}
}