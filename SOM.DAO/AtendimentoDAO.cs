
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
	public class AtendimentoDAO : BaseDAO<Atendimento, long>, SOM.DAO.IAtendimentoDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="AtendimentoDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public AtendimentoDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="AtendimentoDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public AtendimentoDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="AtendimentoDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public AtendimentoDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="AtendimentoDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public AtendimentoDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dia">O(A) dia.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorDia(Dia dia)
		{
			return Listar("IdDia","IdDia",dia.IdDia,"IdDia");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorUnidade(Unidade unidade)
		{
			return Listar("IdUnidade","IdUnidade",unidade.IdUnidade,"IdUnidade");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="procedencia">O(A) procedencia.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorProcedencia(Procedencia procedencia)
		{
			return Listar("IdProcedencia","IdProcedencia",procedencia.IdProcedencia,"IdProcedencia");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="postosaude">O(A) postosaude.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorPostoSaude(PostoSaude postosaude)
		{
			return Listar("IdPostoSaude","IdPostoSaude",postosaude.IdPostoSaude,"IdPostoSaude");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="origem">O(A) origem.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorOrigem(Origem origem)
		{
			return Listar("IdOrigem","IdOrigem",origem.IdOrigem,"IdOrigem");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="paciente">O(A) paciente.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorPaciente(Paciente paciente)
		{
			return Listar("IdPaciente","IdPaciente",paciente.IdPaciente,"IdPaciente");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorMedico(Medico medico)
		{
			return Listar("IdMedico","IdMedico",medico.IdMedico,"IdMedico");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="causa">O(A) causa.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorCausa(Causa causa)
		{
			return Listar("IdCausa","IdCausa",causa.IdCausa,"IdCausa");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="procedimento">O(A) procedimento.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorProcedimento(Procedimento procedimento)
		{
			return Listar("IdProcedimento","IdProcedimento",procedimento.IdProcedimento,"IdProcedimento");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="tipoobito">O(A) tipoobito.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPorTipoObito(TipoObito tipoobito)
		{
			return Listar("IdTipoObito","IdTipoObito",tipoobito.IdTipoObito,"IdTipoObito");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="iddia"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Atendimento> ListarPor(string iddia)
		{
			throw new NotImplementedException("Não implementado.");
		}

		public IList<Atendimento> ListarPorNome(Unidade unidade, string nome, int ano)
		{
			DateTime dataInicial = Convert.ToDateTime("1/1/" + ano), dataFinal = Convert.ToDateTime("31/12/" + ano);
			ICriteria crit = Get<ICriteria>()
					.Add(Restrictions.IsNull("DataExclusao"))
				.CreateAlias("IdDia","dia",NHibernate.SqlCommand.JoinType.InnerJoin)
					.Add(Restrictions.Between("dia.Data",dataInicial,dataFinal))
				.CreateAlias("IdUnidade", "unidade", NHibernate.SqlCommand.JoinType.InnerJoin)
					.Add(Restrictions.Eq("unidade.IdUnidade", unidade.IdUnidade))
				.CreateAlias("IdPaciente", "paciente", NHibernate.SqlCommand.JoinType.InnerJoin)
					.Add(Restrictions.InsensitiveLike("paciente.Nome", nome, MatchMode.Start))
					.AddOrder(Order.Asc("paciente.Nome"));
			return crit.List<Atendimento>();
		}

		public IList<Atendimento> ListarObitos(int ano)
        {
			DateTime dataInicial = Convert.ToDateTime("1/1/" + ano), dataFinal = Convert.ToDateTime("31/12/" + ano);
			ICriteria crit = Get<ICriteria>()
					.Add(Restrictions.IsNull("DataExclusao"))
					.Add(Restrictions.IsNotNull("IdTipoObito"))
				.CreateAlias("IdDia", "dia", NHibernate.SqlCommand.JoinType.InnerJoin)
					.Add(Restrictions.Between("dia.Data", dataInicial, dataFinal))
					.AddOrder(Order.Asc("dia.Data"))
					.AddOrder(Order.Asc("Hora"));
			return crit.List<Atendimento>();
		}

		public IList ResumoPorUnidade(int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/"+ano);
			string hql = @"select distinct u.IdUnidade,	
									u.Nome,
									d.Data,
									(select count(*) from Atendimento aa 
									where aa.IdUnidade.IdUnidade=u.IdUnidade and aa.IdDia.IdDia=d.IdDia and
										aa.DataExclusao is null and aa.IdDia.Data between :d1 and :d2)
							from Atendimento a, Dia d
							inner join a.IdUnidade u
							inner join d.IdCarnaval carnaval
							where a.DataExclusao is null and carnaval.Ano=:ano
							order by u.Nome, d.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			return query.List();
		}
		public IList ResumoPorSiglaUnidade(int ano)
		{
			string hql = @"select u.IdUnidade, u.Sigla, u.Cor, count(*) from Atendimento a
							inner join a.IdUnidade u
							inner join a.IdDia d
							inner join d.IdCarnaval c
							where c.Ano=:ano and a.DataExclusao is null
							group by u.IdUnidade,u.Sigla, u.Cor
							order by u.Sigla";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetInt32("ano", ano);
			return query.List();
		}
		public IList ResumoPorOrigem(int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct o.IdOrigem,	
									o.Descricao,
									d.Data,
									(select count(*) from Atendimento aa 
									where aa.IdOrigem.IdOrigem=o.IdOrigem and aa.IdDia.IdDia=d.IdDia and
										aa.DataExclusao is null and aa.IdDia.Data between :d1 and :d2)
							from Atendimento a, Dia d
							inner join a.IdOrigem o
							inner join d.IdCarnaval carnaval
							where a.DataExclusao is null and carnaval.Ano=:ano
							order by o.Descricao, d.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			return query.List();
		}
		public IList ResumoPorCausa(int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct c.IdCausa,	
									c.Descricao,
									d.Data,
									(select count(*) from Atendimento aa 
									where aa.IdCausa.IdCausa=c.IdCausa and aa.IdDia.IdDia=d.IdDia and
										aa.DataExclusao is null and aa.IdDia.Data between :d1 and :d2)
							from Atendimento a, Dia d
							inner join a.IdCausa c
							inner join d.IdCarnaval carnaval
							where a.DataExclusao is null and carnaval.Ano=:ano
							order by c.Descricao, d.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			return query.List();
		}
		public IList ResumoPorProcedimento(int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct p.IdProcedimento, 	
									p.Descricao,
									d.Data,
									(select count(*) from Atendimento aa 
									where aa.IdProcedimento.IdProcedimento=p.IdProcedimento and aa.IdDia.IdDia=d.IdDia and
										aa.DataExclusao is null and aa.IdDia.Data between :d1 and :d2)
							from Atendimento a, Dia d
							inner join a.IdProcedimento p
							inner join d.IdCarnaval carnaval
							where a.DataExclusao is null and carnaval.Ano=:ano
							order by p.Descricao, d.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			return query.List();
		}
		public IList ResumoPorProcedencia(int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct p.IdProcedencia,	
									p.Descricao,
									d.Data,
									(select count(*) from Atendimento aa 
									where aa.IdProcedencia.IdProcedencia=p.IdProcedencia and aa.IdDia.IdDia=d.IdDia and
										aa.DataExclusao is null and aa.IdDia.Data between :d1 and :d2)
							from Atendimento a, Dia d
							inner join a.IdProcedencia p
							inner join d.IdCarnaval carnaval
							where a.DataExclusao is null and carnaval.Ano=:ano
							order by p.Descricao, d.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			return query.List();
		}
		public long TotalOcorrencias(int ano)
		{
			string hql = @"select count(*) from Atendimento a
						   inner join a.IdDia d
						   inner join d.IdCarnaval c
                           where c.Ano=:ano and a.DataExclusao is null";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetInt64("ano", ano);
			return query.UniqueResult<long>();
		}
		public IList ResumoCausaPorOrigem(Origem origem, int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct	causa.IdCausa, 
											causa.Descricao,
											dia.Data,
											(select count(*) from atendimento a
											inner join a.IdDia d
											inner join a.IdOrigem o
											inner join a.IdCausa c
											where o.IdOrigem=origem.IdOrigem and c.IdCausa=causa.IdCausa and 
												  d.IdDia.IdDia=dia.IdDia and a.DataExclusao is null and d.Data between :d1 and :d2)
						from Atendimento atendimento, Dia dia
							inner join atendimento.IdCausa causa
							inner join atendimento.IdOrigem origem
							inner join dia.IdCarnaval carnaval
						where atendimento.DataExclusao is null and origem.IdOrigem=:origem and carnaval.Ano=:ano
						order by causa.Descricao, dia.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			query.SetInt64("origem", origem.IdOrigem.Value);
			return query.List();
		}
		public IList ResumoOrigemPorCausa(Causa causa, int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct	origem.IdOrigem, 
											origem.Descricao,
											dia.Data,
											(select count(*) from atendimento a
											inner join a.IdDia d
											inner join a.IdCausa c
											inner join a.IdOrigem o
											where c.IdCausa=causa.IdCausa and o.IdOrigem=origem.IdOrigem and 
												  d.IdDia.IdDia=dia.IdDia and a.DataExclusao is null and d.Data between :d1 and :d2)
						from Atendimento atendimento, Dia dia
							inner join atendimento.IdOrigem origem
							inner join atendimento.IdCausa causa
							inner join dia.IdCarnaval carnaval
						where atendimento.DataExclusao is null and causa.IdCausa=:causa and carnaval.Ano=:ano
						order by origem.Descricao, dia.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			query.SetInt64("causa", causa.IdCausa.Value);
			return query.List();
		}
		public IList ResumoPorPostoSaude(int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct	postoSaude.IdPostoSaude, 
											postoSaude.Nome,
											dia.Data,
											(select count(*) from atendimento a
											inner join a.IdDia d
											inner join a.IdPostoSaude p
											where p.IdPostoSaude=postoSaude.IdPostoSaude and 
												  d.IdDia.IdDia=dia.IdDia and a.DataExclusao is null and d.Data between :d1 and :d2)
						from Atendimento atendimento, Dia dia
							inner join atendimento.IdPostoSaude postoSaude
							inner join dia.IdCarnaval carnaval
						where atendimento.DataExclusao is null and carnaval.Ano=:ano
						order by postoSaude.Nome, dia.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			return query.List();
		}
		public IList ResumoPorDemandaExpontanea(int ano)
		{
			DateTime d1 = Convert.ToDateTime("1/1/" + ano), d2 = Convert.ToDateTime("31/12/" + ano);
			string hql = @"select distinct u.IdUnidade,	
									u.Nome,
									d.Data,
									(select count(*) from Atendimento aa 
									where aa.IdUnidade.IdUnidade=u.IdUnidade and aa.IdDia.IdDia=d.IdDia and
										aa.DataExclusao is null and aa.IdPostoSaude is null and aa.IdDia.Data between :d1 and :d2)
							from Atendimento a, Dia d
							inner join a.IdUnidade u
							inner join d.IdCarnaval carnaval
							where a.DataExclusao is null and carnaval.Ano=:ano and a.IdPostoSaude is null
							order by u.Nome, d.Data";
			IQuery query = Get<ISession>().CreateQuery(hql);
			query.SetDateTime("d1", d1);
			query.SetDateTime("d2", d2);
			query.SetInt64("ano", ano);
			return query.List();
		}
	}
}
