using MauiHybridMeroora.mvvm.model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybridMeroora.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class MeroViewModel
    {
        public List<MeroOra> Oraallasok { get; set; }=new List<MeroOra>();
        public MeroOra AktualisOraallas { get; set; } = new MeroOra();

        public bool Modositas { get; set; } = false;

        public MeroViewModel()
        {
           // var ujadat = new MeroOra { Termeles = 10, Fogyasztas = 20 };
            // var ujadat2 = new MeroOra { Termeles = 20, Fogyasztas = 42 };
            // UjOraAllas(ujadat);
            // UjOraAllas(ujadat2);

            Adatletoltes();
        }

        public void Adatletoltes()
        {
            Oraallasok = App.MeroRepo.GetItems();
        }

        public void UjOraAllas(MeroOra meroora)
        {
            try
            {
                App.MeroRepo.NewItem(meroora);
                Application.Current.MainPage.DisplayAlert("Info", App.MeroRepo.StatusMsg, "Ok");
                Adatletoltes();
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Hiba", ex.Message, "Ok");                
            }
        }

        public void ModositOraallas(MeroOra meroora) 
        {
            try
            {
                App.MeroRepo.UpdateItem(meroora);
                Application.Current.MainPage.DisplayAlert("Info", App.MeroRepo.StatusMsg, "Ok");
                Adatletoltes();
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Hiba", ex.Message, "Ok");
            }

        }
        public async void TorolOraallas(MeroOra meroora)
        {
            try
            {
                var result = await Application.Current.MainPage.DisplayAlert("Törlés", "Biztosan törli?", "Igen", "Mégse");

                if (result)
                {
                    App.MeroRepo.DeleteItem(meroora);
                    await Application.Current.MainPage.DisplayAlert("Info", App.MeroRepo.StatusMsg, "Ok");
                    Adatletoltes();
                }

                
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Hiba", ex.Message, "Ok");
            }

        }

    }
}
