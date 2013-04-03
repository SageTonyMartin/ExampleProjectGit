using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleProject;

namespace ExampleProjectTests
{
    [TestClass]
    public class ExampleProjectTests
    {

        private Vehicle _vehicle;
        private Aircraft _aircraft;
        private Automobile _car;
        private Boat _boat;
        private Locomotive _loco;
        private Fleet _fleet;

        [AssemblyInitialize]
        public static void InitTests(TestContext tc)
        {
        }

        [TestMethod]
        public void CreateVehicle()
        {
            _vehicle = new Vehicle();
            Assert.IsNotNull(_vehicle);
        }

        [TestMethod]
        public void CreateAircraft()
        {
            _aircraft = new Aircraft();
            Assert.IsNotNull(_aircraft);
        }

        [TestMethod]
        public void CreateAutomobile()
        {
            _car = new Automobile();
            Assert.IsNotNull(_car);
        }

        [TestMethod]
        public void CreateBoat()
        {
            _boat = new Boat();
            Assert.IsNotNull(_boat);
        }

        [TestMethod]
        public void CreateLocomotive()
        {
            _loco = new Locomotive();
            Assert.IsNotNull(_loco);
        }

        [TestMethod]
        public void CreateFleet()
        {
            // Test fleet creation.
            _fleet = new Fleet();
            Assert.IsNotNull(_fleet);
        }

        [TestMethod]
        public void TestVehicleAttributes()
        {
            _vehicle = new Vehicle();
            if (!_vehicle.Equals(null))
            {
                // Valid normal values
                _vehicle.MaxSpeed = 1000;
                _vehicle.NumPassengers = 4;
                Assert.AreEqual(1000, _vehicle.MaxSpeed);
                Assert.AreEqual(4, _vehicle.NumPassengers);

                // Low boundary conditions
                _vehicle.NumPassengers = 0;
                _vehicle.MaxSpeed = 0;
                Assert.AreEqual(0, _vehicle.NumPassengers);
                Assert.AreEqual(0, _vehicle.MaxSpeed); // This should work now.

                // High boundary conditions
                _vehicle.NumPassengers = int.MaxValue;
                _vehicle.MaxSpeed = int.MaxValue;
                Assert.AreEqual(int.MaxValue, _vehicle.NumPassengers);
                Assert.AreEqual(int.MaxValue, _vehicle.MaxSpeed);
            }
        }

        [TestMethod]
        public void TestAircraftAttributes()
        {
            _aircraft = new Aircraft();
            if (!_aircraft.Equals(null))
            {
                // Valid normal values
                _aircraft.MaxSpeed = 1000;
                _aircraft.NumPassengers = 4;
                _aircraft.NumEngines = 2;
                _aircraft.Wingspan = 272.5F;
                // Test default value of EngineType before it is set to see if it picks up the default.
                Assert.AreEqual(Aircraft.EngineType.None, _aircraft.TypeOfEngine);
                _aircraft.TypeOfEngine = Aircraft.EngineType.HighBypassTurbofan;
                Assert.AreEqual(1000, _aircraft.MaxSpeed);
                Assert.AreEqual(4, _aircraft.NumPassengers);
                Assert.AreEqual(2, _aircraft.NumEngines);
                Assert.AreEqual(272.5F, _aircraft.Wingspan);
                Assert.AreEqual(Aircraft.EngineType.HighBypassTurbofan, _aircraft.TypeOfEngine);

                // Low boundary conditions
                _aircraft.NumPassengers = 0;
                _aircraft.MaxSpeed = 0;
                _aircraft.Wingspan = 0.0F;
                _aircraft.NumEngines = 0;
                Assert.AreEqual(0, _aircraft.NumPassengers);
                Assert.AreEqual(0, _aircraft.MaxSpeed);
                Assert.AreEqual(0.0F, _aircraft.Wingspan);
                Assert.AreEqual(0, _aircraft.NumEngines);

                // High boundary conditions
                _aircraft.NumPassengers = int.MaxValue;
                _aircraft.MaxSpeed = int.MaxValue;
                _aircraft.Wingspan = float.MaxValue;
                _aircraft.NumEngines = int.MaxValue;
                Assert.AreEqual(int.MaxValue, _aircraft.NumPassengers);
                Assert.AreEqual(int.MaxValue, _aircraft.MaxSpeed);
                Assert.AreEqual(float.MaxValue, _aircraft.Wingspan);
                Assert.AreEqual(int.MaxValue, _aircraft.NumEngines);
            }
        }

        [TestMethod]
        public void TestAutomobileAttributes()
        {
            _car = new Automobile();
            if (!_car.Equals(null))
            {
                // Valid normal values
                _car.MaxSpeed = 160;
                _car.NumPassengers = 4;
                _car.EngineDisplacement = 2.8F;
                _car.Manufacturer = "Scion";
                _car.Model = "tC";
                _car.HorsePower = 240;
                Assert.AreEqual(160, _car.MaxSpeed);
                Assert.AreEqual(4, _car.NumPassengers);
                Assert.AreEqual(2.8F, _car.EngineDisplacement);
                Assert.AreEqual("Scion", _car.Manufacturer);
                Assert.AreEqual("tC", _car.Model);
                Assert.AreEqual(240, _car.HorsePower);

                // Low boundary conditions
                _car.NumPassengers = 0;
                _car.MaxSpeed = 0;
                _car.EngineDisplacement = 0.0F;
                _car.Manufacturer = "";
                _car.Model = "";
                _car.HorsePower = 0;
                Assert.AreEqual(0, _car.NumPassengers);
                Assert.AreEqual(0, _car.MaxSpeed);
                Assert.AreEqual(0.0F, _car.EngineDisplacement);
                Assert.AreEqual("", _car.Manufacturer);
                Assert.AreEqual("", _car.Model);
                Assert.AreEqual(0, _car.HorsePower);

                // High boundary conditions
                _car.NumPassengers = int.MaxValue;
                _car.MaxSpeed = int.MaxValue;
                _car.EngineDisplacement = 2.8F;
                _car.HorsePower = int.MaxValue;
                Assert.AreEqual(int.MaxValue, _car.NumPassengers);
                Assert.AreEqual(int.MaxValue, _car.MaxSpeed);
                Assert.AreEqual(2.8F, _car.EngineDisplacement);
                Assert.AreEqual(int.MaxValue, _car.HorsePower);
            }
        }

        [TestMethod]
        public void TestBoatAttributes()
        {
            _boat = new Boat();
            if (!_boat.Equals(null))
            {
                // Valid normal values
                _boat.MaxSpeed = 1000;
                _boat.NumPassengers = 4;
                // Check for default BoatType value before assignment.
                Assert.AreEqual(Boat.BoatType.None, _boat.TypeOfBoat);
                _boat.TypeOfBoat = Boat.BoatType.Sailboat;
                Assert.AreEqual(1000, _boat.MaxSpeed);
                Assert.AreEqual(4, _boat.NumPassengers);

                // Low boundary conditions
                _boat.NumPassengers = 0;
                _boat.MaxSpeed = 0;
                Assert.AreEqual(0, _boat.NumPassengers);
                Assert.AreEqual(0, _boat.MaxSpeed);

                // High boundary conditions
                _boat.NumPassengers = int.MaxValue;
                _boat.MaxSpeed = int.MaxValue;
                Assert.AreEqual(int.MaxValue, _boat.NumPassengers);
                Assert.AreEqual(int.MaxValue, _boat.MaxSpeed);
            }
        }

        [TestMethod]
        public void TestSetSailMethod()
        {
            _boat = new Boat();
            string dest = _boat.SetSail("Bora Bora");
            Assert.AreEqual("Your boat has set sail to Bora Bora.", dest);
        }

        [TestMethod]
        public void TestLocomotiveAttributes()
        {
            _loco = new Locomotive();
            if (!_loco.Equals(null))
            {
                // Valid normal values
                _loco.MaxSpeed = 95;
                _loco.NumPassengers = 2;
                _loco.HaulingCapacityTons = 3000.0F;
                _loco.LastMaintenanceDate = Convert.ToDateTime("06/15/2012");
                _loco.Manufacturer = "General Motors";
                _loco.Model = "GP38-2";
                _loco.TypeOfEngine = "16-645E, 16 cylinder, roots-blown, GM Diesel";
                Assert.AreEqual(Locomotive.FuelType.None, _loco.TypeOfFuel);
                _loco.TypeOfFuel = Locomotive.FuelType.Diesel;
                Assert.AreEqual(95, _loco.MaxSpeed);
                Assert.AreEqual(2, _loco.NumPassengers);
                Assert.AreEqual(3000.0F, _loco.HaulingCapacityTons);
                Assert.AreEqual(new DateTime(2012, 6, 15), _loco.LastMaintenanceDate);
                Assert.AreEqual("General Motors", _loco.Manufacturer);
                Assert.AreEqual("GP38-2", _loco.Model);
                Assert.AreEqual("16-645E, 16 cylinder, roots-blown, GM Diesel", _loco.TypeOfEngine);
                Assert.AreEqual(Locomotive.FuelType.Diesel, _loco.TypeOfFuel);

                // Low boundary conditions
                _loco.NumPassengers = 0;
                _loco.MaxSpeed = 0;
                _loco.HaulingCapacityTons = 0.0F;
                _loco.Manufacturer = "";
                _loco.Model = "";
                _loco.TypeOfEngine = "";
                Assert.AreEqual(0, _loco.NumPassengers);
                Assert.AreEqual(0, _loco.MaxSpeed);
                Assert.AreEqual(0.0F, _loco.HaulingCapacityTons);
                Assert.AreEqual("", _loco.Manufacturer);
                Assert.AreEqual("", _loco.Model);
                Assert.AreEqual("", _loco.TypeOfEngine);

                // High boundary conditions
                _loco.NumPassengers = int.MaxValue;
                _loco.MaxSpeed = int.MaxValue;
                _loco.HaulingCapacityTons = float.MaxValue;
                Assert.AreEqual(int.MaxValue, _loco.NumPassengers);
                Assert.AreEqual(int.MaxValue, _loco.MaxSpeed);
                Assert.AreEqual(float.MaxValue, _loco.HaulingCapacityTons);
            }
        }
    }
}
