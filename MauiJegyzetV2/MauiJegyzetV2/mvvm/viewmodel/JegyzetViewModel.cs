using MauiJegyzetV2.mvvm.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;

namespace MauiJegyzetV2.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class JegyzetViewModel
    {
        public List<Jegyzet> Jegyzetek { get; set; }=new List<Jegyzet>();
        public Jegyzet AktJegyzet { get; set; }

        public ICommand UpdateCommand {  get; set; }
        public ICommand DeleteCommand { get; set; }

        public JegyzetViewModel()
        {
            GetJegyzetek();
            UpdateCommand = new Command(async () => {

                var result = await Application.Current.MainPage.DisplayAlert("Jegyzet módosítása","Biztosan módosítja?","Igen","Mégse");
                if (result)
                {
                    App.JegyzetRepo.UpdateItem(AktJegyzet);
                    await Application.Current.MainPage.DisplayAlert("Módosítás", App.JegyzetRepo.StatusMsg, "Ok");
                    GetJegyzetek();
                }
                
            });

            DeleteCommand = new Command(async () => {

                var result = await Application.Current.MainPage.DisplayAlert("Jegyzet törlése", "Biztosan törli?", "Igen", "Mégse");
                if (result)
                {
                    App.JegyzetRepo.DeleteItem(AktJegyzet);
                    await Application.Current.MainPage.DisplayAlert("Törlés", App.JegyzetRepo.StatusMsg, "Ok");
                    GetJegyzetek();
                }
            });
        }

        public void GetJegyzetek()
        {
            Jegyzetek = App.JegyzetRepo.GetItems();
        }

    }
}
