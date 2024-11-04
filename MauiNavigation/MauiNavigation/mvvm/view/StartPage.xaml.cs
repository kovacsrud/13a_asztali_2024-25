using MauiNavigation.mvvm.viewmodel;

namespace MauiNavigation.mvvm.view;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
		BindingContext = new PageViewModel();
	}

    private void buttonTovabb_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MiddlePage());
    }
}