using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    /// <summary>
    /// Base class for all vehicle types.
    /// </summary>
    public class Vehicle
    {
        public int MaxSpeed { get; set; }
        public int NumPassengers { get; set; }
        public string Manufacturer { get; set; }
        public float Range { get; set; }
    }
}
