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
            var v = new Car(ExpectedRegNr, ExpectedNrOfWheels, ExpectedColor, ExpectedFueltype);
            GarageHandler garageHandler = new GarageHandler(1);
            string ExpectedOutput =$"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}";

            Assert.IsTrue(garageHandler.garage.Add(v));
            garageHandler.garage.Add(v);
            var actual = garageHandler.GetVehicleByRegNr(ExpectedRegNr);
            
            Assert.AreEqual(ExpectedOutput, actual);
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

            Assert.IsTrue(garageHandler.garage.Remove(ExpectedRegNr));
            


        }

    }
}
