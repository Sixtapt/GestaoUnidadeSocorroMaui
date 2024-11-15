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


    public class Equipamento
    {
        [PrimaryKey, AutoIncrement]
        public int NumeroSerie { get; set; }
        public string Nome { get; set; }
        public EstadoConservacao EstadoConservacao { get; set; }
        public Manutencao Manutencao { get; set; }

        #region Métodos de Atualização

        // Método para atualizar o estado de conservação do equipamento
        public void AtualizarEstadoConservacao(EstadoConservacao novoEstado)
        {
            EstadoConservacao = novoEstado;
        }

        // Método para atualizar o nome do equipamento
        public void AtualizarNome(string novoNome)
        {
            Nome = novoNome;
        }

        // Método para atualizar a manutenção do equipamento
        public void AtualizarManutencao(Manutencao novaManutencao)
        {
            Manutencao = novaManutencao;
        }

        #endregion

        #region Métodos de Consulta

        // Método para obter o estado de conservação do equipamento
        public EstadoConservacao ObterEstadoConservacao()
        {
            return EstadoConservacao;
        }

        // Método para obter o nome do equipamento
        public string ObterNome()
        {
            return Nome;
        }

        // Método para obter a manutenção do equipamento
        public static List<Manutencao> ObterManutencoesPorNumeroSerie(SQLiteConnection db, int numeroSerie)
        {
            return db.Table<Manutencao>().Where(m => m.NumeroSerie == numeroSerie.ToString()).ToList();
        }

        #endregion
    }
}
