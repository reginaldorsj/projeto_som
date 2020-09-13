
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
	public class CarnavalDAO : BaseDAO<Carnaval, long>, SOM.DAO.ICarnavalDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="CarnavalDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
		public CarnavalDAO(string factoryConfigPath)
			: base(factoryConfigPath, "SOM.OR", null)
		{
		}
		/// <summary>
		/// Inicializa uma instância de <see cref="CarnavalDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
		public CarnavalDAO()
			: base()
		{
		}
		/// <summary>
		/// Inicializa uma instância da classe <see cref="CarnavalDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
		public CarnavalDAO(ISession session, Configuration configuration)
			: base(session, configuration)
		{
		}
		/// <summary>
		/// Inicializa uma instância da classe <see cref="CarnavalDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public CarnavalDAO(System.Data.Common.DbConnection connection)
			: base(connection)
		{
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="ano"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Carnaval> ListarPor(string ano)
		{
			throw new NotImplementedException("Não implementado.");
		}
		public IList<Carnaval> ListarAtivos()
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Restrictions.Eq("Ativo", true));
			return crit.List<Carnaval>();
		}
	}
}
