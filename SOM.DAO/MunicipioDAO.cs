
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
using Regisoft;

namespace SOM.DAO
{
	/// <summary>
	/// Classe para acesso ao banco de dados utilizando o NHiberante.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class MunicipioDAO : BaseDAO<Municipio, long>, SOM.DAO.IMunicipioDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="MunicipioDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public MunicipioDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="MunicipioDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public MunicipioDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="MunicipioDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public MunicipioDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="MunicipioDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public MunicipioDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <returns>A lista.</returns>
		public IList<Municipio> ListarPorUf(Uf uf)
		{
			return Listar("IdUf","IdUf",uf.IdUf,"Descricao");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="iduf"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Municipio> ListarPor(string iduf)
		{
			throw new NotImplementedException("Não implementado.");
		}
		public Municipio SelecionarPorNome(Uf uf, string nomeMunicipio)
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Expression.Eq("IdUf", uf))
				.Add(Expression.Eq("Descricao", nomeMunicipio));
			return ToolsBO.PrimeiroOuNulo<Municipio>(crit.List<Municipio>());
		}
		public IList<Municipio> ListarPorNome(Uf uf, string nomeMunicipio)
		{
			ICriteria crit = Get<ICriteria>()
					.Add(Expression.Eq("IdUf", uf))
					.Add(Expression.InsensitiveLike("Descricao", nomeMunicipio, MatchMode.Start));

			return crit.List<Municipio>();
		}
	}
}
