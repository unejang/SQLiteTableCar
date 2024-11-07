using SQLiteCar.Repositories;

namespace SQLiteCar;

public partial class App : Application
{
	public static CarRepository _carRepo {get ; set;}
	public App(CarRepository carRepo)
	{
		InitializeComponent();

		_carRepo = carRepo;

		//MainPage = new AppShell();
		MainPage = new CarPage();
	}
}
