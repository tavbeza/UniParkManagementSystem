
namespace UniParkManagementSystem
{
   partial class UserHomePageForm
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
         this.lbl_hello = new System.Windows.Forms.Label();
         this.lbl_checkinout = new System.Windows.Forms.Label();
         this.btn_checkinout = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lbl_hello
         // 
         this.lbl_hello.AutoSize = true;
         this.lbl_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
         this.lbl_hello.Location = new System.Drawing.Point(33, 41);
         this.lbl_hello.Name = "lbl_hello";
         this.lbl_hello.Size = new System.Drawing.Size(0, 25);
         this.lbl_hello.TabIndex = 1;
         this.lbl_hello.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lbl_checkinout
         // 
         this.lbl_checkinout.AutoSize = true;
         this.lbl_checkinout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
         this.lbl_checkinout.Location = new System.Drawing.Point(33, 110);
         this.lbl_checkinout.Name = "lbl_checkinout";
         this.lbl_checkinout.Size = new System.Drawing.Size(0, 25);
         this.lbl_checkinout.TabIndex = 2;
         this.lbl_checkinout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // btn_checkinout
         // 
         this.btn_checkinout.Location = new System.Drawing.Point(38, 197);
         this.btn_checkinout.Name = "btn_checkinout";
         this.btn_checkinout.Size = new System.Drawing.Size(75, 23);
         this.btn_checkinout.TabIndex = 3;
         this.btn_checkinout.UseVisualStyleBackColor = true;
         this.btn_checkinout.Click += new System.EventHandler(this.btn_checkinout_Click);
         // 
         // UserHomePageForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btn_checkinout);
         this.Controls.Add(this.lbl_checkinout);
         this.Controls.Add(this.lbl_hello);
         this.Name = "UserHomePageForm";
         this.Text = "UserHomePageForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbl_hello;
      private System.Windows.Forms.Label lbl_checkinout;
      private System.Windows.Forms.Button btn_checkinout;
   }
}