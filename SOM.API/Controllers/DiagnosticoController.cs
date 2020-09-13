using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using System.Web.Http.Cors;
using SOM.OR;

namespace SOM.API
{
	/// <summary>
	/// Controller da classe <see cref='DiagnosticoController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class DiagnosticoController : ApiController
	{
		[HttpGet]
		[Route("diagnostico/listardoencas")]
		public IList<Doenca> ListarDoencasPorAtendimento(long idAtendimento)
		{
			Atendimento atendimento = BOAccess.getBOFactory().AtendimentoBO().SelecionarPorId(idAtendimento);
			return BOAccess.getBOFactory().DiagnosticoBO().ListarDoencasPorAtendimento(atendimento); 
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="atendimento">O(A) atendimento.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("diagnostico/listarporatendimento")]
		public IList<SOM.OR.Diagnostico> ListarPorAtendimento(Atendimento atendimento)
		{
			return BOAccess.getBOFactory().DiagnosticoBO().ListarPorAtendimento(atendimento);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="doenca">O(A) doenca.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("diagnostico/listarpordoenca")]
		public IList<SOM.OR.Diagnostico> ListarPorDoenca(Doenca doenca)
		{
			return BOAccess.getBOFactory().DiagnosticoBO().ListarPorDoenca(doenca);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("diagnostico/selecionarporid/{id}")]
		public SOM.OR.Diagnostico SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().DiagnosticoBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("diagnostico/listar/{propertyOrder}")]
		public IList<SOM.OR.Diagnostico> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().DiagnosticoBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="diagnostico">O(A) diagnostico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("diagnostico/inserir")]
		public SOM.OR.Diagnostico Inserir(SOM.OR.Diagnostico diagnostico)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().DiagnosticoBO().InserirAlterar(u, diagnostico, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="diagnostico">O(A) diagnostico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("diagnostico/alterar")]
		public SOM.OR.Diagnostico Alterar(SOM.OR.Diagnostico diagnostico)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().DiagnosticoBO().InserirAlterar(u, diagnostico, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="diagnostico">O(A) diagnostico.</param>
		[HttpDelete]
		[Route("diagnostico/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Diagnostico diagnostico = BOAccess.getBOFactory().DiagnosticoBO().SelecionarPorId(id);
			BOAccess.getBOFactory().DiagnosticoBO().Excluir(u, diagnostico);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("diagnostico/excluirlista")]
		public void Excluir(IList<SOM.OR.Diagnostico> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().DiagnosticoBO().Excluir(u, lst);
		}
	}
}
