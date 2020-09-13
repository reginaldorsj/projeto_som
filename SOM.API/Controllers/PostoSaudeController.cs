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
	/// Controller da classe <see cref='PostoSaudeController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class PostoSaudeController : ApiController
	{
		[HttpGet]
		[Route("postosaude/listar/")]
		public IList<SOM.OR.PostoSaude> Listar()
		{
			return BOAccess.getBOFactory().PostoSaudeBO().ListarAtivos();
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("postosaude/selecionarporid/{id}")]
		public SOM.OR.PostoSaude SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().PostoSaudeBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("postosaude/listar/{propertyOrder}")]
		public IList<SOM.OR.PostoSaude> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().PostoSaudeBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="postosaude">O(A) postosaude.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("postosaude/inserir")]
		public SOM.OR.PostoSaude Inserir(SOM.OR.PostoSaude postosaude)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().PostoSaudeBO().InserirAlterar(u, postosaude, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="postosaude">O(A) postosaude.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("postosaude/alterar")]
		public SOM.OR.PostoSaude Alterar(SOM.OR.PostoSaude postosaude)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().PostoSaudeBO().InserirAlterar(u, postosaude, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="postosaude">O(A) postosaude.</param>
		[HttpDelete]
		[Route("postosaude/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.PostoSaude postosaude = BOAccess.getBOFactory().PostoSaudeBO().SelecionarPorId(id);
			BOAccess.getBOFactory().PostoSaudeBO().Excluir(u, postosaude);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("postosaude/excluirlista")]
		public void Excluir(IList<SOM.OR.PostoSaude> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().PostoSaudeBO().Excluir(u, lst);
		}
	}
}
