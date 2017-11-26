using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAcademia
{ 
	public class Turma
	{
		StringBuilder sql = new StringBuilder();

		SqlCommand comandoSql = new SqlCommand();

		DataTable dadosTabela = new DataTable();

		public void Salvar(int idModalidade, int maximoAluno, int turma)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("insert into turma (ID_MODALIDADE, MAXIMO_ALUNOS, NUMERO_TURMA) ");
					sql.Append(" values (@idModalidade, @maximoAluno, @turma)");

					comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));
					comandoSql.Parameters.Add(new SqlParameter("@maximoAluno", maximoAluno));
					comandoSql.Parameters.Add(new SqlParameter("@turma", turma));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{ 				
				throw new Exception("Erro no método Salva da tabela Turma, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
		public DataTable listar()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select Turma.ID_MODALIDADE, Turma.ID_TURMA, Turma.MAXIMO_ALUNOS, Turma.NUMERO_TURMA, Modalidade.NOME_MODALIDADE ");
					sql.Append("from Modalidade inner join Turma on Turma.ID_MODALIDADE = Modalidade.ID_MODALIDADE order by Modalidade.NOME_MODALIDADE ");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método Listar da tabela Turma, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
		public DataTable listarComMesalidade()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select Turma.ID_MODALIDADE, Turma.ID_TURMA, Turma.MAXIMO_ALUNOS, Turma.NUMERO_TURMA, Modalidade.NOME_MODALIDADE, Modalidade.MENSALIDADE ");
					sql.Append("from Modalidade inner join Turma on Turma.ID_MODALIDADE = Modalidade.ID_MODALIDADE order by Modalidade.NOME_MODALIDADE ");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método Listar da tabela Turma, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
		public void alterar(int idTurma, int idModalidade, int turma, int maxAluno)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("update Turma set ID_MODALIDADE = @idModalidade, MAXIMO_ALUNOS = @maxAluno, NUMERO_TURMA = @turma ");
					sql.Append("where (ID_TURMA=@idTurma)");
					
					comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));
					comandoSql.Parameters.Add(new SqlParameter("@maxAluno", maxAluno));
					comandoSql.Parameters.Add(new SqlParameter("@turma", turma));
					comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));
					
					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();

				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método Alterar da tabela Turma, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
		public void excluir(int idTurma)
		{
			try 
			{	        
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("Delete from Turma where ID_TURMA = @idTurma");

					comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método Excluir da tabela Turma, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
		public DataTable pesquisaModalidade(string modalidade)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select Turma.ID_MODALIDADE, Turma.ID_TURMA, Turma.MAXIMO_ALUNOS, Turma.NUMERO_TURMA, Modalidade.NOME_MODALIDADE ");
					sql.Append("from Turma inner join Modalidade on Turma.ID_MODALIDADE = Modalidade.ID_MODALIDADE");
					sql.Append(" where Modalidade.NOME_MODALIDADE LIKE '%'+@modalidade+'%' ");
					sql.Append("Order by Modalidade.NOME_MODALIDADE");

					comandoSql.Parameters.Add(new SqlParameter("@modalidade", modalidade));
					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método pesquisa modalidade da tabela Turma, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
	}
}
