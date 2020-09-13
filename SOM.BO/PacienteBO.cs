
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
	/// Regras de negócio para gerenciamento da classe <see cref='PacienteBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class PacienteBO : MarshalByRefObject, SOM.BO.IPacienteBO
	{
		/// <summary>
		/// Define o objeto de controle de usuario.
		/// </summary>
		protected IUsuarioBO usuarioBO;
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IPacienteDAO pacienteDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="PacienteBO"/>.
		/// </summary>
		public PacienteBO(IUsuarioBO usuarioBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			pacienteDAO = daoAccess.PacienteDAO();
			this.usuarioBO = usuarioBO;
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="PacienteBO"/> is reclaimed by garbage collection.
		/// </summary>
		~PacienteBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			pacienteDAO.Dispose();
			usuarioBO.Dispose();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="municipio">O(A) municipio.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Paciente> ListarPorMunicipio(Municipio municipio)
		{
			return pacienteDAO.ListarPorMunicipio(municipio);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="raca">O(A) raca.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Paciente> ListarPorRaca(Raca raca)
		{
			return pacienteDAO.ListarPorRaca(raca);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="sexo">O(A) sexo.</param>
		/// <returns>A lista.</returns>
		public IList<SOM.OR.Paciente> ListarPorSexo(Sexo sexo)
		{
			return pacienteDAO.ListarPorSexo(sexo);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<SOM.OR.Paciente> lst)
		{
			return pacienteDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Paciente SelecionarPor(string propertyName, object value)
		{
			return pacienteDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Paciente SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return pacienteDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Paciente SelecionarPor(string[] propertyName, object[] value)
		{
			return pacienteDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public SOM.OR.Paciente SelecionarPorId(object id)
		{
			return pacienteDAO.SelecionarPor("IdPaciente",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<SOM.OR.Paciente> Listar(string propertyOrder)
		{
			return pacienteDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="paciente">O(A) paciente.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public SOM.OR.Paciente InserirAlterar(SOM.OR.Usuario u, SOM.OR.Paciente paciente, Regisoft.Operacao op)
		{
			paciente.Nome = stringf.UmEspacoEntre(stringf.SemAcentos(paciente.Nome)).Trim().ToUpper();

			pacienteDAO.ValidaNotNull(paciente);
			pacienteDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					paciente = pacienteDAO.CopiarParaPersistente(paciente.IdPaciente.Value,paciente);
				paciente = pacienteDAO.InserirAlterar(paciente,op);
				pacienteDAO.CommitTransaction();				
			}			
			catch
			{
				pacienteDAO.RollbackTransaction();
				throw;
			}				
			return paciente;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="paciente">O(A) paciente.</param>
		public void Excluir(SOM.OR.Usuario u, SOM.OR.Paciente paciente)
		{
			pacienteDAO.BeginTransaction();
			try 
			{
				pacienteDAO.Excluir(paciente);
				pacienteDAO.CommitTransaction();				
			}			
			catch
			{
				pacienteDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="u">O usuário.</param>
		/// <param name="lst">A lista.</param>
		public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Paciente> lst)
		{
			pacienteDAO.BeginTransaction();
			try 
			{
				foreach (SOM.OR.Paciente paciente in lst)
				{
					pacienteDAO.Excluir(paciente);
				}
				pacienteDAO.CommitTransaction();				
			}			
			catch
			{
				pacienteDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Paciente> ListarPor(string dado)
		{
			return pacienteDAO.ListarPor(dado);
		}
	}
}
