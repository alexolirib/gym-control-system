using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAcademia
{
	public class Professores
	{
		//comandos sql
		SqlCommand comandoSql = new SqlCommand();

		//concatenar as strings presente no SQL
		StringBuilder sql;

		//Armazena as informações que o banco retorna  com o select dentro de uma tabela
		DataTable dadosTabela = new DataTable();

		//metado que irá salvar as informações conforme os parâmetros 
		public void Salvar(string nome, string endereco, string bairro, string cidade, string cep, string cpf, decimal salario, string telefone, string observacao)
		{
			try
			{
				//estabelece conexao com o banco
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					sql = new StringBuilder();
					//abre a conexão com o banco
					conexao.Open();

					//Comando SQL para a inserção  de valores  nos respectivos campos da tabela Professor
					sql.Append("INSERT INTO Professor (NOME_PROFESSOR, ENDERECO_PROFESSOR, BAIRRO_PROFESSOR, CIDADE_PROFESSOR,");
					sql.Append(" CEP_PROFESSOR, CPF_PROFESSOR, SALARIO, TELEFONE_PROFESSOR, OBSERVACAO)");
					sql.Append("VALUES (@nome, @endereco, @bairro, @cidade, @cep, @cpf, @salario, @telefone, @observacao);");


					//Relacionar cada valor  com seu respectivo parâmetro
					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
					comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
					comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));				
					comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
					comandoSql.Parameters.Add(new SqlParameter("@salario", salario));
					comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
					comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));

					//A partir daqui será a execução

					comandoSql.CommandText = sql.ToString();// o que foi definido na stringBuilder(sql) é a instrução que deverá ser executada pelo método (comandoSql)
					comandoSql.Connection = conexao; //(conexao dos comandos) conexao será utilizada para a execução dos comandos sql, com que está definida na string de conexão
					comandoSql.ExecuteNonQuery(); //inserção dos dados no banco (executar os comandos)
					conexao.Close();

				}

			}
			catch (Exception)
			{
				//caso ocorra erro no bloco try, entrará o catch onde irá detectalo
				throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do sistema.");
			}
		}
		public DataTable Listar()
		{
			try
			{
				using(SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					sql = new StringBuilder();
					conexao.Open();

					sql.Append("SELECT * FROM Professor");
					sql.Append(" order by NOME_PROFESSOR");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;					
				}
			}
			catch (Exception)
			{
				
				throw new Exception("Ocorreu um erro no método listar. Caso o problema persista, entre em contato com o Administrador do sistema.");
			}
		}
		public void alterar(int idProfessor, string nome, string endereco, string bairro, string cep, string cidade, string telefone, string cpf, decimal salario, string observacao)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					sql = new StringBuilder();					
					conexao.Open();
					sql.Append("UPDATE Professor SET NOME_PROFESSOR = @nome, ENDERECO_PROFESSOR = @endereco, BAIRRO_PROFESSOR = @bairro, CIDADE_PROFESSOR = @cidade,");
					sql.Append(" CEP_PROFESSOR = @cep, CPF_PROFESSOR = @cpf, SALARIO = @salario, TELEFONE_PROFESSOR = @telefone, OBSERVACAO = @observacao");
					sql.Append(" Where (ID_Professor = @idProfessor)");


					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
					comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
					comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
					comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
					comandoSql.Parameters.Add(new SqlParameter("@cpf",cpf));
					comandoSql.Parameters.Add(new SqlParameter("@salario", salario));
					comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
					comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));
					comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
					conexao.Close();
				}

			}
			catch (Exception)
			{
				
				throw new Exception("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato com o administrador do sistema. ");
			}
		}
		public void excluir(int idProfessor)
		{
			try
			{
				using( SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					sql = new StringBuilder();
					conexao.Open();
					sql.Append("Delete From Professor ");
					sql.Append("where (ID_Professor = @idProfessor)");

					comandoSql.Parameters.Add(new SqlParameter("@idProfessor",idProfessor));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
					conexao.Close();
					
				}
			}
			catch (Exception)
			{
				
				throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o administrador do sistema. ");
			}
		}
		public DataTable PesquisarNome(string nome)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					sql = new StringBuilder();
					conexao.Open();

					sql.Append("SELECT * FROM Professor");
					sql.Append(" WHERE NOME_PROFESSOR LIKE '%'+@nome+'%'");
					sql.Append(" ORDER BY NOME_PROFESSOR DESC");
					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				
				throw new Exception("Ocorreu um erro no método PesquisarNome. Caso o problema persista, entre em contato com o administrador do sistema. ");
			}
		}
		public DataTable pesquisarCpf(string cpf)
		{
			try
			{
				
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					sql = new StringBuilder();
					conexao.Open();

					sql.Append("SELECT * FROM Professor");
					sql.Append(" WHERE CPF_PROFESSOR LIKE '%'+@cpf+'%'");
					sql.Append(" ORDER BY NOME_PROFESSOR DESC");
					comandoSql.Parameters.Add(new SqlParameter("@cpf",cpf));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;

				}
			}
			catch (Exception)
			{
				
				throw  new Exception("Ocorreu um erro no método pesquisarCpf. Caso o problema persista, entre em contato com o administrador do sistema.");
			}
		}
	}
}
