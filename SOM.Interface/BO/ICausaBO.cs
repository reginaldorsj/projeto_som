

using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using SOM.OR;

namespace SOM.BO
{
	/// <summary>
	/// Regras de negócio para gerenciamento da classe <see cref='ICausaBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface ICausaBO : IDisposable
	{
		IList<Causa> ListarAtivos();
		/// <summary>
		/// Selecionar objeto.
		/// </summary>
		/// <param name="id">O id.</param>
		/// <returns></returns>
		SOM.OR.Causa SelecionarPorId(object id);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="propertyOrder">A propriedade ordem.</param>
		/// <returns>A lista ordenada.</returns>
		System.Collections.Generic.IList<SOM.OR.Causa> Listar(string propertyOrder);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		SOM.OR.Causa SelecionarPor(string propertyName, object value);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		SOM.OR.Causa SelecionarPor(string propertyName1, object value1,string propertyName2, object value2);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		SOM.OR.Causa SelecionarPor(string[] propertyName, object[] value);
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		DataTable ToDataTable(IList<SOM.OR.Causa> lst);
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="causa">O(A) causa.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		SOM.OR.Causa InserirAlterar(SOM.OR.Usuario u, SOM.OR.Causa causa, Regisoft.Operacao op);
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="causa">O(A) causa.</param>
		void Excluir(SOM.OR.Usuario u, SOM.OR.Causa causa);
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Causa> lst);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Causa> ListarPor(string dado);
					
	}
}
