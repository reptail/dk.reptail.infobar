using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace dk.reptail.infobar.Modules
{
    public partial class Uptime : Module
    {
        private bool _hideDays = false;

        public Uptime(bool hideDays)
        {
            InitializeComponent();
            _hideDays = hideDays;
        }

        public Uptime() : this(false) {  }

        private PerformanceCounter _uptime = new PerformanceCounter("System", "System Up Time");
    
        private void Uptime_Load(object sender, EventArgs e)
        {
            _uptime.NextValue();
        }

        public override void UpdateData()
        {
            //lblUptime.Text = _uptime.NextValue().ToString();
            lblUptime.Text = GetUptime();

            // Resizing module
            int width = lblUptime.Location.X + lblUptime.Size.Width - 4;
            this.Size = new Size(width, this.Size.Height);
        }

        private string GetUptime()
        {

            TimeSpan ts = TimeSpan.FromSeconds(_uptime.NextValue());
            string d = ts.Days.ToString();
            string h = ts.Hours.ToString();
            string m = ts.Minutes.ToString();
            string s = ts.Seconds.ToString();
            if (h.Length <= 1)
            {
                h = "0" + h;
            }
            if (m.Length <= 1)
            {
                m = "0" + m;
            }
            if (s.Length <= 1)
            {
                s = "0" + s;
            }

            string uptime = h + ":" + m + ":" + s;
            if (_hideDays)
            {
                if (d != "0")
                {
                    uptime = d + "d " + uptime;
                }
            }
            else
            {
                uptime = d + "d " + uptime;
            }

            return uptime;
        }
            
        
    }
}
