
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
	public class OcupacaoDAO : BaseDAO<Ocupacao, long>, SOM.DAO.IOcupacaoDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="OcupacaoDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public OcupacaoDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="OcupacaoDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public OcupacaoDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="OcupacaoDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public OcupacaoDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="OcupacaoDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public OcupacaoDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="codigo"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Ocupacao> ListarPor(string codigo)
		{
			throw new NotImplementedException("Não implementado.");
		}
	}
}
