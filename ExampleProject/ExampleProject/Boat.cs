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
        
        // Enum for boat type - add more as more types of boats are invented.
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
            Destroyer,
            AircraftCarrier,
            Rafting,
            Dingy
        }

        /// <summary>
        /// Gets/sets type of boat.
        /// </summary>
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
