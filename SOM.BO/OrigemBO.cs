
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
	/// Regras de negócio para gerenciamento da classe <see cref='OrigemBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class OrigemBO : MarshalByRefObject, SOM.BO.IOrigemBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IOrigemDAO origemDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="OrigemBO"/>.
		/// </summary>
		public OrigemBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			origemDAO = daoAccess.OrigemDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="OrigemBO"/> is reclaimed by garbage collection.
		/// </summary>
		~OrigemBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			origemDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList<Origem> ListarAtivos()
		{
			return origemDAO.ListarAtivos();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Origem> lst)
		{
			return origemDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Origem SelecionarPor(string propertyName, object value)
		{
			return origemDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Origem SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return origemDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Origem SelecionarPor(string[] propertyName, object[] value)
		{
			return origemDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Origem SelecionarPorId(object id)
		{
			return origemDAO.SelecionarPor("IdOrigem",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Origem> Listar(string propertyOrder)
		{
			return origemDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="origem">O(A) origem.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Origem InserirAlterar(SOM.OR.Usuario u, SOM.OR.Origem origem, Regisoft.Operacao op)
		{
			origemDAO.ValidaNotNull(origem);
			origemDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					origem = origemDAO.CopiarParaPersistente(origem.IdOrigem.Value,origem);
				origem = origemDAO.InserirAlterar(origem,op);
				origemDAO.CommitTransaction();				
			}			
			catch
			{
				origemDAO.RollbackTransaction();
				throw;
			}				
			return origem;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="origem">O(A) origem.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Origem origem)
		{
			origemDAO.BeginTransaction();
			try 
			{
				origemDAO.Excluir(origem);
				origemDAO.CommitTransaction();				
			}			
			catch
			{
				origemDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Origem> lst)
		{
			origemDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Origem origem in lst)
				{
					origemDAO.Excluir(origem);
				}
				origemDAO.CommitTransaction();				
			}			
			catch
			{
				origemDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Origem> ListarPor(string dado)
		{
			return origemDAO.ListarPor(dado);
		}
	}
}
