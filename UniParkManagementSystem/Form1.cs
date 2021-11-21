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
   public partial class Form1 : Form
   {
      UniParkDBDataContext dataContext = new UniParkDBDataContext();
      public TblVehicle TblVehicle { get; set; }

      public Form1()
      {
         InitializeComponent();
      }

      private void VehicleExistCheck(string licensePlateId)
      {
         TblVehicle = dataContext.TblVehicles.Select(l => l).Where(l => l.LicensePlateId == licensePlateId).SingleOrDefault();

         if (TblVehicle == null) // New user
         {
            
            UserDetailsForm f = new UserDetailsForm();
            f.LicensePlateId = licensePlateId;
            f.Show();
         }
         else // Exist user
         {
            string[] userStringArray = TblVehicle.User.Split(' ');

            UserHomePageForm f = new UserHomePageForm(TblVehicle.LicensePlateId, userStringArray[0], userStringArray[1]);

            //f.UserName = userStringArray[0];
            //f.UserPhone = userStringArray[1];
            //f.LicensePlateId = TblVehicle.LicensePlateId;
            f.Show();
         }
      }

      private void button_next_Click(object sender, EventArgs e)
      {
         string licensePlateId = input_licensePlateId.Text;
         VehicleExistCheck(licensePlateId);
      }

      private void btn_currentState_Click(object sender, EventArgs e)
      {
         dataGridView_tblLots.DataSource = dataContext.TblLots;
      }

      private void btn_randomVehicles_Click(object sender, EventArgs e)
      {

         Random rand = new Random();
         int toSkip = rand.Next(0, dataContext.TblVehicles.Count());

         var queryResult = dataContext.TblVehicles
            .Skip(toSkip)
            .Take(5);
         
         var data = queryResult.ToList();
         if (data != null)
         {
            QueryResultForm f = new QueryResultForm(data);
            f.Show();
         }
      }

   }
}
