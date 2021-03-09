using System.Collections.Generic;

namespace CarFactory.UMLDiagramClasses
{
    public class CarsStorage : Storage
    {
        public List<Car> Cars { get; set; }

        public List<Car> GetCars(int carsCount)
        {
            List<Car> orderedCars = new List<Car>();
            if (Cars.Count >= carsCount)
            {
                for (int i = 0; i < carsCount; i++)
                    orderedCars.Add(Cars[i]);
            }
            return orderedCars;
        }
    }
}
