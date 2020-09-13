
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
	public class MedicoDAO : BaseDAO<Medico, long>, SOM.DAO.IMedicoDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="MedicoDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public MedicoDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="MedicoDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public MedicoDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="MedicoDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public MedicoDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="MedicoDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public MedicoDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <returns>A lista.</returns>
		public IList<Medico> ListarPorUf(Uf uf)
		{
			return Listar("IdUf","IdUf",uf.IdUf,"IdUf");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="cremeb"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Medico> ListarPor(string cremeb)
		{
			throw new NotImplementedException("Não implementado.");
		}

		public Medico SelecionarPor(string cremeb, Uf uf)
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Restrictions.Eq("Cremeb", cremeb))
				.CreateAlias("IdUf", "uf", NHibernate.SqlCommand.JoinType.InnerJoin)
					.Add(Restrictions.Eq("uf.IdUf", uf.IdUf));
			return crit.UniqueResult<Medico>();
		}
		public IList<Medico> ListarPorNome(string nome)
		{
			ICriteria crit = Get<ICriteria>()
					.Add(Restrictions.InsensitiveLike("Nome", nome, MatchMode.Start))
					.AddOrder(Order.Asc("Nome"));
			return crit.List<Medico>();
		}
	}
}
