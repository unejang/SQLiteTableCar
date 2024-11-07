using System;
using System.Windows.Input;
using PropertyChanged;
using SQLiteCar.MVVM.Models;

namespace SQLiteCar.MVVM.ViewModels;

[AddINotifyPropertyChangedInterface]
public class CarPageViewModel
{
    public List<Car> Cars { get; set; }
    public Car CurrentCar { get; set; }
    public ICommand AddOrUpdateCommand { get; set; }
    public ICommand DeleteCommand { get; set; }
    public CarPageViewModel()
    {
        this.Refresh();
        AddOrUpdateCommand = new Command(async () =>
        {
            App._carRepo.AddOrUpdate(CurrentCar);
            Console.WriteLine(App._carRepo.StatusMessage);
            this.Refresh();
        });

        DeleteCommand = new Command(async () => {
            App._carRepo.Delete(CurrentCar.ID);
            this.Refresh();
        });
    }
    private void Refresh()
    {
        CurrentCar = new Car();

        this.Cars = App._carRepo.GetAll();
    }
}
