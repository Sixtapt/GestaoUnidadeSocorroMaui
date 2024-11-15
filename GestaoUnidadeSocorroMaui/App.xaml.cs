using GestaoUnidadeSocorroMaui.Views;

namespace GestaoUnidadeSocorroMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UtilizadorView();
        }
    }
}
