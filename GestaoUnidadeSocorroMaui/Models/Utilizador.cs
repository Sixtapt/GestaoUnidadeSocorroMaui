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
    public class Utilizador
    {
        #region Propriedades
        [PrimaryKey, AutoIncrement]
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Apelido { get; private set; }
        public string Morada { get; private set; }
        public string Categoria { get; private set; }
        public string Contacto { get; private set; }
        public string Email { get; private set; }
        #endregion

        #region Construtor
        public Utilizador(string nome, string apelido, string morada, string categoria, string contacto, string email)
        {
            Nome = nome;
            Apelido = apelido;
            Morada = morada;
            Categoria = categoria;
            Contacto = contacto;
            Email = email;
        }
        #endregion

        #region Polimorfismo
        public virtual string ResponderOcorrencia()
        {
            return $"{Nome} está a responder a uma ocorrência";
        }
        #endregion
    }
}
