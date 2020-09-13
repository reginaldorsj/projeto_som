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
	/// Controller da classe <see cref='UsuarioController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class UsuarioController : ApiController
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("usuario/listarporunidade")]
		public IList<SOM.OR.Usuario> ListarPorUnidade(Unidade unidade)
		{
			return BOAccess.getBOFactory().UsuarioBO().ListarPorUnidade(unidade);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("usuario/selecionarporid/{id}")]
		public SOM.OR.Usuario SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("usuario/listar/{propertyOrder}")]
		public IList<SOM.OR.Usuario> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().UsuarioBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="usuario">O(A) usuario.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("usuario/inserir")]
		public SOM.OR.Usuario Inserir(SOM.OR.Usuario usuario)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().UsuarioBO().InserirAlterar(u, usuario, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="usuario">O(A) usuario.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("usuario/alterar")]
		public SOM.OR.Usuario Alterar(SOM.OR.Usuario usuario)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().UsuarioBO().InserirAlterar(u, usuario, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="usuario">O(A) usuario.</param>
		[HttpDelete]
		[Route("usuario/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Usuario usuario = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(id);
			BOAccess.getBOFactory().UsuarioBO().Excluir(u, usuario);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("usuario/excluirlista")]
		public void Excluir(IList<SOM.OR.Usuario> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().UsuarioBO().Excluir(u, lst);
		}
	}
}
