using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoUnidadeSocorroMaui.Models
{
    public class Manutencao
    {
        public int IdManutencao { get; set; }
        public string NumeroSerie { get; set; } //chave estrangeira
        public DataType DataInicio { get; set; }
        public DataType DataFim { get; set; }
        public string Descricao { get; set; }

    }
    public class gestaoManutencao
    {
        public void AdicionarManutencao()
        {
            // Adicionar Manutencao
        }

        public void RemoverManutencao()
        {
            // Remover Manutencao
        }

        public void ListarTodasManutencoes()
        {
        }
    }
}
