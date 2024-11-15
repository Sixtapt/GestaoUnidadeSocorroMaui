using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoUnidadeSocorroMaui.Models
{
    public class Medico : Utilizador
    {
        #region Construtor
        public Medico(string nome, string apelido, string morada, string categoria, string contacto, string email, string numeroIdentificacao, string especialidade, DateTime dataAdmissao) : base(nome, apelido, morada, categoria, contacto, email)
        {
            NumeroIdentificacao = numeroIdentificacao;
            Especialidade = especialidade;
            DataAdmissao = dataAdmissao;
        }
        #endregion

        #region PropriedadesEspecificasBombeiro
        public string NumeroIdentificacao { get; set; }
        public string Especialidade { get; set; }
        public DateTime DataAdmissao { get; set; }
        #endregion

        #region Polimorfismo
        public override string ResponderOcorrencia()
        {
            return $"{Nome} (Medico) está a responder a uma ocorrência";
        }
        #endregion
    }
   
}
