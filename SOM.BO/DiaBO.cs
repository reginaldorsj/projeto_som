
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
	/// Regras de negócio para gerenciamento da classe <see cref='DiaBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class DiaBO : MarshalByRefObject, SOM.BO.IDiaBO
	{
		protected Carnaval carnaval;
		protected ICarnavalBO carnavalBO;
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IDiaDAO diaDAO;

		/// <summary>
		/// Inicializa uma instância da classe <see cref="DiaBO"/>.
		/// </summary>
		public DiaBO(IUsuarioBO usuarioBO, ICarnavalBO carnavalBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			diaDAO = daoAccess.DiaDAO();
			this.usuarioBO = usuarioBO;
			this.carnavalBO = carnavalBO;

			carnaval = carnavalBO.GetAtivo();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="DiaBO"/> is reclaimed by garbage collection.
		/// </summary>
		~DiaBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			diaDAO.Dispose();
			usuarioBO.Dispose();
			carnavalBO.Dispose();
		}
		public IList<Dia> ListarAtivos()
		{
			return diaDAO.ListarPorAno(carnaval.Ano);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="carnaval">O(A) carnaval.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Dia> ListarPorCarnaval(Carnaval carnaval)
		{
			return diaDAO.ListarPorCarnaval(carnaval);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Dia> lst)
		{
			return diaDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Dia SelecionarPor(string propertyName, object value)
		{
			return diaDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Dia SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return diaDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Dia SelecionarPor(string[] propertyName, object[] value)
		{
			return diaDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Dia SelecionarPorId(object id)
		{
			return diaDAO.SelecionarPor("IdDia",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Dia> Listar(string propertyOrder)
		{
			return diaDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="dia">O(A) dia.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Dia InserirAlterar(SOM.OR.Usuario u, SOM.OR.Dia dia, Regisoft.Operacao op)
		{
			diaDAO.ValidaNotNull(dia);
			Dia _ix_dia = diaDAO.SelecionarPor(new string[]{ "IdCarnaval" , "Data" }, new object[]{ dia.IdCarnaval , dia.Data });
			 if ((op == Operacao.Incluir && _ix_dia != null) ||(op == Operacao.Alterar && _ix_dia != null && _ix_dia.IdDia != dia.IdDia))
				throw new ExceptionRS("Violação do índice: IX_DIA");

			diaDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					dia = diaDAO.CopiarParaPersistente(dia.IdDia.Value,dia);
				dia = diaDAO.InserirAlterar(dia,op);
				diaDAO.CommitTransaction();				
			}			
			catch
			{
				diaDAO.RollbackTransaction();
				throw;
			}				
			return dia;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="dia">O(A) dia.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Dia dia)
		{
			diaDAO.BeginTransaction();
			try 
			{
				diaDAO.Excluir(dia);
				diaDAO.CommitTransaction();				
			}			
			catch
			{
				diaDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Dia> lst)
		{
			diaDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Dia dia in lst)
				{
					diaDAO.Excluir(dia);
				}
				diaDAO.CommitTransaction();				
			}			
			catch
			{
				diaDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Dia> ListarPor(string dado)
		{
			return diaDAO.ListarPor(dado);
		}
	}
}
