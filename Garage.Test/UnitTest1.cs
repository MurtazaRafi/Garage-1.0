using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovning5.Vehicles;      //ToDo TEST Hur göra så att hittar Ovning5 garage

namespace Garage.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddCar_Should_AddToTheArray()
        {
            string regNr = "ABc124";
            int nrOfWheels = 4;
            string color = "Red";
            string fueltype = "Gasoline";
            var vehicle = new Car(regNr, nrOfWheels, color, fueltype);
        }
    }
}
