using SQLiteCar.MVVM.ViewModels;

namespace SQLiteCar;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
		BindingContext = new CarPageViewModel();
	}
}