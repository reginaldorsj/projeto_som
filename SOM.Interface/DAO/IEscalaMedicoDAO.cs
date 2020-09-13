

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IEscalaMedicoDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IEscalaMedicoDAO : Regisoft.Camadas.Generic.IBaseDAO<EscalaMedico, long>
	{
		IList TotalPorSiglaUnidade(int ano);
		IList TotalPorUnidadeAgora(Ocupacao o, int ano);
		IList ListarPlantao(Unidade unidade, int ano);
		IList TotalPorUnidade(Ocupacao o, int ano);
		IList TotalPorEspecialidadeAgora(int ano);
		IList TotalPorUnidade(int ano);
		IList TotalPorEspecialidade(int ano);
		long TotalPlantoes(int ano);
		IList<EscalaMedico> ListarPor(Unidade unidade, Medico medico, int ano);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		IList<EscalaMedico> ListarPorUnidade(Unidade unidade);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		/// <returns>A lista.</returns>
		IList<EscalaMedico> ListarPorOcupacao(Ocupacao ocupacao);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <returns>A lista.</returns>
		IList<EscalaMedico> ListarPorMedico(Medico medico);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idunidade"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<EscalaMedico> ListarPor(string idunidade);
			
	}
}
