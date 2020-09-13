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
	/// Controller da classe <see cref='PacienteController'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Authorize]
	public class PacienteController : ApiController
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="municipio">O(A) municipio.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("paciente/listarpormunicipio")]
		public IList<SOM.OR.Paciente> ListarPorMunicipio(Municipio municipio)
		{
			return BOAccess.getBOFactory().PacienteBO().ListarPorMunicipio(municipio);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="raca">O(A) raca.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("paciente/listarporraca")]
		public IList<SOM.OR.Paciente> ListarPorRaca(Raca raca)
		{
			return BOAccess.getBOFactory().PacienteBO().ListarPorRaca(raca);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="sexo">O(A) sexo.</param>
		/// <returns>A lista.</returns>
		[HttpPost]
		[Route("paciente/listarporsexo")]
		public IList<SOM.OR.Paciente> ListarPorSexo(Sexo sexo)
		{
			return BOAccess.getBOFactory().PacienteBO().ListarPorSexo(sexo);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		[HttpGet]
		[Route("paciente/selecionarporid/{id}")]
		public SOM.OR.Paciente SelecionarPorId(long id)
		{
			return BOAccess.getBOFactory().PacienteBO().SelecionarPorId(id);
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		[HttpGet]
		[Route("paciente/listar/{propertyOrder}")]
		public IList<SOM.OR.Paciente> Listar(string propertyOrder)
		{
			return BOAccess.getBOFactory().PacienteBO().Listar(propertyOrder);
		}
		/// <summary>
		/// Inserir um objeto no banco de dados.
		/// </summary>
		/// <param name="paciente">O(A) paciente.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPost]
		[Route("paciente/inserir")]
		public SOM.OR.Paciente Inserir(SOM.OR.Paciente paciente)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().PacienteBO().InserirAlterar(u, paciente, Regisoft.Operacao.Incluir);
		}
		/// <summary>
		/// Altera um objeto no banco de dados.
		/// </summary>
		/// <param name="paciente">O(A) paciente.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		[HttpPut]
		[Route("paciente/alterar")]
		public SOM.OR.Paciente Alterar(SOM.OR.Paciente paciente)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			return BOAccess.getBOFactory().PacienteBO().InserirAlterar(u, paciente, Regisoft.Operacao.Alterar);
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="paciente">O(A) paciente.</param>
		[HttpDelete]
		[Route("paciente/excluir/{id}")]
		public void Excluir(long id)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			SOM.OR.Paciente paciente = BOAccess.getBOFactory().PacienteBO().SelecionarPorId(id);
			BOAccess.getBOFactory().PacienteBO().Excluir(u, paciente);
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		[HttpDelete]
		[Route("paciente/excluirlista")]
		public void Excluir(IList<SOM.OR.Paciente> lst)
		{
			SOM.OR.Usuario u = BOAccess.getBOFactory().UsuarioBO().SelecionarPorId(User.Identity.GetUserId());
			BOAccess.getBOFactory().PacienteBO().Excluir(u, lst);
		}
	}
}
