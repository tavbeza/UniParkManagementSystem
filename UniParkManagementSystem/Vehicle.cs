using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniParkManagementSystem
{
   class Vehicle
   {
      public string LicensePlateId { get; set; }
      public Finals.VehicleType Type { get; set; }
      public int Height { get; set; }
      public int Width { get; set; }
      public int Length { get; set; }
      public User User { get; set; }

      

   }
}
