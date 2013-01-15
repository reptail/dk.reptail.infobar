using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemMonitor;

namespace dk.reptail.infobar.Modules
{
    public partial class CPUMonitor : Module
    {
        public CPUMonitor(SystemData sysData)
        {
            InitializeComponent();
            _sysData = sysData;
        }

        private SystemData _sysData;

        public override void UpdateData()
        {
            string s = _sysData.GetProcessorData();
            double d = RoundUp(double.Parse(s.Substring(0, s.IndexOf("%"))));
            lblCPU.Text = d.ToString() + " %";
            dataCPU.UpdateChart(d);
        }

        private double RoundUp(double valueToRound)
        {
            return (Math.Floor(valueToRound + 0.5));
        }
    }
}
