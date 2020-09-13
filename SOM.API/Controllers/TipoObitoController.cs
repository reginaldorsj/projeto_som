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
	/// Controller da classe <see cref='TipoObitoController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class TipoObitoController : ApiController
	{
		[HttpGet]
		[Route("tipoobito/listar")]
		public IList<SOM.OR.TipoObito> ListarAtivos()
		{
			return BOAccess.getBOFactory().TipoObitoBO().ListarAtivos();
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("tipoobito/selecionarporid/{id}")]
		public SOM.OR.TipoObito SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().TipoObitoBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("tipoobito/listar/{propertyOrder}")]
		public IList<SOM.OR.TipoObito> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().TipoObitoBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="tipoobito">O(A) tipoobito.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("tipoobito/inserir")]
		public SOM.OR.TipoObito Inserir(SOM.OR.TipoObito tipoobito)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().TipoObitoBO().InserirAlterar(u, tipoobito, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="tipoobito">O(A) tipoobito.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("tipoobito/alterar")]
		public SOM.OR.TipoObito Alterar(SOM.OR.TipoObito tipoobito)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().TipoObitoBO().InserirAlterar(u, tipoobito, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="tipoobito">O(A) tipoobito.</param>
		[HttpDelete]
		[Route("tipoobito/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.TipoObito tipoobito = BOAccess.getBOFactory().TipoObitoBO().SelecionarPorId(id);
			BOAccess.getBOFactory().TipoObitoBO().Excluir(u, tipoobito);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("tipoobito/excluirlista")]
		public void Excluir(IList<SOM.OR.TipoObito> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().TipoObitoBO().Excluir(u, lst);
		}
	}
}
