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
            _vehicleTypeList = new List<string>();
            _vehicleTypeList.Add("Aircraft");
            _vehicleTypeList.Add("Automobile");
            _vehicleTypeList.Add("Boat");
            _vehicleTypeList.Add("Locomotive");
            _vehicleTypeList.Add("Vehicle");
        }

        public List<string> VehicleTypes
        {
            get { return _vehicleTypeList; }
        }
    }
}
