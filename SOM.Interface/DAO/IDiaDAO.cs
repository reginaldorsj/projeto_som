

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IDiaDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IDiaDAO : Regisoft.Camadas.Generic.IBaseDAO<Dia, long>
	{
		IList<Dia> ListarPorAno(int ano);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="carnaval">O(A) carnaval.</param>
		/// <returns>A lista.</returns>
		IList<Dia> ListarPorCarnaval(Carnaval carnaval);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idcarnaval"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Dia> ListarPor(string idcarnaval);
			
	}
}
