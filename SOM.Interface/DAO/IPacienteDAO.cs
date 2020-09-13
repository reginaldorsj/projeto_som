

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using SOM.OR;

namespace SOM.DAO
{
	/// <summary>
	/// Classe <see cref='IPacienteDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IPacienteDAO : Regisoft.Camadas.Generic.IBaseDAO<Paciente, long>
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="municipio">O(A) municipio.</param>
		/// <returns>A lista.</returns>
		IList<Paciente> ListarPorMunicipio(Municipio municipio);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="raca">O(A) raca.</param>
		/// <returns>A lista.</returns>
		IList<Paciente> ListarPorRaca(Raca raca);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="sexo">O(A) sexo.</param>
		/// <returns>A lista.</returns>
		IList<Paciente> ListarPorSexo(Sexo sexo);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="nome"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Paciente> ListarPor(string nome);
			
	}
}
