using System.Collections.Generic;

namespace CarFactory.UMLDiagramClasses
{
    public class Dealer
    {
        public List<Car> Cars { get; set; }
        public List<Car> OrderCars(CarsStorage carsStorage, int carsCount)
        {
            return carsStorage.GetCars(carsCount);
        }
    }
}
