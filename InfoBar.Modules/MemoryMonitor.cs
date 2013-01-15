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
    public partial class MemoryMonitor : Module
    {
        public MemoryMonitor(SystemData sysData)
        {
            InitializeComponent();
            _sysData = sysData;
        }

        private SystemData _sysData;

        public override void UpdateData()
        {
            string s = _sysData.GetMemoryPData();
            double d = _sysData.GetMemoryPercentage();
            lblMem.Text = s;
            dataMem.UpdateChart(d - 5);
        }
    }
}
