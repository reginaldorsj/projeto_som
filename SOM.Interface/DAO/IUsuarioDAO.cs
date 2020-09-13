

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IUsuarioDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IUsuarioDAO : Regisoft.Camadas.Generic.IBaseDAO<Usuario, long>
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		IList<Usuario> ListarPorUnidade(Unidade unidade);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idunidade"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Usuario> ListarPor(string idunidade);
			
	}
}
