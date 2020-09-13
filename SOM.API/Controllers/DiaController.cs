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
	/// Controller da classe <see cref='DiaController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	[EnableCors(origins: " * ", headers: " * ", methods: " * ")] // tune to your needs
	public class DiaController : ApiController
	{

		[HttpGet]
		[Route("dia/listar")]
		public IList<SOM.OR.Dia> ListarAtivos()
		{
			return BOAccess.getBOFactory().DiaBO().ListarAtivos();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="carnaval">O(A) carnaval.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("dia/listarporcarnaval")]
		public IList<SOM.OR.Dia> ListarPorCarnaval(Carnaval carnaval)
		{
			return BOAccess.getBOFactory().DiaBO().ListarPorCarnaval(carnaval);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("dia/selecionarporid/{id}")]
		public SOM.OR.Dia SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().DiaBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("dia/listar/{propertyOrder}")]
		public IList<SOM.OR.Dia> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().DiaBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="dia">O(A) dia.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("dia/inserir")]
		public SOM.OR.Dia Inserir(SOM.OR.Dia dia)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().DiaBO().InserirAlterar(u, dia, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="dia">O(A) dia.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("dia/alterar")]
		public SOM.OR.Dia Alterar(SOM.OR.Dia dia)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().DiaBO().InserirAlterar(u, dia, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="dia">O(A) dia.</param>
		[HttpDelete]
		[Route("dia/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Dia dia = BOAccess.getBOFactory().DiaBO().SelecionarPorId(id);
			BOAccess.getBOFactory().DiaBO().Excluir(u, dia);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("dia/excluirlista")]
		public void Excluir(IList<SOM.OR.Dia> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().DiaBO().Excluir(u, lst);
		}
	}
}
