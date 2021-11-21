using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniParkManagementSystem
{
   abstract class Ticket
   {
      public Finals finals = new Finals();
      public int[] LotIndexes { get; set; }
      public int HeightLimit { get; set; }
      public int WidthLimit { get; set; }
      public int LengthLimit { get; set; }
      public List<string> Classes { get; set; }
      public int Cost { get; set; }
      public bool IsTimeLimit { get; set; }
      public int TimeLimit { get; set; }

      public Ticket()
      {
         Classes = new List<string>();
      }
   }

   class TicketVIP : Ticket
   {
      public TicketVIP()
      {
         LotIndexes = new int[finals.VIP_TICKET_MAX_LOT - finals.VIP_TICKET_MIN_LOT + 1];
         Classes.Add("A");
         Classes.Add("B");
         Classes.Add("C");
         Cost = 200;
         IsTimeLimit = false;
         TimeLimit = 0;
      }
   }

   class TicketValue : Ticket
   {
      public TicketValue()
      {
         LotIndexes = new int[finals.VALUE_TICKET_MAX_LOT - finals.VALUE_TICKET_MIN_LOT + 1];
         HeightLimit = 2500;
         WidthLimit = 2400;
         LengthLimit = 5000;
         Classes.Add("A");
         Classes.Add("B");
         Cost = 100;
         IsTimeLimit = true;
         TimeLimit = 72;
      }
   }

   class TicketRegular : Ticket
   {
      public TicketRegular()
      {
         LotIndexes = new int[finals.REGULAR_TICKET_MAX_LOT - finals.REGULAR_TICKET_MIN_LOT + 1];
         HeightLimit = 2000;
         WidthLimit = 2000;
         LengthLimit = 3000;
         Classes.Add("A");
         Cost = 50;
         IsTimeLimit = true;
         TimeLimit = 24;
      }
   }
}
