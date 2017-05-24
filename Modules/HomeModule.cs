using Nancy;
// using Cars.Objects;
using System.Collections.Generic;

namespace Cars.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/car_added"] = _ => {
        Car myCar = new Car(Request.Form["model"], Request.Form["year"], Request.Form["mileage"]);
        myCar.AddToList();
        return View["car_added.cshtml", myCar];
      };

      Get["/allCars"] = _ => {
        List<Car> carDirectory = Car.GetAll();
        return View["allCars.cshtml", carDirectory];
      };
    }
  }
}
