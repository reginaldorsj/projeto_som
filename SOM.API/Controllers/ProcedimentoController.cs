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
	/// Controller da classe <see cref='ProcedimentoController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class ProcedimentoController : ApiController
	{
		[HttpGet]
		[Route("procedimento/listar")]
		public IList<SOM.OR.Procedimento> ListarAtivos()
		{
			return BOAccess.getBOFactory().ProcedimentoBO().ListarAtivos();
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("procedimento/selecionarporid/{id}")]
		public SOM.OR.Procedimento SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().ProcedimentoBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("procedimento/listar/{propertyOrder}")]
		public IList<SOM.OR.Procedimento> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().ProcedimentoBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="procedimento">O(A) procedimento.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("procedimento/inserir")]
		public SOM.OR.Procedimento Inserir(SOM.OR.Procedimento procedimento)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().ProcedimentoBO().InserirAlterar(u, procedimento, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="procedimento">O(A) procedimento.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("procedimento/alterar")]
		public SOM.OR.Procedimento Alterar(SOM.OR.Procedimento procedimento)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().ProcedimentoBO().InserirAlterar(u, procedimento, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="procedimento">O(A) procedimento.</param>
		[HttpDelete]
		[Route("procedimento/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Procedimento procedimento = BOAccess.getBOFactory().ProcedimentoBO().SelecionarPorId(id);
			BOAccess.getBOFactory().ProcedimentoBO().Excluir(u, procedimento);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("procedimento/excluirlista")]
		public void Excluir(IList<SOM.OR.Procedimento> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().ProcedimentoBO().Excluir(u, lst);
		}
	}
}
