using System.Text.Json;

namespace MauiRandom.Pages;

public partial class ListPage : ContentPage
{
	HttpClient client;
	JsonSerializerOptions serializerOptions;
	string baseUrl = "https://randomuser.me/api";

	public ListPage()
	{
		InitializeComponent();
		client = new HttpClient();
		serializerOptions= new JsonSerializerOptions { WriteIndented = true };
	}

    private void buttonGetData_Clicked(object sender, EventArgs e)
    {

    }
}