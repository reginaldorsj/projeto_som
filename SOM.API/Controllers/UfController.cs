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
	/// Controller da classe <see cref='UfController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class UfController : ApiController
	{
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("uf/selecionarporid/{id}")]
		public SOM.OR.Uf SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().UfBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade espec�fica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a sele��o.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("uf/listar/{propertyOrder}")]
		public IList<SOM.OR.Uf> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().UfBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <param name="op">A opera��o.</param>
		/// <returns>O objeto ap�s a persist�ncia.</returns>
		[HttpPost]
		[Route("uf/inserir")]
		public SOM.OR.Uf Inserir(SOM.OR.Uf uf)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().UfBO().InserirAlterar(u, uf, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <param name="op">A opera��o.</param>
		/// <returns>O objeto ap�s a persist�ncia.</returns>
		[HttpPut]
		[Route("uf/alterar")]
		public SOM.OR.Uf Alterar(SOM.OR.Uf uf)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().UfBO().InserirAlterar(u, uf, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		[HttpDelete]
		[Route("uf/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Uf uf = BOAccess.getBOFactory().UfBO().SelecionarPorId(id);
			BOAccess.getBOFactory().UfBO().Excluir(u, uf);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("uf/excluirlista")]
		public void Excluir(IList<SOM.OR.Uf> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().UfBO().Excluir(u, lst);
		}
	}
}
