
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
	/// Regras de neg�cio para gerenciamento da classe <see cref='ProcedimentoBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class ProcedimentoBO : MarshalByRefObject, SOM.BO.IProcedimentoBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IProcedimentoDAO procedimentoDAO;
	
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="ProcedimentoBO"/>.
		/// </summary>
		public ProcedimentoBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			procedimentoDAO = daoAccess.ProcedimentoDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="ProcedimentoBO"/> is reclaimed by garbage collection.
		/// </summary>
		~ProcedimentoBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			procedimentoDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList<Procedimento> ListarAtivos()
		{
			return procedimentoDAO.ListarAtivos();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Procedimento> lst)
		{
			return procedimentoDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na sele��o.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Procedimento SelecionarPor(string propertyName, object value)
		{
			return procedimentoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na sele��o.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na sele��o.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Procedimento SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return procedimentoDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na sele��o.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Procedimento SelecionarPor(string[] propertyName, object[] value)
		{
			return procedimentoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Procedimento SelecionarPorId(object id)
		{
			return procedimentoDAO.SelecionarPor("IdProcedimento",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade espec�fica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a sele��o.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Procedimento> Listar(string propertyOrder)
		{
			return procedimentoDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="procedimento">O(A) procedimento.</param>
		/// <param name="op">A opera��o.</param>
		/// <returns>O objeto ap�s a persist�ncia.</returns>
		public SOM.OR.Procedimento InserirAlterar(SOM.OR.Usuario u, SOM.OR.Procedimento procedimento, Regisoft.Operacao op)
		{
			procedimentoDAO.ValidaNotNull(procedimento);
			procedimentoDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					procedimento = procedimentoDAO.CopiarParaPersistente(procedimento.IdProcedimento.Value,procedimento);
				procedimento = procedimentoDAO.InserirAlterar(procedimento,op);
				procedimentoDAO.CommitTransaction();				
			}			
			catch
			{
				procedimentoDAO.RollbackTransaction();
				throw;
			}				
			return procedimento;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="procedimento">O(A) procedimento.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Procedimento procedimento)
		{
			procedimentoDAO.BeginTransaction();
			try 
			{
				procedimentoDAO.Excluir(procedimento);
				procedimentoDAO.CommitTransaction();				
			}			
			catch
			{
				procedimentoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Procedimento> lst)
		{
			procedimentoDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Procedimento procedimento in lst)
				{
					procedimentoDAO.Excluir(procedimento);
				}
				procedimentoDAO.CommitTransaction();				
			}			
			catch
			{
				procedimentoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Procedimento> ListarPor(string dado)
		{
			return procedimentoDAO.ListarPor(dado);
		}
	}
}
