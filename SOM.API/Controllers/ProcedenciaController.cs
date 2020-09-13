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
	/// Controller da classe <see cref='ProcedenciaController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class ProcedenciaController : ApiController
	{
		[HttpGet]
		[Route("procedencia/listar/")]
		public IList<SOM.OR.Procedencia> Listar()
		{
			return BOAccess.getBOFactory().ProcedenciaBO().ListarAtivos();
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("procedencia/selecionarporid/{id}")]
		public SOM.OR.Procedencia SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().ProcedenciaBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("procedencia/listar/{propertyOrder}")]
		public IList<SOM.OR.Procedencia> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().ProcedenciaBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="procedencia">O(A) procedencia.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("procedencia/inserir")]
		public SOM.OR.Procedencia Inserir(SOM.OR.Procedencia procedencia)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().ProcedenciaBO().InserirAlterar(u, procedencia, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="procedencia">O(A) procedencia.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("procedencia/alterar")]
		public SOM.OR.Procedencia Alterar(SOM.OR.Procedencia procedencia)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().ProcedenciaBO().InserirAlterar(u, procedencia, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="procedencia">O(A) procedencia.</param>
		[HttpDelete]
		[Route("procedencia/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Procedencia procedencia = BOAccess.getBOFactory().ProcedenciaBO().SelecionarPorId(id);
			BOAccess.getBOFactory().ProcedenciaBO().Excluir(u, procedencia);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("procedencia/excluirlista")]
		public void Excluir(IList<SOM.OR.Procedencia> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().ProcedenciaBO().Excluir(u, lst);
		}
	}
}
