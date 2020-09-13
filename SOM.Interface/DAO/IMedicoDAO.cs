

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IMedicoDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IMedicoDAO : Regisoft.Camadas.Generic.IBaseDAO<Medico, long>
	{
		IList<Medico> ListarPorNome(string nome);
		Medico SelecionarPor(string cremeb, Uf uf);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <returns>A lista.</returns>
		IList<Medico> ListarPorUf(Uf uf);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="cremeb"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Medico> ListarPor(string cremeb);
			
	}
}
