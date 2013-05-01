using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    public class Aircraft : Vehicle
    {
        public enum EngineType
        {
            None,
            Reciprocating,
            Turboprop,
            Turbojet,
            Turbofan,
            HighBypassTurbofan,
            DuctedFan,
            UnductedFan,
            Ramjet,
            IonDrive,
            FissionDrive,
            FusionDrive
            WarpDrive
        }

        // Public properties
        public float Wingspan { get; set; }
        public int NumEngines { get; set; }
        public EngineType TypeOfEngine { get; set; }
        public bool Winglets { get; set; }   // Customers requested a Winglets property
        public int CrewSize { get; set; }
        public int PassengerCapacity { get; set, }
    }
}
