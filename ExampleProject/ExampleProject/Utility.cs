using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    public class Utility
    {
        private List<string> _vehicleTypeList;

        public Utility()
        {
            VehicleTypeList = new List<string>();
            VehicleTypeList.Add("Aircraft");
            VehicleTypeList.Add("Automobile");
            VehicleTypeList.Add("Boat");
            VehicleTypeList.Add("Locomotive");
            VehicleTypeList.Add("Vehicle");
        }

        public List<string> VehicleTypes
        {
            get { return VehicleTypeList; }
        }
    }
}
