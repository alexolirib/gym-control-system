using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmAcademia
{
	public class CONEXAO
	{
		//conexao com o banco "string de conexao"
		private static string conexao = "Data Source=DESKTOP-AR4BPQV;Initial Catalog=academia2;User ID=SA;Password=aluno123";
		
		//leitura da string de conexao(metado)
		public static string stringConexao
		{
			get { return conexao; }
		}
	}

}
