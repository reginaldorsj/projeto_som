

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='ICarnavalDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface ICarnavalDAO : Regisoft.Camadas.Generic.IBaseDAO<Carnaval, long>
	{
		IList<Carnaval> ListarAtivos();
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="ano"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Carnaval> ListarPor(string ano);
			
	}
}
