using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniParkManagementSystem.DataAccess.DataObjects;

namespace UniParkManagementSystem
{
   public partial class UserDetailsForm : Form
   {
      UniParkDBDataContext dataContext = new UniParkDBDataContext();

      Finals.VehicleType VehicleType;
      TblVehicle tblVehicle = new TblVehicle();

      TblLot tblLot = new TblLot();

      Ticket ticket;
      Finals f = new Finals();
      public string LicensePlateId { get; set; }
      bool IsExistUser = false;

      ErrorProvider error = new ErrorProvider();

      public UserDetailsForm()
      {
         tblVehicle.LicensePlateId = LicensePlateId;
         InitializeComponent();
      }

      public UserDetailsForm(string userName, string userPhone)
      {
         IsExistUser = true;
         tblVehicle.LicensePlateId = LicensePlateId;
         InitializeComponent();
         input_name.Text = userName;
         input_phone.Text = userPhone;
      }

      private void InitVehicle()
      {
         // Generate Vehicle License Plate ID
         tblVehicle.LicensePlateId = LicensePlateId;

         // Generate Vehicle User
         tblVehicle.User = input_name.Text + " " + input_phone.Text;

         // Generate Vehicle Type
         string vType = comboBox_vehicleType.Text;
         foreach (Finals.VehicleType type in Enum.GetValues(typeof(Finals.VehicleType)))
         {
            if (type.ToString().Equals(vType))
            {
               VehicleType = type;
               tblVehicle.VehicleType = type.ToString();
            }
         }

         // Generate Vehicle Dimensions
         tblVehicle.VehicleHeight = int.Parse(input_vehicleHeight.Text);
         tblVehicle.VehicleWidth = int.Parse(input_vehicleWidth.Text);
         tblVehicle.VehicleLength = int.Parse(input_vehicleLength.Text);
      }

      private void InitTicket()
      {
         string ticketType = comboBox_ticketType.Text; // VIP, Value, Regular
         bool isVehicalTypeClassCorrect = false;
         
         if (ticketType.Equals("VIP"))
         {
            ticket = new TicketVIP();
         }
         else if (ticketType.Equals("Value")) 
         {
            ticket = new TicketValue(); // Value ticket get Classes A,B

            List<string> classes = ticket.Classes;
            foreach (var c in classes)
            {
               Finals.VehicleType[] vt;
               Finals.classAndTypeDict.TryGetValue(c, out vt);

               if (vt.Contains(VehicleType))
               {
                  isVehicalTypeClassCorrect = true;
                  break;
               }
            }

            if (tblVehicle.VehicleHeight > ticket.HeightLimit ||
               tblVehicle.VehicleWidth > ticket.WidthLimit ||
               tblVehicle.VehicleLength > ticket.LengthLimit ||
               isVehicalTypeClassCorrect == false)
            {
               int oldPrice = ticket.Cost;
               ticket = new TicketVIP();
               int diffPrice = ticket.Cost - oldPrice;

               MessageBox.Show(
                  "You need to trade to VIP ticket.\nThe money that added: " + diffPrice.ToString(),
                  "Error Dimensions",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                  );
            }
         }
         else if (ticketType.Equals("Regular"))
         {
            ticket = new TicketRegular();
            int oldPrice = ticket.Cost;

            List<string> classes = ticket.Classes;
            foreach (var c in classes)
            {
               Finals.VehicleType[] vt;
               Finals.classAndTypeDict.TryGetValue(c, out vt);

               if (vt.Contains(VehicleType))
               {
                  isVehicalTypeClassCorrect = true;
                  break;
               }
            }

            if (tblVehicle.VehicleHeight > ticket.HeightLimit ||
               tblVehicle.VehicleWidth > ticket.WidthLimit ||
               tblVehicle.VehicleLength > ticket.LengthLimit ||
               isVehicalTypeClassCorrect == false)
            {
               ticket = new TicketValue();

               if (tblVehicle.VehicleHeight <= ticket.HeightLimit &&
               tblVehicle.VehicleWidth <= ticket.WidthLimit &&
               tblVehicle.VehicleLength <= ticket.LengthLimit)
               {
                  int diffPrice = ticket.Cost - oldPrice;
                  MessageBox.Show(
                  "You need to trade to Value ticket.\nThe money that added: " + diffPrice.ToString(),
                  "Error Dimensions",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                  );
               }
               else
               {
                  ticket = new TicketVIP();
                  int diffPrice = ticket.Cost - oldPrice;
                  MessageBox.Show(
                  "You need to trade to VIP ticket.\nThe money that added: " + diffPrice.ToString(),
                  "Error Dimensions",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                  );
               }


            }
         }
      }

      private bool InitLot() // Return true when the lot generated
      {
         bool isThereFreeLot = false;

         TblLot[] lotsArray = new TblLot[f.MAX_LOTS];
         IEnumerable<TblLot> qLots;
         qLots = dataContext.TblLots.Select(l => l);

         for (int i = 0; i < f.MAX_LOTS; i++)
         {
            lotsArray[i] = new TblLot();
         }

         foreach (var l in qLots)
         {
            lotsArray[l.LodId].LodId = l.LodId;
            lotsArray[l.LodId].TimeLimit = l.TimeLimit;
            lotsArray[l.LodId].CheckInTime = l.CheckInTime;
            lotsArray[l.LodId].VehicleLicensePlateId = l.VehicleLicensePlateId;
            }

         //lotsArray = (TblLot[])qLots;

         if (ticket.GetType().Equals(typeof(TicketVIP)))
         {
            tblLot.TimeLimit = 8760;
            tblLot.CheckInTime = DateTime.Now;
            tblLot.VehicleLicensePlateId = LicensePlateId;

            if (dataContext.TblLots.Any()) // if there is any elements
            {
               for (int i = f.VIP_TICKET_MIN_LOT; i <= f.VIP_TICKET_MAX_LOT; i++)
               {
                  if(lotsArray[i].VehicleLicensePlateId == null)
                  {
                     tblLot.LodId = i;
                     isThereFreeLot = true;
                     break;
                  }
               }
            }
            else // The TblLots is empty
            {
               tblLot.LodId = f.VIP_TICKET_MIN_LOT;
               isThereFreeLot = true;
            }
         }
         else if (ticket.GetType().Equals(typeof(TicketValue)))
         {
            tblLot.TimeLimit = 72;
            tblLot.CheckInTime = DateTime.Now;
            tblLot.VehicleLicensePlateId = LicensePlateId;

            if (dataContext.TblLots.Any()) // if there is any elements
            {
               for (int i = f.VALUE_TICKET_MIN_LOT; i <= f.VALUE_TICKET_MAX_LOT; i++)
               {
                  if (lotsArray[i].VehicleLicensePlateId == null) // free lot
                  {
                     tblLot.LodId = i;
                     isThereFreeLot = true;
                     break;
                  }
               }
            }
            else // The TblLots is empty
            {
               tblLot.LodId = f.VALUE_TICKET_MIN_LOT;
               isThereFreeLot = true;
            }
         }
         else
         {
            tblLot.TimeLimit = 24;
            tblLot.CheckInTime = DateTime.Now;
            tblLot.VehicleLicensePlateId = LicensePlateId;

            if (dataContext.TblLots.Any()) // if there is any elements
            {
               for (int i = f.REGULAR_TICKET_MIN_LOT; i <= f.REGULAR_TICKET_MAX_LOT; i++)
               {
                  if (lotsArray[i].VehicleLicensePlateId == null) // free lot
                  {
                     tblLot.LodId = i;
                     isThereFreeLot = true;
                     break;
                  }
               }
            }
            else // The TblLots is empty
            {
               tblLot.LodId = f.REGULAR_TICKET_MIN_LOT;
               isThereFreeLot = true;
            }
         }


         return isThereFreeLot;
      }
      
      private void btn_checkIn_Click(object sender, EventArgs e)
      {
         // If all the details filled
         if (IsTextboxFilled())
         {
            // Generate Vehicle
            InitVehicle();

            // Generate Ticket type
            InitTicket();

            //Generate Lot
            bool isThereFreeLot = InitLot();

            if(!IsExistUser)
            {
               // Write the vehicle to db
               dataContext.TblVehicles.InsertOnSubmit(tblVehicle);
               dataContext.SubmitChanges();
            }

            // Write the lot to db
            if (isThereFreeLot)
            {
               //tblLot.TblVehicle = tblVehicle;
               dataContext.TblLots.InsertOnSubmit(tblLot);
               dataContext.SubmitChanges();

               MoveToSuccessCheckInForm();
            }
            else // There is no place for the vehicle
            {

            }

         }

      }

      private void MoveToSuccessCheckInForm()
      {
         SuccessCheckInForm f = new SuccessCheckInForm();
         f.LodId = tblLot.LodId.ToString();
         f.CheckInTime = tblLot.CheckInTime.ToString();
         f.TimeLimit = tblLot.TimeLimit.ToString();
         f.VehicleLicensePlateId = tblLot.VehicleLicensePlateId;
         f.Show();
      }

      private bool IsTextboxFilled()
      {
         if (string.IsNullOrEmpty(input_name.Text))
         {
            input_name.Focus();
            error.SetError(input_name, "Please Enter Name");
            return false;
         }

         if (string.IsNullOrEmpty(input_phone.Text))
         {
            input_phone.Focus();
            error.SetError(input_phone, "Please Enter Phone");
            return false;
         }

         if (string.IsNullOrEmpty(input_vehicleHeight.Text))
         {
            input_vehicleHeight.Focus();
            error.SetError(input_vehicleHeight, "Please Enter Height");
            return false;
         }

         if (string.IsNullOrEmpty(input_vehicleWidth.Text))
         {
            input_vehicleWidth.Focus();
            error.SetError(input_vehicleWidth, "Please Enter Width");
            return false;
         }

         if (string.IsNullOrEmpty(input_vehicleLength.Text))
         {
            input_vehicleLength.Focus();
            error.SetError(input_vehicleLength, "Please Enter Length");
            return false;
         }

         return true;
      }
   }
}
