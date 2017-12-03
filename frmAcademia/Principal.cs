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
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
		}
		
		//load = evento pelo carregamento do formulário
		private void Principal_Load(object sender, EventArgs e)
		{
			//estabelece a conexao com o banco através da classe "CONEXAO" e seu metado "stringConexao"
			using (SqlConnection novaConexao = new SqlConnection(CONEXAO.stringConexao))
				try //tenta realizar tarefa
				{
					/*novaConexao.Open(); //abre Conexao com o banco
					MessageBox.Show("Conectou!");//avisa que foi conectado!*/
				}
				catch (Exception) //erro em executar
				{
					MessageBox.Show("Não conectou!");
				}
				/*finally //por fim é realizada esta ação!
				{
					MessageBox.Show("Seja bem-vindo ao sistema!");
				}*/
		}
		//chamar form professor
		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			frmProfessores novoProfessor = new frmProfessores();
			//novoProfessor.ShowDialog();
			verificaFormulario(novoProfessor);
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			frmModalidades modalidades = new frmModalidades();
			//modalidades.ShowDialog();
			verificaFormulario(modalidades);
		}

		private void verificaFormulario(Form novoForm)
		{//todo objeto form recebido por parametro será filho do frmPrincipal e assim acessaremos o MDiParent para que ocorra
		// se o formulario tiver presente na tela será encerrado  pois receberá o focus e o metoda será encerrado, contrario criarar normalemnte
			foreach (Form formularios in this.MdiChildren)
			{
				if (formularios.Name == novoForm.Name)
				{
					formularios.Focus();
					return;
				}
			}
			this.LayoutMdi(MdiLayout.Cascade);
			novoForm.MdiParent = this;
			novoForm.Show();
		}

		private void pbxMusculo_Click(object sender, EventArgs e)
		{
			pbxMusculo.BringToFront();
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			frmAlunos novoAluno = new frmAlunos();
			verificaFormulario(novoAluno);
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			frmTurmas novaTurma = new frmTurmas();
			verificaFormulario(novaTurma);
		}
	}
}
