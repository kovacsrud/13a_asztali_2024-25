using MauiJegyzetV2.mvvm.model;
using MauiJegyzetV2.mvvm.view;
using MauiJegyzetV2.Repository;

namespace MauiJegyzetV2
{
    public partial class App : Application
    {
        public static BaseRepository<Jegyzet> JegyzetRepo {  get; private set; }
        public App(BaseRepository<Jegyzet> jegyzetrepo)
        {
            InitializeComponent();
            JegyzetRepo=jegyzetrepo;
            MainPage = new NavigationPage(new JegyzetView());
        }
    }
}
