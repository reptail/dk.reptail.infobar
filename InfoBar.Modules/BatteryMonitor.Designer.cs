namespace dk.reptail.infobar.Modules
{
    partial class BatteryMonitor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgBattery = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imgBattery
            // 
            this.imgBattery.Image = global::dk.reptail.infobar.Modules.Properties.Resources.power_15;
            this.imgBattery.Location = new System.Drawing.Point(2, 3);
            this.imgBattery.Name = "imgBattery";
            this.imgBattery.Size = new System.Drawing.Size(16, 16);
            this.imgBattery.TabIndex = 0;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattery.Location = new System.Drawing.Point(20, 5);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(39, 13);
            this.lblBattery.TabIndex = 1;
            this.lblBattery.Text = "- - - - -";
            // 
            // BatteryMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.imgBattery);
            this.Name = "BatteryMonitor";
            this.Size = new System.Drawing.Size(105, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imgBattery;
        private System.Windows.Forms.Label lblBattery;
    }
}
