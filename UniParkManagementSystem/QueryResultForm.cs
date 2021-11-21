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
   public partial class QueryResultForm : Form
   {
      public List<TblVehicle> Vehicles { get; set; }

      public QueryResultForm()
      {
         InitializeComponent();
         dataGridView_tblVehicles.DataSource = Vehicles;
      }

      public QueryResultForm(List<TblVehicle> vehicles)
      {
         Vehicles = vehicles;
         InitializeComponent();
         dataGridView_tblVehicles.DataSource = Vehicles;
      }
   }
}
