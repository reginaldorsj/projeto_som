
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
	public class TipoObitoDAO : BaseDAO<TipoObito, long>, SOM.DAO.ITipoObitoDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="TipoObitoDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public TipoObitoDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="TipoObitoDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public TipoObitoDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="TipoObitoDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public TipoObitoDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="TipoObitoDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public TipoObitoDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="descricao"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<TipoObito> ListarPor(string descricao)
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Expression.InsensitiveLike("Descricao",descricao,MatchMode.Anywhere))
				.AddOrder(Order.Asc("Descricao"));
			return crit.List<TipoObito>();
		}
		public IList<TipoObito> ListarAtivos()
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Restrictions.Eq("Ativo", true))
				.AddOrder(Order.Asc("Descricao"));
			return crit.List<TipoObito>();
		}
	}
}
