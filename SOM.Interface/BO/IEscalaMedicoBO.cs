

using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using SOM.OR;

namespace SOM.BO
{
	/// <summary>
	/// Regras de neg�cio para gerenciamento da classe <see cref='IEscalaMedicoBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IEscalaMedicoBO : IDisposable
	{
		IList TotalPorSiglaUnidade();
		IList TotalPorUnidadeAgora(Ocupacao o);
		IList ListarPlantao(Unidade unidade);
		IList TotalPorUnidade(Ocupacao o);
		IList TotalPorEspecialidadeAgora();
		IList TotalPorUnidade();
		IList TotalPorEspecialidade();
		long TotalPlantoes();
		IList<EscalaMedico> ListarPor(Unidade unidade, Medico medico);
		/// <summary>
		/// Selecionar objeto.
		/// </summary>
		/// <param name="id">O id.</param>
		/// <returns></returns>
		SOM.OR.EscalaMedico SelecionarPorId(object id);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="propertyOrder">A propriedade ordem.</param>
		/// <returns>A lista ordenada.</returns>
		System.Collections.Generic.IList<SOM.OR.EscalaMedico> Listar(string propertyOrder);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na sele��o.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		SOM.OR.EscalaMedico SelecionarPor(string propertyName, object value);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na sele��o.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na sele��o.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		SOM.OR.EscalaMedico SelecionarPor(string propertyName1, object value1,string propertyName2, object value2);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na sele��o.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		SOM.OR.EscalaMedico SelecionarPor(string[] propertyName, object[] value);
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		DataTable ToDataTable(IList<SOM.OR.EscalaMedico> lst);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		IList<SOM.OR.EscalaMedico> ListarPorUnidade(SOM.OR.Unidade unidade);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		/// <returns>A lista.</returns>
		IList<SOM.OR.EscalaMedico> ListarPorOcupacao(SOM.OR.Ocupacao ocupacao);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <returns>A lista.</returns>
		IList<SOM.OR.EscalaMedico> ListarPorMedico(SOM.OR.Medico medico);
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="escalamedico">O(A) escalamedico.</param>
		/// <param name="op">A opera��o.</param>
		/// <returns>O objeto ap�s a persist�ncia.</returns>
		SOM.OR.EscalaMedico InserirAlterar(SOM.OR.Usuario u, SOM.OR.EscalaMedico escalamedico, Regisoft.Operacao op);
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="escalamedico">O(A) escalamedico.</param>
		void Excluir(SOM.OR.Usuario u, SOM.OR.EscalaMedico escalamedico);
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="lst">A lista.</param>
		void Excluir(SOM.OR.Usuario u, IList<SOM.OR.EscalaMedico> lst);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<EscalaMedico> ListarPor(string dado);
					
	}
}
