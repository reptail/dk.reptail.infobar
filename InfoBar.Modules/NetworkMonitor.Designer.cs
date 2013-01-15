namespace dk.reptail.infobar.Modules
{
    partial class NetworkMonitor
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
            this.imgDown = new System.Windows.Forms.Label();
            this.imgUp = new System.Windows.Forms.Label();
            this.imgUpDown = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imgDown
            // 
            this.imgDown.Image = global::dk.reptail.infobar.Modules.Properties.Resources.black_down_8;
            this.imgDown.Location = new System.Drawing.Point(20, 7);
            this.imgDown.Name = "imgDown";
            this.imgDown.Size = new System.Drawing.Size(12, 12);
            this.imgDown.TabIndex = 2;
            // 
            // imgUp
            // 
            this.imgUp.Image = global::dk.reptail.infobar.Modules.Properties.Resources.black_up_8;
            this.imgUp.Location = new System.Drawing.Point(75, 7);
            this.imgUp.Name = "imgUp";
            this.imgUp.Size = new System.Drawing.Size(12, 12);
            this.imgUp.TabIndex = 1;
            // 
            // imgUpDown
            // 
            this.imgUpDown.Image = global::dk.reptail.infobar.Modules.Properties.Resources.up_down_14;
            this.imgUpDown.Location = new System.Drawing.Point(2, 5);
            this.imgUpDown.Name = "imgUpDown";
            this.imgUpDown.Size = new System.Drawing.Size(14, 14);
            this.imgUpDown.TabIndex = 0;
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.BackColor = System.Drawing.Color.Transparent;
            this.lblDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.Location = new System.Drawing.Point(33, 5);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(32, 13);
            this.lblDown.TabIndex = 3;
            this.lblDown.Text = "- - - -";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.Location = new System.Drawing.Point(88, 5);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(32, 13);
            this.lblUp.TabIndex = 4;
            this.lblUp.Text = "- - - -";
            // 
            // NetworkMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.imgDown);
            this.Controls.Add(this.imgUp);
            this.Controls.Add(this.imgUpDown);
            this.Name = "NetworkMonitor";
            this.Size = new System.Drawing.Size(133, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imgUpDown;
        private System.Windows.Forms.Label imgUp;
        private System.Windows.Forms.Label imgDown;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblUp;
    }
}
