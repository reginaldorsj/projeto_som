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
	/// Controller da classe <see cref='CausaController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class CausaController : ApiController
	{
		[HttpGet]
		[Route("causa/listar/")]
		public IList<SOM.OR.Causa> ListarAtivos()
		{
			return BOAccess.getBOFactory().CausaBO().ListarAtivos();
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("causa/selecionarporid/{id}")]
		public SOM.OR.Causa SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().CausaBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("causa/listar/{propertyOrder}")]
		public IList<SOM.OR.Causa> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().CausaBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="causa">O(A) causa.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("causa/inserir")]
		public SOM.OR.Causa Inserir(SOM.OR.Causa causa)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().CausaBO().InserirAlterar(u, causa, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="causa">O(A) causa.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("causa/alterar")]
		public SOM.OR.Causa Alterar(SOM.OR.Causa causa)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().CausaBO().InserirAlterar(u, causa, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="causa">O(A) causa.</param>
		[HttpDelete]
		[Route("causa/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Causa causa = BOAccess.getBOFactory().CausaBO().SelecionarPorId(id);
			BOAccess.getBOFactory().CausaBO().Excluir(u, causa);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("causa/excluirlista")]
		public void Excluir(IList<SOM.OR.Causa> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().CausaBO().Excluir(u, lst);
		}
	}
}
