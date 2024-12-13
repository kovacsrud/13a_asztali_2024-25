using MauiJegyzetV2.mvvm.model;
using MauiJegyzetV2.mvvm.viewmodel;
using PropertyChanged;

namespace MauiJegyzetV2.mvvm.view;

[AddINotifyPropertyChangedInterface]
public partial class UjJegyzetView : ContentPage
{
	public Jegyzet UjJegyzet { get; set; }=new Jegyzet();
	public JegyzetViewModel ViewModel { get; set; }
	public UjJegyzetView(JegyzetViewModel viewModel)
	{
		InitializeComponent();
		ViewModel = viewModel;
		BindingContext = this;
	}

    private async void buttonUj_Clicked(object sender, EventArgs e)
    {
		var result = await DisplayAlert("Új jegyzet", "Biztosan rögzíti", "Igen", "Mégse");
		if (result)
		{
			App.JegyzetRepo.NewItem(UjJegyzet);
			ViewModel.GetJegyzetek();
		}
    }
}