using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoUnidadeSocorroMaui.Interfaces
{
    internal interface IUtilizador
    {
        #region CriarUtilizador
        // Método para criar um utilizador
        void CriarUtilizador(string nome, string email);
        #endregion

        #region EditarUtilizador
        // Método para editar um utilizador
        void EditarUtilizador(int id, string nome, string email);
        #endregion

        #region EliminarUtilizador
        // Método para eliminar um utilizador
        void EliminarUtilizador(int id);
        #endregion
    }
}
