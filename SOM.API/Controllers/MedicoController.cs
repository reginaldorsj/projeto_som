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
	/// Controller da classe <see cref='MedicoController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class MedicoController : ApiController
	{
		[HttpGet]
		[Route("medico/{cremeb}/{siglaUf}")]
		public SOM.OR.Medico SelecionarPor(string cremeb, string siglaUf)
		{
			Uf uf = BOAccess.getBOFactory().UfBO().SelecionarPor("Sigla", siglaUf.ToUpper());
			return BOAccess.getBOFactory().MedicoBO().SelecionarPor(cremeb, uf);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("medico/listarporuf")]
		public IList<SOM.OR.Medico> ListarPorUf(Uf uf)
		{
			return BOAccess.getBOFactory().MedicoBO().ListarPorUf(uf);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("medico/selecionarporid/{id}")]
		public SOM.OR.Medico SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().MedicoBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("medico/listar/{propertyOrder}")]
		public IList<SOM.OR.Medico> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().MedicoBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("medico/inserir")]
		public SOM.OR.Medico Inserir(SOM.OR.Medico medico)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().MedicoBO().InserirAlterar(u, medico, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("medico/alterar")]
		public SOM.OR.Medico Alterar(SOM.OR.Medico medico)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().MedicoBO().InserirAlterar(u, medico, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		[HttpDelete]
		[Route("medico/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Medico medico = BOAccess.getBOFactory().MedicoBO().SelecionarPorId(id);
			BOAccess.getBOFactory().MedicoBO().Excluir(u, medico);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("medico/excluirlista")]
		public void Excluir(IList<SOM.OR.Medico> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().MedicoBO().Excluir(u, lst);
		}
		[HttpGet]
		[Route("medico/listarpornome")]
		public IList<Medico> ListarPorNome(string nome)
		{
			return BOAccess.getBOFactory().MedicoBO().ListarPorNome(nome);
		}
	}
}
