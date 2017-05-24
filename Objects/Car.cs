using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car{
    private string _model;
    // public string _color{get;set;};
    private string _year;
    private string _mileage;
    private static List<Car> _carDirectory = new List<Car>{};
    public Car(string makeModel, string year, string mileage)
    {
      _model = makeModel;
      _year = year;
      _mileage = mileage;
    }
    public string GetModel()
    {
      return _model;
    }
    public string GetYear()
    {
      return _year;
    }
    public string GetMileage()
    {
      return _mileage;
    }

    public void AddToList()
    {
      _carDirectory.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _carDirectory;
    }
  }
}
