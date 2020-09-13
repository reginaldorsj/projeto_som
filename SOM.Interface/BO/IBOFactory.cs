
using System;

namespace SOM.BO
{
	/// <summary>
	/// Classe que expõe os BO's.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
    public interface IBOFactory
    {
		/// <summary>
		/// Acesso a classe AtendimentoBO.
		/// </summary>
		/// <returns></returns>
		IAtendimentoBO AtendimentoBO();
		/// <summary>
		/// Acesso a classe CarnavalBO.
		/// </summary>
		/// <returns></returns>
		ICarnavalBO CarnavalBO();
		/// <summary>
		/// Acesso a classe CausaBO.
		/// </summary>
		/// <returns></returns>
		ICausaBO CausaBO();
		/// <summary>
		/// Acesso a classe DiaBO.
		/// </summary>
		/// <returns></returns>
		IDiaBO DiaBO();
		/// <summary>
		/// Acesso a classe DiagnosticoBO.
		/// </summary>
		/// <returns></returns>
		IDiagnosticoBO DiagnosticoBO();
		/// <summary>
		/// Acesso a classe DoencaBO.
		/// </summary>
		/// <returns></returns>
		IDoencaBO DoencaBO();
		/// <summary>
		/// Acesso a classe EscalaMedicoBO.
		/// </summary>
		/// <returns></returns>
		IEscalaMedicoBO EscalaMedicoBO();
		/// <summary>
		/// Acesso a classe MedicoBO.
		/// </summary>
		/// <returns></returns>
		IMedicoBO MedicoBO();
		/// <summary>
		/// Acesso a classe MunicipioBO.
		/// </summary>
		/// <returns></returns>
		IMunicipioBO MunicipioBO();
		/// <summary>
		/// Acesso a classe OcupacaoBO.
		/// </summary>
		/// <returns></returns>
		IOcupacaoBO OcupacaoBO();
		/// <summary>
		/// Acesso a classe OrigemBO.
		/// </summary>
		/// <returns></returns>
		IOrigemBO OrigemBO();
		/// <summary>
		/// Acesso a classe PacienteBO.
		/// </summary>
		/// <returns></returns>
		IPacienteBO PacienteBO();
		/// <summary>
		/// Acesso a classe PostoSaudeBO.
		/// </summary>
		/// <returns></returns>
		IPostoSaudeBO PostoSaudeBO();
		/// <summary>
		/// Acesso a classe ProcedenciaBO.
		/// </summary>
		/// <returns></returns>
		IProcedenciaBO ProcedenciaBO();
		/// <summary>
		/// Acesso a classe ProcedimentoBO.
		/// </summary>
		/// <returns></returns>
		IProcedimentoBO ProcedimentoBO();
		/// <summary>
		/// Acesso a classe RacaBO.
		/// </summary>
		/// <returns></returns>
		IRacaBO RacaBO();
		/// <summary>
		/// Acesso a classe SexoBO.
		/// </summary>
		/// <returns></returns>
		ISexoBO SexoBO();
		/// <summary>
		/// Acesso a classe TipoObitoBO.
		/// </summary>
		/// <returns></returns>
		ITipoObitoBO TipoObitoBO();
		/// <summary>
		/// Acesso a classe UfBO.
		/// </summary>
		/// <returns></returns>
		IUfBO UfBO();
		/// <summary>
		/// Acesso a classe UnidadeBO.
		/// </summary>
		/// <returns></returns>
		IUnidadeBO UnidadeBO();
		/// <summary>
		/// Acesso a classe UsuarioBO.
		/// </summary>
		/// <returns></returns>
		IUsuarioBO UsuarioBO();

    }
}
