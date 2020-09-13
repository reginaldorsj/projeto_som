
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Regisoft;
using SOM.OR;
using SOM.DAO;
using Microsoft.Practices.ObjectBuilder2;

namespace SOM.BO
{
    /// <summary>
    /// Regras de negócio para gerenciamento da classe <see cref='AtendimentoBO'/>
    /// Gerado por RSClass - Gerador de Classes
    /// </summary>
    public class AtendimentoBO : MarshalByRefObject, SOM.BO.IAtendimentoBO
    {
        protected Carnaval carnaval;
        protected IDiagnosticoDAO diagnosticoDAO;
        protected IPacienteBO pacienteBO;
        /// <summary>
        /// Define o objeto de controle de usuario.
        /// </summary>
        protected IUsuarioBO usuarioBO;
        /// <summary>
        /// Define o objeto de acesso a dados.
        /// </summary>
        protected IAtendimentoDAO atendimentoDAO;
        protected ICarnavalBO carnavalBO;
        /// <summary>
        /// Inicializa uma instância da classe <see cref="AtendimentoBO"/>.
        /// </summary>
        public AtendimentoBO(IUsuarioBO usuarioBO, IPacienteBO pacienteBO, ICarnavalBO carnavalBO)
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
            atendimentoDAO = daoAccess.AtendimentoDAO();
            this.usuarioBO = usuarioBO;
            this.pacienteBO = pacienteBO;
            this.diagnosticoDAO = daoAccess.DiagnosticoDAO();
            this.carnavalBO = carnavalBO;

            carnaval = carnavalBO.GetAtivo();

        }
        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="AtendimentoBO"/> is reclaimed by garbage collection.
        /// </summary>
        ~AtendimentoBO()
        {
            Dispose();
        }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            atendimentoDAO.Dispose();
            usuarioBO.Dispose();
            pacienteBO.Dispose();
            diagnosticoDAO.Dispose();
            carnavalBO.Dispose();
        }
        public IList<Atendimento> ListarObitos()
        {
            return atendimentoDAO.ListarObitos(carnaval.Ano);
        }
        public IList ResumoPorDemandaExpontanea()
        {
            return atendimentoDAO.ResumoPorDemandaExpontanea(carnaval.Ano);
        }
        public IList ResumoPorPostoSaude()
        {
            return atendimentoDAO.ResumoPorPostoSaude(carnaval.Ano);
        }
        public IList ResumoOrigemPorCausa(Causa causa)
        {
            return atendimentoDAO.ResumoOrigemPorCausa(causa, carnaval.Ano);
        }
        public IList ResumoCausaPorOrigem(Origem origem)
        {
            return atendimentoDAO.ResumoCausaPorOrigem(origem, carnaval.Ano);
        }
        public IList ResumoPorProcedencia()
        {
            return atendimentoDAO.ResumoPorProcedencia(carnaval.Ano);
        }
        public IList ResumoPorProcedimento()
        {
            return atendimentoDAO.ResumoPorProcedimento(carnaval.Ano);
        }
        public long TotalOcorrencias()
        {
            return atendimentoDAO.TotalOcorrencias(carnaval.Ano);
        }
        public IList ResumoPorSiglaUnidade()
        {
            return atendimentoDAO.ResumoPorSiglaUnidade(carnaval.Ano);
        }
        public IList ResumoPorCausa()
        {
            return atendimentoDAO.ResumoPorCausa(carnaval.Ano);
        }
        public IList ResumoPorOrigem()
        {
            return atendimentoDAO.ResumoPorOrigem(carnaval.Ano);
        }
        public IList ResumoPorUnidade()
        {
            return atendimentoDAO.ResumoPorUnidade(carnaval.Ano);
        }
        public IList<Atendimento> ListarPorNome(Unidade unidade, string nome)
        {
            if (unidade == null)
                throw new ExceptionRS("Você não tem permissão para realizar esta operação");

            return atendimentoDAO.ListarPorNome(unidade, nome, carnaval.Ano);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="dia">O(A) dia.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorDia(Dia dia)
        {
            return atendimentoDAO.ListarPorDia(dia);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="unidade">O(A) unidade.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorUnidade(Unidade unidade)
        {
            return atendimentoDAO.ListarPorUnidade(unidade);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="procedencia">O(A) procedencia.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorProcedencia(Procedencia procedencia)
        {
            return atendimentoDAO.ListarPorProcedencia(procedencia);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="postosaude">O(A) postosaude.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorPostoSaude(PostoSaude postosaude)
        {
            return atendimentoDAO.ListarPorPostoSaude(postosaude);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="origem">O(A) origem.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorOrigem(Origem origem)
        {
            return atendimentoDAO.ListarPorOrigem(origem);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="paciente">O(A) paciente.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorPaciente(Paciente paciente)
        {
            return atendimentoDAO.ListarPorPaciente(paciente);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="medico">O(A) medico.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorMedico(Medico medico)
        {
            return atendimentoDAO.ListarPorMedico(medico);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="causa">O(A) causa.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorCausa(Causa causa)
        {
            return atendimentoDAO.ListarPorCausa(causa);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="procedimento">O(A) procedimento.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorProcedimento(Procedimento procedimento)
        {
            return atendimentoDAO.ListarPorProcedimento(procedimento);
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="tipoobito">O(A) tipoobito.</param>
        /// <returns>A lista.</returns>
        public IList<SOM.OR.Atendimento> ListarPorTipoObito(TipoObito tipoobito)
        {
            return atendimentoDAO.ListarPorTipoObito(tipoobito);
        }
        /// <summary>
        /// Transforma um lista em um DataTable.
        /// </summary>
        /// <param name="lst">A lista.</param>
        /// <returns>O DataTable.</returns>
        public DataTable ToDataTable(IList<SOM.OR.Atendimento> lst)
        {
            return atendimentoDAO.ToDataTable(lst);
        }
        /// <summary>
        /// Selecionar um objeto.
        /// </summary>
        /// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
        /// <param name="value">O valor procurado na propriedade.</param>
        /// <returns>O objeto selecionado.</returns>
        public SOM.OR.Atendimento SelecionarPor(string propertyName, object value)
        {
            return atendimentoDAO.SelecionarPor(propertyName, value);
        }
        /// <summary>
        /// Selecionar um objeto.
        /// </summary>
        /// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
        /// <param name="value1">O valor procurado na primeira propriedade.</param>
        /// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
        /// <param name="value2">TO valor procurado na segunda propriedade.</param>
        /// <returns>O objeto selecionado.</returns>
        public SOM.OR.Atendimento SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
        {
            return atendimentoDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
        }
        /// <summary>
        /// Selecionar um objeto.
        /// </summary>
        /// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
        /// <param name="value">O array de valores procurados nas propriedades.</param>
        /// <returns>O objeto selecionado.</returns>
        public SOM.OR.Atendimento SelecionarPor(string[] propertyName, object[] value)
        {
            return atendimentoDAO.SelecionarPor(propertyName, value);
        }
        /// <summary>
        /// Selecionar um objeto.
        /// </summary>
        /// <param name="id">O ID do objeto.</param>
        /// <returns>O objeto selecionado.</returns>
        public SOM.OR.Atendimento SelecionarPorId(object id)
        {
            return atendimentoDAO.SelecionarPor("IdAtendimento", Convert.ChangeType(id, typeof(long)));
        }
        /// <summary>
        /// Listar objetos por uma propriedade específica.
        /// </summary>
        /// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
        /// <returns>A lista ordenada.</returns>
        public IList<SOM.OR.Atendimento> Listar(string propertyOrder)
        {
            return atendimentoDAO.Listar(propertyOrder);
        }
        /// <summary>
        /// Insere ou altera um objeto no banco de dados.
        /// </summary>
        /// <param name="u">O usuário.</param>
        /// <param name="atendimento">O(A) atendimento.</param>
        /// <param name="op">A operação.</param>
        /// <param name="lstDoenca">Lista de doenças</param>
        /// <returns>O objeto após a persistência.</returns>
        public SOM.OR.Atendimento InserirAlterar(SOM.OR.Usuario u, SOM.OR.Atendimento atendimento, Regisoft.Operacao op, IList<Doenca> lstDoenca)
        {
            if (u.IdUnidade == null)
                throw new ExceptionRS("Você não tem permissão para realizar esta operação");

            if (carnaval.DataHoraEncerramento <= DateTime.Now)
                throw new ExceptionRS("Operação não permitida devido ao encerramento do carnaval.");

            if (op == Operacao.Incluir)
            {
                atendimento.IdUnidade = u.IdUnidade;
                atendimento.DataInclusao = DateTime.Now;
            }
            else
            {
                Atendimento a_tmp = atendimentoDAO.SelecionarPorId(atendimento.IdAtendimento.Value);
                atendimento.IdUnidade = u.IdUnidade;
                atendimento.DataInclusao = a_tmp.DataInclusao;
                atendimento.DataUltimaAlteracao = DateTime.Now;
            }
            atendimentoDAO.ValidaNotNull(atendimento);
            if (atendimento.IdDia.IdCarnaval.Ano != carnaval.Ano)
                throw new ExceptionRS("Este atendimento não pertence ao Carnaval/Ano ativo.");

            if (lstDoenca == null || lstDoenca.Count == 0)
                throw new ExceptionRS("Informe as doenças encontradas.");

            if (op == Operacao.Alterar)
            {
                diagnosticoDAO.BeginTransaction();
                try
                {
                    IList<Diagnostico> lst = diagnosticoDAO.ListarPorAtendimento(atendimento);
                    diagnosticoDAO.Excluir(lst);

                    diagnosticoDAO.CommitTransaction();
                }
                catch
                {
                    diagnosticoDAO.RollbackTransaction();
                    throw;
                }
            }

            atendimentoDAO.BeginTransaction();
            try
            {
                atendimento.IdPaciente = pacienteBO.InserirAlterar(u, atendimento.IdPaciente, op);

                if (op == Regisoft.Operacao.Alterar)
                    atendimento = atendimentoDAO.CopiarParaPersistente(atendimento.IdAtendimento.Value, atendimento);
                atendimento = atendimentoDAO.InserirAlterar(atendimento, op);
                
                foreach (Doenca d in lstDoenca)
                {
                    Diagnostico diag = new Diagnostico()
                    {
                        IdAtendimento = atendimento,
                        IdDoenca = d
                    };
                    diagnosticoDAO.Inserir(diag);
                }

                atendimentoDAO.CommitTransaction();
            }
            catch
            {
                atendimentoDAO.RollbackTransaction();
                throw;
            }
            return atendimento;
        }
        /// <summary>
        /// Exclui o objeto do banco de dados.
        /// </summary>
        /// <param name="u">O usuário.</param>
        /// <param name="atendimento">O(A) atendimento.</param>
        public void Excluir(SOM.OR.Usuario u, SOM.OR.Atendimento atendimento)
        {
            if (u.IdUnidade == null)
                throw new ExceptionRS("Você não tem permissão para realizar esta operação");

            if (atendimento.IdDia.IdCarnaval.Ano != carnaval.Ano)
                throw new ExceptionRS("Este atendimento não pertence ao Carnaval/Ano ativo.");

            if (carnaval.DataHoraEncerramento <= DateTime.Now)
                throw new ExceptionRS("Operação não permitida devido ao encerramento do carnaval.");

            atendimentoDAO.BeginTransaction();
            try
            {
                atendimento.DataExclusao = DateTime.Now;
                atendimentoDAO.Alterar(atendimento);

                atendimentoDAO.CommitTransaction();
            }
            catch
            {
                atendimentoDAO.RollbackTransaction();
                throw new ExceptionRS("Impossivel excluir. Registro em uso.");
            }
        }
        /// <summary>
        /// Exclui uma lista de objeto do banco de dados.
        /// </summary>
        /// <param name="u">O usuário.</param>
        /// <param name="lst">A lista.</param>
        public void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Atendimento> lst)
        {
            if (u.IdUnidade == null)
                throw new ExceptionRS("Você não tem permissão para realizar esta operação");

            if (carnaval.DataHoraEncerramento <= DateTime.Now)
                throw new ExceptionRS("Operação não permitida devido ao encerramento do carnaval.");

            atendimentoDAO.BeginTransaction();
            try
            {
                lst.ForEach<Atendimento>(atendimento => {
                    if (atendimento.IdDia.IdCarnaval.Ano != carnaval.Ano)
                        throw new ExceptionRS("Na lista possui atendimento(s) que não pertence(m) ao Carnaval/Ano ativo.");
                    atendimento.DataExclusao = DateTime.Now;
                    atendimentoDAO.Alterar(atendimento);
                });
                atendimentoDAO.CommitTransaction();
            }
            catch
            {
                atendimentoDAO.RollbackTransaction();
                throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
            }
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="dado"> O dado para pesquisa.</param>
        /// <returns>A lista.</returns>
        public IList<Atendimento> ListarPor(string dado)
        {
            return atendimentoDAO.ListarPor(dado);
        }
    }
}
