using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using System.Web.Http.Cors;
using SOM.OR;
using SOM.API.Models;

namespace SOM.API
{
	/// <summary>
	/// Controller da classe <see cref='AtendimentoController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class AtendimentoController : ApiController
	{
		[HttpGet]
		[Route("atendimento/obitos")]
		public IList<Atendimento> ListarObitos()
        {
			return BOAccess.getBOFactory().AtendimentoBO().ListarObitos();
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dia">O(A) dia.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarpordia")]
		public IList<SOM.OR.Atendimento> ListarPorDia(Dia dia)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorDia(dia);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarporunidade")]
		public IList<SOM.OR.Atendimento> ListarPorUnidade(Unidade unidade)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorUnidade(unidade);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="procedencia">O(A) procedencia.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarporprocedencia")]
		public IList<SOM.OR.Atendimento> ListarPorProcedencia(Procedencia procedencia)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorProcedencia(procedencia);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="postosaude">O(A) postosaude.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarporpostosaude")]
		public IList<SOM.OR.Atendimento> ListarPorPostoSaude(PostoSaude postosaude)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorPostoSaude(postosaude);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="origem">O(A) origem.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarpororigem")]
		public IList<SOM.OR.Atendimento> ListarPorOrigem(Origem origem)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorOrigem(origem);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="paciente">O(A) paciente.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarporpaciente")]
		public IList<SOM.OR.Atendimento> ListarPorPaciente(Paciente paciente)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorPaciente(paciente);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarpormedico")]
		public IList<SOM.OR.Atendimento> ListarPorMedico(Medico medico)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorMedico(medico);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="causa">O(A) causa.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarporcausa")]
		public IList<SOM.OR.Atendimento> ListarPorCausa(Causa causa)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorCausa(causa);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="procedimento">O(A) procedimento.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarporprocedimento")]
		public IList<SOM.OR.Atendimento> ListarPorProcedimento(Procedimento procedimento)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorProcedimento(procedimento);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="tipoobito">O(A) tipoobito.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("atendimento/listarportipoobito")]
		public IList<SOM.OR.Atendimento> ListarPorTipoObito(TipoObito tipoobito)
		{
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorTipoObito(tipoobito);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("atendimento/selecionarporid/{id}")]
		public SOM.OR.Atendimento SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().AtendimentoBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("atendimento/listar/{propertyOrder}")]
		public IList<SOM.OR.Atendimento> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().AtendimentoBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="ocorrencia">O(A) ocorrencia.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("atendimento/inserir")]
		public SOM.OR.Atendimento Inserir(Ocorrencia ocorrencia)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().AtendimentoBO().InserirAlterar(u, ocorrencia.Atendimento, Regisoft.Operacao.Incluir, ocorrencia.Doencas);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="ocorrencia">O(A) ocorrencia.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("atendimento/alterar")]
		public SOM.OR.Atendimento Alterar(Ocorrencia ocorrencia)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().AtendimentoBO().InserirAlterar(u, ocorrencia.Atendimento, Regisoft.Operacao.Alterar, ocorrencia.Doencas);
		}

		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="atendimento">O(A) atendimento.</param>
		[HttpDelete]
		[Route("atendimento/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Atendimento atendimento = BOAccess.getBOFactory().AtendimentoBO().SelecionarPorId(id);
			BOAccess.getBOFactory().AtendimentoBO().Excluir(u, atendimento);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("atendimento/excluirlista")]
		public void Excluir(IList<SOM.OR.Atendimento> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().AtendimentoBO().Excluir(u, lst);
		}

		[HttpGet]
		[Route("atendimento/listarpornome")]
		public IList<Atendimento> ListarPorNome(string nome)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().AtendimentoBO().ListarPorNome(u.IdUnidade, nome);
		}
	}
}
