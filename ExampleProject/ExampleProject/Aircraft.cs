﻿using System;
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
            WarpDrive,
            IonDrive
        }

        // Properties
        public float Wingspan { get; set; }
        public int NumEngines { get; set; }
        public EngineType TypeOfEngine { get; set; }
        public bool Winglets { get; set; }
        public int NumWings { get; set; }
        public bool V1 { get; set; }
        public float VR { get; set; }
    }
}
