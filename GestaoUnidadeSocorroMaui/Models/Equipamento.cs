using GestaoUnidadeSocorroMaui.Models;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoUnidadeSocorroMaui.Models
{


    /// <summary>
    /// Representa um equipamento com suas propriedades e métodos de atualização e consulta.
    /// </summary>
    public class Equipamento
    {
        /// <summary>
        /// Obtém ou define o número de série do equipamento.
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int NumeroSerie { get; set; }

        /// <summary>
        /// Obtém ou define o nome do equipamento.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o estado de conservação do equipamento.
        /// </summary>
        public EstadoConservacao EstadoConservacao { get; set; }

        /// <summary>
        /// Obtém ou define a manutenção do equipamento.
        /// </summary>
        public Manutencao Manutencao { get; set; }

        #region Métodos de Atualização

        /// <summary>
        /// Atualiza o estado de conservação do equipamento.
        /// </summary>
        /// <param name="novoEstado">Novo estado de conservação.</param>
        public void AtualizarEstadoConservacao(EstadoConservacao novoEstado)
        {
            EstadoConservacao = novoEstado;
        }

        /// <summary>
        /// Atualiza o nome do equipamento.
        /// </summary>
        /// <param name="novoNome">Novo nome do equipamento.</param>
        public void AtualizarNome(string novoNome)
        {
            Nome = novoNome;
        }

        /// <summary>
        /// Atualiza a manutenção do equipamento.
        /// </summary>
        /// <param name="novaManutencao">Nova manutenção do equipamento.</param>
        public void AtualizarManutencao(Manutencao novaManutencao)
        {
            Manutencao = novaManutencao;
        }

        #endregion

        #region Métodos de Consulta

        /// <summary>
        /// Obtém o estado de conservação do equipamento.
        /// </summary>
        /// <returns>O estado de conservação do equipamento.</returns>
        public EstadoConservacao ObterEstadoConservacao()
        {
            return EstadoConservacao;
        }

        /// <summary>
        /// Obtém o nome do equipamento.
        /// </summary>
        /// <returns>O nome do equipamento.</returns>
        public string ObterNome()
        {
            return Nome;
        }

        /// <summary>
        /// Obtém a lista de manutenções do equipamento pelo número de série.
        /// </summary>
        /// <param name="db">Conexão com o banco de dados SQLite.</param>
        /// <param name="numeroSerie">Número de série do equipamento.</param>
        /// <returns>Lista de manutenções do equipamento.</returns>
        public static List<Manutencao> ObterManutencoesPorNumeroSerie(SQLiteConnection db, int numeroSerie)
        {
            return db.Table<Manutencao>().Where(m => m.NumeroSerie == numeroSerie.ToString()).ToList();
        }

        #endregion
    }
}
