using MauiJegyzetV2.mvvm.viewmodel;

namespace MauiJegyzetV2.mvvm.view;

public partial class ModositJegyzetView : ContentPage
{
	public ModositJegyzetView(JegyzetViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}