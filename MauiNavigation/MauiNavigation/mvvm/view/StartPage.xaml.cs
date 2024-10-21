namespace MauiNavigation.mvvm.view;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void buttonTovabb_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MiddlePage());
    }
}