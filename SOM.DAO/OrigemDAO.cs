
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
	public class OrigemDAO : BaseDAO<Origem, long>, SOM.DAO.IOrigemDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="OrigemDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public OrigemDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="OrigemDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public OrigemDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="OrigemDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public OrigemDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="OrigemDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public OrigemDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="descricao"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Origem> ListarPor(string descricao)
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Expression.InsensitiveLike("Descricao",descricao,MatchMode.Anywhere))
				.AddOrder(Order.Asc("Descricao"));
			return crit.List<Origem>();
		}
		public IList<Origem> ListarAtivos()
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Restrictions.Eq("Ativo", true))
				.AddOrder(Order.Asc("IdOrigem"));
			return crit.List<Origem>();
		}
	}
}
