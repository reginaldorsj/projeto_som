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
	/// Controller da classe <see cref='OcupacaoController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class OcupacaoController : ApiController
	{
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("ocupacao/selecionarporid/{id}")]
		public SOM.OR.Ocupacao SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().OcupacaoBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("ocupacao/listar/{propertyOrder}")]
		public IList<SOM.OR.Ocupacao> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().OcupacaoBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("ocupacao/inserir")]
		public SOM.OR.Ocupacao Inserir(SOM.OR.Ocupacao ocupacao)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().OcupacaoBO().InserirAlterar(u, ocupacao, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("ocupacao/alterar")]
		public SOM.OR.Ocupacao Alterar(SOM.OR.Ocupacao ocupacao)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().OcupacaoBO().InserirAlterar(u, ocupacao, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		[HttpDelete]
		[Route("ocupacao/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Ocupacao ocupacao = BOAccess.getBOFactory().OcupacaoBO().SelecionarPorId(id);
			BOAccess.getBOFactory().OcupacaoBO().Excluir(u, ocupacao);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("ocupacao/excluirlista")]
		public void Excluir(IList<SOM.OR.Ocupacao> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().OcupacaoBO().Excluir(u, lst);
		}
	}
}
