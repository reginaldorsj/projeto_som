
using System;
using Microsoft.Practices.Unity;

namespace SOM.DAO
{
	/// <summary>
	/// Classe que expõe os DAO's.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
    public class DAOFactory : MarshalByRefObject, SOM.DAO.IDAOFactory
    {
		/// <summary>
		/// Container para injeção de dependência.
		/// </summary>
        private UnityContainer unityContainer;
		/// <summary>
		/// Inicializa uma instância de <see cref="DAOFactory"/>.
		/// </summary>
        public DAOFactory() 
        {			
			Inicialize();
		}
		/// <summary>
		/// Inicializa esta instância.
		/// </summary>
		private void Inicialize() 
		{
			unityContainer = new UnityContainer();
			unityContainer.RegisterType<IAtendimentoDAO, AtendimentoDAO>();
			unityContainer.RegisterType<ICarnavalDAO, CarnavalDAO>();
			unityContainer.RegisterType<ICausaDAO, CausaDAO>();
			unityContainer.RegisterType<IDiaDAO, DiaDAO>();
			unityContainer.RegisterType<IDiagnosticoDAO, DiagnosticoDAO>();
			unityContainer.RegisterType<IDoencaDAO, DoencaDAO>();
			unityContainer.RegisterType<IEscalaMedicoDAO, EscalaMedicoDAO>();
			unityContainer.RegisterType<IMedicoDAO, MedicoDAO>();
			unityContainer.RegisterType<IMunicipioDAO, MunicipioDAO>();
			unityContainer.RegisterType<IOcupacaoDAO, OcupacaoDAO>();
			unityContainer.RegisterType<IOrigemDAO, OrigemDAO>();
			unityContainer.RegisterType<IPacienteDAO, PacienteDAO>();
			unityContainer.RegisterType<IPostoSaudeDAO, PostoSaudeDAO>();
			unityContainer.RegisterType<IProcedenciaDAO, ProcedenciaDAO>();
			unityContainer.RegisterType<IProcedimentoDAO, ProcedimentoDAO>();
			unityContainer.RegisterType<IRacaDAO, RacaDAO>();
			unityContainer.RegisterType<ISexoDAO, SexoDAO>();
			unityContainer.RegisterType<ITipoObitoDAO, TipoObitoDAO>();
			unityContainer.RegisterType<IUfDAO, UfDAO>();
			unityContainer.RegisterType<IUnidadeDAO, UnidadeDAO>();
			unityContainer.RegisterType<IUsuarioDAO, UsuarioDAO>();
		}
		#region IDAOFactory Members
		/// <summary>
		/// Acesso a classe AtendimentoDAO.
		/// </summary>
		/// <returns></returns>
        public IAtendimentoDAO AtendimentoDAO()
        {
			return unityContainer.Resolve<AtendimentoDAO>();
        }
		/// <summary>
		/// Acesso a classe CarnavalDAO.
		/// </summary>
		/// <returns></returns>
        public ICarnavalDAO CarnavalDAO()
        {
			return unityContainer.Resolve<CarnavalDAO>();
        }
		/// <summary>
		/// Acesso a classe CausaDAO.
		/// </summary>
		/// <returns></returns>
        public ICausaDAO CausaDAO()
        {
			return unityContainer.Resolve<CausaDAO>();
        }
		/// <summary>
		/// Acesso a classe DiaDAO.
		/// </summary>
		/// <returns></returns>
        public IDiaDAO DiaDAO()
        {
			return unityContainer.Resolve<DiaDAO>();
        }
		/// <summary>
		/// Acesso a classe DiagnosticoDAO.
		/// </summary>
		/// <returns></returns>
        public IDiagnosticoDAO DiagnosticoDAO()
        {
			return unityContainer.Resolve<DiagnosticoDAO>();
        }
		/// <summary>
		/// Acesso a classe DoencaDAO.
		/// </summary>
		/// <returns></returns>
        public IDoencaDAO DoencaDAO()
        {
			return unityContainer.Resolve<DoencaDAO>();
        }
		/// <summary>
		/// Acesso a classe EscalaMedicoDAO.
		/// </summary>
		/// <returns></returns>
        public IEscalaMedicoDAO EscalaMedicoDAO()
        {
			return unityContainer.Resolve<EscalaMedicoDAO>();
        }
		/// <summary>
		/// Acesso a classe MedicoDAO.
		/// </summary>
		/// <returns></returns>
        public IMedicoDAO MedicoDAO()
        {
			return unityContainer.Resolve<MedicoDAO>();
        }
		/// <summary>
		/// Acesso a classe MunicipioDAO.
		/// </summary>
		/// <returns></returns>
        public IMunicipioDAO MunicipioDAO()
        {
			return unityContainer.Resolve<MunicipioDAO>();
        }
		/// <summary>
		/// Acesso a classe OcupacaoDAO.
		/// </summary>
		/// <returns></returns>
        public IOcupacaoDAO OcupacaoDAO()
        {
			return unityContainer.Resolve<OcupacaoDAO>();
        }
		/// <summary>
		/// Acesso a classe OrigemDAO.
		/// </summary>
		/// <returns></returns>
        public IOrigemDAO OrigemDAO()
        {
			return unityContainer.Resolve<OrigemDAO>();
        }
		/// <summary>
		/// Acesso a classe PacienteDAO.
		/// </summary>
		/// <returns></returns>
        public IPacienteDAO PacienteDAO()
        {
			return unityContainer.Resolve<PacienteDAO>();
        }
		/// <summary>
		/// Acesso a classe PostoSaudeDAO.
		/// </summary>
		/// <returns></returns>
        public IPostoSaudeDAO PostoSaudeDAO()
        {
			return unityContainer.Resolve<PostoSaudeDAO>();
        }
		/// <summary>
		/// Acesso a classe ProcedenciaDAO.
		/// </summary>
		/// <returns></returns>
        public IProcedenciaDAO ProcedenciaDAO()
        {
			return unityContainer.Resolve<ProcedenciaDAO>();
        }
		/// <summary>
		/// Acesso a classe ProcedimentoDAO.
		/// </summary>
		/// <returns></returns>
        public IProcedimentoDAO ProcedimentoDAO()
        {
			return unityContainer.Resolve<ProcedimentoDAO>();
        }
		/// <summary>
		/// Acesso a classe RacaDAO.
		/// </summary>
		/// <returns></returns>
        public IRacaDAO RacaDAO()
        {
			return unityContainer.Resolve<RacaDAO>();
        }
		/// <summary>
		/// Acesso a classe SexoDAO.
		/// </summary>
		/// <returns></returns>
        public ISexoDAO SexoDAO()
        {
			return unityContainer.Resolve<SexoDAO>();
        }
		/// <summary>
		/// Acesso a classe TipoObitoDAO.
		/// </summary>
		/// <returns></returns>
        public ITipoObitoDAO TipoObitoDAO()
        {
			return unityContainer.Resolve<TipoObitoDAO>();
        }
		/// <summary>
		/// Acesso a classe UfDAO.
		/// </summary>
		/// <returns></returns>
        public IUfDAO UfDAO()
        {
			return unityContainer.Resolve<UfDAO>();
        }
		/// <summary>
		/// Acesso a classe UnidadeDAO.
		/// </summary>
		/// <returns></returns>
        public IUnidadeDAO UnidadeDAO()
        {
			return unityContainer.Resolve<UnidadeDAO>();
        }
		/// <summary>
		/// Acesso a classe UsuarioDAO.
		/// </summary>
		/// <returns></returns>
        public IUsuarioDAO UsuarioDAO()
        {
			return unityContainer.Resolve<UsuarioDAO>();
        }
		public void Dispose()
		{
			// Nada
		}

        #endregion
		
    }
}
