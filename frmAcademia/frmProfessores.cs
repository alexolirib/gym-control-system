using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAcademia
{
	public partial class frmProfessores : Form
	{
		public frmProfessores()
		{
			InitializeComponent();
		}

		Professores novoProfessor;

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			if (txtCodigo.Text == "0")
			{
				//Evento do botão Salvar o qual grava as informações através do método salvar (classe professor)
				try
				{
					novoProfessor = new Professores();
					novoProfessor.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text,
										txtCpf.Text, Convert.ToDecimal(txtSalario.Text), txtTelefone.Text, txtObservacao.Text);
					MessageBox.Show("Professor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					listarProfessores();
					Limpar();
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				try
				{
					novoProfessor = new Professores();
					novoProfessor.alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text,
											txtTelefone.Text, txtCpf.Text, Convert.ToDecimal(txtSalario.Text), txtObservacao.Text);
					MessageBox.Show("Professor alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					listarProfessores();

				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}
		private void listarProfessores()
		{//Utiliza o método listar da Classe Professores o qual traz todos os registros da tabela 
			try
			{
				novoProfessor = new Professores();
				dgvProfessores.DataSource = novoProfessor.Listar();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		private void Limpar()
		{//Limpa campos do formulario
			txtCodigo.Text = "0";
			txtNome.Clear();
			txtEndereco.Clear();
			txtBairro.Clear();
			txtCep.Clear();
			txtCidade.Clear();
			txtCpf.Clear();
			txtTelefone.Clear();
			txtSalario.Clear();
			txtObservacao.Clear();
		}

		private void frmProfessores_Load(object sender, EventArgs e)
		{
			listarProfessores();

		}
		//cARREGA A 'Área de cadastro' com os dados da linha seleciona na DataGridView
		private void dgvProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//verifica o nome da coluna que recebeu o clique
			if (dgvProfessores.Columns[e.ColumnIndex].Name =="btnEditar")
			{
				txtCodigo.Text = dgvProfessores.Rows[e.RowIndex].Cells["ID_Professor"].Value.ToString();
				txtNome.Text = dgvProfessores.Rows[e.RowIndex].Cells["NOME_PROFESSOR"].Value.ToString();
				txtEndereco.Text = dgvProfessores.Rows[e.RowIndex].Cells["ENDERECO_PROFESSOR"].Value.ToString();
				txtBairro.Text = dgvProfessores.Rows[e.RowIndex].Cells["BAIRRO_PROFESSOR"].Value.ToString();
				txtCidade.Text = dgvProfessores.Rows[e.RowIndex].Cells["CIDADE_PROFESSOR"].Value.ToString();
				txtCep.Text = dgvProfessores.Rows[e.RowIndex].Cells["CEP_PROFESSOR"].Value.ToString();
				txtCpf.Text = dgvProfessores.Rows[e.RowIndex].Cells["CPF_PROFESSOR"].Value.ToString();
				txtSalario.Text = dgvProfessores.Rows[e.RowIndex].Cells["SALARIO"].Value.ToString();
				txtTelefone.Text = dgvProfessores.Rows[e.RowIndex].Cells["TELEFONE_PROFESSOR"].Value.ToString();
				txtObservacao.Text = dgvProfessores.Rows[e.RowIndex].Cells["OBSERVACAO"].Value.ToString();
			}
			else
				if (dgvProfessores.Columns[e.ColumnIndex].Name == "btnExcluir")
				{
					try
					{
						novoProfessor = new Professores();
						novoProfessor.excluir(Convert.ToInt32(dgvProfessores.Rows[e.RowIndex].Cells["ID_Professor"].Value.ToString()));
						MessageBox.Show("Exclusão do professor feita com sucesso!");
						listarProfessores();
						Limpar();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			Limpar();
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			/* Evento do txt pesquisa, o qual verifica se desejamos pesquisar por um nome ou cpf
				e exiba os resultados de acordo como que for digitado no mesmo*/
			novoProfessor = new Professores();

			try
			{

				if (rbnNome.Checked == true)
				{
					dgvProfessores.DataSource = novoProfessor.PesquisarNome(txtPesquisa.Text);
				}
				else
				{
					dgvProfessores.DataSource = novoProfessor.pesquisarCpf(txtPesquisa.Text);
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void rbnCpf_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
