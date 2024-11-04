namespace MauiNavigation.mvvm.view;

public partial class EndPage : ContentPage
{
	public EndPage()
	{
		InitializeComponent();
	}

    private void buttonVissza_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private void buttonStartPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}