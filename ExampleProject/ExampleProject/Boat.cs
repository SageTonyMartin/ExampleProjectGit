using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    public class Boat : Vehicle
    {
        private string currentDestination;

        public enum BoatType
        {
            None,
            Canoe, 
            Paddleboat, 
            Rowboat, 
            Sailboat, 
            Catamaran, 
            Fishing, 
            CruiseShip, 
            AircraftCarrier
        }

        public BoatType TypeOfBoat { get; set; }

        /// <summary>
        /// Sets a new destination for the boat.
        /// </summary>
        /// <param name="Destination">The new destination for the boat.</param>
        /// <returns>A displayable string that says where the boat is now headed.</returns>
        public string SetSail(string Destination)
        {
            if (Destination.Length < 1 || Destination.Equals(null))
            {
                throw new ArgumentException("Invalid destination", "Destination");
            }

            // Set the destination.
            currentDestination = Destination;
            return "Your boat has set sail to " + currentDestination + ".";
        }
    }
}
