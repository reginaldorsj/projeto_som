using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SOM.API.Models;
using Regisoft;
using SOM.OR;

namespace SOM.API.Controllers
{
    public class OcorrenciaController : ApiController
    {
        [HttpGet]
        [Route("dia")]
        public IList<SOM.OR.Dia> ListarDiasAtivos()
        {
            return BOAccess.getBOFactory().DiaBO().ListarAtivos();
        }

        [HttpGet]
        [Route("carnaval")]
        public Carnaval Get()
        {
            return BOAccess.getBOFactory().CarnavalBO().GetAtivo();
        }
        [HttpGet]
        [Route("totalocorrencia")]
        public long TotalOcorrencias()
        {
            return BOAccess.getBOFactory().AtendimentoBO().TotalOcorrencias();
        }
        [HttpGet]
        [Route("doencaprocedimento/{idprocedimento}")]
        public IList<Totalizacao> ResumoDoencaPorProcedimento(long idProcedimento)
        {
            Procedimento procedimento = BOAccess.getBOFactory().ProcedimentoBO().SelecionarPorId(idProcedimento);
            IList lst = BOAccess.getBOFactory().DiagnosticoBO().ResumoDoencaPorProcedimento(procedimento);
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("origemcausa/{idcausa}")]
        public IList<Totalizacao> ResumoOrigemPorCausa(long idCausa)
        {
            Causa causa = BOAccess.getBOFactory().CausaBO().SelecionarPorId(idCausa);
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoOrigemPorCausa(causa);
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("causaorigem/{idorigem}")]
        public IList<Totalizacao> ResumoCausaPorOrigem(long idOrigem)
        {
            Origem origem = BOAccess.getBOFactory().OrigemBO().SelecionarPorId(idOrigem);
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoCausaPorOrigem(origem);
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("doencaunidade/{idUnidade}")]
        public IList<Totalizacao> ResumoDoencaPorUnidade(long idUnidade)
        {
            Unidade unidade = BOAccess.getBOFactory().UnidadeBO().SelecionarPorId(idUnidade);
            IList lst = BOAccess.getBOFactory().DiagnosticoBO().ResumoDoencaPorUnidade(unidade);
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("unidadesigla")]
        public IList<Totalizacao> ResumoPorSiglaUnidade()
        {
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoPorSiglaUnidade();
            List<Totalizacao> lstTotalizacao = new List<Totalizacao>();
            foreach (System.Array a in lst)
            {
                Totalizacao t = new Totalizacao();
                t.Id = Convert.ToInt64(a.GetValue(0));
                t.Detalhe = a.GetValue(1).ToString();
                t.Cor = a.GetValue(2).ToString();
                t.Quantidade = Convert.ToInt32(a.GetValue(3));

                lstTotalizacao.Add(t);
            }
            return lstTotalizacao;
        }
        [HttpGet]
        [Route("unidade")]
        public IList<Totalizacao> ResumoPorUnidade()
        {
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoPorUnidade();
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("causa")]
        public IList<Totalizacao> ResumoPorCausa()
        {
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoPorCausa();
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("origem")]
        public IList<Totalizacao> ResumoPorOrigem()
        {
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoPorOrigem();
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("procedencia")]
        public IList<Totalizacao> ResumoPorProcedencia()
        {
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoPorProcedencia();
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("procedimento")]
        public IList<Totalizacao> ResumoPorProcedimento()
        {
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoPorProcedimento();
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("postosaude")]
        public IList<Totalizacao> ResumoPorPostoSaude()
        {
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoPorPostoSaude();
            return getTotalizacao(lst);
        }
        [HttpGet]
        [Route("demandaexpontanea")]
        public IList<Totalizacao> ResumoPorDemandaExpontanea()
        {
            IList lst = BOAccess.getBOFactory().AtendimentoBO().ResumoPorDemandaExpontanea();
            return getTotalizacao(lst);
        }

        private IList<Totalizacao> getTotalizacao(IList lst)
        {
            List<Totalizacao> lstTotalizacao = new List<Totalizacao>();
            foreach (System.Array a in lst)
            {
                Totalizacao t = new Totalizacao();
                t.Id = Convert.ToInt64(a.GetValue(0));
                t.Detalhe = a.GetValue(1).ToString();
                t.Data = Convert.ToDateTime(a.GetValue(2));
                t.Quantidade = Convert.ToInt32(a.GetValue(3));

                lstTotalizacao.Add(t);
            }
            return lstTotalizacao;
        }
    }
}
