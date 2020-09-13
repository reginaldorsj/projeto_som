

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='ITipoObitoDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface ITipoObitoDAO : Regisoft.Camadas.Generic.IBaseDAO<TipoObito, long>
	{
		IList<TipoObito> ListarAtivos();
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="descricao"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<TipoObito> ListarPor(string descricao);
			
	}
}
