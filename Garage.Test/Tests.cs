using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovning5;
using Ovning5.Vehicles;

namespace Garage.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        // namnetPåMetodenDuTestar_VadSomTestas_VadSomBörHända
        public void AddVehicle_WithExistingRegNo_ShouldBeAdded()
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
        public void RemoveVehicle_WithExistingRegNo_ShouldBeRemoved()
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

        [TestMethod]
        public void SetNrOfVehicles_NrOfVehiclesInGarage_ShouldSet()
        {
            int ExpectedNrOfVehicles = 5;

            GarageHandler garageHandler = new GarageHandler(5);

            Assert.AreEqual(ExpectedNrOfVehicles, garageHandler.garage.NrOfVehicles);
            // Vfr ger fel?
        }

        [TestMethod]
        public void GetEnumerator_NullCheck_ShouldNotReturnNull()
        {
            GarageHandler garageHandler = new GarageHandler(10);

            Assert.IsNotNull(garageHandler.PrintAll());
        }

    }
}
