
using System;

namespace SOM.DAO
{
	/// <summary>
	/// Classe que expõe os DAO's.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
    public interface IDAOFactory : IDisposable
    {
		/// <summary>
		/// Acesso a classe AtendimentoDAO.
		/// </summary>
		/// <returns></returns>
		IAtendimentoDAO AtendimentoDAO();
		/// <summary>
		/// Acesso a classe CarnavalDAO.
		/// </summary>
		/// <returns></returns>
		ICarnavalDAO CarnavalDAO();
		/// <summary>
		/// Acesso a classe CausaDAO.
		/// </summary>
		/// <returns></returns>
		ICausaDAO CausaDAO();
		/// <summary>
		/// Acesso a classe DiaDAO.
		/// </summary>
		/// <returns></returns>
		IDiaDAO DiaDAO();
		/// <summary>
		/// Acesso a classe DiagnosticoDAO.
		/// </summary>
		/// <returns></returns>
		IDiagnosticoDAO DiagnosticoDAO();
		/// <summary>
		/// Acesso a classe DoencaDAO.
		/// </summary>
		/// <returns></returns>
		IDoencaDAO DoencaDAO();
		/// <summary>
		/// Acesso a classe EscalaMedicoDAO.
		/// </summary>
		/// <returns></returns>
		IEscalaMedicoDAO EscalaMedicoDAO();
		/// <summary>
		/// Acesso a classe MedicoDAO.
		/// </summary>
		/// <returns></returns>
		IMedicoDAO MedicoDAO();
		/// <summary>
		/// Acesso a classe MunicipioDAO.
		/// </summary>
		/// <returns></returns>
		IMunicipioDAO MunicipioDAO();
		/// <summary>
		/// Acesso a classe OcupacaoDAO.
		/// </summary>
		/// <returns></returns>
		IOcupacaoDAO OcupacaoDAO();
		/// <summary>
		/// Acesso a classe OrigemDAO.
		/// </summary>
		/// <returns></returns>
		IOrigemDAO OrigemDAO();
		/// <summary>
		/// Acesso a classe PacienteDAO.
		/// </summary>
		/// <returns></returns>
		IPacienteDAO PacienteDAO();
		/// <summary>
		/// Acesso a classe PostoSaudeDAO.
		/// </summary>
		/// <returns></returns>
		IPostoSaudeDAO PostoSaudeDAO();
		/// <summary>
		/// Acesso a classe ProcedenciaDAO.
		/// </summary>
		/// <returns></returns>
		IProcedenciaDAO ProcedenciaDAO();
		/// <summary>
		/// Acesso a classe ProcedimentoDAO.
		/// </summary>
		/// <returns></returns>
		IProcedimentoDAO ProcedimentoDAO();
		/// <summary>
		/// Acesso a classe RacaDAO.
		/// </summary>
		/// <returns></returns>
		IRacaDAO RacaDAO();
		/// <summary>
		/// Acesso a classe SexoDAO.
		/// </summary>
		/// <returns></returns>
		ISexoDAO SexoDAO();
		/// <summary>
		/// Acesso a classe TipoObitoDAO.
		/// </summary>
		/// <returns></returns>
		ITipoObitoDAO TipoObitoDAO();
		/// <summary>
		/// Acesso a classe UfDAO.
		/// </summary>
		/// <returns></returns>
		IUfDAO UfDAO();
		/// <summary>
		/// Acesso a classe UnidadeDAO.
		/// </summary>
		/// <returns></returns>
		IUnidadeDAO UnidadeDAO();
		/// <summary>
		/// Acesso a classe UsuarioDAO.
		/// </summary>
		/// <returns></returns>
		IUsuarioDAO UsuarioDAO();

    }
}
