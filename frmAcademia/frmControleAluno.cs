﻿using System;
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
	public partial class txtAtiva : Form
	{

		frmAlunos formulario;
		//instanciamento do frmAunos no forme irá ser o metodo construtor, assim o form terá acesso a todos os eventos frmAlunos
		
		public txtAtiva(frmAlunos formulario)
		{
			InitializeComponent();
			
			this.formulario = formulario;
		}
		Mensalidade novaMensalidade;
		alunos novoAluno;
		Turma novoTurma;
		matricula novaMatricula;
		frmMatricula novaFrmMatricula;
		public void listarTurmas()
		{
			novoTurma = new Turma();
			try
			{
				
				dgvTurmasCadastro.DataSource = novoTurma.listarComMesalidade();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			novoAluno = new alunos();
			
			try
			{
				if (txtCodigo.Text == "0")
				{
					novoAluno.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtCpf.Text, txtTelefone.Text, txtCelular.Text, txtObservacao.Text, txtSexo.Text);
					MessageBox.Show("Salvo aluno com sucesso!!");
					this.Close();
					
					
				}
				else
				{
					novoAluno.Update(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtCpf.Text, txtTelefone.Text, txtCelular.Text, txtObservacao.Text, txtSexo.Text);
					MessageBox.Show("Alterado com Sucesso!!");
					limpar();
					this.Close();
				}
			}
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmControleAluno_Load(object sender, EventArgs e)
		{			
			listarTurmas();
			//atualizaVagas();
			listarMatricula();
			cbxVencimento.SelectedIndex = -1;
			bloqueaCadastro();
			listarMensalidade();
			cbSiatuacao.SelectedIndex = 0;
			
		}
		public void ExibirAluno(DataGridView aluno)
		{
			//é para exibir as informações do aluno, as quais estão está armazenado a variavel aluno
			try
			{
				//adicionar o nome do aluno no título do formulário
				this.Text = "SCA - CONTROLE DE ALUNOS :: " + aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_Aluno"].Value.ToString() + "::";
 
				//Passagem dos valores do dataGridView para os textBox
				txtCodigo.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["ID_Aluno"].Value.ToString();
				txtNome.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_Aluno"].Value.ToString();
				txtEndereco.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["ENDERECO_Aluno"].Value.ToString();
				txtBairro.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["BAIRRO_Aluno"].Value.ToString();
				txtCidade.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CIDADE_Aluno"].Value.ToString();
				txtCep.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CEP_Aluno"].Value.ToString();
				txtCpf.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CPF_Aluno"].Value.ToString();
				txtTelefone.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["TELEFONE_Aluno"].Value.ToString();
				txtCelular.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CELULAR_Aluno"].Value.ToString();
				txtObservacao.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["OBSERVACAO"].Value.ToString();
				txtSexo.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["Sexo"].Value.ToString();

				txtCodAluno.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["ID_Aluno"].Value.ToString();
				txtNomeAluno.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_Aluno"].Value.ToString();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void limpar()
		{
			txtBairro.Clear();
			txtCelular.Clear();
			txtCep.Clear();
			txtCidade.Clear();
			txtCodigo.Text = "0";
			txtCpf.Clear();
			txtEndereco.Clear();
			txtNome.Clear();
			txtObservacao.Clear();
			txtSexo.SelectedIndex = -1;
			txtTelefone.Clear();
			txtAlunoMatriculado.Clear();
			this.Text = "SCA - CONTROLE DE ALUNOS";
			btnSalvar.Enabled = true;
			txtNomeAluno.Clear();
			txtCodAluno.Text = "0";
			listarMatricula();
			listarTurmas();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if (txtCodigo.Text == "0")
			{
				MessageBox.Show("Impossivel Excluir");
			}
			else
			{
				novoAluno = new alunos();
				if (MessageBox.Show("Deseja realmente excluir esse aluno??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
				{
					novoAluno.Delete(Convert.ToInt32(txtCodigo.Text));
					MessageBox.Show("Exclusão feita com sucesso!");
					limpar();
					this.Close();
				}
			}
		}
		private void btnNovo_Click(object sender, EventArgs e)
		{
			limpar();
		}

		private void frmControleAluno_FormClosed(object sender, FormClosedEventArgs e)
		{// o método formClosed faz com que ocorra uma ação assim que eu feche esse form
			// assim sempre quando fechar já irá atualizar as informações do lista alunos do frmAlunos
			formulario.listarAlunos();
		}
		private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvTurmasCadastro.Columns[e.ColumnIndex].Name == "btnHorario")
			{
				frmHorarios frmHorario = new frmHorarios(Convert.ToInt32(dgvTurmasCadastro.Rows[dgvTurmasCadastro.CurrentRow.Index].Cells["ID_TURMA_CADASTRO"].Value.ToString()), dgvTurmasCadastro.Rows[dgvTurmasCadastro.CurrentRow.Index].Cells["NOME_MODALIDADE"].Value.ToString(),dgvTurmasCadastro.Rows[dgvTurmasCadastro.CurrentRow.Index].Cells["numeroTurmaCadastro"].Value.ToString());
				frmHorario.ShowDialog();
			}
			bloqueaCadastro();			 
		}

		private void dgvTurmasCadastro_DoubleClick(object sender, EventArgs e)
		{
			if (txtCodAluno.Text == "0")
			{
				MessageBox.Show("Nenhum Aluno selecionado!!","Error");
			}
			else
			{
				try
				{
					DataTable dadosTabela = new DataTable();
					novaMatricula = new matricula();
					dadosTabela = novaMatricula.verificaAlunoMatriculado(Convert.ToInt32(txtCodAluno.Text), Convert.ToInt32(dgvTurmasCadastro.Rows[dgvTurmasCadastro.CurrentRow.Index].Cells["ID_TURMA_CADASTRO"].Value.ToString()));
					int linhas = dadosTabela.Rows.Count;
					if (linhas > 0)
					{
						MessageBox.Show("Aluno já cadastrado na modalidade desejada!!");
					}
					else
					{
						if (dgvTurmasCadastro.Rows[dgvTurmasCadastro.CurrentRow.Index].Cells["VagasSobrando"].Value.ToString() == "0")
						{
							MessageBox.Show("Turma Lotada!!", "Lotada");
						}
						else
						{
							novaFrmMatricula = new frmMatricula(this, txtNomeAluno.Text, Convert.ToInt32(txtCodAluno.Text));
							DataGridView modalidadeSelecionada = dgvTurmasCadastro.Rows[dgvTurmasCadastro.CurrentRow.Index].DataGridView;
							novaFrmMatricula.ExibirMatricula(modalidadeSelecionada);
							novaFrmMatricula.ShowDialog();
							listarTurmas();
							//Para fazer a gravação da Mensalidade, sempre gerá
							if (teste == 1)
							{								
								int dia = Convert.ToInt32(dgvMatriculas.Rows[0].Cells["VENCIMENTO2"].Value);
								int mes = Convert.ToInt32(DateTime.Today.Month);
								int ano = Convert.ToInt32(DateTime.Today.Year);
								if (Convert.ToDateTime(dia + "/" + mes + "/" + ano) < DateTime.Today.Date)
								{
									if (mes == 12)
									{
										mes = 1;
										ano++;
									}
									else
									{
										mes++;
									}
								}
								DateTime data = Convert.ToDateTime(dia + "/" + mes + "/" + ano);
								novaMensalidade = new Mensalidade();
								novaMensalidade.Salvar(Convert.ToInt32(dgvMatriculas.Rows[0].Cells["ID_MATRICULA2"].Value), data, "Em Aberto");
								MessageBox.Show("Foi Gerado uma mensalidade para essa matrícula!!", "Mensalidade");
								listarMensalidade();
							}
							teste = 0;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} 
			}
		}
		public void detalhesMensalidade()
		{
			//Verifica a situação do aluno! 
			Decimal total = 0;

			for (int i = 0; i < dgvMensalidade.Rows.Count; i++)
			{
				if (dgvMensalidade.Rows[i].Cells["SITUACAO"].Value.ToString() == "Em Aberto")
				{
					if (Convert.ToDateTime(dgvMensalidade.Rows[i].Cells["DATA_VENCIMENTO"].Value) < DateTime.Today.Date)
					{						
						dgvMensalidade.Rows[i].Cells["SITUACAO"].Value = "Atrasado";
						
						total += Convert.ToDecimal(dgvMensalidade.Rows[i].Cells["MENSALIDADE10"].Value); 
					}
					else
					{
						dgvMensalidade.Rows[i].Cells["SITUACAO"].Value = "Em Aberto";
					}
				}
				else
				{
					dgvMensalidade.Rows[i].Cells["SITUACAO"].Value = "Pago";
				}
			}
			if (total > 0)
			{
				txtAtraso.Text = "R$ " + total;
			}
			else
			{ 
				txtAtraso.Text = "--------------";
			}
		}
		private void listarMensalidadePagas()
		{
			try
			{
				novaMensalidade = new Mensalidade();
				dgvMensalidade.DataSource = novaMensalidade.ListarPelasContasPagas(Convert.ToInt32(txtCodAluno.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void listarMensalidadeNaoPagas()
		{
			try
			{
				novaMensalidade = new Mensalidade();
				dgvMensalidade.DataSource = novaMensalidade.ListarPelasContasNaoPagas(Convert.ToInt32(txtCodAluno.Text));
				detalhesMensalidade();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void listarMensalidade()
		{
			try
			{
				novaMensalidade = new Mensalidade();
				dgvMensalidade.DataSource = novaMensalidade.Listar(Convert.ToInt32(txtCodAluno.Text));
				detalhesMensalidade();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//Variavel para ajudar a saber se tem que criar ou não uma mensalidade 
		int teste = 0;
		public void verificaMensalidade()
		{
			teste = 1;
		}
		private void dgvMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{//Isso é para o método de alterar e apagar
			txtParaAtivar.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["SITUACAO2"].Value.ToString();
			if (txtParaAtivar.Text == "ATIVO")
			{
				chbAtivar.Checked = true;
			}
			else
			{
				chbAtivar.Checked = false;
			}
			cbxVencimento.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["VENCIMENTO2"].Value.ToString();
			txtIdMatricula.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["ID_MATRICULA2"].Value.ToString();
			txtIdTurma.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["ID_TURMA2"].Value.ToString();
			txtAlunoMatriculado.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["ALUNO_MATRICULADO1"].Value.ToString();
			int linhas = dgvMatriculas.Rows.Count;
			if (linhas>0)
			{
				liberaCadastro();
			}
			else
			{
				bloqueaCadastro();
			}
			
		}
		public void listarMatricula()
		{
			try
			{
				novaMatricula = new matricula();
				DataTable dadosTabela = new DataTable();
				dadosTabela = novaMatricula.listarMatricula(Convert.ToInt32(txtCodAluno.Text));
				dgvMatriculas.DataSource = dadosTabela;
				dgvTurma.DataSource = dadosTabela;
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tabPsage2_Click(object sender, EventArgs e)
		{

		}

		private void chbAtivar_CheckedChanged(object sender, EventArgs e)
		{
			if (chbAtivar.Checked == true)
			{
				txtParaAtivar.Text = "ATIVO";
			}
			else
			{
				txtParaAtivar.Text = "INATIVO";
			}
		}

		private void btnSalvarMatricula_Click(object sender, EventArgs e)
		{
			try
			{
				novaMatricula = new matricula();
				novaMatricula.update(Convert.ToInt32(txtIdMatricula.Text),Convert.ToInt32(txtCodAluno.Text),Convert.ToInt32(txtIdTurma.Text) , Convert.ToInt32(cbxVencimento.Text), txtParaAtivar.Text);
				bloqueaCadastro();
				listarMatricula();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void bloqueaCadastro()
		{
			cbxVencimento.Enabled = false;
			btnExcluirMatricula.Enabled = false;
			btnSalvarMatricula.Enabled = false; 
			chbAtivar.Enabled = false;
			cbxVencimento.SelectedIndex = -1;
			txtParaAtivar.Clear();
			txtIdMatricula.Clear();
			txtIdTurma.Clear();

			chbAtivar.Checked = false;
		}
		private void liberaCadastro()
		{
			cbxVencimento.Enabled = true;
			btnExcluirMatricula.Enabled = true;
			btnSalvarMatricula.Enabled = true;
			chbAtivar.Enabled = true;
		}

		private void btnExcluirMatricula_Click(object sender, EventArgs e)
		{
			try
			{
				novaMensalidade = new Mensalidade();
				novaMensalidade.DeletePelaMatricula(Convert.ToInt32(txtIdMatricula.Text));
				novaMatricula = new matricula();
				novaMatricula.delete(Convert.ToInt32(txtIdMatricula.Text));
				MessageBox.Show("Excluido!!");

				novoTurma = new Turma();
				novoTurma.alterarAlunoMatriculado(Convert.ToInt32(txtAlunoMatriculado.Text) - 1,Convert.ToInt32(txtIdTurma.Text));
				listarMatricula();
				bloqueaCadastro();
				listarTurmas();
				listarMensalidade();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvMatriculas_DoubleClick(object sender, EventArgs e)
		{//Isso é para o método de alterar e apagar
			txtParaAtivar.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["SITUACAO2"].Value.ToString();
			if (txtParaAtivar.Text == "ATIVO")
			{
				chbAtivar.Checked = true;
			}
			else
			{
				chbAtivar.Checked = false;
			}
			cbxVencimento.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["VENCIMENTO2"].Value.ToString();
			txtIdMatricula.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["ID_MATRICULA2"].Value.ToString();
			txtIdTurma.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["ID_TURMA2"].Value.ToString();
			txtAlunoMatriculado.Text = dgvMatriculas.Rows[dgvMatriculas.CurrentRow.Index].Cells["ALUNO_MATRICULADO1"].Value.ToString();
			int linhas = dgvMatriculas.Rows.Count;
			if (linhas > 0)
			{
				liberaCadastro();
			}
			else
			{
				bloqueaCadastro();
			}
		}

		private void dgvTurmasCadastro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
									
		}

		private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnFiltro_Click(object sender, EventArgs e)
		{
			if (cbSiatuacao.Text == "TODOS")
			{
				listarMensalidade();
			}
			else
			{
				if (cbSiatuacao.Text == "NÃO PAGAS")
				{
					listarMensalidadeNaoPagas();
				}
				else
				{
					if (cbSiatuacao.Text == "PAGAS")
					{
						listarMensalidadePagas();
					}
				}
			}
		}

		private void txtAtraso_TextChanged(object sender, EventArgs e)
		{

		}

		private void dgvMensalidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		
	}
}
