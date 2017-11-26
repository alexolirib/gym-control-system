using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAcademia
{
	public class alunos
	{
		SqlCommand comandoSql = new SqlCommand();

		DataTable dadosTabela = new DataTable();

		StringBuilder sql = new StringBuilder();


		public void Salvar(string nomeAluno, string enderecoAluno, string bairroAluno, string cidadeAluno, string cep, string cpf, string telefone, string celular, string observacao, string sexo)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("insert into Aluno (NOME_Aluno, ENDERECO_Aluno, BAIRRO_Aluno, CIDADE_Aluno, CEP_Aluno, CPF_Aluno, TELEFONE_Aluno, CELULAR_Aluno, OBSERVACAO, Sexo) ");
					sql.Append(" values (@nomeAluno, @enderecoAluno, @bairroAluno, @cidadeAluno, @cep, @cpf, @telefone, @celular, @observacao, @sexo)");

					comandoSql.Parameters.Add(new SqlParameter("@nomeAluno", nomeAluno));
					comandoSql.Parameters.Add(new SqlParameter("@enderecoAluno", enderecoAluno));
					comandoSql.Parameters.Add(new SqlParameter("@bairroAluno", bairroAluno));
					comandoSql.Parameters.Add(new SqlParameter("@cidadeAluno", cidadeAluno));
					comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
					comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
					comandoSql.Parameters.Add(new SqlParameter("@celular", celular));
					comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));
					comandoSql.Parameters.Add(new SqlParameter("@sexo", sexo));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método Salvar da tabela Alunos, se o problema persistir entre em contato com o administrador do sistema!");
			}
		}
		public DataTable Listar()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select * from Aluno ");
					sql.Append("order by nome_Aluno ");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());

					return dadosTabela;
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método Listar da tabela Alunos, se o problema persistir entre em contato com o administrador do sistema!");
			}
		}
		public void Delete(int idAluno)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("delete from Aluno where ID_Aluno = @idAluno");
					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método Excluir da tabela Alunos, se o problema persistir entre em contato com o administrador do sistema!");
			}
		}
		public void Update(int idAluno, string nomeAluno, string enderecoAluno, string bairroAluno, string cidadeAluno, string cep, string cpf, string telefone, string celular, string observacao, string sexo)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append(" update Aluno set NOME_Aluno = @nomeAluno, ENDERECO_Aluno = @enderecoAluno, BAIRRO_Aluno = @bairroAluno, CIDADE_Aluno = @cidadeAluno, ");
					sql.Append("CEP_Aluno = @cepAluno, CPF_Aluno = @cpfAluno, TELEFONE_Aluno = @telefoneAluno, CELULAR_Aluno = @celularAluno, OBSERVACAO = @observacao, Sexo = @sexo  ");
					sql.Append("where (ID_Aluno = @idAluno)");

					comandoSql.Parameters.Add(new SqlParameter("@nomeAluno", nomeAluno));
					comandoSql.Parameters.Add(new SqlParameter("@enderecoAluno", enderecoAluno));
					comandoSql.Parameters.Add(new SqlParameter("@bairroAluno", bairroAluno));
					comandoSql.Parameters.Add(new SqlParameter("@cidadeAluno", cidadeAluno));
					comandoSql.Parameters.Add(new SqlParameter("@cepAluno", cep));
					comandoSql.Parameters.Add(new SqlParameter("@cpfAluno", cpf));
					comandoSql.Parameters.Add(new SqlParameter("@telefoneAluno", telefone));
					comandoSql.Parameters.Add(new SqlParameter("@celularAluno", celular));
					comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));
					comandoSql.Parameters.Add(new SqlParameter("@sexo", sexo));
					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método Alterar da tabela Alunos, se o problema persistir entre em contato com o administrador do sistema!");
			}
		}
		public DataTable searchNome(string nome)
		{
			dadosTabela = new DataTable();
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select * from Aluno where NOME_Aluno LIKE '%'+@nome+'%'");
					sql.Append(" order by NOME_Aluno");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método pesquisaNome da tabela Alunos, se o problema persistir entre em contato com o administrador do sistema!");
			}
		}
		public DataTable searchCpf(string cpf)
		{
			dadosTabela = new DataTable();
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select * from Aluno where CPF_Aluno LIKE '%'+@cpf+'%'");
					sql.Append(" order by NOME_Aluno");

					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método pesquisaCpf da tabela Alunos, se o problema persistir entre em contato com o administrador do sistema!");
			}
		}
	}
}
