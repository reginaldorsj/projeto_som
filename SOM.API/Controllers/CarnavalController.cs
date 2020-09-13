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
	/// Controller da classe <see cref='CarnavalController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class CarnavalController : ApiController
	{
		[HttpGet]
		[Route("carnaval/ativo")]
		public SOM.OR.Carnaval GetAtivo()
		{
			return BOAccess.getBOFactory().CarnavalBO().GetAtivo();
		}

		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("carnaval/selecionarporid/{id}")]
		public SOM.OR.Carnaval SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().CarnavalBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("carnaval/listar/{propertyOrder}")]
		public IList<SOM.OR.Carnaval> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().CarnavalBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="carnaval">O(A) carnaval.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("carnaval/inserir")]
		public SOM.OR.Carnaval Inserir(SOM.OR.Carnaval carnaval)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().CarnavalBO().InserirAlterar(u, carnaval, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="carnaval">O(A) carnaval.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("carnaval/alterar")]
		public SOM.OR.Carnaval Alterar(SOM.OR.Carnaval carnaval)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().CarnavalBO().InserirAlterar(u, carnaval, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="carnaval">O(A) carnaval.</param>
		[HttpDelete]
		[Route("carnaval/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Carnaval carnaval = BOAccess.getBOFactory().CarnavalBO().SelecionarPorId(id);
			BOAccess.getBOFactory().CarnavalBO().Excluir(u, carnaval);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("carnaval/excluirlista")]
		public void Excluir(IList<SOM.OR.Carnaval> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().CarnavalBO().Excluir(u, lst);
		}
	}
}
