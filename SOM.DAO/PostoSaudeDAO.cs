
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
	public class PostoSaudeDAO : BaseDAO<PostoSaude, long>, SOM.DAO.IPostoSaudeDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="PostoSaudeDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public PostoSaudeDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="PostoSaudeDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public PostoSaudeDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="PostoSaudeDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public PostoSaudeDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="PostoSaudeDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public PostoSaudeDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="nome"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<PostoSaude> ListarPor(string nome)
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Expression.InsensitiveLike("Nome",nome,MatchMode.Anywhere))
				.AddOrder(Order.Asc("Nome"));
			return crit.List<PostoSaude>();
		}
		public IList<PostoSaude> ListarAtivos()
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Restrictions.Eq("Ativo", true))
				.AddOrder(Order.Asc("Nome"));
			return crit.List<PostoSaude>();
		}
	}
}
