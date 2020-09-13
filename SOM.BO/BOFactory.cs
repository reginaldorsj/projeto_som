
using System;
using Microsoft.Practices.Unity;

namespace SOM.BO
{
	/// <summary>
	/// Classe que expõe os BO's.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
    public class BOFactory : MarshalByRefObject, SOM.BO.IBOFactory
    {
		/// <summary>
		/// Container para injeção de dependência.
		/// </summary>
        private UnityContainer unityContainer;
		/// <summary>
		/// Instância da classe para acesso estático.
		/// </summary>
        private static BOFactory instance = null;

		/// <summary>
		/// Inicializa uma instância de <see cref="BOFactory"/>.
		/// </summary>
		public BOFactory()
		{
			Inicialize();
		}

		/// <summary>
		/// Lê/Cria uma instância da classe.
		/// </summary>
		/// <returns></returns>
        public static BOFactory getInstance()
        {
            if (instance == null)
            {
                instance = new BOFactory();
            }
            return instance;
        }
		/// <summary>
		/// Inicializa esta instância.
		/// </summary>
		private void Inicialize() 
		{
			unityContainer = new UnityContainer();
			unityContainer.RegisterType<IAtendimentoBO, AtendimentoBO>();
			unityContainer.RegisterType<ICarnavalBO, CarnavalBO>();
			unityContainer.RegisterType<ICausaBO, CausaBO>();
			unityContainer.RegisterType<IDiaBO, DiaBO>();
			unityContainer.RegisterType<IDiagnosticoBO, DiagnosticoBO>();
			unityContainer.RegisterType<IDoencaBO, DoencaBO>();
			unityContainer.RegisterType<IEscalaMedicoBO, EscalaMedicoBO>();
			unityContainer.RegisterType<IMedicoBO, MedicoBO>();
			unityContainer.RegisterType<IMunicipioBO, MunicipioBO>();
			unityContainer.RegisterType<IOcupacaoBO, OcupacaoBO>();
			unityContainer.RegisterType<IOrigemBO, OrigemBO>();
			unityContainer.RegisterType<IPacienteBO, PacienteBO>();
			unityContainer.RegisterType<IPostoSaudeBO, PostoSaudeBO>();
			unityContainer.RegisterType<IProcedenciaBO, ProcedenciaBO>();
			unityContainer.RegisterType<IProcedimentoBO, ProcedimentoBO>();
			unityContainer.RegisterType<IRacaBO, RacaBO>();
			unityContainer.RegisterType<ISexoBO, SexoBO>();
			unityContainer.RegisterType<ITipoObitoBO, TipoObitoBO>();
			unityContainer.RegisterType<IUfBO, UfBO>();
			unityContainer.RegisterType<IUnidadeBO, UnidadeBO>();
			unityContainer.RegisterType<IUsuarioBO, UsuarioBO>();
		}

		#region IDAOFactory Members
		/// <summary>
		/// Acesso a classe AtendimentoBO.
		/// </summary>
		/// <returns></returns>
        public IAtendimentoBO AtendimentoBO()
        {
			return unityContainer.Resolve<AtendimentoBO>();
        }
		/// <summary>
		/// Acesso a classe CarnavalBO.
		/// </summary>
		/// <returns></returns>
        public ICarnavalBO CarnavalBO()
        {
			return unityContainer.Resolve<CarnavalBO>();
        }
		/// <summary>
		/// Acesso a classe CausaBO.
		/// </summary>
		/// <returns></returns>
        public ICausaBO CausaBO()
        {
			return unityContainer.Resolve<CausaBO>();
        }
		/// <summary>
		/// Acesso a classe DiaBO.
		/// </summary>
		/// <returns></returns>
        public IDiaBO DiaBO()
        {
			return unityContainer.Resolve<DiaBO>();
        }
		/// <summary>
		/// Acesso a classe DiagnosticoBO.
		/// </summary>
		/// <returns></returns>
        public IDiagnosticoBO DiagnosticoBO()
        {
			return unityContainer.Resolve<DiagnosticoBO>();
        }
		/// <summary>
		/// Acesso a classe DoencaBO.
		/// </summary>
		/// <returns></returns>
        public IDoencaBO DoencaBO()
        {
			return unityContainer.Resolve<DoencaBO>();
        }
		/// <summary>
		/// Acesso a classe EscalaMedicoBO.
		/// </summary>
		/// <returns></returns>
        public IEscalaMedicoBO EscalaMedicoBO()
        {
			return unityContainer.Resolve<EscalaMedicoBO>();
        }
		/// <summary>
		/// Acesso a classe MedicoBO.
		/// </summary>
		/// <returns></returns>
        public IMedicoBO MedicoBO()
        {
			return unityContainer.Resolve<MedicoBO>();
        }
		/// <summary>
		/// Acesso a classe MunicipioBO.
		/// </summary>
		/// <returns></returns>
        public IMunicipioBO MunicipioBO()
        {
			return unityContainer.Resolve<MunicipioBO>();
        }
		/// <summary>
		/// Acesso a classe OcupacaoBO.
		/// </summary>
		/// <returns></returns>
        public IOcupacaoBO OcupacaoBO()
        {
			return unityContainer.Resolve<OcupacaoBO>();
        }
		/// <summary>
		/// Acesso a classe OrigemBO.
		/// </summary>
		/// <returns></returns>
        public IOrigemBO OrigemBO()
        {
			return unityContainer.Resolve<OrigemBO>();
        }
		/// <summary>
		/// Acesso a classe PacienteBO.
		/// </summary>
		/// <returns></returns>
        public IPacienteBO PacienteBO()
        {
			return unityContainer.Resolve<PacienteBO>();
        }
		/// <summary>
		/// Acesso a classe PostoSaudeBO.
		/// </summary>
		/// <returns></returns>
        public IPostoSaudeBO PostoSaudeBO()
        {
			return unityContainer.Resolve<PostoSaudeBO>();
        }
		/// <summary>
		/// Acesso a classe ProcedenciaBO.
		/// </summary>
		/// <returns></returns>
        public IProcedenciaBO ProcedenciaBO()
        {
			return unityContainer.Resolve<ProcedenciaBO>();
        }
		/// <summary>
		/// Acesso a classe ProcedimentoBO.
		/// </summary>
		/// <returns></returns>
        public IProcedimentoBO ProcedimentoBO()
        {
			return unityContainer.Resolve<ProcedimentoBO>();
        }
		/// <summary>
		/// Acesso a classe RacaBO.
		/// </summary>
		/// <returns></returns>
        public IRacaBO RacaBO()
        {
			return unityContainer.Resolve<RacaBO>();
        }
		/// <summary>
		/// Acesso a classe SexoBO.
		/// </summary>
		/// <returns></returns>
        public ISexoBO SexoBO()
        {
			return unityContainer.Resolve<SexoBO>();
        }
		/// <summary>
		/// Acesso a classe TipoObitoBO.
		/// </summary>
		/// <returns></returns>
        public ITipoObitoBO TipoObitoBO()
        {
			return unityContainer.Resolve<TipoObitoBO>();
        }
		/// <summary>
		/// Acesso a classe UfBO.
		/// </summary>
		/// <returns></returns>
        public IUfBO UfBO()
        {
			return unityContainer.Resolve<UfBO>();
        }
		/// <summary>
		/// Acesso a classe UnidadeBO.
		/// </summary>
		/// <returns></returns>
        public IUnidadeBO UnidadeBO()
        {
			return unityContainer.Resolve<UnidadeBO>();
        }
		/// <summary>
		/// Acesso a classe UsuarioBO.
		/// </summary>
		/// <returns></returns>
        public IUsuarioBO UsuarioBO()
        {
			return unityContainer.Resolve<UsuarioBO>();
        }

        #endregion
		
    }
}
