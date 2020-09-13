

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IMunicipioDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IMunicipioDAO : Regisoft.Camadas.Generic.IBaseDAO<Municipio, long>
	{
		IList<Municipio> ListarPorNome(Uf uf, string nomeMunicipio);
		Municipio SelecionarPorNome(Uf uf, string nomeMunicipio);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <returns>A lista.</returns>
		IList<Municipio> ListarPorUf(Uf uf);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="iduf"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Municipio> ListarPor(string iduf);
			
	}
}
