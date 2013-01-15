namespace dk.reptail.infobar.Modules
{
    partial class MemoryMonitor
    {
        /// <summary> 
        ///     Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///     Clean up any resources being used.
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
            this.dataMem = new SystemMonitor.DataChart();
            this.lblMem = new System.Windows.Forms.Label();
            this.lblMemText = new System.Windows.Forms.Label();
            this.imgMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataMem
            // 
            this.dataMem.BackColor = System.Drawing.Color.Gainsboro;
            this.dataMem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataMem.ChartType = SystemMonitor.ChartType.Line;
            this.dataMem.GridColor = System.Drawing.SystemColors.Control;
            this.dataMem.GridPixels = 0;
            this.dataMem.InitialHeight = 90;
            this.dataMem.LineColor = System.Drawing.Color.DarkBlue;
            this.dataMem.Location = new System.Drawing.Point(174, 2);
            this.dataMem.Name = "dataMem";
            this.dataMem.Size = new System.Drawing.Size(60, 17);
            this.dataMem.TabIndex = 10;
            // 
            // lblMem
            // 
            this.lblMem.AutoSize = true;
            this.lblMem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMem.Location = new System.Drawing.Point(68, 5);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(19, 13);
            this.lblMem.TabIndex = 9;
            this.lblMem.Text = "---";
            // 
            // lblMemText
            // 
            this.lblMemText.AutoSize = true;
            this.lblMemText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemText.Location = new System.Drawing.Point(24, 5);
            this.lblMemText.Name = "lblMemText";
            this.lblMemText.Size = new System.Drawing.Size(49, 13);
            this.lblMemText.TabIndex = 8;
            this.lblMemText.Text = "Memory:";
            // 
            // imgMemory
            // 
            this.imgMemory.Image = global::dk.reptail.infobar.Modules.Properties.Resources.memory_12;
            this.imgMemory.Location = new System.Drawing.Point(3, 5);
            this.imgMemory.Name = "imgMemory";
            this.imgMemory.Size = new System.Drawing.Size(16, 13);
            this.imgMemory.TabIndex = 11;
            // 
            // MemoryMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.imgMemory);
            this.Controls.Add(this.dataMem);
            this.Controls.Add(this.lblMem);
            this.Controls.Add(this.lblMemText);
            this.Name = "MemoryMonitor";
            this.Size = new System.Drawing.Size(235, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SystemMonitor.DataChart dataMem;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.Label lblMemText;
        private System.Windows.Forms.Label imgMemory;
    }
}
