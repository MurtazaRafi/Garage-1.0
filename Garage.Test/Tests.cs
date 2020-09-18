using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovning5;
using Ovning5.Vehicles;

namespace Garage.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void AddCar_Should_AddToTheArray()
        {
            string ExpectedRegNr = "ABc124";
            int ExpectedNrOfWheels = 4;
            string ExpectedColor = "Red";
            string ExpectedFueltype = "Gasoline";
            IVehicle ExpectedVehicle = new Car(ExpectedRegNr, ExpectedNrOfWheels, ExpectedColor, ExpectedFueltype);
            GarageHandler garageHandler = new GarageHandler(1);

            Assert.IsTrue(garageHandler.garage.Add(ExpectedVehicle));

            garageHandler.garage.Add(ExpectedVehicle);
            var actual = garageHandler.GetVehicleByRegNr(ExpectedRegNr);

            Assert.AreEqual(ExpectedVehicle, actual);
        }

        [TestMethod]
        public void RemoveVehicle_Should_RemoveFromArray()
        {
            string ExpectedRegNr = "DC34b";
            int ExpectedNrOfWheels = 3;
            string ExpectedColor = "White";
            double ExpectedWingSpan = 10.5;
            IVehicle airplane = new Airplane(ExpectedRegNr, ExpectedNrOfWheels, ExpectedColor, ExpectedWingSpan);
            GarageHandler garageHandler = new GarageHandler(1);
            garageHandler.Add(airplane);
            string ExpectedString = "";

            Assert.IsTrue(garageHandler.garage.Remove(ExpectedRegNr));
            
            var actual = garageHandler.PrintAll();
            Assert.AreEqual(ExpectedString, actual);
        
        }

    }
}
