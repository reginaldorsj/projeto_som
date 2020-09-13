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
	/// Controller da classe <see cref='SexoController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class SexoController : ApiController
	{
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("sexo/selecionarporid/{id}")]
		public SOM.OR.Sexo SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().SexoBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade espec�fica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a sele��o.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("sexo/listar/{propertyOrder}")]
		public IList<SOM.OR.Sexo> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().SexoBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="sexo">O(A) sexo.</param>
		/// <param name="op">A opera��o.</param>
		/// <returns>O objeto ap�s a persist�ncia.</returns>
		[HttpPost]
		[Route("sexo/inserir")]
		public SOM.OR.Sexo Inserir(SOM.OR.Sexo sexo)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().SexoBO().InserirAlterar(u, sexo, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="sexo">O(A) sexo.</param>
		/// <param name="op">A opera��o.</param>
		/// <returns>O objeto ap�s a persist�ncia.</returns>
		[HttpPut]
		[Route("sexo/alterar")]
		public SOM.OR.Sexo Alterar(SOM.OR.Sexo sexo)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().SexoBO().InserirAlterar(u, sexo, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="sexo">O(A) sexo.</param>
		[HttpDelete]
		[Route("sexo/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Sexo sexo = BOAccess.getBOFactory().SexoBO().SelecionarPorId(id);
			BOAccess.getBOFactory().SexoBO().Excluir(u, sexo);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("sexo/excluirlista")]
		public void Excluir(IList<SOM.OR.Sexo> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().SexoBO().Excluir(u, lst);
		}
	}
}
