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
	/// Controller da classe <see cref='RacaController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class RacaController : ApiController
	{
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("raca/selecionarporid/{id}")]
		public SOM.OR.Raca SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().RacaBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("raca/listar/{propertyOrder}")]
		public IList<SOM.OR.Raca> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().RacaBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="raca">O(A) raca.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("raca/inserir")]
		public SOM.OR.Raca Inserir(SOM.OR.Raca raca)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().RacaBO().InserirAlterar(u, raca, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="raca">O(A) raca.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("raca/alterar")]
		public SOM.OR.Raca Alterar(SOM.OR.Raca raca)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().RacaBO().InserirAlterar(u, raca, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="raca">O(A) raca.</param>
		[HttpDelete]
		[Route("raca/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Raca raca = BOAccess.getBOFactory().RacaBO().SelecionarPorId(id);
			BOAccess.getBOFactory().RacaBO().Excluir(u, raca);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("raca/excluirlista")]
		public void Excluir(IList<SOM.OR.Raca> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().RacaBO().Excluir(u, lst);
		}
	}
}
