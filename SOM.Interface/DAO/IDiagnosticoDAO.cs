

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IDiagnosticoDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IDiagnosticoDAO : Regisoft.Camadas.Generic.IBaseDAO<Diagnostico, long>
	{
		IList ResumoDoencaPorProcedimento(Procedimento procedimento, int ano);
		IList ResumoDoencaPorUnidade(Unidade unidade, int ano);
		IList<Doenca> ListarDoencasPorAtendimento(Atendimento atendimento);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="atendimento">O(A) atendimento.</param>
		/// <returns>A lista.</returns>
		IList<Diagnostico> ListarPorAtendimento(Atendimento atendimento);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="doenca">O(A) doenca.</param>
		/// <returns>A lista.</returns>
		IList<Diagnostico> ListarPorDoenca(Doenca doenca);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idatendimento"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Diagnostico> ListarPor(string idatendimento);
			
	}
}
