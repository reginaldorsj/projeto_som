
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
	/// Regras de negócio para gerenciamento da classe <see cref='MedicoBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class MedicoBO : MarshalByRefObject, SOM.BO.IMedicoBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IMedicoDAO medicoDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="MedicoBO"/>.
		/// </summary>
		public MedicoBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			medicoDAO = daoAccess.MedicoDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="MedicoBO"/> is reclaimed by garbage collection.
		/// </summary>
		~MedicoBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			medicoDAO.Dispose();
			usuarioBO.Dispose();
		}
		public IList<Medico> ListarPorNome(string nome)
		{
			return medicoDAO.ListarPorNome(nome);
		}
		public Medico SelecionarPor(string cremeb, Uf uf)
		{
			return medicoDAO.SelecionarPor(cremeb, uf);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="uf">O(A) uf.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Medico> ListarPorUf(Uf uf)
		{
			return medicoDAO.ListarPorUf(uf);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Medico> lst)
		{
			return medicoDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Medico SelecionarPor(string propertyName, object value)
		{
			return medicoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Medico SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return medicoDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Medico SelecionarPor(string[] propertyName, object[] value)
		{
			return medicoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Medico SelecionarPorId(object id)
		{
			return medicoDAO.SelecionarPor("IdMedico",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Medico> Listar(string propertyOrder)
		{
			return medicoDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="medico">O(A) medico.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Medico InserirAlterar(SOM.OR.Usuario u, SOM.OR.Medico medico, Regisoft.Operacao op)
		{
			medico.Nome = medico.Nome.UmEspacoEntre().SemAcentos().Trim().ToUpper();
			medicoDAO.ValidaNotNull(medico);
			Medico _ix_medico = medicoDAO.SelecionarPor(new string[]{ "Cremeb" , "IdUf" }, new object[]{ medico.Cremeb , medico.IdUf });
			 if ((op == Operacao.Incluir && _ix_medico != null) ||(op == Operacao.Alterar && _ix_medico != null && _ix_medico.IdMedico != medico.IdMedico))
				throw new ExceptionRS("Já existe médico cadastrado com esse Cremeb/UF.");

			medicoDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					medico = medicoDAO.CopiarParaPersistente(medico.IdMedico.Value,medico);
				medico = medicoDAO.InserirAlterar(medico,op);
				medicoDAO.CommitTransaction();				
			}			
			catch
			{
				medicoDAO.RollbackTransaction();
				throw;
			}				
			return medico;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="medico">O(A) medico.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Medico medico)
		{
			medicoDAO.BeginTransaction();
			try 
			{
				medicoDAO.Excluir(medico);
				medicoDAO.CommitTransaction();				
			}			
			catch
			{
				medicoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Medico> lst)
		{
			medicoDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Medico medico in lst)
				{
					medicoDAO.Excluir(medico);
				}
				medicoDAO.CommitTransaction();				
			}			
			catch
			{
				medicoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Medico> ListarPor(string dado)
		{
			return medicoDAO.ListarPor(dado);
		}
	}
}
