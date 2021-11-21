using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniParkManagementSystem
{
   class Lot
   {
      public int LotId { get; set; }
      public int TimeLimit { get; set; }
      public DateTime CheckInTime { get; set; }
      public int VehicleLicensePlateId { get; set; }
   }
}
