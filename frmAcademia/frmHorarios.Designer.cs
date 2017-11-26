namespace frmAcademia
{
	partial class frmHorarios
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarios));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFim = new System.Windows.Forms.DateTimePicker();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.dgvHorarios = new System.Windows.Forms.DataGridView();
			this.ID_HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DIA_SEMANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbxDia = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dia da Semana";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(188, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "INICIO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(304, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "FIM";
			// 
			// dtpInicio
			// 
			this.dtpInicio.CustomFormat = "HH:mm";
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpInicio.Location = new System.Drawing.Point(191, 28);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.ShowUpDown = true;
			this.dtpInicio.Size = new System.Drawing.Size(91, 22);
			this.dtpInicio.TabIndex = 4;
			// 
			// dtpFim
			// 
			this.dtpFim.CustomFormat = "HH:mm";
			this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFim.Location = new System.Drawing.Point(307, 28);
			this.dtpFim.Name = "dtpFim";
			this.dtpFim.ShowUpDown = true;
			this.dtpFim.Size = new System.Drawing.Size(81, 22);
			this.dtpFim.TabIndex = 5;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Image = global::frmAcademia.Properties.Resources.if_cross_24_1031811;
			this.btnExcluir.Location = new System.Drawing.Point(355, 174);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(79, 52);
			this.btnExcluir.TabIndex = 7;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Image = global::frmAcademia.Properties.Resources.if_save_173091;
			this.btnSalvar.Location = new System.Drawing.Point(355, 83);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(79, 53);
			this.btnSalvar.TabIndex = 6;
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// dgvHorarios
			// 
			this.dgvHorarios.AllowUserToAddRows = false;
			this.dgvHorarios.AllowUserToDeleteRows = false;
			this.dgvHorarios.AllowUserToResizeColumns = false;
			this.dgvHorarios.AllowUserToResizeRows = false;
			this.dgvHorarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HORARIO,
            this.ID_TURMA,
            this.DIA_SEMANA,
            this.INICIO,
            this.FIM});
			this.dgvHorarios.Location = new System.Drawing.Point(12, 56);
			this.dgvHorarios.Name = "dgvHorarios";
			this.dgvHorarios.ReadOnly = true;
			this.dgvHorarios.RowHeadersVisible = false;
			this.dgvHorarios.Size = new System.Drawing.Size(325, 207);
			this.dgvHorarios.TabIndex = 10;
			this.dgvHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellContentClick);
			this.dgvHorarios.DoubleClick += new System.EventHandler(this.dgvHorarios_DoubleClick);
			// 
			// ID_HORARIO
			// 
			this.ID_HORARIO.DataPropertyName = "ID_HORARIO";
			this.ID_HORARIO.HeaderText = "ID_HORARIO";
			this.ID_HORARIO.Name = "ID_HORARIO";
			this.ID_HORARIO.ReadOnly = true;
			this.ID_HORARIO.Visible = false;
			// 
			// ID_TURMA
			// 
			this.ID_TURMA.DataPropertyName = "ID_TURMA";
			this.ID_TURMA.HeaderText = "ID_TURMA";
			this.ID_TURMA.Name = "ID_TURMA";
			this.ID_TURMA.ReadOnly = true;
			this.ID_TURMA.Visible = false;
			// 
			// DIA_SEMANA
			// 
			this.DIA_SEMANA.DataPropertyName = "DIA_SEMANA";
			this.DIA_SEMANA.HeaderText = "DIA DA SEMANA";
			this.DIA_SEMANA.Name = "DIA_SEMANA";
			this.DIA_SEMANA.ReadOnly = true;
			this.DIA_SEMANA.Width = 172;
			// 
			// INICIO
			// 
			this.INICIO.DataPropertyName = "INICIO";
			dataGridViewCellStyle1.Format = "t";
			dataGridViewCellStyle1.NullValue = null;
			this.INICIO.DefaultCellStyle = dataGridViewCellStyle1;
			this.INICIO.HeaderText = "Inicio";
			this.INICIO.Name = "INICIO";
			this.INICIO.ReadOnly = true;
			this.INICIO.Width = 75;
			// 
			// FIM
			// 
			this.FIM.DataPropertyName = "FIM";
			dataGridViewCellStyle2.Format = "t";
			dataGridViewCellStyle2.NullValue = null;
			this.FIM.DefaultCellStyle = dataGridViewCellStyle2;
			this.FIM.HeaderText = "Fim";
			this.FIM.Name = "FIM";
			this.FIM.ReadOnly = true;
			this.FIM.Width = 75;
			// 
			// cbxDia
			// 
			this.cbxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDia.FormattingEnabled = true;
			this.cbxDia.Items.AddRange(new object[] {
            "- Selecione um dia -",
            "Segunda - Feira",
            "Terça - Feira",
            "Quarta - Feira",
            "Quinta - Feira",
            "Sexta - Feira",
            "Sabado",
            "Domingo"});
			this.cbxDia.Location = new System.Drawing.Point(6, 28);
			this.cbxDia.Name = "cbxDia";
			this.cbxDia.Size = new System.Drawing.Size(158, 21);
			this.cbxDia.TabIndex = 3;
			this.cbxDia.SelectedIndexChanged += new System.EventHandler(this.cbxDia_SelectedIndexChanged);
			// 
			// frmHorarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 281);
			this.Controls.Add(this.dgvHorarios);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.dtpFim);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.cbxDia);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHorarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmHorarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DateTimePicker dtpFim;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.DataGridView dgvHorarios;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_HORARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_TURMA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA;
		private System.Windows.Forms.DataGridViewTextBoxColumn INICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FIM;
		private System.Windows.Forms.ComboBox cbxDia;
	}
}