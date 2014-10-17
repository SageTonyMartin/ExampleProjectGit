using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    /// <summary>
    /// Class represents an Aircraft.
    /// </summary>
    public class Aircraft : Vehicle
    {
        // Enum for aircarft engine type
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
            WarpDrive,
            IonDrive,
            RubberBand,
            FusionDrive
        }

        // Properties
        public float StallSpeed { get; set; }
        public float Wingspan { get; set; }
        public int NumEngines { get; set; }
        public EngineType TypeOfEngine { get; set; }
        public bool Winglets { get; set; }
        public int NumWings { get; set; }
        public bool V1 { get; set; }
        public float VR { get; set; }
    }
}
