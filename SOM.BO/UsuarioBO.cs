
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
	/// Regras de negócio para gerenciamento da classe <see cref='UsuarioBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class UsuarioBO : MarshalByRefObject, SOM.BO.IUsuarioBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IUsuarioDAO usuarioDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="UsuarioBO"/>.
		/// </summary>
		public UsuarioBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			usuarioDAO = daoAccess.UsuarioDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="UsuarioBO"/> is reclaimed by garbage collection.
		/// </summary>
		~UsuarioBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			usuarioDAO.Dispose();
		}
		public Usuario SelecionarPor(string login, string senha)
		{
			Usuario u = usuarioDAO.SelecionarPor("Login", login);
			if (u != null && u.Senha == senha && ((u.IdUnidade != null && u.IdUnidade.Ativo) || u.IdUnidade == null))
				return u;
			return null;
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="unidade">O(A) unidade.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Usuario> ListarPorUnidade(Unidade unidade)
		{
			return usuarioDAO.ListarPorUnidade(unidade);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Usuario> lst)
		{
			return usuarioDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Usuario SelecionarPor(string propertyName, object value)
		{
			return usuarioDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Usuario SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return usuarioDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Usuario SelecionarPor(string[] propertyName, object[] value)
		{
			return usuarioDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Usuario SelecionarPorId(object id)
		{
			return usuarioDAO.SelecionarPor("IdUsuario",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Usuario> Listar(string propertyOrder)
		{
			return usuarioDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="usuario">O(A) usuario.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Usuario InserirAlterar(SOM.OR.Usuario u, SOM.OR.Usuario usuario, Regisoft.Operacao op)
		{
			usuarioDAO.ValidaNotNull(usuario);
			Usuario _ix_usuario = usuarioDAO.SelecionarPor(new string[]{ "Login" }, new object[]{ usuario.Login });
			 if ((op == Operacao.Incluir && _ix_usuario != null) ||(op == Operacao.Alterar && _ix_usuario != null && _ix_usuario.IdUsuario != usuario.IdUsuario))
				throw new ExceptionRS("Violação do índice: IX_USUARIO");

			usuarioDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					usuario = usuarioDAO.CopiarParaPersistente(usuario.IdUsuario.Value,usuario);
				usuario = usuarioDAO.InserirAlterar(usuario,op);
				usuarioDAO.CommitTransaction();				
			}			
			catch
			{
				usuarioDAO.RollbackTransaction();
				throw;
			}				
			return usuario;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="usuario">O(A) usuario.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Usuario usuario)
		{
			usuarioDAO.BeginTransaction();
			try 
			{
				usuarioDAO.Excluir(usuario);
				usuarioDAO.CommitTransaction();				
			}			
			catch
			{
				usuarioDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Usuario> lst)
		{
			usuarioDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Usuario usuario in lst)
				{
					usuarioDAO.Excluir(usuario);
				}
				usuarioDAO.CommitTransaction();				
			}			
			catch
			{
				usuarioDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Usuario> ListarPor(string dado)
		{
			return usuarioDAO.ListarPor(dado);
		}
	}
}
