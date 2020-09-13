
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
	/// Regras de neg�cio para gerenciamento da classe <see cref='CausaBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class CausaBO : MarshalByRefObject, SOM.BO.ICausaBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected ICausaDAO causaDAO;
	
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="CausaBO"/>.
		/// </summary>
		public CausaBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			causaDAO = daoAccess.CausaDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="CausaBO"/> is reclaimed by garbage collection.
		/// </summary>
		~CausaBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			causaDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList<Causa> ListarAtivos()
		{
			return causaDAO.ListarAtivos();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Causa> lst)
		{
			return causaDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na sele��o.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Causa SelecionarPor(string propertyName, object value)
		{
			return causaDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na sele��o.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na sele��o.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Causa SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return causaDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na sele��o.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Causa SelecionarPor(string[] propertyName, object[] value)
		{
			return causaDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Causa SelecionarPorId(object id)
		{
			return causaDAO.SelecionarPor("IdCausa",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade espec�fica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a sele��o.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Causa> Listar(string propertyOrder)
		{
			return causaDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="causa">O(A) causa.</param>
		/// <param name="op">A opera��o.</param>
		/// <returns>O objeto ap�s a persist�ncia.</returns>
		public SOM.OR.Causa InserirAlterar(SOM.OR.Usuario u, SOM.OR.Causa causa, Regisoft.Operacao op)
		{
			causaDAO.ValidaNotNull(causa);
			causaDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					causa = causaDAO.CopiarParaPersistente(causa.IdCausa.Value,causa);
				causa = causaDAO.InserirAlterar(causa,op);
				causaDAO.CommitTransaction();				
			}			
			catch
			{
				causaDAO.RollbackTransaction();
				throw;
			}				
			return causa;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="causa">O(A) causa.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Causa causa)
		{
			causaDAO.BeginTransaction();
			try 
			{
				causaDAO.Excluir(causa);
				causaDAO.CommitTransaction();				
			}			
			catch
			{
				causaDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Causa> lst)
		{
			causaDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Causa causa in lst)
				{
					causaDAO.Excluir(causa);
				}
				causaDAO.CommitTransaction();				
			}			
			catch
			{
				causaDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Causa> ListarPor(string dado)
		{
			return causaDAO.ListarPor(dado);
		}
	}
}
