namespace dk.reptail.infobar.Modules
{
    partial class WinampControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinampControl));
            this.bNext = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.bPrev = new System.Windows.Forms.Button();
            this.imgWinamp = new System.Windows.Forms.Label();
            this.ttImg = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // bNext
            // 
            this.bNext.FlatAppearance.BorderSize = 0;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.Image = ((System.Drawing.Image)(resources.GetObject("bNext.Image")));
            this.bNext.Location = new System.Drawing.Point(90, 4);
            this.bNext.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(14, 15);
            this.bNext.TabIndex = 5;
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bStop
            // 
            this.bStop.FlatAppearance.BorderSize = 0;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.Image = global::dk.reptail.infobar.Modules.Properties.Resources.winamp_stop;
            this.bStop.Location = new System.Drawing.Point(73, 4);
            this.bStop.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(14, 15);
            this.bStop.TabIndex = 4;
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bPause
            // 
            this.bPause.FlatAppearance.BorderSize = 0;
            this.bPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPause.Image = global::dk.reptail.infobar.Modules.Properties.Resources.winamp_pause;
            this.bPause.Location = new System.Drawing.Point(57, 4);
            this.bPause.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(14, 15);
            this.bPause.TabIndex = 3;
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bPlay
            // 
            this.bPlay.FlatAppearance.BorderSize = 0;
            this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlay.Image = global::dk.reptail.infobar.Modules.Properties.Resources.winamp_play;
            this.bPlay.Location = new System.Drawing.Point(41, 4);
            this.bPlay.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(14, 15);
            this.bPlay.TabIndex = 2;
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bPrev
            // 
            this.bPrev.FlatAppearance.BorderSize = 0;
            this.bPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrev.Image = ((System.Drawing.Image)(resources.GetObject("bPrev.Image")));
            this.bPrev.Location = new System.Drawing.Point(24, 4);
            this.bPrev.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(14, 15);
            this.bPrev.TabIndex = 1;
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // imgWinamp
            // 
            this.imgWinamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgWinamp.Image = ((System.Drawing.Image)(resources.GetObject("imgWinamp.Image")));
            this.imgWinamp.Location = new System.Drawing.Point(3, 3);
            this.imgWinamp.Name = "imgWinamp";
            this.imgWinamp.Size = new System.Drawing.Size(15, 16);
            this.imgWinamp.TabIndex = 0;
            this.imgWinamp.Click += new System.EventHandler(this.imgWinamp_Click);
            // 
            // WinampControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bPause);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.bPrev);
            this.Controls.Add(this.imgWinamp);
            this.Name = "WinampControl";
            this.Size = new System.Drawing.Size(110, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label imgWinamp;
        private System.Windows.Forms.Button bPrev;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.ToolTip ttImg;
    }
}
