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
	/// Controller da classe <see cref='UnidadeController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class UnidadeController : ApiController
	{
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("unidade/selecionarporid/{id}")]
		public SOM.OR.Unidade SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().UnidadeBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("unidade/listar/{propertyOrder}")]
		public IList<SOM.OR.Unidade> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().UnidadeBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("unidade/inserir")]
		public SOM.OR.Unidade Inserir(SOM.OR.Unidade unidade)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().UnidadeBO().InserirAlterar(u, unidade, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("unidade/alterar")]
		public SOM.OR.Unidade Alterar(SOM.OR.Unidade unidade)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().UnidadeBO().InserirAlterar(u, unidade, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		[HttpDelete]
		[Route("unidade/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Unidade unidade = BOAccess.getBOFactory().UnidadeBO().SelecionarPorId(id);
			BOAccess.getBOFactory().UnidadeBO().Excluir(u, unidade);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("unidade/excluirlista")]
		public void Excluir(IList<SOM.OR.Unidade> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().UnidadeBO().Excluir(u, lst);
		}
	}
}
