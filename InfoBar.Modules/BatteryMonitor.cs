using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dk.reptail.infobar.Modules
{
    public partial class BatteryMonitor : Module
    {   
        public BatteryMonitor()
        {
            InitializeComponent();
            UpdateData();
        }

        public override void UpdateData()
        { 
            PowerStatus power = SystemInformation.PowerStatus;
            
            if (power.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)
            {
                lblBattery.Text = "No Battery";
            }
            else if (power.PowerLineStatus == PowerLineStatus.Online)
            {
                float battery = power.BatteryLifePercent * 100;
                lblBattery.Text = battery.ToString() + "% [AC]";
            }
            else if (power.BatteryChargeStatus == BatteryChargeStatus.Unknown)
            {
                lblBattery.Text = "Unknown Status";
            }
            else
            {
                float battery = power.BatteryLifePercent * 100;
                lblBattery.Text = battery.ToString() + "%";
            }

            // Resizing module
            int label = lblBattery.Location.X + lblBattery.Size.Width - 4;
            this.Size = new Size(label, this.Size.Height);
        }
    }
}
