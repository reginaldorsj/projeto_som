
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
	/// Regras de negócio para gerenciamento da classe <see cref='DiagnosticoBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class DiagnosticoBO : MarshalByRefObject, SOM.BO.IDiagnosticoBO
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
		protected IDiagnosticoDAO diagnosticoDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="DiagnosticoBO"/>.
		/// </summary>
		public DiagnosticoBO(IUsuarioBO usuarioBO, ICarnavalBO carnavalBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			diagnosticoDAO = daoAccess.DiagnosticoDAO();
			this.usuarioBO = usuarioBO;
			this.carnavalBO = carnavalBO;

			this.carnaval = carnavalBO.GetAtivo();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="DiagnosticoBO"/> is reclaimed by garbage collection.
		/// </summary>
		~DiagnosticoBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			diagnosticoDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList ResumoDoencaPorProcedimento(Procedimento procedimento)
        {
			return diagnosticoDAO.ResumoDoencaPorProcedimento(procedimento, carnaval.Ano);
        }
		public IList ResumoDoencaPorUnidade(Unidade unidade)
        {
			return diagnosticoDAO.ResumoDoencaPorUnidade(unidade, carnaval.Ano);

        }
		public IList<Doenca> ListarDoencasPorAtendimento(Atendimento atendimento)
		{
			return diagnosticoDAO.ListarDoencasPorAtendimento(atendimento);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="atendimento">O(A) atendimento.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Diagnostico> ListarPorAtendimento(Atendimento atendimento)
		{
			return diagnosticoDAO.ListarPorAtendimento(atendimento);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="doenca">O(A) doenca.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Diagnostico> ListarPorDoenca(Doenca doenca)
		{
			return diagnosticoDAO.ListarPorDoenca(doenca);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Diagnostico> lst)
		{
			return diagnosticoDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Diagnostico SelecionarPor(string propertyName, object value)
		{
			return diagnosticoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Diagnostico SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return diagnosticoDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Diagnostico SelecionarPor(string[] propertyName, object[] value)
		{
			return diagnosticoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Diagnostico SelecionarPorId(object id)
		{
			return diagnosticoDAO.SelecionarPor("IdDiagnostico",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Diagnostico> Listar(string propertyOrder)
		{
			return diagnosticoDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="diagnostico">O(A) diagnostico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Diagnostico InserirAlterar(SOM.OR.Usuario u, SOM.OR.Diagnostico diagnostico, Regisoft.Operacao op)
		{
			diagnosticoDAO.ValidaNotNull(diagnostico);
			Diagnostico _ix_diagnostico = diagnosticoDAO.SelecionarPor(new string[]{ "IdAtendimento" , "IdDoenca" }, new object[]{ diagnostico.IdAtendimento , diagnostico.IdDoenca });
			 if ((op == Operacao.Incluir && _ix_diagnostico != null) ||(op == Operacao.Alterar && _ix_diagnostico != null && _ix_diagnostico.IdDiagnostico != diagnostico.IdDiagnostico))
				throw new ExceptionRS("Violação do índice: IX_DIAGNOSTICO");

			diagnosticoDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					diagnostico = diagnosticoDAO.CopiarParaPersistente(diagnostico.IdDiagnostico.Value,diagnostico);
				diagnostico = diagnosticoDAO.InserirAlterar(diagnostico,op);
				diagnosticoDAO.CommitTransaction();				
			}			
			catch
			{
				diagnosticoDAO.RollbackTransaction();
				throw;
			}				
			return diagnostico;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="diagnostico">O(A) diagnostico.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Diagnostico diagnostico)
		{
			diagnosticoDAO.BeginTransaction();
			try 
			{
				diagnosticoDAO.Excluir(diagnostico);
				diagnosticoDAO.CommitTransaction();				
			}			
			catch
			{
				diagnosticoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Diagnostico> lst)
		{
			diagnosticoDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Diagnostico diagnostico in lst)
				{
					diagnosticoDAO.Excluir(diagnostico);
				}
				diagnosticoDAO.CommitTransaction();				
			}			
			catch
			{
				diagnosticoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Diagnostico> ListarPor(string dado)
		{
			return diagnosticoDAO.ListarPor(dado);
		}
	}
}
