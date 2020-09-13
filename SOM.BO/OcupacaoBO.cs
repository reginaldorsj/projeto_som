
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
	/// Regras de negócio para gerenciamento da classe <see cref='OcupacaoBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class OcupacaoBO : MarshalByRefObject, SOM.BO.IOcupacaoBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IOcupacaoDAO ocupacaoDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="OcupacaoBO"/>.
		/// </summary>
		public OcupacaoBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			ocupacaoDAO = daoAccess.OcupacaoDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="OcupacaoBO"/> is reclaimed by garbage collection.
		/// </summary>
		~OcupacaoBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			ocupacaoDAO.Dispose();
			usuarioBO.Dispose();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Ocupacao> lst)
		{
			return ocupacaoDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Ocupacao SelecionarPor(string propertyName, object value)
		{
			return ocupacaoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Ocupacao SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return ocupacaoDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Ocupacao SelecionarPor(string[] propertyName, object[] value)
		{
			return ocupacaoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Ocupacao SelecionarPorId(object id)
		{
			return ocupacaoDAO.SelecionarPor("IdOcupacao",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Ocupacao> Listar(string propertyOrder)
		{
			return ocupacaoDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Ocupacao InserirAlterar(SOM.OR.Usuario u, SOM.OR.Ocupacao ocupacao, Regisoft.Operacao op)
		{
			ocupacaoDAO.ValidaNotNull(ocupacao);
			Ocupacao _ix_ocupacao2 = ocupacaoDAO.SelecionarPor(new string[]{ "Codigo" }, new object[]{ ocupacao.Codigo });
			 if ((op == Operacao.Incluir && _ix_ocupacao2 != null) ||(op == Operacao.Alterar && _ix_ocupacao2 != null && _ix_ocupacao2.IdOcupacao != ocupacao.IdOcupacao))
				throw new ExceptionRS("Violação do índice: IX_OCUPACAO2");

			ocupacaoDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					ocupacao = ocupacaoDAO.CopiarParaPersistente(ocupacao.IdOcupacao.Value,ocupacao);
				ocupacao = ocupacaoDAO.InserirAlterar(ocupacao,op);
				ocupacaoDAO.CommitTransaction();				
			}			
			catch
			{
				ocupacaoDAO.RollbackTransaction();
				throw;
			}				
			return ocupacao;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="ocupacao">O(A) ocupacao.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Ocupacao ocupacao)
		{
			ocupacaoDAO.BeginTransaction();
			try 
			{
				ocupacaoDAO.Excluir(ocupacao);
				ocupacaoDAO.CommitTransaction();				
			}			
			catch
			{
				ocupacaoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Ocupacao> lst)
		{
			ocupacaoDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Ocupacao ocupacao in lst)
				{
					ocupacaoDAO.Excluir(ocupacao);
				}
				ocupacaoDAO.CommitTransaction();				
			}			
			catch
			{
				ocupacaoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Ocupacao> ListarPor(string dado)
		{
			return ocupacaoDAO.ListarPor(dado);
		}
	}
}
