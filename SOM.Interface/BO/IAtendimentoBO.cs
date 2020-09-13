

using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using SOM.OR;

namespace SOM.BO
{
    /// <summary>
    /// Regras de negócio para gerenciamento da classe <see cref='IAtendimentoBO'/>
    /// Gerado por RSClass - Gerador de ;
    /// </summary>
    public interface IAtendimentoBO : IDisposable
    {
        IList<Atendimento> ListarObitos();
        IList ResumoPorDemandaExpontanea();
        IList ResumoPorPostoSaude();
        IList ResumoOrigemPorCausa(Causa causa);
        IList ResumoCausaPorOrigem(Origem origem);
        IList ResumoPorProcedencia();
        IList ResumoPorProcedimento();
        long TotalOcorrencias();
        IList ResumoPorSiglaUnidade();
        IList ResumoPorCausa();
        IList ResumoPorOrigem();
        IList ResumoPorUnidade();
        IList<Atendimento> ListarPorNome(Unidade unidade, string nome);
        /// <summary>
        /// Selecionar objeto.
        /// </summary>
        /// <param name="id">O id.</param>
        /// <returns></returns>
        SOM.OR.Atendimento SelecionarPorId(object id);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="propertyOrder">A propriedade ordem.</param>
        /// <returns>A lista ordenada.</returns>
        System.Collections.Generic.IList<SOM.OR.Atendimento> Listar(string propertyOrder);
        /// <summary>
        /// Selecionar um objeto.
        /// </summary>
        /// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
        /// <param name="value">O valor procurado na propriedade.</param>
        /// <returns>O objeto selecionado.</returns>
        SOM.OR.Atendimento SelecionarPor(string propertyName, object value);
        /// <summary>
        /// Selecionar um objeto.
        /// </summary>
        /// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
        /// <param name="value1">O valor procurado na primeira propriedade.</param>
        /// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
        /// <param name="value2">TO valor procurado na segunda propriedade.</param>
        /// <returns>O objeto selecionado.</returns>
        SOM.OR.Atendimento SelecionarPor(string propertyName1, object value1, string propertyName2, object value2);
        /// <summary>
        /// Selecionar um objeto.
        /// </summary>
        /// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
        /// <param name="value">O array de valores procurados nas propriedades.</param>
        /// <returns>O objeto selecionado.</returns>
        SOM.OR.Atendimento SelecionarPor(string[] propertyName, object[] value);
        /// <summary>
        /// Transforma um lista em um DataTable.
        /// </summary>
        /// <param name="lst">A lista.</param>
        /// <returns>O DataTable.</returns>
        DataTable ToDataTable(IList<SOM.OR.Atendimento> lst);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="dia">O(A) dia.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorDia(SOM.OR.Dia dia);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="unidade">O(A) unidade.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorUnidade(SOM.OR.Unidade unidade);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="procedencia">O(A) procedencia.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorProcedencia(SOM.OR.Procedencia procedencia);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="postosaude">O(A) postosaude.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorPostoSaude(SOM.OR.PostoSaude postosaude);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="origem">O(A) origem.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorOrigem(SOM.OR.Origem origem);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="paciente">O(A) paciente.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorPaciente(SOM.OR.Paciente paciente);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="medico">O(A) medico.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorMedico(SOM.OR.Medico medico);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="causa">O(A) causa.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorCausa(SOM.OR.Causa causa);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="procedimento">O(A) procedimento.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorProcedimento(SOM.OR.Procedimento procedimento);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="tipoobito">O(A) tipoobito.</param>
        /// <returns>A lista.</returns>
        IList<SOM.OR.Atendimento> ListarPorTipoObito(SOM.OR.TipoObito tipoobito);
        /// <summary>
        /// Insere ou altera um objeto no banco de dados.
        /// </summary>
        /// <param name="u">O usuário.</param>
        /// <param name="atendimento">O(A) atendimento.</param>
        /// <param name="op">A operação.</param>
        /// <param name="lstDoenca">Lista de doenças</param>
        /// <returns>O objeto após a persistência.</returns>
        SOM.OR.Atendimento InserirAlterar(SOM.OR.Usuario u, SOM.OR.Atendimento atendimento, Regisoft.Operacao op, IList<Doenca> lstDoenca);
        /// <summary>
        /// Exclui o objeto do banco de dados.
        /// </summary>
        /// <param name="u">O usuário.</param>
        /// <param name="atendimento">O(A) atendimento.</param>
        void Excluir(SOM.OR.Usuario u, SOM.OR.Atendimento atendimento);
        /// <summary>
        /// Exclui uma lista de objeto do banco de dados.
        /// </summary>
        /// <param name="u">O usuário.</param>
        /// <param name="lst">A lista.</param>
        void Excluir(SOM.OR.Usuario u, IList<SOM.OR.Atendimento> lst);
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="dado"> O dado para pesquisa.</param>
        /// <returns>A lista.</returns>
        IList<Atendimento> ListarPor(string dado);

    }
}
