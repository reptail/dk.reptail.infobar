namespace dk.reptail.infobar.Modules
{
    partial class Uptime
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
            this.lblUptimeText = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUptimeText
            // 
            this.lblUptimeText.AutoSize = true;
            this.lblUptimeText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptimeText.Location = new System.Drawing.Point(1, 5);
            this.lblUptimeText.Name = "lblUptimeText";
            this.lblUptimeText.Size = new System.Drawing.Size(44, 13);
            this.lblUptimeText.TabIndex = 0;
            this.lblUptimeText.Text = "Uptime:";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptime.Location = new System.Drawing.Point(41, 5);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(51, 13);
            this.lblUptime.TabIndex = 1;
            this.lblUptime.Text = "00:00:00";
            // 
            // Uptime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblUptime);
            this.Controls.Add(this.lblUptimeText);
            this.Name = "Uptime";
            this.Size = new System.Drawing.Size(93, 22);
            this.Load += new System.EventHandler(this.Uptime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUptimeText;
        private System.Windows.Forms.Label lblUptime;
    }
}
