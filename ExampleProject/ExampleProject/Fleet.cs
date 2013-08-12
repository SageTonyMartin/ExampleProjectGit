using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    /// <summary>
    /// Contains a list of vehicles organized into a fleet.
    /// </summary>
    public class Fleet
    {
        // Public properties.
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Vehicle> VehicleList { get; set; }
        public decimal CurrentValue { get; set; }
        public int Count { get; set; }
        public float DisplacementInTons { get; set; }
    }
}
