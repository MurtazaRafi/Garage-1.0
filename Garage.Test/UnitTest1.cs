using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovning5;
using Ovning5.Vehicles;    

namespace Garage.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddCar_Should_AddToTheArray()
        {
            string ExpectedRegNr = "ABc124";
            int ExpectedNrOfWheels = 4;
            string ExpectedColor = "Red";
            string ExpectedFueltype = "Gasoline";
            var vehicle = new Car(ExpectedRegNr, ExpectedNrOfWheels, ExpectedColor, ExpectedFueltype);
            GarageHandler garageHandler = new GarageHandler(1);

            Assert.IsTrue(garageHandler.garage.Add(vehicle));

            //var actual = garageHandler.GetVehicleByRegNr(ExpectedRegNr);
            //Assert.AreEqual(ExpectedRegNr, actual); 
            //$"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}"
        }
    }
}
