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
	public partial class frmAlunos : Form
	{
		public frmAlunos()
		{
			InitializeComponent();
		}
		alunos novosAlunos;
		txtAtiva controleAluno;
		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			controleAluno = new txtAtiva(this);
			controleAluno.ShowDialog();
		}

		public void listarAlunos()
		{
			
			try
			{
				novosAlunos = new alunos();
				dgvAlunos.DataSource = novosAlunos.Listar();
				estilo();
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmAlunos_Load(object sender, EventArgs e)
		{
			listarAlunos();
		}

		private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dgvAlunos_DoubleClick(object sender, EventArgs e)
		{//fazendo comunicação com o form ControleAluno
			//o this é para passar o atual form como parametro feito para atualizar o método listar alunos
			controleAluno = new txtAtiva(this);
			DataGridView alunoSelecionado = dgvAlunos.Rows[dgvAlunos.CurrentRow.Index].DataGridView;
			controleAluno.ExibirAluno(alunoSelecionado);
			controleAluno.ShowDialog();
			
		}

		private void dgvAlunos_Enter(object sender, EventArgs e)
		{
			listarAlunos();
			
		}
		private void estilo()
		{
			int linhas = dgvAlunos.Rows.Count;

			for (int i = 0; i < linhas; i++)
			{
				dgvAlunos.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
				i++;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			novosAlunos = new alunos();
			DataTable dadosTabela = new DataTable();
			try
			{
				if (rbnNome.Checked == true) 
				{
					dgvAlunos.DataSource = novosAlunos.searchNome(txtPesquisaAluno.Text);
					estilo(); 
				}
				else
				{
					dgvAlunos.DataSource = novosAlunos.searchCpf(txtPesquisaAluno.Text);
					estilo();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
