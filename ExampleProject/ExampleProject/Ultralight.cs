using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    public class Ultralight : Aircraft
    {
        public string Model { get; set; }
        public bool RequiresPilotsLicense { get; set; }
        public string SailMaterial { get; set; }
    }
}
