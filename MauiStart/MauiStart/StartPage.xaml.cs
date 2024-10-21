namespace MauiStart;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void buttonIr_Clicked(object sender, EventArgs e)
    {
		labelSzoveg.Text = entrySzoveg.Text;
		
    }
}