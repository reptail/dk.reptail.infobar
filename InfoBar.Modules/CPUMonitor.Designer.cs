namespace dk.reptail.infobar.Modules
{
    partial class CPUMonitor
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
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblCPUText = new System.Windows.Forms.Label();
            this.dataCPU = new SystemMonitor.DataChart();
            this.imgChip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(47, 5);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(19, 13);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "---";
            // 
            // lblCPUText
            // 
            this.lblCPUText.AutoSize = true;
            this.lblCPUText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUText.Location = new System.Drawing.Point(20, 5);
            this.lblCPUText.Name = "lblCPUText";
            this.lblCPUText.Size = new System.Drawing.Size(31, 13);
            this.lblCPUText.TabIndex = 3;
            this.lblCPUText.Text = "CPU:";
            // 
            // dataCPU
            // 
            this.dataCPU.BackColor = System.Drawing.Color.Gainsboro;
            this.dataCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataCPU.ChartType = SystemMonitor.ChartType.Line;
            this.dataCPU.GridColor = System.Drawing.SystemColors.Control;
            this.dataCPU.GridPixels = 0;
            this.dataCPU.InitialHeight = 90;
            this.dataCPU.LineColor = System.Drawing.Color.DarkBlue;
            this.dataCPU.Location = new System.Drawing.Point(85, 2);
            this.dataCPU.Name = "dataCPU";
            this.dataCPU.Size = new System.Drawing.Size(60, 17);
            this.dataCPU.TabIndex = 5;
            // 
            // imgChip
            // 
            this.imgChip.Image = global::dk.reptail.infobar.Modules.Properties.Resources.chip_14;
            this.imgChip.Location = new System.Drawing.Point(3, 4);
            this.imgChip.Name = "imgChip";
            this.imgChip.Size = new System.Drawing.Size(15, 15);
            this.imgChip.TabIndex = 6;
            // 
            // CPUMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.imgChip);
            this.Controls.Add(this.dataCPU);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblCPUText);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CPUMonitor";
            this.Size = new System.Drawing.Size(145, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SystemMonitor.DataChart dataCPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblCPUText;
        private System.Windows.Forms.Label imgChip;
    }
}
