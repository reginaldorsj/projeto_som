
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
    public class EscalaMedicoDAO : BaseDAO<EscalaMedico, long>, SOM.DAO.IEscalaMedicoDAO
    {
        /// <summary>
        /// Inicializa uma instância da classe <see cref="EscalaMedicoDAO"/>.
        /// </summary>
        /// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public EscalaMedicoDAO(string factoryConfigPath)
            : base(factoryConfigPath, "SOM.OR", null)
        {
        }
        /// <summary>
        /// Inicializa uma instância de <see cref="EscalaMedicoDAO"/>.
        /// </summary>
        [Microsoft.Practices.Unity.InjectionConstructor]
        public EscalaMedicoDAO()
            : base()
        {
        }
        /// <summary>
        /// Inicializa uma instância da classe <see cref="EscalaMedicoDAO"/>.
        /// </summary>
        /// <param name="session">A sessão NHibernate.</param>
        /// <param name="configuration">A configuração.</param>
        public EscalaMedicoDAO(ISession session, Configuration configuration)
            : base(session, configuration)
        {
        }
        /// <summary>
        /// Inicializa uma instância da classe <see cref="EscalaMedicoDAO"/>.
        /// </summary>
        /// <param name="connection">A conexão.</param>
        public EscalaMedicoDAO(System.Data.Common.DbConnection connection)
            : base(connection)
        {
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="unidade">O(A) unidade.</param>
        /// <returns>A lista.</returns>
        public IList<EscalaMedico> ListarPorUnidade(Unidade unidade)
        {
            return Listar("IdUnidade", "IdUnidade", unidade.IdUnidade, "IdUnidade");
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="ocupacao">O(A) ocupacao.</param>
        /// <returns>A lista.</returns>
        public IList<EscalaMedico> ListarPorOcupacao(Ocupacao ocupacao)
        {
            return Listar("IdOcupacao", "IdOcupacao", ocupacao.IdOcupacao, "IdOcupacao");
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="medico">O(A) medico.</param>
        /// <returns>A lista.</returns>
        public IList<EscalaMedico> ListarPorMedico(Medico medico)
        {
            return Listar("IdMedico", "IdMedico", medico.IdMedico, "DataHoraInicio");
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="idunidade"> O dado para pesquisa.</param>
        /// <returns>A lista.</returns>
        public IList<EscalaMedico> ListarPor(string idunidade)
        {
            throw new NotImplementedException("Não implementado.");
        }
        public IList<EscalaMedico> ListarPor(Unidade unidade, Medico medico, int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            ICriteria crit = Get<ICriteria>()
                    .Add(Restrictions.Between("DataHoraInicio", dataInicio, dataFim))
                .CreateAlias("IdUnidade", "unidade", NHibernate.SqlCommand.JoinType.InnerJoin)
                    .Add(Restrictions.Eq("unidade.IdUnidade", unidade.IdUnidade))
                .CreateAlias("IdMedico", "medico", NHibernate.SqlCommand.JoinType.InnerJoin)
                    .Add(Restrictions.Eq("medico.IdMedico", medico.IdMedico));
            return crit.List<EscalaMedico>();
        }

        public long TotalPlantoes(int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            string hql = @"select count(*) from EscalaMedico em
                           where em.DataHoraInicio between :d1 and :d2";
            IQuery query = Get<ISession>().CreateQuery(hql);
            query.SetDateTime("d1", dataInicio);
            query.SetDateTime("d2", dataFim);
            return query.UniqueResult<long>();
        }

        public IList TotalPorSiglaUnidade(int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            string hql = @"select u.IdUnidade, u.Sigla, u.Cor, count(*) from EscalaMedico em
                           inner join em.IdUnidade u 
                           where em.DataHoraInicio between :d1 and :d2
                           group by u.IdUnidade, u.Sigla, u.Cor
                           order by u.Sigla";

            IQuery query = Get<ISession>().CreateQuery(hql);
            query.SetDateTime("d1", dataInicio);
            query.SetDateTime("d2", dataFim);
            return query.List();
        }
        public IList TotalPorUnidade(int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            string hql = @"select u.IdUnidade, u.Nome, u.Cor, count(*) from EscalaMedico em
                           inner join em.IdUnidade u 
                           where em.DataHoraInicio between :d1 and :d2
                           group by u.IdUnidade, u.Nome, u.Cor
                           order by u.Nome";

            IQuery query = Get<ISession>().CreateQuery(hql);
            query.SetDateTime("d1", dataInicio);
            query.SetDateTime("d2", dataFim);
            return query.List();
        }
        public IList TotalPorUnidade(Ocupacao o, int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            string hql = @"select u.IdUnidade, u.Nome, count(*) from EscalaMedico em
                           inner join em.IdUnidade u 
                           inner join em.IdOcupacao o
                           where em.DataHoraInicio between :d1 and :d2 and
                                 o.IdOcupacao =:ocupacao
                           group by u.IdUnidade, u.Nome
                           order by u.Nome";

            IQuery query = Get<ISession>().CreateQuery(hql);
            query.SetDateTime("d1", dataInicio);
            query.SetDateTime("d2", dataFim);
            query.SetInt64("ocupacao", o.IdOcupacao.Value);
            return query.List();
        }
        public IList TotalPorEspecialidade(int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            string hql = @"select o.IdOcupacao, o.Nome, count(*) from EscalaMedico em
                           inner join em.IdOcupacao o 
                           where em.DataHoraInicio between :d1 and :d2
                           group by o.IdOcupacao, o.Nome
                           order by o.Nome";

            IQuery query = Get<ISession>().CreateQuery(hql);
            query.SetDateTime("d1", dataInicio);
            query.SetDateTime("d2", dataFim);
            return query.List();
        }
        public IList ListarPlantao(Unidade unidade, int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            string hql = @"select o.Nome, m.Nome, m.Cremeb, uf.Sigla, em.DataHoraInicio, em.DataHoraFim from EscalaMedico em
                            inner join em.IdOcupacao o
                            inner join em.IdMedico m
                            inner join m.IdUf uf
                            inner join em.IdUnidade u
                            where u.IdUnidade = :unidade and
                                em.DataHoraInicio between :d1 and :d2
                            order by o.Nome";

            IQuery query = Get<ISession>().CreateQuery(hql);
            query.SetDateTime("d1", dataInicio);
            query.SetDateTime("d2", dataFim);
            query.SetInt64("unidade", unidade.IdUnidade.Value);
            return query.List();
        }
        public IList TotalPorEspecialidadeAgora(int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            string hql = @"select o.IdOcupacao, o.Nome, count(*) from EscalaMedico em
                           inner join em.IdOcupacao o 
                           where :now between em.DataHoraInicio and em.DataHoraFim and
                                em.DataHoraInicio between :d1 and :d2
                           group by o.IdOcupacao, o.Nome
                           order by o.Nome";

            IQuery query = Get<ISession>().CreateQuery(hql);
            query.SetDateTime("d1", dataInicio);
            query.SetDateTime("d2", dataFim);
            query.SetDateTime("now", DateTime.Now);
            return query.List();
        }

        public IList TotalPorUnidadeAgora(Ocupacao o, int ano)
        {
            DateTime dataInicio = Convert.ToDateTime("1/1/" + ano), dataFim = Convert.ToDateTime("31/12/" + ano);
            string hql = @"select u.IdUnidade, u.Nome, count(*) from EscalaMedico em
                           inner join em.IdUnidade u 
                           inner join em.IdOcupacao o
                           where o.IdOcupacao =:ocupacao and
                                :now between em.DataHoraInicio and em.DataHoraFim and
                                em.DataHoraInicio between :d1 and :d2
                           group by u.IdUnidade, u.Nome
                           order by u.Nome";

            IQuery query = Get<ISession>().CreateQuery(hql);
            query.SetDateTime("d1", dataInicio);
            query.SetDateTime("d2", dataFim);
            query.SetDateTime("now", DateTime.Now);
            query.SetInt64("ocupacao", o.IdOcupacao.Value);
            return query.List();
        }
    }
}
