
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
	/// Regras de negócio para gerenciamento da classe <see cref='CarnavalBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class CarnavalBO : MarshalByRefObject, SOM.BO.ICarnavalBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected ICarnavalDAO carnavalDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="CarnavalBO"/>.
		/// </summary>
		public CarnavalBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			carnavalDAO = daoAccess.CarnavalDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="CarnavalBO"/> is reclaimed by garbage collection.
		/// </summary>
		~CarnavalBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			carnavalDAO.Dispose();
			usuarioBO.Dispose();
		}
		public Carnaval GetAtivo()
		{
			IList<Carnaval> lst = carnavalDAO.ListarAtivos();
			if (lst.Count == 0)
				throw new ExceptionRS("Nenhum Carnaval/Ano ativado.");
			else if (lst.Count > 1)
				throw new ExceptionRS("Erro interno. Existe ativado mais de um Carnaval/Ano.");
			return lst[0];
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Carnaval> lst)
		{
			return carnavalDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Carnaval SelecionarPor(string propertyName, object value)
		{
			return carnavalDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Carnaval SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return carnavalDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Carnaval SelecionarPor(string[] propertyName, object[] value)
		{
			return carnavalDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Carnaval SelecionarPorId(object id)
		{
			return carnavalDAO.SelecionarPor("IdCarnaval",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Carnaval> Listar(string propertyOrder)
		{
			return carnavalDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="carnaval">O(A) carnaval.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Carnaval InserirAlterar(SOM.OR.Usuario u, SOM.OR.Carnaval carnaval, Regisoft.Operacao op)
		{
			carnavalDAO.ValidaNotNull(carnaval);
			Carnaval _ix_carnaval = carnavalDAO.SelecionarPor(new string[]{ "Ano" }, new object[]{ carnaval.Ano });
			 if ((op == Operacao.Incluir && _ix_carnaval != null) ||(op == Operacao.Alterar && _ix_carnaval != null && _ix_carnaval.IdCarnaval != carnaval.IdCarnaval))
				throw new ExceptionRS("Violação do índice: IX_CARNAVAL");

			carnavalDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					carnaval = carnavalDAO.CopiarParaPersistente(carnaval.IdCarnaval.Value,carnaval);
				carnaval = carnavalDAO.InserirAlterar(carnaval,op);
				carnavalDAO.CommitTransaction();				
			}			
			catch
			{
				carnavalDAO.RollbackTransaction();
				throw;
			}				
			return carnaval;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="carnaval">O(A) carnaval.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Carnaval carnaval)
		{
			carnavalDAO.BeginTransaction();
			try 
			{
				carnavalDAO.Excluir(carnaval);
				carnavalDAO.CommitTransaction();				
			}			
			catch
			{
				carnavalDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Carnaval> lst)
		{
			carnavalDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Carnaval carnaval in lst)
				{
					carnavalDAO.Excluir(carnaval);
				}
				carnavalDAO.CommitTransaction();				
			}			
			catch
			{
				carnavalDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Carnaval> ListarPor(string dado)
		{
			return carnavalDAO.ListarPor(dado);
		}
	}
}
