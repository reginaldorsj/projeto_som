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
	/// Controller da classe <see cref='MunicipioController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class MunicipioController : ApiController
	{
		[HttpPost]
		[Route("municipio/listar/")]
		public IList<SOM.OR.Municipio> ListarPorNome(Uf uf)
		{
			return BOAccess.getBOFactory().MunicipioBO().ListarPorUf(uf);
		}
		[HttpPost]
		[Route("municipio/listar/{nomeMunicipio}")]
		public IList<SOM.OR.Municipio> ListarPorNome(Uf uf, string nomeMunicipio)
		{
			return BOAccess.getBOFactory().MunicipioBO().ListarPorNome(uf, nomeMunicipio);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("municipio/listarporuf")]
		public IList<SOM.OR.Municipio> ListarPorUf(Uf uf)
		{
			return BOAccess.getBOFactory().MunicipioBO().ListarPorUf(uf);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("municipio/selecionarporid/{id}")]
		public SOM.OR.Municipio SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().MunicipioBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("municipio/listar/{propertyOrder}")]
		public IList<SOM.OR.Municipio> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().MunicipioBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="municipio">O(A) municipio.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("municipio/inserir")]
		public SOM.OR.Municipio Inserir(SOM.OR.Municipio municipio)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().MunicipioBO().InserirAlterar(u, municipio, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="municipio">O(A) municipio.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("municipio/alterar")]
		public SOM.OR.Municipio Alterar(SOM.OR.Municipio municipio)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().MunicipioBO().InserirAlterar(u, municipio, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="municipio">O(A) municipio.</param>
		[HttpDelete]
		[Route("municipio/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Municipio municipio = BOAccess.getBOFactory().MunicipioBO().SelecionarPorId(id);
			BOAccess.getBOFactory().MunicipioBO().Excluir(u, municipio);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("municipio/excluirlista")]
		public void Excluir(IList<SOM.OR.Municipio> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().MunicipioBO().Excluir(u, lst);
		}
	}
}
