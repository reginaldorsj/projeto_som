
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
	public class PacienteDAO : BaseDAO<Paciente, long>, SOM.DAO.IPacienteDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="PacienteDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public PacienteDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="PacienteDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public PacienteDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="PacienteDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public PacienteDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="PacienteDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public PacienteDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="municipio">O(A) municipio.</param>
		/// <returns>A lista.</returns>
		public IList<Paciente> ListarPorMunicipio(Municipio municipio)
		{
			return Listar("IdMunicipio","IdMunicipio",municipio.IdMunicipio,"IdMunicipio");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="raca">O(A) raca.</param>
		/// <returns>A lista.</returns>
		public IList<Paciente> ListarPorRaca(Raca raca)
		{
			return Listar("IdRaca","IdRaca",raca.IdRaca,"IdRaca");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="sexo">O(A) sexo.</param>
		/// <returns>A lista.</returns>
		public IList<Paciente> ListarPorSexo(Sexo sexo)
		{
			return Listar("IdSexo","IdSexo",sexo.IdSexo,"IdSexo");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="nome"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Paciente> ListarPor(string nome)
		{
			ICriteria crit = Get<ICriteria>()
				.Add(Expression.InsensitiveLike("Nome",nome,MatchMode.Anywhere))
				.AddOrder(Order.Asc("Nome"));
			return crit.List<Paciente>();
		}
	}
}
