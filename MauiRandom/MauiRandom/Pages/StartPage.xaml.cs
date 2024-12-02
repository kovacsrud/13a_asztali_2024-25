namespace MauiRandom.Pages;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void buttonStart_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ListPage());
    }
}