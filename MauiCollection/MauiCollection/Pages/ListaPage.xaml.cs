using MauiCollection.Model;
using System.Collections.ObjectModel;

namespace MauiCollection.Pages;

public partial class ListaPage : ContentPage
{
	ObservableCollection<Hegy> Hegyek { get; set; } = new ObservableCollection<Hegy>();
	public ListaPage()
	{
		InitializeComponent();
		
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await LoadMauiAsset();
		BindingContext = Hegyek;
    }

    async Task LoadMauiAsset()
	{
		using var stream = await FileSystem.OpenAppPackageFileAsync("hegyekMo.txt");
		using var reader = new StreamReader(stream);
		reader.ReadLine();
		while (!reader.EndOfStream)
		{
			Hegyek.Add(new Hegy(reader.ReadLine()));
		}
	}

    private async void buttonSzures_Clicked(object sender, EventArgs e)
    {
		try
		{
			var result = Hegyek.Where(x => x.Magassag >= Convert.ToInt32(entryMagassag.Text));
			if (result.Count() > 0)
			{
				collectionHegyek.ItemsSource = result;
			} else
			{
				await DisplayAlert("Info", "Nincs találat!", "Ok");
			}

		}
		catch (Exception ex)
		{
			await DisplayAlert("Hiba!", ex.Message, "Ok");			
		}
    }

    private void buttonVissza_Clicked(object sender, EventArgs e)
    {
		collectionHegyek.ItemsSource= Hegyek;
    }
}

