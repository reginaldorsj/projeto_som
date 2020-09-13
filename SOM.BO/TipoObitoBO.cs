
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
	/// Regras de negócio para gerenciamento da classe <see cref='TipoObitoBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class TipoObitoBO : MarshalByRefObject, SOM.BO.ITipoObitoBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected ITipoObitoDAO tipoobitoDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="TipoObitoBO"/>.
		/// </summary>
		public TipoObitoBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			tipoobitoDAO = daoAccess.TipoObitoDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="TipoObitoBO"/> is reclaimed by garbage collection.
		/// </summary>
		~TipoObitoBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			tipoobitoDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList<TipoObito> ListarAtivos()
		{
			return tipoobitoDAO.ListarAtivos();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.TipoObito> lst)
		{
			return tipoobitoDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.TipoObito SelecionarPor(string propertyName, object value)
		{
			return tipoobitoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.TipoObito SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return tipoobitoDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.TipoObito SelecionarPor(string[] propertyName, object[] value)
		{
			return tipoobitoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.TipoObito SelecionarPorId(object id)
		{
			return tipoobitoDAO.SelecionarPor("IdTipoObito",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.TipoObito> Listar(string propertyOrder)
		{
			return tipoobitoDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="tipoobito">O(A) tipoobito.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.TipoObito InserirAlterar(SOM.OR.Usuario u, SOM.OR.TipoObito tipoobito, Regisoft.Operacao op)
		{
			tipoobitoDAO.ValidaNotNull(tipoobito);
			tipoobitoDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					tipoobito = tipoobitoDAO.CopiarParaPersistente(tipoobito.IdTipoObito.Value,tipoobito);
				tipoobito = tipoobitoDAO.InserirAlterar(tipoobito,op);
				tipoobitoDAO.CommitTransaction();				
			}			
			catch
			{
				tipoobitoDAO.RollbackTransaction();
				throw;
			}				
			return tipoobito;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="tipoobito">O(A) tipoobito.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.TipoObito tipoobito)
		{
			tipoobitoDAO.BeginTransaction();
			try 
			{
				tipoobitoDAO.Excluir(tipoobito);
				tipoobitoDAO.CommitTransaction();				
			}			
			catch
			{
				tipoobitoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.TipoObito> lst)
		{
			tipoobitoDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.TipoObito tipoobito in lst)
				{
					tipoobitoDAO.Excluir(tipoobito);
				}
				tipoobitoDAO.CommitTransaction();				
			}			
			catch
			{
				tipoobitoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<TipoObito> ListarPor(string dado)
		{
			return tipoobitoDAO.ListarPor(dado);
		}
	}
}
