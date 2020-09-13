

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IOrigemDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IOrigemDAO : Regisoft.Camadas.Generic.IBaseDAO<Origem, long>
	{
		IList<Origem> ListarAtivos();

		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="descricao"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Origem> ListarPor(string descricao);
			
	}
}
