

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IPostoSaudeDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IPostoSaudeDAO : Regisoft.Camadas.Generic.IBaseDAO<PostoSaude, long>
	{
		IList<PostoSaude> ListarAtivos();
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="nome"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<PostoSaude> ListarPor(string nome);
			
	}
}
