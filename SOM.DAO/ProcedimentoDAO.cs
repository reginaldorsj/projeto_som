
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
	public class ProcedimentoDAO : BaseDAO<Procedimento, long>, SOM.DAO.IProcedimentoDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ProcedimentoDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public ProcedimentoDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="ProcedimentoDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public ProcedimentoDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ProcedimentoDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public ProcedimentoDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ProcedimentoDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public ProcedimentoDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="descricao"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Procedimento> ListarPor(string descricao)
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Expression.InsensitiveLike("Descricao",descricao,MatchMode.Anywhere))
				.AddOrder(Order.Asc("Descricao"));
			return crit.List<Procedimento>();
		}
		public IList<Procedimento> ListarAtivos()
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Restrictions.Eq("Ativo", true))
				.AddOrder(Order.Asc("IdProcedimento"));
			return crit.List<Procedimento>();
		}
	}
}
