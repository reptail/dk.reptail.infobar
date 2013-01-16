namespace dk.reptail.infobar.Modules
{
    partial class Spotify
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
            this.ttImg = new System.Windows.Forms.ToolTip(this.components);
            this.lblSongName = new System.Windows.Forms.Label();
            this.imgSpotify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSongName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.Location = new System.Drawing.Point(24, 2);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(300, 17);
            this.lblSongName.TabIndex = 1;
            this.lblSongName.Text = "Spotify is not running!";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgSpotify
            // 
            this.imgSpotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSpotify.Image = global::dk.reptail.infobar.Modules.Properties.Resources.spotify_15;
            this.imgSpotify.Location = new System.Drawing.Point(3, 3);
            this.imgSpotify.Name = "imgSpotify";
            this.imgSpotify.Size = new System.Drawing.Size(15, 16);
            this.imgSpotify.TabIndex = 0;
            // 
            // Spotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.imgSpotify);
            this.Name = "Spotify";
            this.Size = new System.Drawing.Size(327, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label imgSpotify;
        private System.Windows.Forms.ToolTip ttImg;
        private System.Windows.Forms.Label lblSongName;
    }
}
