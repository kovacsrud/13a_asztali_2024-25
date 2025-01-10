using MauiHybridMeroora.mvvm.model;
using MauiHybridMeroora.repository;

namespace MauiHybridMeroora
{
    public partial class App : Application
    {
        public static BaseRepository<MeroOra> MeroRepo { get; private set; }
        public App(BaseRepository<MeroOra> merorepo)
        {
            InitializeComponent();
            MeroRepo = merorepo;
            MainPage = new MainPage();
        }
    }
}
