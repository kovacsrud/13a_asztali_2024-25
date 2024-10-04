using Microsoft.EntityFrameworkCore;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfKutyakEFUnique.mvvm.models;

namespace WpfKutyakEFUnique.mvvm.viewmodels
{
    [AddINotifyPropertyChangedInterface]
    public class KutyaViewModel
    {
        KutyakGoodUniqueContext context;
        public ObservableCollection<Kutya> Kutyak { get; set; }
        public ObservableCollection<Kutyanevek> Kutyanevek { get; set; }
        public ObservableCollection<Kutyafajtak> Kutyafajtak { get; set; }

        public Kutya SelectedKutya { get; set; }

        public KutyaViewModel()
        {
            context= new KutyakGoodUniqueContext();
            context.Kutyas.Load();
            context.Kutyaneveks.Load();
            context.Kutyafajtaks.Load();
            Kutyak=context.Kutyas.Local.ToObservableCollection(); 
            Kutyafajtak=context.Kutyafajtaks.Local.ToObservableCollection();
            Kutyanevek=context.Kutyaneveks.Local.ToObservableCollection();

        }

        public void DbMentes()
        {
            try
            {
                var result=context.SaveChanges();
                if (result>0)
                {
                    MessageBox.Show("Adatok mentve");
                } else
                {
                    MessageBox.Show("Nincs változás");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
