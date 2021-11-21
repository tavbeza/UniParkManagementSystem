
namespace UniParkManagementSystem
{
   partial class Form1
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
         this.label1 = new System.Windows.Forms.Label();
         this.input_licensePlateId = new System.Windows.Forms.TextBox();
         this.button_next = new System.Windows.Forms.Button();
         this.btn_currentState = new System.Windows.Forms.Button();
         this.dataGridView_tblLots = new System.Windows.Forms.DataGridView();
         this.btn_randomVehicles = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tblLots)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(26, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(256, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Please enter license plate ID:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // input_licensePlateId
         // 
         this.input_licensePlateId.Location = new System.Drawing.Point(257, 25);
         this.input_licensePlateId.Name = "input_licensePlateId";
         this.input_licensePlateId.Size = new System.Drawing.Size(301, 22);
         this.input_licensePlateId.TabIndex = 1;
         // 
         // button_next
         // 
         this.button_next.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         this.button_next.Location = new System.Drawing.Point(584, 25);
         this.button_next.Name = "button_next";
         this.button_next.Size = new System.Drawing.Size(188, 23);
         this.button_next.TabIndex = 2;
         this.button_next.Text = "Next";
         this.button_next.UseVisualStyleBackColor = false;
         this.button_next.Click += new System.EventHandler(this.button_next_Click);
         // 
         // btn_currentState
         // 
         this.btn_currentState.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         this.btn_currentState.Location = new System.Drawing.Point(109, 65);
         this.btn_currentState.Name = "btn_currentState";
         this.btn_currentState.Size = new System.Drawing.Size(261, 47);
         this.btn_currentState.TabIndex = 4;
         this.btn_currentState.Text = "Current state:";
         this.btn_currentState.UseVisualStyleBackColor = false;
         this.btn_currentState.Click += new System.EventHandler(this.btn_currentState_Click);
         // 
         // dataGridView_tblLots
         // 
         this.dataGridView_tblLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView_tblLots.Location = new System.Drawing.Point(12, 127);
         this.dataGridView_tblLots.Name = "dataGridView_tblLots";
         this.dataGridView_tblLots.RowHeadersWidth = 51;
         this.dataGridView_tblLots.RowTemplate.Height = 24;
         this.dataGridView_tblLots.Size = new System.Drawing.Size(776, 311);
         this.dataGridView_tblLots.TabIndex = 6;
         // 
         // btn_randomVehicles
         // 
         this.btn_randomVehicles.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         this.btn_randomVehicles.Location = new System.Drawing.Point(394, 65);
         this.btn_randomVehicles.Name = "btn_randomVehicles";
         this.btn_randomVehicles.Size = new System.Drawing.Size(261, 47);
         this.btn_randomVehicles.TabIndex = 7;
         this.btn_randomVehicles.Text = "5 Randomly Vehicles:";
         this.btn_randomVehicles.UseVisualStyleBackColor = false;
         this.btn_randomVehicles.Click += new System.EventHandler(this.btn_randomVehicles_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btn_randomVehicles);
         this.Controls.Add(this.dataGridView_tblLots);
         this.Controls.Add(this.btn_currentState);
         this.Controls.Add(this.button_next);
         this.Controls.Add(this.input_licensePlateId);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tblLots)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox input_licensePlateId;
      private System.Windows.Forms.Button button_next;
      private System.Windows.Forms.Button btn_currentState;
      private System.Windows.Forms.DataGridView dataGridView_tblLots;
      private System.Windows.Forms.Button btn_randomVehicles;
   }
}

