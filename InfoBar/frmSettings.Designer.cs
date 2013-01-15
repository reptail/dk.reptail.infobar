namespace dk.reptail.infobar
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.rbBottom = new System.Windows.Forms.RadioButton();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.gbColors = new System.Windows.Forms.GroupBox();
            this.lblGraphBox = new System.Windows.Forms.Label();
            this.lblGraph = new System.Windows.Forms.Label();
            this.lblBackgroundColorBox = new System.Windows.Forms.Label();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.bCpuRight = new System.Windows.Forms.Button();
            this.bCpuLeft = new System.Windows.Forms.Button();
            this.cbCPU = new System.Windows.Forms.CheckBox();
            this.bMemoryRight = new System.Windows.Forms.Button();
            this.bMemoryLeft = new System.Windows.Forms.Button();
            this.cbMemory = new System.Windows.Forms.CheckBox();
            this.cbNetwork = new System.Windows.Forms.CheckBox();
            this.cbUptime = new System.Windows.Forms.CheckBox();
            this.cbBattery = new System.Windows.Forms.CheckBox();
            this.bWinampRight = new System.Windows.Forms.Button();
            this.bWinampLeft = new System.Windows.Forms.Button();
            this.cbWinamp = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.gbWinamp = new System.Windows.Forms.GroupBox();
            this.bNetworkRight = new System.Windows.Forms.Button();
            this.bNetworkLeft = new System.Windows.Forms.Button();
            this.bUptimeRight = new System.Windows.Forms.Button();
            this.bUptimeLeft = new System.Windows.Forms.Button();
            this.bBatteryRight = new System.Windows.Forms.Button();
            this.bBatteryLeft = new System.Windows.Forms.Button();
            this.lblWinampLocation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bWinampLocationBrowse = new System.Windows.Forms.Button();
            this.lblCpuConf = new System.Windows.Forms.Label();
            this.lblNetworkConf = new System.Windows.Forms.Label();
            this.lblBatteryConf = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.gbCPU = new System.Windows.Forms.GroupBox();
            this.gbMemory = new System.Windows.Forms.GroupBox();
            this.lblMemoryConf = new System.Windows.Forms.Label();
            this.gbNetwork = new System.Windows.Forms.GroupBox();
            this.gbUptime = new System.Windows.Forms.GroupBox();
            this.cbUptimeHideDays = new System.Windows.Forms.CheckBox();
            this.gbBattery = new System.Windows.Forms.GroupBox();
            this.gbFeed = new System.Windows.Forms.GroupBox();
            this.cbFeed = new System.Windows.Forms.CheckBox();
            this.bFeedRight = new System.Windows.Forms.Button();
            this.bFeedLeft = new System.Windows.Forms.Button();
            this.lblFeedURL = new System.Windows.Forms.Label();
            this.txtFeedURL = new System.Windows.Forms.TextBox();
            this.lblFeedHeadlineNum = new System.Windows.Forms.Label();
            this.txtFeedHeadlineNum = new System.Windows.Forms.TextBox();
            this.txtFeedModuleWidth = new System.Windows.Forms.TextBox();
            this.lblFeedModuleWidth = new System.Windows.Forms.Label();
            this.lblFeedModuleWidthSet = new System.Windows.Forms.Label();
            this.gbGoogle = new System.Windows.Forms.GroupBox();
            this.bGoogleLeft = new System.Windows.Forms.Button();
            this.bGoogleRight = new System.Windows.Forms.Button();
            this.cbGoogle = new System.Windows.Forms.CheckBox();
            this.lblGoogleConf = new System.Windows.Forms.Label();
            this.gbLocation.SuspendLayout();
            this.gbColors.SuspendLayout();
            this.gbWinamp.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.gbCPU.SuspendLayout();
            this.gbMemory.SuspendLayout();
            this.gbNetwork.SuspendLayout();
            this.gbUptime.SuspendLayout();
            this.gbBattery.SuspendLayout();
            this.gbFeed.SuspendLayout();
            this.gbGoogle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLocation
            // 
            this.gbLocation.Controls.Add(this.rbBottom);
            this.gbLocation.Controls.Add(this.rbTop);
            this.gbLocation.Enabled = false;
            this.gbLocation.Location = new System.Drawing.Point(194, 20);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Size = new System.Drawing.Size(182, 68);
            this.gbLocation.TabIndex = 4;
            this.gbLocation.TabStop = false;
            this.gbLocation.Text = "Location";
            // 
            // rbBottom
            // 
            this.rbBottom.AutoSize = true;
            this.rbBottom.Checked = true;
            this.rbBottom.Location = new System.Drawing.Point(7, 44);
            this.rbBottom.Name = "rbBottom";
            this.rbBottom.Size = new System.Drawing.Size(59, 17);
            this.rbBottom.TabIndex = 1;
            this.rbBottom.TabStop = true;
            this.rbBottom.Text = "Bottom";
            this.rbBottom.UseVisualStyleBackColor = true;
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Location = new System.Drawing.Point(7, 21);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(43, 17);
            this.rbTop.TabIndex = 0;
            this.rbTop.Text = "Top";
            this.rbTop.UseVisualStyleBackColor = true;
            // 
            // gbColors
            // 
            this.gbColors.Controls.Add(this.lblGraphBox);
            this.gbColors.Controls.Add(this.lblGraph);
            this.gbColors.Controls.Add(this.lblBackgroundColorBox);
            this.gbColors.Controls.Add(this.lblBackgroundColor);
            this.gbColors.Location = new System.Drawing.Point(6, 20);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(182, 68);
            this.gbColors.TabIndex = 0;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "Colors";
            // 
            // lblGraphBox
            // 
            this.lblGraphBox.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGraphBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGraphBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGraphBox.Location = new System.Drawing.Point(142, 40);
            this.lblGraphBox.Name = "lblGraphBox";
            this.lblGraphBox.Size = new System.Drawing.Size(25, 14);
            this.lblGraphBox.TabIndex = 3;
            this.lblGraphBox.Click += new System.EventHandler(this.lblGraphBox_Click);
            // 
            // lblGraph
            // 
            this.lblGraph.AutoSize = true;
            this.lblGraph.Location = new System.Drawing.Point(7, 41);
            this.lblGraph.Name = "lblGraph";
            this.lblGraph.Size = new System.Drawing.Size(109, 13);
            this.lblGraph.TabIndex = 2;
            this.lblGraph.Text = "Set Graph Line Color:";
            // 
            // lblBackgroundColorBox
            // 
            this.lblBackgroundColorBox.BackColor = System.Drawing.Color.Gainsboro;
            this.lblBackgroundColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBackgroundColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackgroundColorBox.Location = new System.Drawing.Point(142, 21);
            this.lblBackgroundColorBox.Name = "lblBackgroundColorBox";
            this.lblBackgroundColorBox.Size = new System.Drawing.Size(25, 14);
            this.lblBackgroundColorBox.TabIndex = 1;
            this.lblBackgroundColorBox.Click += new System.EventHandler(this.lblBackgroundColorBox_Click);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(7, 21);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(114, 13);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Set Background Color:";
            // 
            // bCpuRight
            // 
            this.bCpuRight.Enabled = false;
            this.bCpuRight.Image = global::dk.reptail.infobar.Properties.Resources.arrow_right;
            this.bCpuRight.Location = new System.Drawing.Point(160, 21);
            this.bCpuRight.Name = "bCpuRight";
            this.bCpuRight.Size = new System.Drawing.Size(18, 18);
            this.bCpuRight.TabIndex = 2;
            this.bCpuRight.UseVisualStyleBackColor = true;
            this.bCpuRight.Click += new System.EventHandler(this.bCpuRight_Click);
            // 
            // bCpuLeft
            // 
            this.bCpuLeft.Enabled = false;
            this.bCpuLeft.Image = global::dk.reptail.infobar.Properties.Resources.arrow_left;
            this.bCpuLeft.Location = new System.Drawing.Point(137, 21);
            this.bCpuLeft.Name = "bCpuLeft";
            this.bCpuLeft.Size = new System.Drawing.Size(18, 18);
            this.bCpuLeft.TabIndex = 1;
            this.bCpuLeft.UseVisualStyleBackColor = true;
            this.bCpuLeft.Click += new System.EventHandler(this.bCpuLeft_Click);
            // 
            // cbCPU
            // 
            this.cbCPU.AutoSize = true;
            this.cbCPU.Location = new System.Drawing.Point(9, 23);
            this.cbCPU.Margin = new System.Windows.Forms.Padding(6);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(109, 17);
            this.cbCPU.TabIndex = 0;
            this.cbCPU.Text = "Show this module";
            this.cbCPU.UseVisualStyleBackColor = true;
            // 
            // bMemoryRight
            // 
            this.bMemoryRight.Enabled = false;
            this.bMemoryRight.Image = ((System.Drawing.Image)(resources.GetObject("bMemoryRight.Image")));
            this.bMemoryRight.Location = new System.Drawing.Point(160, 21);
            this.bMemoryRight.Name = "bMemoryRight";
            this.bMemoryRight.Size = new System.Drawing.Size(18, 18);
            this.bMemoryRight.TabIndex = 4;
            this.bMemoryRight.UseVisualStyleBackColor = true;
            this.bMemoryRight.Click += new System.EventHandler(this.bMemoryRight_Click);
            // 
            // bMemoryLeft
            // 
            this.bMemoryLeft.Enabled = false;
            this.bMemoryLeft.Image = ((System.Drawing.Image)(resources.GetObject("bMemoryLeft.Image")));
            this.bMemoryLeft.Location = new System.Drawing.Point(137, 21);
            this.bMemoryLeft.Name = "bMemoryLeft";
            this.bMemoryLeft.Size = new System.Drawing.Size(18, 18);
            this.bMemoryLeft.TabIndex = 3;
            this.bMemoryLeft.UseVisualStyleBackColor = true;
            this.bMemoryLeft.Click += new System.EventHandler(this.bMemoryLeft_Click);
            // 
            // cbMemory
            // 
            this.cbMemory.AutoSize = true;
            this.cbMemory.Location = new System.Drawing.Point(9, 23);
            this.cbMemory.Margin = new System.Windows.Forms.Padding(6);
            this.cbMemory.Name = "cbMemory";
            this.cbMemory.Size = new System.Drawing.Size(109, 17);
            this.cbMemory.TabIndex = 1;
            this.cbMemory.Text = "Show this module";
            this.cbMemory.UseVisualStyleBackColor = true;
            // 
            // cbNetwork
            // 
            this.cbNetwork.AutoSize = true;
            this.cbNetwork.Location = new System.Drawing.Point(9, 23);
            this.cbNetwork.Margin = new System.Windows.Forms.Padding(6);
            this.cbNetwork.Name = "cbNetwork";
            this.cbNetwork.Size = new System.Drawing.Size(109, 17);
            this.cbNetwork.TabIndex = 1;
            this.cbNetwork.Text = "Show this module";
            this.cbNetwork.UseVisualStyleBackColor = true;
            // 
            // cbUptime
            // 
            this.cbUptime.AutoSize = true;
            this.cbUptime.Location = new System.Drawing.Point(9, 23);
            this.cbUptime.Margin = new System.Windows.Forms.Padding(6);
            this.cbUptime.Name = "cbUptime";
            this.cbUptime.Size = new System.Drawing.Size(109, 17);
            this.cbUptime.TabIndex = 1;
            this.cbUptime.Text = "Show this module";
            this.cbUptime.UseVisualStyleBackColor = true;
            // 
            // cbBattery
            // 
            this.cbBattery.AutoSize = true;
            this.cbBattery.Location = new System.Drawing.Point(9, 23);
            this.cbBattery.Margin = new System.Windows.Forms.Padding(6);
            this.cbBattery.Name = "cbBattery";
            this.cbBattery.Size = new System.Drawing.Size(109, 17);
            this.cbBattery.TabIndex = 1;
            this.cbBattery.Text = "Show this module";
            this.cbBattery.UseVisualStyleBackColor = true;
            // 
            // bWinampRight
            // 
            this.bWinampRight.Enabled = false;
            this.bWinampRight.Image = ((System.Drawing.Image)(resources.GetObject("bWinampRight.Image")));
            this.bWinampRight.Location = new System.Drawing.Point(160, 21);
            this.bWinampRight.Name = "bWinampRight";
            this.bWinampRight.Size = new System.Drawing.Size(18, 18);
            this.bWinampRight.TabIndex = 4;
            this.bWinampRight.UseVisualStyleBackColor = true;
            this.bWinampRight.Click += new System.EventHandler(this.bWinampRight_Click);
            // 
            // bWinampLeft
            // 
            this.bWinampLeft.Enabled = false;
            this.bWinampLeft.Image = ((System.Drawing.Image)(resources.GetObject("bWinampLeft.Image")));
            this.bWinampLeft.Location = new System.Drawing.Point(137, 21);
            this.bWinampLeft.Name = "bWinampLeft";
            this.bWinampLeft.Size = new System.Drawing.Size(18, 18);
            this.bWinampLeft.TabIndex = 3;
            this.bWinampLeft.UseVisualStyleBackColor = true;
            this.bWinampLeft.Click += new System.EventHandler(this.bWinampLeft_Click);
            // 
            // cbWinamp
            // 
            this.cbWinamp.AutoSize = true;
            this.cbWinamp.Location = new System.Drawing.Point(9, 23);
            this.cbWinamp.Margin = new System.Windows.Forms.Padding(6);
            this.cbWinamp.Name = "cbWinamp";
            this.cbWinamp.Size = new System.Drawing.Size(109, 17);
            this.cbWinamp.TabIndex = 1;
            this.cbWinamp.Text = "Show this module";
            this.cbWinamp.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(341, 26);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Select which modules you want to display.  \r\nUse the left / right arrow-buttons t" +
                "o select where to place the module";
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(711, 450);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // gbWinamp
            // 
            this.gbWinamp.Controls.Add(this.bWinampLocationBrowse);
            this.gbWinamp.Controls.Add(this.bWinampRight);
            this.gbWinamp.Controls.Add(this.textBox1);
            this.gbWinamp.Controls.Add(this.bWinampLeft);
            this.gbWinamp.Controls.Add(this.lblWinampLocation);
            this.gbWinamp.Controls.Add(this.cbWinamp);
            this.gbWinamp.Enabled = false;
            this.gbWinamp.Location = new System.Drawing.Point(402, 120);
            this.gbWinamp.Name = "gbWinamp";
            this.gbWinamp.Size = new System.Drawing.Size(384, 81);
            this.gbWinamp.TabIndex = 5;
            this.gbWinamp.TabStop = false;
            this.gbWinamp.Text = "Winamp Control";
            // 
            // bNetworkRight
            // 
            this.bNetworkRight.Enabled = false;
            this.bNetworkRight.Image = global::dk.reptail.infobar.Properties.Resources.arrow_right;
            this.bNetworkRight.Location = new System.Drawing.Point(160, 21);
            this.bNetworkRight.Name = "bNetworkRight";
            this.bNetworkRight.Size = new System.Drawing.Size(18, 18);
            this.bNetworkRight.TabIndex = 4;
            this.bNetworkRight.UseVisualStyleBackColor = true;
            this.bNetworkRight.Click += new System.EventHandler(this.bNetworkRight_Click);
            // 
            // bNetworkLeft
            // 
            this.bNetworkLeft.Enabled = false;
            this.bNetworkLeft.Image = global::dk.reptail.infobar.Properties.Resources.arrow_left;
            this.bNetworkLeft.Location = new System.Drawing.Point(137, 21);
            this.bNetworkLeft.Name = "bNetworkLeft";
            this.bNetworkLeft.Size = new System.Drawing.Size(18, 18);
            this.bNetworkLeft.TabIndex = 3;
            this.bNetworkLeft.UseVisualStyleBackColor = true;
            this.bNetworkLeft.Click += new System.EventHandler(this.bNetworkLeft_Click);
            // 
            // bUptimeRight
            // 
            this.bUptimeRight.Enabled = false;
            this.bUptimeRight.Image = global::dk.reptail.infobar.Properties.Resources.arrow_right;
            this.bUptimeRight.Location = new System.Drawing.Point(160, 21);
            this.bUptimeRight.Name = "bUptimeRight";
            this.bUptimeRight.Size = new System.Drawing.Size(18, 18);
            this.bUptimeRight.TabIndex = 4;
            this.bUptimeRight.UseVisualStyleBackColor = true;
            this.bUptimeRight.Click += new System.EventHandler(this.bUptimeRight_Click);
            // 
            // bUptimeLeft
            // 
            this.bUptimeLeft.Enabled = false;
            this.bUptimeLeft.Image = global::dk.reptail.infobar.Properties.Resources.arrow_left;
            this.bUptimeLeft.Location = new System.Drawing.Point(137, 21);
            this.bUptimeLeft.Name = "bUptimeLeft";
            this.bUptimeLeft.Size = new System.Drawing.Size(18, 18);
            this.bUptimeLeft.TabIndex = 3;
            this.bUptimeLeft.UseVisualStyleBackColor = true;
            this.bUptimeLeft.Click += new System.EventHandler(this.bUptimeLeft_Click);
            // 
            // bBatteryRight
            // 
            this.bBatteryRight.Enabled = false;
            this.bBatteryRight.Image = global::dk.reptail.infobar.Properties.Resources.arrow_right;
            this.bBatteryRight.Location = new System.Drawing.Point(160, 21);
            this.bBatteryRight.Name = "bBatteryRight";
            this.bBatteryRight.Size = new System.Drawing.Size(18, 18);
            this.bBatteryRight.TabIndex = 4;
            this.bBatteryRight.UseVisualStyleBackColor = true;
            this.bBatteryRight.Click += new System.EventHandler(this.bBatteryRight_Click);
            // 
            // bBatteryLeft
            // 
            this.bBatteryLeft.Enabled = false;
            this.bBatteryLeft.Image = global::dk.reptail.infobar.Properties.Resources.arrow_left;
            this.bBatteryLeft.Location = new System.Drawing.Point(137, 21);
            this.bBatteryLeft.Name = "bBatteryLeft";
            this.bBatteryLeft.Size = new System.Drawing.Size(18, 18);
            this.bBatteryLeft.TabIndex = 3;
            this.bBatteryLeft.UseVisualStyleBackColor = true;
            this.bBatteryLeft.Click += new System.EventHandler(this.bBatteryLeft_Click);
            // 
            // lblWinampLocation
            // 
            this.lblWinampLocation.AutoSize = true;
            this.lblWinampLocation.Location = new System.Drawing.Point(21, 51);
            this.lblWinampLocation.Name = "lblWinampLocation";
            this.lblWinampLocation.Size = new System.Drawing.Size(87, 13);
            this.lblWinampLocation.TabIndex = 0;
            this.lblWinampLocation.Text = "Path to Winamp:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "C:\\Program Files\\Winamp\\winamp.exe";
            // 
            // bWinampLocationBrowse
            // 
            this.bWinampLocationBrowse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bWinampLocationBrowse.Location = new System.Drawing.Point(335, 48);
            this.bWinampLocationBrowse.Name = "bWinampLocationBrowse";
            this.bWinampLocationBrowse.Size = new System.Drawing.Size(41, 21);
            this.bWinampLocationBrowse.TabIndex = 2;
            this.bWinampLocationBrowse.Text = ". . .";
            this.bWinampLocationBrowse.UseVisualStyleBackColor = true;
            this.bWinampLocationBrowse.Click += new System.EventHandler(this.bWinampLocationBrowse_Click);
            // 
            // lblCpuConf
            // 
            this.lblCpuConf.AutoSize = true;
            this.lblCpuConf.Location = new System.Drawing.Point(6, 46);
            this.lblCpuConf.Name = "lblCpuConf";
            this.lblCpuConf.Size = new System.Drawing.Size(158, 13);
            this.lblCpuConf.TabIndex = 3;
            this.lblCpuConf.Text = "This module have no settings...";
            // 
            // lblNetworkConf
            // 
            this.lblNetworkConf.AutoSize = true;
            this.lblNetworkConf.Location = new System.Drawing.Point(6, 46);
            this.lblNetworkConf.Name = "lblNetworkConf";
            this.lblNetworkConf.Size = new System.Drawing.Size(158, 13);
            this.lblNetworkConf.TabIndex = 5;
            this.lblNetworkConf.Text = "This module have no settings...";
            // 
            // lblBatteryConf
            // 
            this.lblBatteryConf.AutoSize = true;
            this.lblBatteryConf.Location = new System.Drawing.Point(6, 46);
            this.lblBatteryConf.Name = "lblBatteryConf";
            this.lblBatteryConf.Size = new System.Drawing.Size(158, 13);
            this.lblBatteryConf.TabIndex = 5;
            this.lblBatteryConf.Text = "This module have no settings...";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.gbLocation);
            this.gbGeneral.Controls.Add(this.gbColors);
            this.gbGeneral.Location = new System.Drawing.Point(12, 46);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(384, 96);
            this.gbGeneral.TabIndex = 4;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // gbCPU
            // 
            this.gbCPU.Controls.Add(this.lblCpuConf);
            this.gbCPU.Controls.Add(this.cbCPU);
            this.gbCPU.Controls.Add(this.bCpuRight);
            this.gbCPU.Controls.Add(this.bCpuLeft);
            this.gbCPU.Location = new System.Drawing.Point(12, 148);
            this.gbCPU.Name = "gbCPU";
            this.gbCPU.Size = new System.Drawing.Size(384, 68);
            this.gbCPU.TabIndex = 5;
            this.gbCPU.TabStop = false;
            this.gbCPU.Text = "CPU Monitor";
            // 
            // gbMemory
            // 
            this.gbMemory.Controls.Add(this.lblMemoryConf);
            this.gbMemory.Controls.Add(this.cbMemory);
            this.gbMemory.Controls.Add(this.bMemoryRight);
            this.gbMemory.Controls.Add(this.bMemoryLeft);
            this.gbMemory.Location = new System.Drawing.Point(12, 222);
            this.gbMemory.Name = "gbMemory";
            this.gbMemory.Size = new System.Drawing.Size(384, 68);
            this.gbMemory.TabIndex = 6;
            this.gbMemory.TabStop = false;
            this.gbMemory.Text = "Memory Monitor";
            // 
            // lblMemoryConf
            // 
            this.lblMemoryConf.AutoSize = true;
            this.lblMemoryConf.Location = new System.Drawing.Point(6, 46);
            this.lblMemoryConf.Name = "lblMemoryConf";
            this.lblMemoryConf.Size = new System.Drawing.Size(158, 13);
            this.lblMemoryConf.TabIndex = 3;
            this.lblMemoryConf.Text = "This module have no settings...";
            // 
            // gbNetwork
            // 
            this.gbNetwork.Controls.Add(this.lblNetworkConf);
            this.gbNetwork.Controls.Add(this.cbNetwork);
            this.gbNetwork.Controls.Add(this.bNetworkRight);
            this.gbNetwork.Controls.Add(this.bNetworkLeft);
            this.gbNetwork.Location = new System.Drawing.Point(12, 296);
            this.gbNetwork.Name = "gbNetwork";
            this.gbNetwork.Size = new System.Drawing.Size(384, 68);
            this.gbNetwork.TabIndex = 7;
            this.gbNetwork.TabStop = false;
            this.gbNetwork.Text = "Network Monitor";
            // 
            // gbUptime
            // 
            this.gbUptime.Controls.Add(this.cbUptimeHideDays);
            this.gbUptime.Controls.Add(this.bUptimeRight);
            this.gbUptime.Controls.Add(this.cbUptime);
            this.gbUptime.Controls.Add(this.bUptimeLeft);
            this.gbUptime.Location = new System.Drawing.Point(12, 370);
            this.gbUptime.Name = "gbUptime";
            this.gbUptime.Size = new System.Drawing.Size(384, 74);
            this.gbUptime.TabIndex = 8;
            this.gbUptime.TabStop = false;
            this.gbUptime.Text = "Uptime";
            // 
            // cbUptimeHideDays
            // 
            this.cbUptimeHideDays.AutoSize = true;
            this.cbUptimeHideDays.Location = new System.Drawing.Point(16, 49);
            this.cbUptimeHideDays.Name = "cbUptimeHideDays";
            this.cbUptimeHideDays.Size = new System.Drawing.Size(202, 17);
            this.cbUptimeHideDays.TabIndex = 5;
            this.cbUptimeHideDays.Text = "Hide days until uptime reaches 1 day";
            this.cbUptimeHideDays.UseVisualStyleBackColor = true;
            // 
            // gbBattery
            // 
            this.gbBattery.Controls.Add(this.lblBatteryConf);
            this.gbBattery.Controls.Add(this.cbBattery);
            this.gbBattery.Controls.Add(this.bBatteryRight);
            this.gbBattery.Controls.Add(this.bBatteryLeft);
            this.gbBattery.Location = new System.Drawing.Point(402, 46);
            this.gbBattery.Name = "gbBattery";
            this.gbBattery.Size = new System.Drawing.Size(384, 68);
            this.gbBattery.TabIndex = 9;
            this.gbBattery.TabStop = false;
            this.gbBattery.Text = "Battery Monitor";
            // 
            // gbFeed
            // 
            this.gbFeed.Controls.Add(this.lblFeedModuleWidthSet);
            this.gbFeed.Controls.Add(this.txtFeedModuleWidth);
            this.gbFeed.Controls.Add(this.txtFeedHeadlineNum);
            this.gbFeed.Controls.Add(this.lblFeedModuleWidth);
            this.gbFeed.Controls.Add(this.lblFeedHeadlineNum);
            this.gbFeed.Controls.Add(this.txtFeedURL);
            this.gbFeed.Controls.Add(this.lblFeedURL);
            this.gbFeed.Controls.Add(this.cbFeed);
            this.gbFeed.Controls.Add(this.bFeedRight);
            this.gbFeed.Controls.Add(this.bFeedLeft);
            this.gbFeed.Enabled = false;
            this.gbFeed.Location = new System.Drawing.Point(402, 207);
            this.gbFeed.Name = "gbFeed";
            this.gbFeed.Size = new System.Drawing.Size(384, 157);
            this.gbFeed.TabIndex = 10;
            this.gbFeed.TabStop = false;
            this.gbFeed.Text = "RSS Feed";
            // 
            // cbFeed
            // 
            this.cbFeed.AutoSize = true;
            this.cbFeed.Location = new System.Drawing.Point(9, 23);
            this.cbFeed.Margin = new System.Windows.Forms.Padding(6);
            this.cbFeed.Name = "cbFeed";
            this.cbFeed.Size = new System.Drawing.Size(109, 17);
            this.cbFeed.TabIndex = 4;
            this.cbFeed.Text = "Show this module";
            this.cbFeed.UseVisualStyleBackColor = true;
            // 
            // bFeedRight
            // 
            this.bFeedRight.Enabled = false;
            this.bFeedRight.Image = global::dk.reptail.infobar.Properties.Resources.arrow_right;
            this.bFeedRight.Location = new System.Drawing.Point(160, 21);
            this.bFeedRight.Name = "bFeedRight";
            this.bFeedRight.Size = new System.Drawing.Size(18, 18);
            this.bFeedRight.TabIndex = 6;
            this.bFeedRight.UseVisualStyleBackColor = true;
            // 
            // bFeedLeft
            // 
            this.bFeedLeft.Enabled = false;
            this.bFeedLeft.Image = global::dk.reptail.infobar.Properties.Resources.arrow_left;
            this.bFeedLeft.Location = new System.Drawing.Point(137, 21);
            this.bFeedLeft.Name = "bFeedLeft";
            this.bFeedLeft.Size = new System.Drawing.Size(18, 18);
            this.bFeedLeft.TabIndex = 5;
            this.bFeedLeft.UseVisualStyleBackColor = true;
            // 
            // lblFeedURL
            // 
            this.lblFeedURL.AutoSize = true;
            this.lblFeedURL.Location = new System.Drawing.Point(9, 50);
            this.lblFeedURL.Name = "lblFeedURL";
            this.lblFeedURL.Size = new System.Drawing.Size(57, 13);
            this.lblFeedURL.TabIndex = 7;
            this.lblFeedURL.Text = "Feed URL:";
            // 
            // txtFeedURL
            // 
            this.txtFeedURL.Location = new System.Drawing.Point(12, 66);
            this.txtFeedURL.Name = "txtFeedURL";
            this.txtFeedURL.Size = new System.Drawing.Size(364, 21);
            this.txtFeedURL.TabIndex = 8;
            // 
            // lblFeedHeadlineNum
            // 
            this.lblFeedHeadlineNum.AutoSize = true;
            this.lblFeedHeadlineNum.Location = new System.Drawing.Point(9, 96);
            this.lblFeedHeadlineNum.Name = "lblFeedHeadlineNum";
            this.lblFeedHeadlineNum.Size = new System.Drawing.Size(157, 13);
            this.lblFeedHeadlineNum.TabIndex = 9;
            this.lblFeedHeadlineNum.Text = "Show this number of headlines:";
            // 
            // txtFeedHeadlineNum
            // 
            this.txtFeedHeadlineNum.Location = new System.Drawing.Point(172, 93);
            this.txtFeedHeadlineNum.Name = "txtFeedHeadlineNum";
            this.txtFeedHeadlineNum.Size = new System.Drawing.Size(29, 21);
            this.txtFeedHeadlineNum.TabIndex = 10;
            this.txtFeedHeadlineNum.Text = "5";
            this.txtFeedHeadlineNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFeedModuleWidth
            // 
            this.txtFeedModuleWidth.Location = new System.Drawing.Point(172, 121);
            this.txtFeedModuleWidth.Name = "txtFeedModuleWidth";
            this.txtFeedModuleWidth.Size = new System.Drawing.Size(100, 21);
            this.txtFeedModuleWidth.TabIndex = 11;
            // 
            // lblFeedModuleWidth
            // 
            this.lblFeedModuleWidth.AutoSize = true;
            this.lblFeedModuleWidth.Location = new System.Drawing.Point(9, 124);
            this.lblFeedModuleWidth.Name = "lblFeedModuleWidth";
            this.lblFeedModuleWidth.Size = new System.Drawing.Size(101, 13);
            this.lblFeedModuleWidth.TabIndex = 9;
            this.lblFeedModuleWidth.Text = "Feed Module width:";
            // 
            // lblFeedModuleWidthSet
            // 
            this.lblFeedModuleWidthSet.AutoSize = true;
            this.lblFeedModuleWidthSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFeedModuleWidthSet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedModuleWidthSet.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFeedModuleWidthSet.Location = new System.Drawing.Point(278, 124);
            this.lblFeedModuleWidthSet.Name = "lblFeedModuleWidthSet";
            this.lblFeedModuleWidthSet.Size = new System.Drawing.Size(23, 13);
            this.lblFeedModuleWidthSet.TabIndex = 12;
            this.lblFeedModuleWidthSet.Text = "Set";
            // 
            // gbGoogle
            // 
            this.gbGoogle.Controls.Add(this.lblGoogleConf);
            this.gbGoogle.Controls.Add(this.cbGoogle);
            this.gbGoogle.Controls.Add(this.bGoogleLeft);
            this.gbGoogle.Controls.Add(this.bGoogleRight);
            this.gbGoogle.Enabled = false;
            this.gbGoogle.Location = new System.Drawing.Point(403, 370);
            this.gbGoogle.Name = "gbGoogle";
            this.gbGoogle.Size = new System.Drawing.Size(383, 74);
            this.gbGoogle.TabIndex = 11;
            this.gbGoogle.TabStop = false;
            this.gbGoogle.Text = "Google Search";
            // 
            // bGoogleLeft
            // 
            this.bGoogleLeft.Enabled = false;
            this.bGoogleLeft.Image = global::dk.reptail.infobar.Properties.Resources.arrow_left;
            this.bGoogleLeft.Location = new System.Drawing.Point(136, 19);
            this.bGoogleLeft.Name = "bGoogleLeft";
            this.bGoogleLeft.Size = new System.Drawing.Size(18, 18);
            this.bGoogleLeft.TabIndex = 3;
            this.bGoogleLeft.UseVisualStyleBackColor = true;
            this.bGoogleLeft.Click += new System.EventHandler(this.bNetworkLeft_Click);
            // 
            // bGoogleRight
            // 
            this.bGoogleRight.Enabled = false;
            this.bGoogleRight.Image = global::dk.reptail.infobar.Properties.Resources.arrow_right;
            this.bGoogleRight.Location = new System.Drawing.Point(159, 19);
            this.bGoogleRight.Name = "bGoogleRight";
            this.bGoogleRight.Size = new System.Drawing.Size(18, 18);
            this.bGoogleRight.TabIndex = 4;
            this.bGoogleRight.UseVisualStyleBackColor = true;
            this.bGoogleRight.Click += new System.EventHandler(this.bNetworkRight_Click);
            // 
            // cbGoogle
            // 
            this.cbGoogle.AutoSize = true;
            this.cbGoogle.Location = new System.Drawing.Point(8, 21);
            this.cbGoogle.Margin = new System.Windows.Forms.Padding(6);
            this.cbGoogle.Name = "cbGoogle";
            this.cbGoogle.Size = new System.Drawing.Size(109, 17);
            this.cbGoogle.TabIndex = 1;
            this.cbGoogle.Text = "Show this module";
            this.cbGoogle.UseVisualStyleBackColor = true;
            // 
            // lblGoogleConf
            // 
            this.lblGoogleConf.AutoSize = true;
            this.lblGoogleConf.Location = new System.Drawing.Point(5, 44);
            this.lblGoogleConf.Name = "lblGoogleConf";
            this.lblGoogleConf.Size = new System.Drawing.Size(158, 13);
            this.lblGoogleConf.TabIndex = 5;
            this.lblGoogleConf.Text = "This module have no settings...";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 484);
            this.Controls.Add(this.gbGoogle);
            this.Controls.Add(this.gbFeed);
            this.Controls.Add(this.gbWinamp);
            this.Controls.Add(this.gbBattery);
            this.Controls.Add(this.gbUptime);
            this.Controls.Add(this.gbNetwork);
            this.Controls.Add(this.gbMemory);
            this.Controls.Add(this.gbCPU);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepBar Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            this.gbColors.ResumeLayout(false);
            this.gbColors.PerformLayout();
            this.gbWinamp.ResumeLayout(false);
            this.gbWinamp.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbCPU.ResumeLayout(false);
            this.gbCPU.PerformLayout();
            this.gbMemory.ResumeLayout(false);
            this.gbMemory.PerformLayout();
            this.gbNetwork.ResumeLayout(false);
            this.gbNetwork.PerformLayout();
            this.gbUptime.ResumeLayout(false);
            this.gbUptime.PerformLayout();
            this.gbBattery.ResumeLayout(false);
            this.gbBattery.PerformLayout();
            this.gbFeed.ResumeLayout(false);
            this.gbFeed.PerformLayout();
            this.gbGoogle.ResumeLayout(false);
            this.gbGoogle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbColors;
        private System.Windows.Forms.Label lblBackgroundColorBox;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lblGraphBox;
        private System.Windows.Forms.Label lblGraph;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.RadioButton rbBottom;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.CheckBox cbCPU;
        private System.Windows.Forms.CheckBox cbMemory;
        private System.Windows.Forms.CheckBox cbNetwork;
        private System.Windows.Forms.CheckBox cbUptime;
        private System.Windows.Forms.CheckBox cbBattery;
        private System.Windows.Forms.CheckBox cbWinamp;
        private System.Windows.Forms.Button bCpuRight;
        private System.Windows.Forms.Button bCpuLeft;
        private System.Windows.Forms.Button bMemoryRight;
        private System.Windows.Forms.Button bMemoryLeft;
        private System.Windows.Forms.Button bWinampRight;
        private System.Windows.Forms.Button bWinampLeft;
        private System.Windows.Forms.GroupBox gbWinamp;
        private System.Windows.Forms.Button bNetworkRight;
        private System.Windows.Forms.Button bNetworkLeft;
        private System.Windows.Forms.Button bUptimeRight;
        private System.Windows.Forms.Button bUptimeLeft;
        private System.Windows.Forms.Button bBatteryRight;
        private System.Windows.Forms.Button bBatteryLeft;
        private System.Windows.Forms.Button bWinampLocationBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblWinampLocation;
        private System.Windows.Forms.Label lblCpuConf;
        private System.Windows.Forms.Label lblNetworkConf;
        private System.Windows.Forms.Label lblBatteryConf;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.GroupBox gbCPU;
        private System.Windows.Forms.GroupBox gbMemory;
        private System.Windows.Forms.Label lblMemoryConf;
        private System.Windows.Forms.GroupBox gbNetwork;
        private System.Windows.Forms.GroupBox gbUptime;
        private System.Windows.Forms.CheckBox cbUptimeHideDays;
        private System.Windows.Forms.GroupBox gbBattery;
        private System.Windows.Forms.GroupBox gbFeed;
        private System.Windows.Forms.Label lblFeedURL;
        private System.Windows.Forms.CheckBox cbFeed;
        private System.Windows.Forms.Button bFeedRight;
        private System.Windows.Forms.Button bFeedLeft;
        private System.Windows.Forms.Label lblFeedHeadlineNum;
        private System.Windows.Forms.TextBox txtFeedURL;
        private System.Windows.Forms.TextBox txtFeedHeadlineNum;
        private System.Windows.Forms.TextBox txtFeedModuleWidth;
        private System.Windows.Forms.Label lblFeedModuleWidthSet;
        private System.Windows.Forms.Label lblFeedModuleWidth;
        private System.Windows.Forms.GroupBox gbGoogle;
        private System.Windows.Forms.Label lblGoogleConf;
        private System.Windows.Forms.CheckBox cbGoogle;
        private System.Windows.Forms.Button bGoogleLeft;
        private System.Windows.Forms.Button bGoogleRight;
    }
}