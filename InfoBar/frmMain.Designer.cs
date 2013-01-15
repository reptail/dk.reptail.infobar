using dk.reptail.infobar.Modules;

namespace dk.reptail.infobar
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.menuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bHide = new System.Windows.Forms.Button();
            this.dummy = new System.Windows.Forms.Button();
            this.menuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // menuContext
            // 
            this.menuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuContext.Name = "menuContext";
            this.menuContext.Size = new System.Drawing.Size(149, 98);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Enabled = false;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Location = new System.Drawing.Point(5, 1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(849, 21);
            this.Panel.TabIndex = 0;
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(1035, 2);
            this.lblTop.TabIndex = 16;
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.Transparent;
            this.bReset.BackgroundImage = global::dk.reptail.infobar.Properties.Resources.reset_w_bg;
            this.bReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bReset.FlatAppearance.BorderSize = 0;
            this.bReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(860, 3);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(22, 18);
            this.bReset.TabIndex = 17;
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            this.bReset.MouseEnter += new System.EventHandler(this.bReset_MouseEnter);
            this.bReset.MouseLeave += new System.EventHandler(this.bReset_MouseLeave);
            // 
            // bHide
            // 
            this.bHide.BackColor = System.Drawing.Color.Transparent;
            this.bHide.BackgroundImage = global::dk.reptail.infobar.Properties.Resources.hide_w_bg;
            this.bHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bHide.FlatAppearance.BorderSize = 0;
            this.bHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHide.Location = new System.Drawing.Point(888, 3);
            this.bHide.Name = "bHide";
            this.bHide.Size = new System.Drawing.Size(22, 18);
            this.bHide.TabIndex = 18;
            this.bHide.UseVisualStyleBackColor = false;
            this.bHide.Click += new System.EventHandler(this.bHide_Click);
            // 
            // dummy
            // 
            this.dummy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dummy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dummy.Image = global::dk.reptail.infobar.Properties.Resources.hide;
            this.dummy.Location = new System.Drawing.Point(939, 18);
            this.dummy.Name = "dummy";
            this.dummy.Size = new System.Drawing.Size(22, 18);
            this.dummy.TabIndex = 19;
            this.dummy.UseVisualStyleBackColor = true;
            this.dummy.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(990, 48);
            this.ContextMenuStrip = this.menuContext;
            this.ControlBox = false;
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.dummy);
            this.Controls.Add(this.bHide);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "dk.reptail.infobar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ContextMenuStrip menuContext;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTop;
        public System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bHide;
        private System.Windows.Forms.Button dummy;




    }
}

