using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAcademia
{
	public class matricula
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public void Salvar(int idAluno, int idTurma, string situacao, int vencimento)
		{
			using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
			{
				try
				{
					conexao.Open();
					sql.Append("insert into Matricula (ID_ALUNO, ID_TURMA, VENCIMENTO, SITUACAO) ");
					sql.Append("values (@idAluno, @idTurma, @vencimento, @situacao)");

					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));
					comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));
					comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));
					comandoSql.Parameters.Add(new SqlParameter("@vencimento", vencimento));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
				catch (Exception)
				{
					throw new Exception("Erro no metado Salvar da tabela Matricula, se o problema persistir entre em contato com o administrador do sistema");
				}
			}
		}
		public DataTable listarMatricula(int idAluno)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select Matricula.ID_MATRICULA, Matricula.ID_ALUNO, Matricula.ID_TURMA, Matricula.VENCIMENTO, Turma.ALUNO_MATRICULADO, Turma.NUMERO_TURMA, Modalidade.NOME_MODALIDADE, Modalidade.MENSALIDADE, Modalidade.ID_MODALIDADE, Aluno.NOME_Aluno, Matricula.SITUACAO ");
					sql.Append("from Matricula inner join Turma on Matricula.ID_TURMA = Turma.ID_TURMA ");
					sql.Append("inner join Modalidade on Turma.ID_MODALIDADE = Modalidade.ID_MODALIDADE ");
					sql.Append("inner join Aluno on Aluno.ID_Aluno = Matricula.ID_ALUNO ");
					sql.Append("where Aluno.ID_Aluno = @idAluno");
					
					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no metado listarMatricula da tabela Matricula, se o problema persistir entre em contato com o administrador do sistema");
			}
		}
		public void update(int idMatricula, int idAluno, int idTurma, int vencimento, string situacao)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("update Matricula set ID_ALUNO = @idAluno, ID_TURMA = @idTurma, VENCIMENTO = @vencimento , SITUACAO = @situacao ");
					sql.Append("where (ID_MATRICULA = @idMatricula)");

					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));
					comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));
					comandoSql.Parameters.Add(new SqlParameter("@vencimento", vencimento));
					comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));
					comandoSql.Parameters.Add(new SqlParameter("@idMatricula", idMatricula));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no métado update da tabela Matricula, se o problema persistir entre em contato com o administrador do sistema");
			}
		}
		public void delete(int idMatricula)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("delete from Matricula where ID_MATRICULA = @idMatricula");
					comandoSql.Parameters.Add(new SqlParameter("@idMatricula", idMatricula));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no métado delete da tabela Matricula, se o problema persistir entre em contato com o administrador do sistema");
			}
		}
		public DataTable verificaAlunoMatriculado(int idAluno, int idTurma)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select * from Matricula where Matricula.ID_ALUNO = @idAluno and Matricula.ID_TURMA = @idTurma");

					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));
					comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				
				throw new Exception("Erro no métado verificaAlunoMatriculado da tabela Matricula, se o problema persistir entre em contato com o administrador do sistema");
			}			
		}		
	}
}
