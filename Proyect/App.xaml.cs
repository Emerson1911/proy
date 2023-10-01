using Proyect.Views;

namespace Proyect
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Contenpage();
        }
    }
}