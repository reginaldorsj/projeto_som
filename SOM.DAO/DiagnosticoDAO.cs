
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
	public class DiagnosticoDAO : BaseDAO<Diagnostico, long>, SOM.DAO.IDiagnosticoDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="DiagnosticoDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public DiagnosticoDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="DiagnosticoDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public DiagnosticoDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="DiagnosticoDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public DiagnosticoDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="DiagnosticoDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public DiagnosticoDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="atendimento">O(A) atendimento.</param>
		/// <returns>A lista.</returns>
		public IList<Diagnostico> ListarPorAtendimento(Atendimento atendimento)
		{
			return Listar("IdAtendimento","IdAtendimento",atendimento.IdAtendimento,"IdAtendimento");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="doenca">O(A) doenca.</param>
		/// <returns>A lista.</returns>
		public IList<Diagnostico> ListarPorDoenca(Doenca doenca)
		{
			return Listar("IdDoenca","IdDoenca",doenca.IdDoenca,"IdDoenca");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idatendimento"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Diagnostico> ListarPor(string idatendimento)
		{
			throw new NotImplementedException("Não implementado.");
		}
		public IList<Doenca> ListarDoencasPorAtendimento(Atendimento atendimento)
		{
			string hql = @"select doenca from Diagnostico diag
							inner join diag.IdAtendimento atendimento
							inner join diag.IdDoenca doenca
							where atendimento.IdAtendimento=:idatendimento
							order by doenca.IdDoenca";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetInt64("idatendimento", atendimento.IdAtendimento.Value);
			return query.List<Doenca>();
		}
		public IList ResumoDoencaPorUnidade(Unidade unidade, int ano)
        {
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct	doenca.IdDoenca, 
											doenca.Descricao,
											dia.Data,
											(select count(*) from Diagnostico diag
											inner join diag.IdAtendimento a
											inner join a.IdDia d
											inner join a.IdUnidade u
											inner join diag.IdDoenca doe
											where u.IdUnidade=unidade.IdUnidade and doe.IdDoenca=doenca.IdDoenca and 
												  d.IdDia=dia.IdDia and a.DataExclusao is null and d.Data between :d1 and :d2)
						from Diagnostico diagnostico, Dia dia
							inner join diagnostico.IdAtendimento atendimento
							inner join atendimento.IdUnidade unidade
							inner join diagnostico.IdDoenca doenca
							inner join dia.IdCarnaval carnaval
						where atendimento.DataExclusao is null and unidade.IdUnidade=:unidade and carnaval.Ano=:ano
						order by doenca.Descricao, dia.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			query.SetInt64("unidade", unidade.IdUnidade.Value);
			return query.List();
		}
		public IList ResumoDoencaPorProcedimento(Procedimento procedimento, int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct	doenca.IdDoenca, 
											doenca.Descricao,
											dia.Data,
											(select count(*) from Diagnostico diag
											inner join diag.IdAtendimento a
											inner join a.IdDia d
											inner join a.IdProcedimento u
											inner join diag.IdDoenca doe
											where u.IdProcedimento=procedimento.IdProcedimento and doe.IdDoenca=doenca.IdDoenca and 
												  d.IdDia=dia.IdDia and a.DataExclusao is null and d.Data between :d1 and :d2)
						from Diagnostico diagnostico, Dia dia
							inner join diagnostico.IdAtendimento atendimento
							inner join atendimento.IdProcedimento procedimento
							inner join diagnostico.IdDoenca doenca
							inner join dia.IdCarnaval carnaval
						where atendimento.DataExclusao is null and procedimento.IdProcedimento=:procedimento and carnaval.Ano=:ano
						order by doenca.Descricao, dia.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			query.SetInt64("procedimento", procedimento.IdProcedimento.Value);
			return query.List();
		}
	}
}
