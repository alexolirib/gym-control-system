using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAcademia
{
	public class modalidade
	{
		SqlCommand comandoSql = new SqlCommand();// indica que vai ser utilizado os comandos sql 

		StringBuilder sql = new StringBuilder(); //auxilia na concatenação da string 

		DataTable dadosTabela = new DataTable(); // armazena as informações que o banco retorna com o select 

		public void salvar(string nome,decimal mensalidade, int idProfessor)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("INSERT INTO Modalidade");
					sql.Append(" (NOME_MODALIDADE, MENSALIDADE, ID_PROFESSOR) ");
					sql.Append("VALUES (@nome, @mensalidade, @idProfessor)");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@mensalidade", mensalidade));
					comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Problema no método Salvar da tabela Modalidade, se o problema persistir entre em contato com o administrador do sistema");
			}
			
		}
		public void alterar(string nome, int idModalidade, int idProfessor, decimal  mensalidade)
		{
				try
				{
					using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
					{
						conexao.Open();
						sql.Append("UPDATE Modalidade SET NOME_MODALIDADE = @nome, MENSALIDADE = @mensalidade, ID_PROFESSOR = @idProfessor");
						sql.Append(" Where (ID_MODALIDADE = @idModalidade)");
						comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
						comandoSql.Parameters.Add(new SqlParameter("@mensalidade", mensalidade));
						comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));
						comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));

						comandoSql.CommandText = sql.ToString();
						comandoSql.Connection = conexao;
						comandoSql.ExecuteNonQuery();
					}
				}
				catch (Exception)
				{

					throw new Exception("Problema no método Alterar da tabela Modalidade, se o problema persistir entre em contato com o administrador do sistema");
				}
		}
		//método responsável para listar  todas as modalidades 
		public DataTable Listar()
		{
			try
			{
				using(SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("SELECT Modalidade.ID_MODALIDADE, Modalidade.MENSALIDADE, Modalidade.NOME_MODALIDADE, Modalidade.ID_PROFESSOR,  Professor.NOME_PROFESSOR");
					sql.Append(" FROM (Modalidade INNER JOIN  Professor ON Modalidade.ID_PROFESSOR = Professor.ID_Professor)");
					sql.Append(" order by Modalidade.NOME_MODALIDADE");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método listar da tabela Modalidade, se o problema persistir entre em contato com o administrador do sistema");
			}
		}
		public void excluir(int idModalidade)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("delete from Modalidade ");
					sql.Append("where (ID_MODALIDADE = @idModalidade)");
					comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{
				
				throw new Exception("Problema no método exclui da tabela modalidade, se o problema persistir entre em contato com o administrador do sistema");
			}
		}
		public DataTable pesquisaCategoria(string cat)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select Modalidade.ID_MODALIDADE, Modalidade.MENSALIDADE, Modalidade.NOME_MODALIDADE, Modalidade.ID_PROFESSOR, Professor.NOME_PROFESSOR ");
					sql.Append("from (Modalidade inner join Professor on Modalidade.ID_PROFESSOR = Professor.ID_Professor)");
					sql.Append(" where Modalidade.NOME_MODALIDADE like '%'+@cat+'%' ");
					sql.Append("Order by Modalidade.NOME_MODALIDADE");

					comandoSql.Parameters.Add(new SqlParameter("@cat", cat));
					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				
				throw new Exception("Problema no método pesquisar categoria da tabela modalidade, se o problema persistir entre em contato com o administrador do sistema");
			}
		}
		public DataTable pesquisaProfessor(string prof)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select Modalidade.ID_MODALIDADE, Modalidade.MENSALIDADE, Modalidade.NOME_MODALIDADE, Modalidade.ID_PROFESSOR, Professor.NOME_PROFESSOR ");
					sql.Append("from (Modalidade inner join Professor on Modalidade.ID_PROFESSOR = Professor.ID_Professor)");
					sql.Append(" where Professor.NOME_PROFESSOR like '%'+@prof+'%' ");
					sql.Append("Order by Professor.NOME_PROFESSOR");
					comandoSql.Parameters.Add(new SqlParameter("@prof", prof));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
				
			}
			catch (Exception)
			{

				throw new Exception("Problema no método pesquisar professor da tabela modalidade, se o problema persistir entre em contato com o administrador do sistema");
			}
		}
	}
}
