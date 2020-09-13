using SOM.OR;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SOM.API.Models;
using Regisoft;

namespace SOM.API.Controllers
{
    public class PlantaoController : ApiController
    {
        [HttpGet]
        [Route("totalplantao")]
        public long TotalPlantoes()
        {
            return BOAccess.getBOFactory().EscalaMedicoBO().TotalPlantoes();
        }
        [HttpGet]
        [Route("plantaounidade")]
        public IList<Totalizacao> TotalizaPlantaoUnidade()
        {
            List<Totalizacao> lstTotalizacao = new List<Totalizacao>();
            IList lst = BOAccess.getBOFactory().EscalaMedicoBO().TotalPorUnidade();
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
        [Route("plantaounidadesigla")]
        public IList<Totalizacao> TotalizaPlantaoUnidadeSigla()
        {
            List<Totalizacao> lstTotalizacao = new List<Totalizacao>();
            IList lst = BOAccess.getBOFactory().EscalaMedicoBO().TotalPorSiglaUnidade();
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
        [Route("plantaoespecialidade")]
        public IList<Totalizacao> TotalizaPlantaoEspecialidade()
        {
            List<Totalizacao> lstTotalizacao = new List<Totalizacao>();
            IList lst = BOAccess.getBOFactory().EscalaMedicoBO().TotalPorEspecialidade();
            foreach (System.Array a in lst)
            {
                Totalizacao t = new Totalizacao();
                t.Id = Convert.ToInt64(a.GetValue(0));
                t.Detalhe = a.GetValue(1).ToString().Captalize();
                t.Quantidade = Convert.ToInt32(a.GetValue(2));

                lstTotalizacao.Add(t);
            }
            return lstTotalizacao;

        }
        [HttpGet]
        [Route("plantaoespecialidadeagora")]
        public IList<Totalizacao> TotalizaPlantaoEspecialidadeAgora()
        {
            List<Totalizacao> lstTotalizacao = new List<Totalizacao>();
            IList lst = BOAccess.getBOFactory().EscalaMedicoBO().TotalPorEspecialidadeAgora();
            foreach (System.Array a in lst)
            {
                Totalizacao t = new Totalizacao();
                t.Id = Convert.ToInt64(a.GetValue(0));
                t.Detalhe = a.GetValue(1).ToString().Captalize();
                t.Quantidade = Convert.ToInt32(a.GetValue(2));

                lstTotalizacao.Add(t);
            }
            return lstTotalizacao;

        }
        [HttpGet]
        [Route("plantaoespecialidadeunidade/{idEspecialidade}")]
        public IList<Totalizacao> TotalizaPlantaoEspecialidadeUnidade(long idEspecialidade)
        {
            Ocupacao o = BOAccess.getBOFactory().OcupacaoBO().SelecionarPorId(idEspecialidade);
            List<Totalizacao> lstTotalizacao = new List<Totalizacao>();
            IList lst = BOAccess.getBOFactory().EscalaMedicoBO().TotalPorUnidade(o);
            foreach (System.Array a in lst)
            {
                Totalizacao t = new Totalizacao();
                t.Id = Convert.ToInt64(a.GetValue(0));
                t.Detalhe = a.GetValue(1).ToString();
                t.Quantidade = Convert.ToInt32(a.GetValue(2));

                lstTotalizacao.Add(t);
            }
            return lstTotalizacao;
        }
        [HttpGet]
        [Route("listagemplantao/{idUnidade}")]
        public IList<Plantao> ListaPlantao(long idUnidade)
        {
            Unidade u = BOAccess.getBOFactory().UnidadeBO().SelecionarPorId(idUnidade);
            List<Plantao> lstPlantao = new List<Plantao>();
            IList lst = BOAccess.getBOFactory().EscalaMedicoBO().ListarPlantao(u);
            foreach (System.Array a in lst)
            {
                Plantao p = new Plantao()
                {
                    Especialidade = a.GetValue(0).ToString().Captalize(),
                    Profissional = a.GetValue(1).ToString(),
                    Cremeb = a.GetValue(2).ToString(),
                    Uf = a.GetValue(3).ToString(),
                    DataHoraInicio = Convert.ToDateTime(a.GetValue(4)),
                    DataHoraFim = Convert.ToDateTime(a.GetValue(5))
                };

                lstPlantao.Add(p);
            }
            return lstPlantao;
        }
        [HttpGet]
        [Route("plantaoespecialidadeunidadeagora/{idEspecialidade}")]
        public IList<Totalizacao> TotalizaPlantaoEspecialidadeUnidadeAgora(long idEspecialidade)
        {
            Ocupacao o = BOAccess.getBOFactory().OcupacaoBO().SelecionarPorId(idEspecialidade);
            List<Totalizacao> lstTotalizacao = new List<Totalizacao>();
            IList lst = BOAccess.getBOFactory().EscalaMedicoBO().TotalPorUnidadeAgora(o);
            foreach (System.Array a in lst)
            {
                Totalizacao t = new Totalizacao();
                t.Id = Convert.ToInt64(a.GetValue(0));
                t.Detalhe = a.GetValue(1).ToString();
                t.Quantidade = Convert.ToInt32(a.GetValue(2));

                lstTotalizacao.Add(t);
            }
            return lstTotalizacao;
        }
    }
}
