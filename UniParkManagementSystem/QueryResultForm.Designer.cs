
namespace UniParkManagementSystem
{
   partial class QueryResultForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dataGridView_tblVehicles = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tblVehicles)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView_tblVehicles
         // 
         this.dataGridView_tblVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView_tblVehicles.Location = new System.Drawing.Point(21, 81);
         this.dataGridView_tblVehicles.Name = "dataGridView_tblVehicles";
         this.dataGridView_tblVehicles.RowHeadersWidth = 51;
         this.dataGridView_tblVehicles.RowTemplate.Height = 24;
         this.dataGridView_tblVehicles.Size = new System.Drawing.Size(767, 357);
         this.dataGridView_tblVehicles.TabIndex = 6;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
         this.label1.Location = new System.Drawing.Point(16, 21);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(90, 25);
         this.label1.TabIndex = 7;
         this.label1.Text = "Results:";
         // 
         // QueryResauktForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dataGridView_tblVehicles);
         this.Name = "QueryResauktForm";
         this.Text = "QueryResauktForm";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tblVehicles)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView_tblVehicles;
      private System.Windows.Forms.Label label1;
   }
}