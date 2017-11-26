namespace frmAcademia
{
	partial class frmModalidades
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModalidades));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnNovo = new System.Windows.Forms.ToolStripButton();
			this.btnSalvar = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtMensalidade = new System.Windows.Forms.TextBox();
			this.cbxProfessor = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbnProfessor = new System.Windows.Forms.RadioButton();
			this.rbnCategoria = new System.Windows.Forms.RadioButton();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.dgvModalidade = new System.Windows.Forms.DataGridView();
			this.ID_MODALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOME_MODALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOME_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MENSALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.toolStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.Size = new System.Drawing.Size(559, 38);
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
			// btnSalvar
			// 
			this.btnSalvar.Image = global::frmAcademia.Properties.Resources.if_save_173091;
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
			this.label1.Location = new System.Drawing.Point(29, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "CODIGO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 87);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "NOME";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(210, 57);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "MENSALIDADE";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(0, 117);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "PROFESSOR";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(102, 54);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(101, 26);
			this.txtCodigo.TabIndex = 5;
			this.txtCodigo.Text = "0";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(102, 86);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(442, 26);
			this.txtNome.TabIndex = 1;
			// 
			// txtMensalidade
			// 
			this.txtMensalidade.Location = new System.Drawing.Point(328, 54);
			this.txtMensalidade.Name = "txtMensalidade";
			this.txtMensalidade.Size = new System.Drawing.Size(216, 26);
			this.txtMensalidade.TabIndex = 0;
			// 
			// cbxProfessor
			// 
			this.cbxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxProfessor.FormattingEnabled = true;
			this.cbxProfessor.Location = new System.Drawing.Point(102, 118);
			this.cbxProfessor.Name = "cbxProfessor";
			this.cbxProfessor.Size = new System.Drawing.Size(442, 26);
			this.cbxProfessor.TabIndex = 2;
			this.cbxProfessor.SelectedIndexChanged += new System.EventHandler(this.cbxProfessor_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbnProfessor);
			this.groupBox1.Controls.Add(this.rbnCategoria);
			this.groupBox1.Controls.Add(this.txtPesquisa);
			this.groupBox1.Location = new System.Drawing.Point(12, 149);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(532, 85);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PESQUISA";
			// 
			// rbnProfessor
			// 
			this.rbnProfessor.AutoSize = true;
			this.rbnProfessor.Location = new System.Drawing.Point(123, 57);
			this.rbnProfessor.Name = "rbnProfessor";
			this.rbnProfessor.Size = new System.Drawing.Size(95, 22);
			this.rbnProfessor.TabIndex = 12;
			this.rbnProfessor.Text = "Professor";
			this.rbnProfessor.UseVisualStyleBackColor = true;
			this.rbnProfessor.CheckedChanged += new System.EventHandler(this.rbnProfessor_CheckedChanged);
			// 
			// rbnCategoria
			// 
			this.rbnCategoria.AutoSize = true;
			this.rbnCategoria.Checked = true;
			this.rbnCategoria.Location = new System.Drawing.Point(20, 57);
			this.rbnCategoria.Name = "rbnCategoria";
			this.rbnCategoria.Size = new System.Drawing.Size(97, 22);
			this.rbnCategoria.TabIndex = 11;
			this.rbnCategoria.TabStop = true;
			this.rbnCategoria.Text = "Categoria";
			this.rbnCategoria.UseVisualStyleBackColor = true;
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(6, 25);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(520, 26);
			this.txtPesquisa.TabIndex = 10;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// dgvModalidade
			// 
			this.dgvModalidade.AllowUserToAddRows = false;
			this.dgvModalidade.AllowUserToDeleteRows = false;
			this.dgvModalidade.AllowUserToResizeColumns = false;
			this.dgvModalidade.AllowUserToResizeRows = false;
			this.dgvModalidade.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvModalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MODALIDADE,
            this.NOME_MODALIDADE,
            this.NOME_PROFESSOR,
            this.MENSALIDADE,
            this.ID_PROFESSOR,
            this.btnEditar,
            this.btnExcluir});
			this.dgvModalidade.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvModalidade.Location = new System.Drawing.Point(0, 240);
			this.dgvModalidade.Name = "dgvModalidade";
			this.dgvModalidade.ReadOnly = true;
			this.dgvModalidade.RowHeadersVisible = false;
			this.dgvModalidade.Size = new System.Drawing.Size(559, 185);
			this.dgvModalidade.TabIndex = 10;
			this.dgvModalidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModalidade_CellContentClick);
			// 
			// ID_MODALIDADE
			// 
			this.ID_MODALIDADE.DataPropertyName = "ID_MODALIDADE";
			this.ID_MODALIDADE.HeaderText = "CODIGO";
			this.ID_MODALIDADE.Name = "ID_MODALIDADE";
			this.ID_MODALIDADE.ReadOnly = true;
			this.ID_MODALIDADE.Visible = false;
			// 
			// NOME_MODALIDADE
			// 
			this.NOME_MODALIDADE.DataPropertyName = "NOME_MODALIDADE";
			this.NOME_MODALIDADE.HeaderText = "NOME";
			this.NOME_MODALIDADE.Name = "NOME_MODALIDADE";
			this.NOME_MODALIDADE.ReadOnly = true;
			this.NOME_MODALIDADE.Width = 245;
			// 
			// NOME_PROFESSOR
			// 
			this.NOME_PROFESSOR.DataPropertyName = "NOME_PROFESSOR";
			this.NOME_PROFESSOR.HeaderText = "PROFESSOR";
			this.NOME_PROFESSOR.Name = "NOME_PROFESSOR";
			this.NOME_PROFESSOR.ReadOnly = true;
			this.NOME_PROFESSOR.Width = 240;
			// 
			// MENSALIDADE
			// 
			this.MENSALIDADE.DataPropertyName = "MENSALIDADE";
			this.MENSALIDADE.HeaderText = "MENSALIDADE";
			this.MENSALIDADE.Name = "MENSALIDADE";
			this.MENSALIDADE.ReadOnly = true;
			this.MENSALIDADE.Visible = false;
			// 
			// ID_PROFESSOR
			// 
			this.ID_PROFESSOR.DataPropertyName = "ID_Professor";
			this.ID_PROFESSOR.HeaderText = "ID_PROFESSOR";
			this.ID_PROFESSOR.Name = "ID_PROFESSOR";
			this.ID_PROFESSOR.ReadOnly = true;
			this.ID_PROFESSOR.Visible = false;
			this.ID_PROFESSOR.Width = 240;
			// 
			// btnEditar
			// 
			this.btnEditar.DataPropertyName = "btnEditar";
			this.btnEditar.HeaderText = "";
			this.btnEditar.Image = global::frmAcademia.Properties.Resources.if_edit_173002;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.ReadOnly = true;
			this.btnEditar.Width = 32;
			// 
			// btnExcluir
			// 
			this.btnExcluir.DataPropertyName = "btnExcluir";
			this.btnExcluir.HeaderText = "";
			this.btnExcluir.Image = global::frmAcademia.Properties.Resources.if_cross_24_103181;
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.ReadOnly = true;
			this.btnExcluir.Width = 32;
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::frmAcademia.Properties.Resources.if_edit_173002;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 32;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::frmAcademia.Properties.Resources.if_cross_24_103181;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Width = 32;
			// 
			// frmModalidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 425);
			this.Controls.Add(this.dgvModalidade);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbxProfessor);
			this.Controls.Add(this.txtMensalidade);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmModalidades";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SCA - Controle de Academia";
			this.Load += new System.EventHandler(this.frmModalidades_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).EndInit();
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
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtMensalidade;
		private System.Windows.Forms.ComboBox cbxProfessor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbnProfessor;
		private System.Windows.Forms.RadioButton rbnCategoria;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.DataGridView dgvModalidade;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODALIDADE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MODALIDADE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PROFESSOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn MENSALIDADE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROFESSOR;
		private System.Windows.Forms.DataGridViewImageColumn btnEditar;
		private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
	}
}