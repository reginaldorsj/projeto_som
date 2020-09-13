
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
	public class ProcedenciaDAO : BaseDAO<Procedencia, long>, SOM.DAO.IProcedenciaDAO
	{
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="ProcedenciaDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configura��o do NHibernate.</param>
        public ProcedenciaDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia de <see cref="ProcedenciaDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public ProcedenciaDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="ProcedenciaDAO"/>.
		/// </summary>
		/// <param name="session">A sess�o NHibernate.</param>
		/// <param name="configuration">A configura��o.</param>
        public ProcedenciaDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="ProcedenciaDAO"/>.
		/// </summary>
		/// <param name="connection">A conex�o.</param>
		public ProcedenciaDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="descricao"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Procedencia> ListarPor(string descricao)
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Expression.InsensitiveLike("Descricao",descricao,MatchMode.Anywhere))
				.AddOrder(Order.Asc("Descricao"));
			return crit.List<Procedencia>();
		}
		public IList<Procedencia> ListarAtivos()
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Restrictions.Eq("Ativo", true))
				.AddOrder(Order.Asc("Descricao"));
			return crit.List<Procedencia>();
		}
	}
}
