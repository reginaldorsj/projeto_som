
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
	/// Regras de neg�cio para gerenciamento da classe <see cref='PostoSaudeBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class PostoSaudeBO : MarshalByRefObject, SOM.BO.IPostoSaudeBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IPostoSaudeDAO postosaudeDAO;
	
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="PostoSaudeBO"/>.
		/// </summary>
		public PostoSaudeBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			postosaudeDAO = daoAccess.PostoSaudeDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="PostoSaudeBO"/> is reclaimed by garbage collection.
		/// </summary>
		~PostoSaudeBO()
		{
			Dispose();
		}
		public IList<PostoSaude> ListarAtivos()
		{
			return postosaudeDAO.ListarAtivos();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			postosaudeDAO.Dispose();
			usuarioBO.Dispose();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.PostoSaude> lst)
		{
			return postosaudeDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na sele��o.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.PostoSaude SelecionarPor(string propertyName, object value)
		{
			return postosaudeDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na sele��o.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na sele��o.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.PostoSaude SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return postosaudeDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na sele��o.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.PostoSaude SelecionarPor(string[] propertyName, object[] value)
		{
			return postosaudeDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.PostoSaude SelecionarPorId(object id)
		{
			return postosaudeDAO.SelecionarPor("IdPostoSaude",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade espec�fica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a sele��o.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.PostoSaude> Listar(string propertyOrder)
		{
			return postosaudeDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="postosaude">O(A) postosaude.</param>
		/// <param name="op">A opera��o.</param>
		/// <returns>O objeto ap�s a persist�ncia.</returns>
		public SOM.OR.PostoSaude InserirAlterar(SOM.OR.Usuario u, SOM.OR.PostoSaude postosaude, Regisoft.Operacao op)
		{
			postosaudeDAO.ValidaNotNull(postosaude);
			postosaudeDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					postosaude = postosaudeDAO.CopiarParaPersistente(postosaude.IdPostoSaude.Value,postosaude);
				postosaude = postosaudeDAO.InserirAlterar(postosaude,op);
				postosaudeDAO.CommitTransaction();				
			}			
			catch
			{
				postosaudeDAO.RollbackTransaction();
				throw;
			}				
			return postosaude;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="postosaude">O(A) postosaude.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.PostoSaude postosaude)
		{
			postosaudeDAO.BeginTransaction();
			try 
			{
				postosaudeDAO.Excluir(postosaude);
				postosaudeDAO.CommitTransaction();				
			}			
			catch
			{
				postosaudeDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usu�rio.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.PostoSaude> lst)
		{
			postosaudeDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.PostoSaude postosaude in lst)
				{
					postosaudeDAO.Excluir(postosaude);
				}
				postosaudeDAO.CommitTransaction();				
			}			
			catch
			{
				postosaudeDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<PostoSaude> ListarPor(string dado)
		{
			return postosaudeDAO.ListarPor(dado);
		}
	}
}
