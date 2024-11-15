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
    public class Corporacao
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }

        // Relacionamento com Atividades de Socorro
        //[OneToMany]
      
    }

    public class gestaoCorporacao
    {
        public void AdicionarCorporacao()
        {
            // Adicionar Corporacao
        }

        public void RemoverCorporacao()
        {
            // Remover Corporacao
        }

        public void ListarTodasCorporacoes()
        {
            // Listar todas as Corporacoes
        }
    }

}
