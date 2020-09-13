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
	/// Controller da classe <see cref='DoencaController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class DoencaController : ApiController
	{
		[HttpGet]
		[Route("doenca/listar")]
		public IList<SOM.OR.Doenca> ListarAtivos()
		{
			return BOAccess.getBOFactory().DoencaBO().ListarAtivos();
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("doenca/selecionarporid/{id}")]
		public SOM.OR.Doenca SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().DoencaBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("doenca/listar/{propertyOrder}")]
		public IList<SOM.OR.Doenca> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().DoencaBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="doenca">O(A) doenca.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("doenca/inserir")]
		public SOM.OR.Doenca Inserir(SOM.OR.Doenca doenca)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().DoencaBO().InserirAlterar(u, doenca, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="doenca">O(A) doenca.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("doenca/alterar")]
		public SOM.OR.Doenca Alterar(SOM.OR.Doenca doenca)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().DoencaBO().InserirAlterar(u, doenca, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="doenca">O(A) doenca.</param>
		[HttpDelete]
		[Route("doenca/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Doenca doenca = BOAccess.getBOFactory().DoencaBO().SelecionarPorId(id);
			BOAccess.getBOFactory().DoencaBO().Excluir(u, doenca);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("doenca/excluirlista")]
		public void Excluir(IList<SOM.OR.Doenca> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().DoencaBO().Excluir(u, lst);
		}
	}
}
