using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAcademia
{
	public class horarios
	{
		StringBuilder sql = new StringBuilder();
		SqlCommand comandoSql = new SqlCommand();
		DataTable dadosTabela = new DataTable();
		public void Salvar(int idTurma, string diaSemana, string inicio, string fim)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("insert into Horario(ID_TURMA, DIA_SEMANA, INICIO, FIM)");
					sql.Append("values(@idTurma, @diaSemana, @inicio, @fim)");

					comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));
					comandoSql.Parameters.Add(new SqlParameter("@diaSemana", diaSemana));
					comandoSql.Parameters.Add(new SqlParameter("@inicio", inicio));
					comandoSql.Parameters.Add(new SqlParameter("@fim", fim));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{
				
				throw new Exception("Erro no método Salvar da tabela horarios, se o problema persistir entre em contato com o administrador do Sistema");

			}

		}
		public DataTable listar(int idturma)
		{
			try 
			{	 
       			using(SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append("select * from Horario where ID_TURMA = @idTurma ");
					sql.Append("order by DIA_SEMANA");

					comandoSql.Parameters.Add(new SqlParameter("@idTurma", idturma));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método Listar da tabela horarios, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
		public void excluir(int idHorario)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(CONEXAO.stringConexao))
				{
					conexao.Open();
					sql.Append(" delete from Horario where ID_HORARIO = @idHorario");

					comandoSql.Parameters.Add(new SqlParameter("@idHorario", idHorario));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método excluir da tabela horarios, se o problema persistir entre em contato com o administrador do Sistema");
			}
		}
	}
}
