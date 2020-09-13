
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Regisoft.Camadas.Generic;
using System.Data;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Cfg;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe para acesso ao banco de dados utilizando o NHiberante.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class DiaDAO : BaseDAO<Dia, long>, SOM.DAO.IDiaDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="DiaDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public DiaDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="DiaDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public DiaDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="DiaDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public DiaDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="DiaDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public DiaDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		public IList<Dia> ListarPorAno(int ano)
		{
			ICriteria crit = Get<ICriteria>()
				.CreateAlias("IdCarnaval","carnaval", NHibernate.SqlCommand.JoinType.InnerJoin)
				.Add(Restrictions.Eq("carnaval.Ano", ano));
			return crit.List<Dia>();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="carnaval">O(A) carnaval.</param>
		/// <returns>A lista.</returns>
		public IList<Dia> ListarPorCarnaval(Carnaval carnaval)
		{
			return Listar("IdCarnaval","IdCarnaval",carnaval.IdCarnaval,"IdCarnaval");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idcarnaval"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Dia> ListarPor(string idcarnaval)
		{
			throw new NotImplementedException("Não implementado.");
		}
	}
}
