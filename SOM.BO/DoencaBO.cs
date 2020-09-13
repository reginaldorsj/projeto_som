
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
	/// Regras de negócio para gerenciamento da classe <see cref='DoencaBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class DoencaBO : MarshalByRefObject, SOM.BO.IDoencaBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IDoencaDAO doencaDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="DoencaBO"/>.
		/// </summary>
		public DoencaBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			doencaDAO = daoAccess.DoencaDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="DoencaBO"/> is reclaimed by garbage collection.
		/// </summary>
		~DoencaBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			doencaDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList<Doenca> ListarAtivos()
		{
			return doencaDAO.ListarAtivos();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Doenca> lst)
		{
			return doencaDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Doenca SelecionarPor(string propertyName, object value)
		{
			return doencaDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Doenca SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return doencaDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Doenca SelecionarPor(string[] propertyName, object[] value)
		{
			return doencaDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Doenca SelecionarPorId(object id)
		{
			return doencaDAO.SelecionarPor("IdDoenca",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Doenca> Listar(string propertyOrder)
		{
			return doencaDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="doenca">O(A) doenca.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Doenca InserirAlterar(SOM.OR.Usuario u, SOM.OR.Doenca doenca, Regisoft.Operacao op)
		{
			doencaDAO.ValidaNotNull(doenca);
			doencaDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					doenca = doencaDAO.CopiarParaPersistente(doenca.IdDoenca.Value,doenca);
				doenca = doencaDAO.InserirAlterar(doenca,op);
				doencaDAO.CommitTransaction();				
			}			
			catch
			{
				doencaDAO.RollbackTransaction();
				throw;
			}				
			return doenca;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="doenca">O(A) doenca.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Doenca doenca)
		{
			doencaDAO.BeginTransaction();
			try 
			{
				doencaDAO.Excluir(doenca);
				doencaDAO.CommitTransaction();				
			}			
			catch
			{
				doencaDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Doenca> lst)
		{
			doencaDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Doenca doenca in lst)
				{
					doencaDAO.Excluir(doenca);
				}
				doencaDAO.CommitTransaction();				
			}			
			catch
			{
				doencaDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Doenca> ListarPor(string dado)
		{
			return doencaDAO.ListarPor(dado);
		}
	}
}
