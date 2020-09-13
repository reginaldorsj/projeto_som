

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IProcedimentoDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IProcedimentoDAO : Regisoft.Camadas.Generic.IBaseDAO<Procedimento, long>
	{
		IList<Procedimento> ListarAtivos();
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="descricao"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Procedimento> ListarPor(string descricao);
			
	}
}
