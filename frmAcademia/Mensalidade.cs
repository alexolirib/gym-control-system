using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAcademia
{
	public class Mensalidade
	{
		DataTable dadosTabela = new DataTable();

		SqlCommand comandoSql = new SqlCommand();

		StringBuilder sql = new StringBuilder();

		public void Salvar(int idMatricula, DateTime dataVencimento, string situacao)
		{
			using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
			{
				try
				{
					conexao.Open();
					sql.Append("INSERT INTO MENSALIDADE (ID_MATRICULA, DATA_VENCIMENTO, SITUACAO) ");
					sql.Append("Values (@idMatricula, @DataVencimento, @situacao) ");

					comandoSql.Parameters.Add(new SqlParameter("@idMatricula", idMatricula));
					comandoSql.Parameters.Add(new SqlParameter("@DataVencimento", dataVencimento));
					comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
				catch (Exception)
				{

					throw new Exception("Erro no método Salvar da tabela Mensalidade, se o problema persistir entre em contato com o administrador do Sistema");
				}
			}
		}
		public DataTable Listar(int idAluno)
		{
			using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
			{
				try
				{
					conexao.Open();
					sql.Append("select  Modalidade.NOME_MODALIDADE, MENSALIDADE.DATA_VENCIMENTO, MENSALIDADE.DATA_PAGAMENTO, Modalidade.MENSALIDADE, MENSALIDADE.SITUACAO, MENSALIDADE.ID_MENSALIDADE, MENSALIDADE.ID_MATRICULA, Modalidade.ID_MODALIDADE, Aluno.ID_Aluno ");
					sql.Append("From MENSALIDADE inner join Matricula on MENSALIDADE.ID_MATRICULA = Matricula.ID_MATRICULA ");
					sql.Append("inner join Turma on Matricula.ID_TURMA = Turma.ID_TURMA ");
					sql.Append("inner join Modalidade on Turma.ID_MODALIDADE = Modalidade.ID_MODALIDADE ");
					sql.Append("inner join Aluno on Matricula.ID_ALUNO = Aluno.ID_Aluno ");
					sql.Append("where Aluno.ID_Aluno = @idAluno ");

					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
				catch (Exception)
				{
					throw new Exception("Erro no método Listar da tabela Mensalidade, se o problema persistir entre em contato com o administrador do Sistema");
				}
			}
		}
		public DataTable ListarPelasContasNaoPagas(int idAluno)
		{
			using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
			{
				try
				{
					conexao.Open();
					sql.Append("select  Modalidade.NOME_MODALIDADE, MENSALIDADE.DATA_VENCIMENTO, MENSALIDADE.DATA_PAGAMENTO, Modalidade.MENSALIDADE, MENSALIDADE.SITUACAO, MENSALIDADE.ID_MENSALIDADE, MENSALIDADE.ID_MATRICULA, Modalidade.ID_MODALIDADE, Aluno.ID_Aluno ");
					sql.Append("From MENSALIDADE inner join Matricula on MENSALIDADE.ID_MATRICULA = Matricula.ID_MATRICULA ");
					sql.Append("inner join Turma on Matricula.ID_TURMA = Turma.ID_TURMA ");
					sql.Append("inner join Modalidade on Turma.ID_MODALIDADE = Modalidade.ID_MODALIDADE ");
					sql.Append("inner join Aluno on Matricula.ID_ALUNO = Aluno.ID_Aluno ");
					sql.Append("where Aluno.ID_Aluno =1 and MENSALIDADE.SITUACAO = 'Em Aberto' ");

					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
				catch (Exception)
				{
					throw new Exception("Erro no método ListarPelasContasNaoPagas da tabela Mensalidade, se o problema persistir entre em contato com o administrador do Sistema");
				}
			}
		}
		public DataTable ListarPelasContasPagas(int idAluno)
		{
			using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
			{
				try
				{
					conexao.Open();
					sql.Append("select  Modalidade.NOME_MODALIDADE, MENSALIDADE.DATA_VENCIMENTO, MENSALIDADE.DATA_PAGAMENTO, Modalidade.MENSALIDADE, MENSALIDADE.SITUACAO, MENSALIDADE.ID_MENSALIDADE, MENSALIDADE.ID_MATRICULA, Modalidade.ID_MODALIDADE, Aluno.ID_Aluno ");
					sql.Append("From MENSALIDADE inner join Matricula on MENSALIDADE.ID_MATRICULA = Matricula.ID_MATRICULA ");
					sql.Append("inner join Turma on Matricula.ID_TURMA = Turma.ID_TURMA ");
					sql.Append("inner join Modalidade on Turma.ID_MODALIDADE = Modalidade.ID_MODALIDADE ");
					sql.Append("inner join Aluno on Matricula.ID_ALUNO = Aluno.ID_Aluno ");
					sql.Append("where Aluno.ID_Aluno =1 and MENSALIDADE.SITUACAO = 'Pago' ");

					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
				catch (Exception)
				{
					throw new Exception("Erro no método ListarPelasContasPagas da tabela Mensalidade, se o problema persistir entre em contato com o administrador do Sistema");
				}
			}
		}
		public void DeletePelaMatricula(int idMatricula)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();

					sql.Append("Delete from MENSALIDADE WHERE ID_MATRICULA = @idMatricula");

					comandoSql.Parameters.Add(new SqlParameter("@idMatricula", idMatricula));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{				
				throw new Exception("Ocorreu um erro no método DeletePelaMatricula da tabela Mensalidade, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
	}
}
