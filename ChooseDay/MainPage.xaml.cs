using ChooseDay.ViewModels;

namespace ChooseDay;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MyDaysViewModel();

    }
	
}

