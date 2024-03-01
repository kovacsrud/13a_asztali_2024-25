using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfKutyakSqlite.mvvm.models;
using PropertyChanged;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace WpfKutyakSqlite.mvvm.viewmodels
{
    [AddINotifyPropertyChangedInterface]
    public class KutyaViewModel
    {
        KutyakContext context;
        public ObservableCollection<Kutya> Kutyak { get; set; }
        public ObservableCollection<Kutyafajtak> Kutyafajtak { get; set; }
        public ObservableCollection<Kutyanevek> Kutyanevek { get; set; }

        public Kutya SelectedKutya { get; set; }

        public KutyaViewModel()
        {
            context = new KutyakContext();
            context.Kutyak.Load();
            context.Kutyanevek.Load();
            context.Kutyafajtak.Load();
            Kutyak = context.Kutyak.Local.ToObservableCollection();
            Kutyanevek=context.Kutyanevek.Local.ToObservableCollection();
            Kutyafajtak=context.Kutyafajtak.Local.ToObservableCollection(); 
        }

        public void DbMentes()
        {
            try
            {
                var valasz = MessageBox.Show("Biztosan menti?", "Mentés", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (valasz==MessageBoxResult.OK)
                {
                    var result = context.SaveChanges();
                    if (result>0)
                    {
                        MessageBox.Show("Adatok mentve!");
                    } else
                    {
                        MessageBox.Show("Nem változtak az adatok!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

    } 
}
