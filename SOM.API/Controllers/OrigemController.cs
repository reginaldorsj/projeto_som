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
	/// Controller da classe <see cref='OrigemController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class OrigemController : ApiController
	{
		[HttpGet]
		[Route("origem/listar/")]
		public IList<SOM.OR.Origem> ListarAtivos()
		{
			return BOAccess.getBOFactory().OrigemBO().ListarAtivos();
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("origem/selecionarporid/{id}")]
		public SOM.OR.Origem SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().OrigemBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("origem/listar/{propertyOrder}")]
		public IList<SOM.OR.Origem> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().OrigemBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="origem">O(A) origem.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("origem/inserir")]
		public SOM.OR.Origem Inserir(SOM.OR.Origem origem)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().OrigemBO().InserirAlterar(u, origem, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="origem">O(A) origem.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("origem/alterar")]
		public SOM.OR.Origem Alterar(SOM.OR.Origem origem)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().OrigemBO().InserirAlterar(u, origem, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="origem">O(A) origem.</param>
		[HttpDelete]
		[Route("origem/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Origem origem = BOAccess.getBOFactory().OrigemBO().SelecionarPorId(id);
			BOAccess.getBOFactory().OrigemBO().Excluir(u, origem);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("origem/excluirlista")]
		public void Excluir(IList<SOM.OR.Origem> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().OrigemBO().Excluir(u, lst);
		}
	}
}
