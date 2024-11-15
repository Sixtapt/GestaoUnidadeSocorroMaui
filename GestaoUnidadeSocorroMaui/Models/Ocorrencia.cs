using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoUnidadeSocorroMaui.Models
{
    public class Ocorrencia
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int AtividadeId { get; set; }
        public string Gravidade { get; set; }
        public string Status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
    }
    public class gestaoOcorrencia
    {
        public void AdicionarOcorrencia()
        {
            // Adicionar Ocorrencia
        }

        public void RemoverOcorrencia()
        {
            // Remover Ocorrencia
        }

        public void ListarTodasOcorrencias()
        {
            // Listar todas as Ocorrencias
        }

        public void AlterarStatusOcorrencia()
        {
            // Listar Ocorrencias Ativas
        }
    }
}

