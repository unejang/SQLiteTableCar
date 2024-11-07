using System;
using SQLite;

namespace SQLiteCar.MVVM.Models;

public class Car
{
    [PrimaryKey , AutoIncrement]
    public int ID { get ; set ;}
    
    [Column("car_id")]
    public string CarId { get; set; }
    
    [Column("model")]
    public string Model { get; set; }
    
    [Column("color")]
    public string Color { get; set; }


}

