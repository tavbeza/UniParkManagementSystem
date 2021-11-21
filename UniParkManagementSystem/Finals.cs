using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniParkManagementSystem
{
   sealed class Finals
   {
      public static Dictionary<string, VehicleType[]> classAndTypeDict = new Dictionary<string, VehicleType[]>()
      {
         ["A"] = new VehicleType[] { VehicleType.Crossover, VehicleType.Private, VehicleType.Motorcycle },
         ["B"] = new VehicleType[] { VehicleType.SUV, VehicleType.Van },
         ["C"] = new VehicleType[] { VehicleType.Truck }
      };
      public enum VehicleType
      {
         Motorcycle , Private, Crossover, // Class A 
         SUV, Van, // Class B
         Truck
      } // Class C

      public enum TicketType
      {
         VIP, Value, Regular
      }

      public readonly int MAX_LOTS = 60;

      public readonly int VIP_TICKET_MAX_LOT = 9;
      public readonly int VIP_TICKET_MIN_LOT = 0;

      public readonly int VALUE_TICKET_MAX_LOT = 29;
      public readonly int VALUE_TICKET_MIN_LOT = 10;

      public readonly int REGULAR_TICKET_MAX_LOT = 59;
      public readonly int REGULAR_TICKET_MIN_LOT = 30;

   }
}
