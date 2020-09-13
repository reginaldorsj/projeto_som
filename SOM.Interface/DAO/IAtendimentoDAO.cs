

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IAtendimentoDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IAtendimentoDAO : Regisoft.Camadas.Generic.IBaseDAO<Atendimento, long>
	{
		IList<Atendimento> ListarObitos(int ano);
		IList ResumoPorDemandaExpontanea(int ano);
		IList ResumoPorPostoSaude(int ano);
		IList ResumoOrigemPorCausa(Causa causa, int ano);
		IList ResumoCausaPorOrigem(Origem origem, int ano);
		IList ResumoPorProcedencia(int ano);
		IList ResumoPorProcedimento(int ano);
		long TotalOcorrencias(int ano);
		IList ResumoPorSiglaUnidade(int ano);
		IList ResumoPorCausa(int ano);
		IList ResumoPorOrigem(int ano);
		IList ResumoPorUnidade(int ano);
		IList<Atendimento> ListarPorNome(Unidade unidade, string nome, int ano);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dia">O(A) dia.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorDia(Dia dia);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorUnidade(Unidade unidade);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="procedencia">O(A) procedencia.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorProcedencia(Procedencia procedencia);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="postosaude">O(A) postosaude.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorPostoSaude(PostoSaude postosaude);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="origem">O(A) origem.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorOrigem(Origem origem);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="paciente">O(A) paciente.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorPaciente(Paciente paciente);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorMedico(Medico medico);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="causa">O(A) causa.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorCausa(Causa causa);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="procedimento">O(A) procedimento.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorProcedimento(Procedimento procedimento);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="tipoobito">O(A) tipoobito.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPorTipoObito(TipoObito tipoobito);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="iddia"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Atendimento> ListarPor(string iddia);
			
	}
}
