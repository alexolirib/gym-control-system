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
	public partial class frmTurmas : Form
	{
		public frmTurmas()
		{
			InitializeComponent();
		}
		Turma novaTurma;
		//Conectar com o a tabela modalidades

		horarios novoHorario;
		//Conectar com o a tabela horario

		void listarModalidade()
		{
			try
			{
				modalidade novaModalidade = new modalidade();

				cbxModalidade.DataSource = novaModalidade.Listar();
				cbxModalidade.DisplayMember = "NOME_MODALIDADE";
				cbxModalidade.ValueMember = "ID_MODALIDADE";

				cbxModalidade.SelectedIndex = -1;
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void frmTurmas_Load(object sender, EventArgs e)
		{
			listarModalidade();
			listarTurma();

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtCodigo.Text == "0")
				{
					if (cbxModalidade.SelectedIndex == -1)
					{
						MessageBox.Show("Seleciona o tipo da modalidade da turma que deseja cadastrar!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						novaTurma = new Turma();
						novaTurma.Salvar(Convert.ToInt32(cbxModalidade.SelectedValue), Convert.ToInt32(txtAluno.Text), Convert.ToInt32(txtTurma.Text), 0);
						MessageBox.Show("Turma Salvo com sucesso!!");
						limpar();
						listarTurma();
					}
				}
				else
				{
					novaTurma = new Turma();
					novaTurma.alterar(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(cbxModalidade.SelectedValue), Convert.ToInt32(txtTurma.Text), Convert.ToInt32(txtAluno.Text));
					MessageBox.Show("Alteração de turma feita com sucesso!");
					limpar();
					listarTurma();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void limpar()
		{
			txtCodigo.Text = "0";
			txtAluno.Clear();			
			txtPesquisa.Clear();
			txtTurma.Clear();
			cbxModalidade.SelectedIndex = -1;
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			limpar();
		}
		public void listarTurma()
		{
			try
			{
				novaTurma = new Turma();
				dgvTurma.DataSource = novaTurma.listar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (dgvTurma.Columns[e.ColumnIndex].Name == "btnEditar")
				{
					txtCodigo.Text = dgvTurma.Rows[e.RowIndex].Cells["ID_TURMA"].Value.ToString();
					txtAluno.Text = dgvTurma.Rows[e.RowIndex].Cells["MAXIMO_ALUNOS"].Value.ToString();
					txtTurma.Text = dgvTurma.Rows[e.RowIndex].Cells["NUMERO_TURMA"].Value.ToString();
					cbxModalidade.Text = dgvTurma.Rows[e.RowIndex].Cells["NOME_MODALIDADE"].Value.ToString();
				}
				else
				{
					if (dgvTurma.Columns[e.ColumnIndex].Name == "btnExcluir" &&
						MessageBox.Show("Deseja realmente excluir??", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes )
					{
						novaTurma = new Turma();
						novaTurma.excluir(Convert.ToInt32(dgvTurma.Rows[e.RowIndex].Cells["ID_TURMA"].Value.ToString()));
						MessageBox.Show("Excluido com sucesso!!");
						listarTurma();
					}
					else
					{//abrir o formulario de horarios
						if (dgvTurma.Columns[e.ColumnIndex].Name == "btnHorario" &&
							MessageBox.Show("Deseja cadastrar Horario para essa turma?", "Cadastrar", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
						{
							frmHorarios frm = new frmHorarios(Convert.ToInt32(dgvTurma.Rows[e.RowIndex].Cells["ID_TURMA"].Value),
												dgvTurma.Rows[e.RowIndex].Cells["NOME_MODALIDADE"].Value.ToString(), dgvTurma.Rows[e.RowIndex].Cells["NUMERO_TURMA"].Value.ToString());
							frm.ShowDialog();
						}
					}
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			try
			{
				novaTurma = new Turma();
				dgvTurma.DataSource = novaTurma.pesquisaModalidade(txtPesquisa.Text);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvTurma_DoubleClick(object sender, EventArgs e)
		{
			lblHorarios.Visible = false;
			lblHorarios2.Visible = false;
			novoHorario = new horarios();

			DataTable dadosTabela = new DataTable();
			
			//Isso é para pegar os horários da turma e colocar no método listar do novoHorario
			dadosTabela = novoHorario.listar(Convert.ToInt32(dgvTurma.Rows[dgvTurma.CurrentRow.Index].Cells["ID_TURMA"].Value));

			//Carregar no dgvHorario
			dgvHorario.DataSource = dadosTabela;

			//número de linhas de dados da tabela horário
			int linhas = dadosTabela.Rows.Count;

			for (int i = 0; i < linhas; i++ )
			{
				dgvHorario.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
				i++;
			}


		}

		private void dgvHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
