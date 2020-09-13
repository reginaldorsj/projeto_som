
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
	/// Regras de negócio para gerenciamento da classe <see cref='MunicipioBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class MunicipioBO : MarshalByRefObject, SOM.BO.IMunicipioBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IMunicipioDAO municipioDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="MunicipioBO"/>.
		/// </summary>
		public MunicipioBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			municipioDAO = daoAccess.MunicipioDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="MunicipioBO"/> is reclaimed by garbage collection.
		/// </summary>
		~MunicipioBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			municipioDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList<Municipio> ListarPorNome(Uf uf, string nomeMunicipio)
		{
			return municipioDAO.ListarPorNome(uf, nomeMunicipio);
		}
		public Municipio SelecionarPorNome(Uf uf, string nomeMunicipio)
		{
			return municipioDAO.SelecionarPorNome(uf, nomeMunicipio);
		}

		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Municipio> ListarPorUf(Uf uf)
		{
			return municipioDAO.ListarPorUf(uf);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Municipio> lst)
		{
			return municipioDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Municipio SelecionarPor(string propertyName, object value)
		{
			return municipioDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Municipio SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return municipioDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Municipio SelecionarPor(string[] propertyName, object[] value)
		{
			return municipioDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Municipio SelecionarPorId(object id)
		{
			return municipioDAO.SelecionarPor("IdMunicipio",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Municipio> Listar(string propertyOrder)
		{
			return municipioDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="municipio">O(A) municipio.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Municipio InserirAlterar(SOM.OR.Usuario u, SOM.OR.Municipio municipio, Regisoft.Operacao op)
		{
			municipioDAO.ValidaNotNull(municipio);
			municipioDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					municipio = municipioDAO.CopiarParaPersistente(municipio.IdMunicipio.Value,municipio);
				municipio = municipioDAO.InserirAlterar(municipio,op);
				municipioDAO.CommitTransaction();				
			}			
			catch
			{
				municipioDAO.RollbackTransaction();
				throw;
			}				
			return municipio;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="municipio">O(A) municipio.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Municipio municipio)
		{
			municipioDAO.BeginTransaction();
			try 
			{
				municipioDAO.Excluir(municipio);
				municipioDAO.CommitTransaction();				
			}			
			catch
			{
				municipioDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Municipio> lst)
		{
			municipioDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Municipio municipio in lst)
				{
					municipioDAO.Excluir(municipio);
				}
				municipioDAO.CommitTransaction();				
			}			
			catch
			{
				municipioDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Municipio> ListarPor(string dado)
		{
			return municipioDAO.ListarPor(dado);
		}
	}
}
