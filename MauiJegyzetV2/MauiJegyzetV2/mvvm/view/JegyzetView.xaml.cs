using MauiJegyzetV2.mvvm.viewmodel;

namespace MauiJegyzetV2.mvvm.view;

public partial class JegyzetView : ContentPage
{
	public JegyzetView()
	{
		InitializeComponent();
        BindingContext = new JegyzetViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var vm=BindingContext as JegyzetViewModel;
        Navigation.PushAsync(new UjJegyzetView(vm));
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        var vm = BindingContext as JegyzetViewModel;
        if (vm.AktJegyzet != null) {
            Navigation.PushAsync(new ModositJegyzetView(vm));
        }
    }
}