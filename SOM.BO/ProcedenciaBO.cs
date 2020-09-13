
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
	/// Regras de negócio para gerenciamento da classe <see cref='ProcedenciaBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class ProcedenciaBO : MarshalByRefObject, SOM.BO.IProcedenciaBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IProcedenciaDAO procedenciaDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ProcedenciaBO"/>.
		/// </summary>
		public ProcedenciaBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			procedenciaDAO = daoAccess.ProcedenciaDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="ProcedenciaBO"/> is reclaimed by garbage collection.
		/// </summary>
		~ProcedenciaBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			procedenciaDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList<Procedencia> ListarAtivos()
		{
			return procedenciaDAO.ListarAtivos();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Procedencia> lst)
		{
			return procedenciaDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Procedencia SelecionarPor(string propertyName, object value)
		{
			return procedenciaDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Procedencia SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return procedenciaDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Procedencia SelecionarPor(string[] propertyName, object[] value)
		{
			return procedenciaDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Procedencia SelecionarPorId(object id)
		{
			return procedenciaDAO.SelecionarPor("IdProcedencia",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Procedencia> Listar(string propertyOrder)
		{
			return procedenciaDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="procedencia">O(A) procedencia.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Procedencia InserirAlterar(SOM.OR.Usuario u, SOM.OR.Procedencia procedencia, Regisoft.Operacao op)
		{
			procedenciaDAO.ValidaNotNull(procedencia);
			procedenciaDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					procedencia = procedenciaDAO.CopiarParaPersistente(procedencia.IdProcedencia.Value,procedencia);
				procedencia = procedenciaDAO.InserirAlterar(procedencia,op);
				procedenciaDAO.CommitTransaction();				
			}			
			catch
			{
				procedenciaDAO.RollbackTransaction();
				throw;
			}				
			return procedencia;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="procedencia">O(A) procedencia.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Procedencia procedencia)
		{
			procedenciaDAO.BeginTransaction();
			try 
			{
				procedenciaDAO.Excluir(procedencia);
				procedenciaDAO.CommitTransaction();				
			}			
			catch
			{
				procedenciaDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Procedencia> lst)
		{
			procedenciaDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Procedencia procedencia in lst)
				{
					procedenciaDAO.Excluir(procedencia);
				}
				procedenciaDAO.CommitTransaction();				
			}			
			catch
			{
				procedenciaDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Procedencia> ListarPor(string dado)
		{
			return procedenciaDAO.ListarPor(dado);
		}
	}
}
