using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAcademia
{
	public partial class frmModalidades : Form
	{
		public frmModalidades()
		{
			InitializeComponent();
		}
		//conectar com a tabela professor, selecionar o campo que desejamos e retornar para o comboBox
		public void listarProfessores()
		{			
			try
			{
				Professores novoProfessor = new Professores();

				cbxProfessor.DataSource = novoProfessor.Listar();//A propriedade DataSource define a origem dos dados
				cbxProfessor.DisplayMember = "NOME_PROFESSOR";//é o campo que será exibido
				cbxProfessor.ValueMember = "ID_Professor";//Armazena o valor do item selecionado no displayMember

				cbxProfessor.SelectedIndex = -1;

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			

		}
		modalidade novaModalidade;
		

		private void frmModalidades_Load(object sender, EventArgs e)
		{
			listarModadelidades();
			listarProfessores();
		}
		public void limpar()
		{
			txtCodigo.Text = "0";
			txtNome.Clear();
			txtMensalidade.Clear();
			cbxProfessor.SelectedIndex = -1;
			txtPesquisa.Clear();
			rbnCategoria.Checked = true;
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			limpar();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			novaModalidade = new modalidade();

			if (txtCodigo.Text == "0")
			{
				try
				{
					if (cbxProfessor.SelectedIndex == -1)
					{
						MessageBox.Show("Selecione um professor antes de salvar.");
					}
					else
					{
						novaModalidade.salvar(txtNome.Text, Convert.ToDecimal(txtMensalidade.Text), Convert.ToInt32(cbxProfessor.SelectedValue));
						MessageBox.Show("Salvado com sucesso!", "Sucesso");
						limpar();
						listarModadelidades(); 
					}
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					limpar();
				}
			}
			else
			{
				try 
				{	        
					novaModalidade.alterar(txtNome.Text,Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(cbxProfessor.SelectedValue), Convert.ToDecimal(txtMensalidade.Text));
					MessageBox.Show("Alterado com sucesso!", "Sucesso");
					limpar();
					listarModadelidades();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					limpar();
					
				}
			}
		}
		private void listarModadelidades()
		{
			try
			{
				novaModalidade = new modalidade();

				dgvModalidade.DataSource = novaModalidade.Listar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvModalidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			novaModalidade = new modalidade();
			try
			{
				if (dgvModalidade.Columns[e.ColumnIndex].Name == "btnEditar")
				{
					txtCodigo.Text = dgvModalidade.Rows[e.RowIndex].Cells["ID_MODALIDADE"].Value.ToString();
					txtNome.Text = dgvModalidade.Rows[e.RowIndex].Cells["NOME_MODALIDADE"].Value.ToString();
					txtMensalidade.Text = dgvModalidade.Rows[e.RowIndex].Cells["MENSALIDADE"].Value.ToString();
					cbxProfessor.Text = dgvModalidade.Rows[e.RowIndex].Cells["NOME_PROFESSOR"].Value.ToString();
				}
				else
				{
					if (dgvModalidade.Columns[e.ColumnIndex].Name == "btnExcluir" &&
					MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						novaModalidade.excluir(Convert.ToInt32(dgvModalidade.Rows[e.RowIndex].Cells["ID_MODALIDADE"].Value.ToString()));
						MessageBox.Show("Exclusão feita com sucesso");
						listarModadelidades();
					}
				}
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			try
			{
				novaModalidade = new modalidade();
				if (rbnCategoria.Checked == true)
				{
					dgvModalidade.DataSource = novaModalidade.pesquisaCategoria(txtPesquisa.Text);
				}
				else
				{
					dgvModalidade.DataSource = novaModalidade.pesquisaProfessor(txtPesquisa.Text);
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void rbnProfessor_CheckedChanged(object sender, EventArgs e)
		{
			txtPesquisa.Clear();
		}

		private void cbxProfessor_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
