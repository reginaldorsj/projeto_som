

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IOcupacaoDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IOcupacaoDAO : Regisoft.Camadas.Generic.IBaseDAO<Ocupacao, long>
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="codigo"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Ocupacao> ListarPor(string codigo);
			
	}
}
