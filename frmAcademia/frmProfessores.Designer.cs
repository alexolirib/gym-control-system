namespace frmAcademia
{
	partial class frmProfessores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessores));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnNovo = new System.Windows.Forms.ToolStripButton();
			this.btnSalvar = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtCep = new System.Windows.Forms.MaskedTextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.MaskedTextBox();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.txtSalario = new System.Windows.Forms.TextBox();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.rbnNome = new System.Windows.Forms.RadioButton();
			this.rbnCpf = new System.Windows.Forms.RadioButton();
			this.dgvProfessores = new System.Windows.Forms.DataGridView();
			this.ID_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOME_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ENDERECO_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BAIRRO_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CIDADE_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CEP_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPF_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONE_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(778, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnNovo
			// 
			this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
			this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(45, 35);
			this.btnNovo.Text = "NOVO";
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(51, 35);
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(39, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "CÓDIGO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(556, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "PESQUISA";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(525, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "OBSERVAÇÕES";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(361, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "CEP";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(397, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 18);
			this.label5.TabIndex = 5;
			this.label5.Text = "SALARIO";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(239, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 18);
			this.label6.TabIndex = 6;
			this.label6.Text = "CPF";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(21, 219);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 18);
			this.label7.TabIndex = 7;
			this.label7.Text = "TELEFONE";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(44, 184);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 18);
			this.label8.TabIndex = 8;
			this.label8.Text = "CIDADE";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(41, 149);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 18);
			this.label9.TabIndex = 9;
			this.label9.Text = "BAIRRO";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(18, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(87, 18);
			this.label10.TabIndex = 10;
			this.label10.Text = "ENDEREÇO";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(54, 79);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(51, 18);
			this.label11.TabIndex = 11;
			this.label11.Text = "NOME";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(111, 41);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(72, 26);
			this.txtCodigo.TabIndex = 12;
			this.txtCodigo.Text = "0";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(111, 73);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(411, 26);
			this.txtNome.TabIndex = 0;
			// 
			// txtObservacao
			// 
			this.txtObservacao.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacao.Location = new System.Drawing.Point(528, 65);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(202, 67);
			this.txtObservacao.TabIndex = 8;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(111, 111);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(411, 26);
			this.txtEndereco.TabIndex = 1;
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(111, 146);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(244, 26);
			this.txtBairro.TabIndex = 2;
			// 
			// txtCep
			// 
			this.txtCep.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCep.Location = new System.Drawing.Point(403, 146);
			this.txtCep.Mask = "00000-000";
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(147, 26);
			this.txtCep.TabIndex = 3;
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(111, 181);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(439, 26);
			this.txtCidade.TabIndex = 4;
			// 
			// txtCpf
			// 
			this.txtCpf.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpf.Location = new System.Drawing.Point(274, 214);
			this.txtCpf.Mask = "000,000,000-00";
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(117, 26);
			this.txtCpf.TabIndex = 6;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone.Location = new System.Drawing.Point(111, 214);
			this.txtTelefone.Mask = "(99) 0000-0000";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(122, 26);
			this.txtTelefone.TabIndex = 5;
			// 
			// txtSalario
			// 
			this.txtSalario.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalario.Location = new System.Drawing.Point(468, 214);
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.Size = new System.Drawing.Size(83, 26);
			this.txtSalario.TabIndex = 7;
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisa.Location = new System.Drawing.Point(556, 175);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(202, 26);
			this.txtPesquisa.TabIndex = 9;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// rbnNome
			// 
			this.rbnNome.AutoSize = true;
			this.rbnNome.Checked = true;
			this.rbnNome.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnNome.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbnNome.Location = new System.Drawing.Point(559, 222);
			this.rbnNome.Name = "rbnNome";
			this.rbnNome.Size = new System.Drawing.Size(69, 22);
			this.rbnNome.TabIndex = 10;
			this.rbnNome.TabStop = true;
			this.rbnNome.Text = "NOME";
			this.rbnNome.UseVisualStyleBackColor = true;
			// 
			// rbnCpf
			// 
			this.rbnCpf.AutoSize = true;
			this.rbnCpf.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnCpf.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbnCpf.Location = new System.Drawing.Point(634, 222);
			this.rbnCpf.Name = "rbnCpf";
			this.rbnCpf.Size = new System.Drawing.Size(54, 22);
			this.rbnCpf.TabIndex = 11;
			this.rbnCpf.Text = "CPF";
			this.rbnCpf.UseVisualStyleBackColor = true;
			this.rbnCpf.CheckedChanged += new System.EventHandler(this.rbnCpf_CheckedChanged);
			// 
			// dgvProfessores
			// 
			this.dgvProfessores.AllowUserToAddRows = false;
			this.dgvProfessores.AllowUserToDeleteRows = false;
			this.dgvProfessores.AllowUserToResizeColumns = false;
			this.dgvProfessores.AllowUserToResizeRows = false;
			this.dgvProfessores.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PROFESSOR,
            this.NOME_PROFESSOR,
            this.ENDERECO_PROFESSOR,
            this.BAIRRO_PROFESSOR,
            this.CIDADE_PROFESSOR,
            this.CEP_PROFESSOR,
            this.CPF_PROFESSOR,
            this.SALARIO,
            this.TELEFONE_PROFESSOR,
            this.OBSERVACAO,
            this.btnEditar,
            this.btnExcluir});
			this.dgvProfessores.Location = new System.Drawing.Point(0, 250);
			this.dgvProfessores.Name = "dgvProfessores";
			this.dgvProfessores.ReadOnly = true;
			this.dgvProfessores.RowHeadersVisible = false;
			this.dgvProfessores.Size = new System.Drawing.Size(777, 181);
			this.dgvProfessores.TabIndex = 25;
			this.dgvProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessores_CellContentClick);
			// 
			// ID_PROFESSOR
			// 
			this.ID_PROFESSOR.DataPropertyName = "ID_Professor";
			this.ID_PROFESSOR.HeaderText = "CÓDIGO";
			this.ID_PROFESSOR.Name = "ID_PROFESSOR";
			this.ID_PROFESSOR.ReadOnly = true;
			this.ID_PROFESSOR.Visible = false;
			// 
			// NOME_PROFESSOR
			// 
			this.NOME_PROFESSOR.DataPropertyName = "NOME_PROFESSOR";
			this.NOME_PROFESSOR.HeaderText = "Nome";
			this.NOME_PROFESSOR.Name = "NOME_PROFESSOR";
			this.NOME_PROFESSOR.ReadOnly = true;
			this.NOME_PROFESSOR.Width = 200;
			// 
			// ENDERECO_PROFESSOR
			// 
			this.ENDERECO_PROFESSOR.DataPropertyName = "ENDERECO_PROFESSOR";
			this.ENDERECO_PROFESSOR.HeaderText = "Endereço";
			this.ENDERECO_PROFESSOR.Name = "ENDERECO_PROFESSOR";
			this.ENDERECO_PROFESSOR.ReadOnly = true;
			this.ENDERECO_PROFESSOR.Width = 250;
			// 
			// BAIRRO_PROFESSOR
			// 
			this.BAIRRO_PROFESSOR.DataPropertyName = "BAIRRO_PROFESSOR";
			this.BAIRRO_PROFESSOR.HeaderText = "BAIRRO";
			this.BAIRRO_PROFESSOR.Name = "BAIRRO_PROFESSOR";
			this.BAIRRO_PROFESSOR.ReadOnly = true;
			this.BAIRRO_PROFESSOR.Visible = false;
			// 
			// CIDADE_PROFESSOR
			// 
			this.CIDADE_PROFESSOR.DataPropertyName = "CIDADE_PROFESSOR";
			this.CIDADE_PROFESSOR.HeaderText = "CIDADE";
			this.CIDADE_PROFESSOR.Name = "CIDADE_PROFESSOR";
			this.CIDADE_PROFESSOR.ReadOnly = true;
			this.CIDADE_PROFESSOR.Visible = false;
			// 
			// CEP_PROFESSOR
			// 
			this.CEP_PROFESSOR.DataPropertyName = "CEP_PROFESSOR";
			this.CEP_PROFESSOR.HeaderText = "CEP";
			this.CEP_PROFESSOR.Name = "CEP_PROFESSOR";
			this.CEP_PROFESSOR.ReadOnly = true;
			this.CEP_PROFESSOR.Visible = false;
			this.CEP_PROFESSOR.Width = 120;
			// 
			// CPF_PROFESSOR
			// 
			this.CPF_PROFESSOR.DataPropertyName = "CPF_PROFESSOR";
			dataGridViewCellStyle3.Format = "000,000,000-00";
			dataGridViewCellStyle3.NullValue = null;
			this.CPF_PROFESSOR.DefaultCellStyle = dataGridViewCellStyle3;
			this.CPF_PROFESSOR.HeaderText = "CPF";
			this.CPF_PROFESSOR.Name = "CPF_PROFESSOR";
			this.CPF_PROFESSOR.ReadOnly = true;
			this.CPF_PROFESSOR.Width = 115;
			// 
			// SALARIO
			// 
			this.SALARIO.DataPropertyName = "SALARIO";
			this.SALARIO.HeaderText = "SALARIO";
			this.SALARIO.Name = "SALARIO";
			this.SALARIO.ReadOnly = true;
			this.SALARIO.Visible = false;
			// 
			// TELEFONE_PROFESSOR
			// 
			this.TELEFONE_PROFESSOR.DataPropertyName = "TELEFONE_PROFESSOR";
			dataGridViewCellStyle4.Format = "(99)9999-9999";
			dataGridViewCellStyle4.NullValue = null;
			this.TELEFONE_PROFESSOR.DefaultCellStyle = dataGridViewCellStyle4;
			this.TELEFONE_PROFESSOR.HeaderText = "Fone";
			this.TELEFONE_PROFESSOR.Name = "TELEFONE_PROFESSOR";
			this.TELEFONE_PROFESSOR.ReadOnly = true;
			this.TELEFONE_PROFESSOR.Width = 130;
			// 
			// OBSERVACAO
			// 
			this.OBSERVACAO.DataPropertyName = "OBSERVACAO";
			this.OBSERVACAO.HeaderText = "OBSERVACAO";
			this.OBSERVACAO.Name = "OBSERVACAO";
			this.OBSERVACAO.ReadOnly = true;
			this.OBSERVACAO.Visible = false;
			// 
			// btnEditar
			// 
			this.btnEditar.HeaderText = "";
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.ReadOnly = true;
			this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnEditar.Width = 32;
			// 
			// btnExcluir
			// 
			this.btnExcluir.HeaderText = "";
			this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.ReadOnly = true;
			this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnExcluir.Width = 32;
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::frmAcademia.Properties.Resources.if_save_173091;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.ReadOnly = true;
			this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewImageColumn1.Width = 32;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::frmAcademia.Properties.Resources.if_close_476323;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.ReadOnly = true;
			this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewImageColumn2.Width = 32;
			// 
			// frmProfessores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 431);
			this.Controls.Add(this.dgvProfessores);
			this.Controls.Add(this.rbnCpf);
			this.Controls.Add(this.rbnNome);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.txtSalario);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtCep);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmProfessores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SCA - CONTROLE DE PROFESSORES";
			this.Load += new System.EventHandler(this.frmProfessores_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnNovo;
		private System.Windows.Forms.ToolStripButton btnSalvar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.MaskedTextBox txtCep;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.MaskedTextBox txtCpf;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.TextBox txtSalario;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.RadioButton rbnNome;
		private System.Windows.Forms.RadioButton rbnCpf;
		private System.Windows.Forms.DataGridView dgvProfessores;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn CEP_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPF_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACAO;
		private System.Windows.Forms.DataGridViewImageColumn btnEditar;
		private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
	}
}