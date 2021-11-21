using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniParkManagementSystem
{
   class User
   {
      public string Name { get; set; }
      public string Phone { get; set; }

      public User()
      {
      }

      public User(string name, string phone)
      {
         Name = name;
         Phone = phone;
      }

      public override string ToString()
      {
         return Name + " " + Phone;
      }
   }
}