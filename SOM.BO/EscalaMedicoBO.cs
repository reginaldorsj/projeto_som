
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Regisoft;
using SOM.OR;
using SOM.DAO;

namespace SOM.BO
{
	/// <summary>
	/// Regras de negócio para gerenciamento da classe <see cref='EscalaMedicoBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class EscalaMedicoBO : MarshalByRefObject, SOM.BO.IEscalaMedicoBO
	{
		protected Carnaval carnaval;
		protected ICarnavalBO carnavalBO;
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IEscalaMedicoDAO escalamedicoDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="EscalaMedicoBO"/>.
		/// </summary>
		public EscalaMedicoBO(IUsuarioBO usuarioBO, ICarnavalBO carnavalBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			escalamedicoDAO = daoAccess.EscalaMedicoDAO();
			this.usuarioBO = usuarioBO;
			this.carnavalBO = carnavalBO;

			carnaval = carnavalBO.GetAtivo();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="EscalaMedicoBO"/> is reclaimed by garbage collection.
		/// </summary>
		~EscalaMedicoBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			escalamedicoDAO.Dispose();
			usuarioBO.Dispose();
			carnavalBO.Dispose();
		}
		public IList TotalPorSiglaUnidade()
        {
			return escalamedicoDAO.TotalPorSiglaUnidade(carnaval.Ano);

        }
		public IList TotalPorUnidadeAgora(Ocupacao o)
        {
			return escalamedicoDAO.TotalPorUnidadeAgora(o, carnaval.Ano);
        }
		public IList ListarPlantao(Unidade unidade)
        {
			return escalamedicoDAO.ListarPlantao(unidade, carnaval.Ano);
        }
		public IList TotalPorUnidade(Ocupacao o)
        {
			return escalamedicoDAO.TotalPorUnidade(o, carnaval.Ano);
        }
		public IList TotalPorEspecialidadeAgora()
        {
			return escalamedicoDAO.TotalPorEspecialidadeAgora(carnaval.Ano);
        }
		public IList TotalPorEspecialidade()
		{
			return escalamedicoDAO.TotalPorEspecialidade(carnaval.Ano);
		}
		public IList TotalPorUnidade()
        {
			return escalamedicoDAO.TotalPorUnidade(carnaval.Ano);
        }
		public long TotalPlantoes()
		{
			return escalamedicoDAO.TotalPlantoes(carnaval.Ano);

		}
		public IList<EscalaMedico> ListarPor(Unidade unidade, Medico medico)
		{
			if (unidade == null)
				throw new ExceptionRS("Você não tem permissão para realizar esta operação.");

			return escalamedicoDAO.ListarPor(unidade, medico, carnaval.Ano);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.EscalaMedico> ListarPorUnidade(Unidade unidade)
		{
			return escalamedicoDAO.ListarPorUnidade(unidade);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.EscalaMedico> ListarPorOcupacao(Ocupacao ocupacao)
		{
			return escalamedicoDAO.ListarPorOcupacao(ocupacao);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="medico">O(A) medico.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.EscalaMedico> ListarPorMedico(Medico medico)
		{
			return escalamedicoDAO.ListarPorMedico(medico);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.EscalaMedico> lst)
		{
			return escalamedicoDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.EscalaMedico SelecionarPor(string propertyName, object value)
		{
			return escalamedicoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.EscalaMedico SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return escalamedicoDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.EscalaMedico SelecionarPor(string[] propertyName, object[] value)
		{
			return escalamedicoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.EscalaMedico SelecionarPorId(object id)
		{
			return escalamedicoDAO.SelecionarPor("IdEscalaMedico",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.EscalaMedico> Listar(string propertyOrder)
		{
			return escalamedicoDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="escalamedico">O(A) escalamedico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.EscalaMedico InserirAlterar(SOM.OR.Usuario u, SOM.OR.EscalaMedico escalamedico, Regisoft.Operacao op)
		{
			if (u.IdUnidade == null)
				throw new ExceptionRS("Você não tem permissão para realizar esta operação");

			if (carnaval.DataHoraEncerramento <= DateTime.Now)
				throw new ExceptionRS("Operação não permitida devido ao encerramento do carnaval.");

			escalamedico.IdUnidade = u.IdUnidade;
			escalamedicoDAO.ValidaNotNull(escalamedico);
			if (escalamedico.DataHoraInicio.Year != carnaval.Ano || escalamedico.DataHoraFim.Year != carnaval.Ano)
				throw new ExceptionRS("Essa escala não pertence ao Carnaval/Ano ativo.");

			if (escalamedico.DataHoraFim < escalamedico.DataHoraInicio)
				throw new ExceptionRS("Período inválido.");

			escalamedicoDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					escalamedico = escalamedicoDAO.CopiarParaPersistente(escalamedico.IdEscalaMedico.Value,escalamedico);
				escalamedico = escalamedicoDAO.InserirAlterar(escalamedico,op);
				escalamedicoDAO.CommitTransaction();				
			}			
			catch
			{
				escalamedicoDAO.RollbackTransaction();
				throw;
			}				
			return escalamedico;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="escalamedico">O(A) escalamedico.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.EscalaMedico escalamedico)
		{
			if (u.IdUnidade == null)
				throw new ExceptionRS("Você não tem permissão para realizar esta operação");

			if (carnaval.DataHoraEncerramento <= DateTime.Now)
				throw new ExceptionRS("Operação não permitida devido ao encerramento do carnaval.");

			if (escalamedico.DataHoraInicio.Year != carnaval.Ano || escalamedico.DataHoraFim.Year != carnaval.Ano)
				throw new ExceptionRS("Essa escala não pertence ao Carnaval/Ano ativo.");

			escalamedicoDAO.BeginTransaction();
			try 
			{
				escalamedicoDAO.Excluir(escalamedico);
				escalamedicoDAO.CommitTransaction();				
			}			
			catch
			{
				escalamedicoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.EscalaMedico> lst)
		{
			if (u.IdUnidade == null)
				throw new ExceptionRS("Você não tem permissão para realizar esta operação");

			if (carnaval.DataHoraEncerramento <= DateTime.Now)
				throw new ExceptionRS("Operação não permitida devido ao encerramento do carnaval.");

			escalamedicoDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.EscalaMedico escalamedico in lst)
				{
					if (escalamedico.DataHoraInicio.Year != carnaval.Ano || escalamedico.DataHoraFim.Year != carnaval.Ano)
						throw new ExceptionRS("Na lista possui escala(s) que  não pertence(m) ao Carnaval/Ano ativo.");
					escalamedicoDAO.Excluir(escalamedico);
				}
				escalamedicoDAO.CommitTransaction();				
			}			
			catch
			{
				escalamedicoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<EscalaMedico> ListarPor(string dado)
		{
			return escalamedicoDAO.ListarPor(dado);
		}
	}
}
