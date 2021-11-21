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
   public partial class SuccessCheckInForm : Form
   {
      public string VehicleLicensePlateId { get; set; }
      public string CheckInTime { get; set; }
      public string LodId { get; set; }
      public string TimeLimit { get; set; }

      public SuccessCheckInForm()
      {
         InitializeComponent();
      }
      protected override void OnLoad(EventArgs e)
      {
         lbl_LicensePlateId.Text = VehicleLicensePlateId;
         lbl_CheckinTime.Text = CheckInTime;
         lbl_LotNumber.Text = LodId;
         lbl_TimeLimit.Text = TimeLimit;
         base.OnLoad(e);
      }



   }
}
