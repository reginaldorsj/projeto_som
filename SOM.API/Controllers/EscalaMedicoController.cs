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
	/// Controller da classe <see cref='EscalaMedicoController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class EscalaMedicoController : ApiController
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("escalamedico/listarporunidade")]
		public IList<SOM.OR.EscalaMedico> ListarPorUnidade(Unidade unidade)
		{
			return BOAccess.getBOFactory().EscalaMedicoBO().ListarPorUnidade(unidade);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("escalamedico/listarporocupacao")]
		public IList<SOM.OR.EscalaMedico> ListarPorOcupacao(Ocupacao ocupacao)
		{
			return BOAccess.getBOFactory().EscalaMedicoBO().ListarPorOcupacao(ocupacao);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("escalamedico/listarpormedico")]
		public IList<SOM.OR.EscalaMedico> ListarPorMedico(Medico medico)
		{
			return BOAccess.getBOFactory().EscalaMedicoBO().ListarPorMedico(medico);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("escalamedico/selecionarporid/{id}")]
		public SOM.OR.EscalaMedico SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().EscalaMedicoBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		//[HttpGet]
		//[Route("escalamedico/listar/{propertyOrder}")]
		public IList<SOM.OR.EscalaMedico> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().EscalaMedicoBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="escalamedico">O(A) escalamedico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("escalamedico/inserir")]
		public SOM.OR.EscalaMedico Inserir(SOM.OR.EscalaMedico escalamedico)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().EscalaMedicoBO().InserirAlterar(u, escalamedico, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="escalamedico">O(A) escalamedico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("escalamedico/alterar")]
		public SOM.OR.EscalaMedico Alterar(SOM.OR.EscalaMedico escalamedico)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().EscalaMedicoBO().InserirAlterar(u, escalamedico, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="escalamedico">O(A) escalamedico.</param>
		[HttpDelete]
		[Route("escalamedico/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.EscalaMedico escalamedico = BOAccess.getBOFactory().EscalaMedicoBO().SelecionarPorId(id);
			BOAccess.getBOFactory().EscalaMedicoBO().Excluir(u, escalamedico);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("escalamedico/excluirlista")]
		public void Excluir(IList<SOM.OR.EscalaMedico> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().EscalaMedicoBO().Excluir(u, lst);
		}
		[HttpGet]
		[Route("escalamedico/listar/{idmedico}")]
		public IList<EscalaMedico> ListarPor(long idmedico)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			Medico m = BOAccess.getBOFactory().MedicoBO().SelecionarPorId(idmedico);
			return BOAccess.getBOFactory().EscalaMedicoBO().ListarPor(u.IdUnidade, m);

		}
	}
}
