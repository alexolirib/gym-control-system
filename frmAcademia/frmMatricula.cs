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
	public partial class frmMatricula : Form
	{
		Turma novaTurma;
		txtAtiva formulario;
		matricula novaMatricula;
		string nomeAluno;
		int codAluno;
		int codTurma;
		int alunoMatriculado;
		public frmMatricula(txtAtiva formulario, string nomeAluno, int codAluno)
		{
			InitializeComponent();

			this.formulario = formulario;
			this.nomeAluno = nomeAluno;
			this.codAluno = codAluno;
		}
		
		private void frmMatricula_Load(object sender, EventArgs e)
		{
			this.Text = "sca - Matrícula  do Aluno -   " + nomeAluno + "::";
			txtVencimento.SelectedIndex = -1;
			txtNomeAluno.Text = nomeAluno;
			txtVencimento.Text = DateTime.Today.Day.ToString();
			
		}
		public void ExibirMatricula(DataGridView matriculas)
		{
			txtModalidade.Text = matriculas.Rows[matriculas.CurrentRow.Index].Cells["NOME_MODALIDADE"].Value.ToString();
			txtMensalidade.Text = matriculas.Rows[matriculas.CurrentRow.Index].Cells["MENSALIDADE3"].Value.ToString();
			txtTurma.Text = matriculas.Rows[matriculas.CurrentRow.Index].Cells["numeroTurmaCadastro"].Value.ToString();
			txtVagas.Text = matriculas.Rows[matriculas.CurrentRow.Index].Cells["maximoAlunosCadastro"].Value.ToString();
			this.codTurma = Convert.ToInt32(matriculas.Rows[matriculas.CurrentRow.Index].Cells["ID_TURMA_CADASTRO"].Value.ToString());
			this.alunoMatriculado = Convert.ToInt32(matriculas.Rows[matriculas.CurrentRow.Index].Cells["ALUNO_MATRICULADO"].Value.ToString());
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtVencimento.SelectedIndex == -1)
				{
					MessageBox.Show("Inserir uma data de vencimento!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtVencimento.Focus();
				}
				else
				{
					novaMatricula = new matricula();
					novaMatricula.Salvar(codAluno, codTurma, "ATIVO", Convert.ToInt32(txtVencimento.Text));
					MessageBox.Show("Salvo com Sucesso!!");

					novaTurma = new Turma();
					novaTurma.alterarAlunoMatriculado(alunoMatriculado + 1, codTurma);
					this.Close();
				}
			}				
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmMatricula_FormClosed(object sender, FormClosedEventArgs e)
		{
			formulario.listarMatricula(); 
		}

		private void txtVencimento_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
