using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    public class Aircraft : Vehicle
    {
        // Engine type for the Aircraft class
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
            PulseJet,
            IonDrive,
            FissionDrive,
            FusionDrive,
            WarpDrive
        }

        // Public properties
        public float Wingspan { get; set; }
        public int NumEngines { get; set; }
        public EngineType TypeOfEngine { get; set; }
        public bool Winglets { get; set; }
    }
}
