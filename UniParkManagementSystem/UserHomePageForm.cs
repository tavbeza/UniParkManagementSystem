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
   public partial class UserHomePageForm : Form
   {
      UniParkDBDataContext dataContext = new UniParkDBDataContext();
      public string UserName { get; set; }
      public string UserPhone { get; set; }
      public string LicensePlateId { get; set; }

      public UserHomePageForm()
      {
         InitializeComponent();
      }

      public UserHomePageForm(string licensePlateId, string name, string phone)
      {
         InitializeComponent();
         LicensePlateId = licensePlateId;
         UserName = name;
         UserPhone = phone;
         lbl_hello.Text = "Hello " + UserName;

         if (IsCheckedIn()) // Offer checkout
         {
            lbl_checkinout.Text = "Do you want to check out?";
            btn_checkinout.Text = "Check Out";
         }
         else // Offer checkin
         {
            lbl_checkinout.Text = "Do you want to check in?";
            btn_checkinout.Text = "Check In";
         }
      }

      private bool IsCheckedIn()
      {
         TblLot qLots;
         qLots = dataContext.TblLots
            .Select(l => l)
            .Where(l => l.VehicleLicensePlateId == LicensePlateId)
            .SingleOrDefault();
         
         if(qLots == null) // No checked in
         {
            return false;
         }
         else // Already checked in
         {
            return true;
         }

      }

      private void CheckOut()
      {
         TblLot tblLot = dataContext.TblLots
            .Select(l => l)
            .Where(lot => lot.VehicleLicensePlateId == LicensePlateId).SingleOrDefault();

         dataContext.TblLots.DeleteOnSubmit(tblLot);
         dataContext.SubmitChanges();

         MessageBox.Show(
            "Have a nice day!",
            "Check Out Complete",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
      }

      private void CheckIn()
      {
         UserDetailsForm f = new UserDetailsForm(UserName, UserPhone);
         f.LicensePlateId = LicensePlateId;
         f.Show();
      }

      private void GoToForm1()
      {
         Form1 f = new Form1();
         f.Show();
      }

      private void btn_checkinout_Click(object sender, EventArgs e)
      {
         if(btn_checkinout.Text == "Check Out")
         {
            CheckOut();
            GoToForm1();
         }
         else
         {
            CheckIn();
         }
      }
   }
}
