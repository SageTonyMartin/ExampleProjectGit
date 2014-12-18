using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    /// <summary>
    /// Class to represent the Locomotive vehicle type.
    /// </summary>
    public class Locomotive : Vehicle
    {
        // Add more fuel types as necessary
        public enum FuelType
        {
            None,
            Electric,
            Diesel,
            Maglev,
            Gasoline
        }

        public string Model { get; set; }
        public DateTime Make { get; set; }
        public FuelType TypeOfFuel { get; set; }
        public string TypeOfEngine { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public float HaulingCapacityTons { get; set; }
    }
}
