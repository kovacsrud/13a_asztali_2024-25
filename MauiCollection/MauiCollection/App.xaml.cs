using MauiCollection.Pages;

namespace MauiCollection
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListaPage();
        }
    }
}
