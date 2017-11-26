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
	public partial class frmHorarios : Form
	{
		private int codigo;
		private string modalidade, turma;
		public frmHorarios(int codigo, string modalidade, string turma)
		{
			InitializeComponent();
			this.codigo = codigo;
			this.modalidade = modalidade;
			this.turma = turma;
		}
		horarios novoHorario;
		private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void frmHorarios_Load(object sender, EventArgs e)
		{
			try
			{
				this.Text = "Turma - " +  turma + "   Categoria - " + modalidade;

				cbxDia.SelectedIndex = 0;
				ListarHorario();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				if (cbxDia.SelectedIndex == 0)
				{
					MessageBox.Show("Insira o dia para o cadastro!");
					
				}
				else
				{
					if (Convert.ToDateTime(dtpInicio.Text) > Convert.ToDateTime(dtpFim.Text))
					{
						MessageBox.Show("Hora cadastrada Invalida!!");
					}
					else
					{
						novoHorario = new horarios();
						novoHorario.Salvar(codigo, cbxDia.Text, dtpInicio.Text, dtpFim.Text);
						MessageBox.Show("Salvo com sucesso!!");
						ListarHorario(); 
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void ListarHorario()
		{
			try
			{
				novoHorario = new horarios();
				dgvHorarios.DataSource = novoHorario.listar(codigo);
				estilo();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Deseja realmente excluir esse campo??", "Deseja", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
				{
					novoHorario = new horarios();
					novoHorario.excluir(Convert.ToInt32(dgvHorarios.Rows[dgvHorarios.CurrentRow.Index].Cells["ID_HORARIO"].Value.ToString()));
					MessageBox.Show("Excluido com sucesso!!");
					ListarHorario();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvHorarios_DoubleClick(object sender, EventArgs e)
		{

		}

		private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void estilo()
		{//todas as linhas
			int linhas = dgvHorarios.Rows.Count;
			for (int i = 0; i < linhas; i++)
			{
				dgvHorarios.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
				i++;

			}
		}
	}
}
