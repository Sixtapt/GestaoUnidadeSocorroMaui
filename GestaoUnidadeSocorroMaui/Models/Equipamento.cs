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
        public string EstadoConservacao { get; set; }

        // Relacionamento com Atividades de Socorro (muitos-para-muitos)
        //[ManyToMany(typeof(AtividadeEquipamento))]
      
    }
    public class gestaoEquipamento
    {

        public void AdicionarEquipamento()
        {
        }

    }
}
