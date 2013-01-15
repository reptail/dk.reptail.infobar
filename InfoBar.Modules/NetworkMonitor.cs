using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemMonitor;
using Echevil.NetworkMonitor;

namespace dk.reptail.infobar.Modules
{
    public partial class NetworkMonitor : Module
    {
        public NetworkMonitor(SystemData sysData)
        {
            InitializeComponent();
            _netMonitor = new Echevil.NetworkMonitor.NetworkMonitor();
        }

        private Echevil.NetworkMonitor.NetworkMonitor _netMonitor;
        private bool _isStarted = false;

        /// <summary>
        ///     Updates the data of the module.
        /// </summary>
        public override void UpdateData()
        {
            if (!_isStarted)
            {
                _netMonitor.StartMonitoring();
            }

            lblDown.Text = CalcValue(_netMonitor.GetDownloadRate());
            lblUp.Text = CalcValue(_netMonitor.GetUploadRate());
        }


        /// <summary>
        ///     Calculates the current value for network traffic.
        /// </summary>
        /// <param name="value">The original bytes value of network traffic.</param>
        /// <returns>A string representing the value in either KB, MB or GB.</returns>
        private string CalcValue(double value)
        {
            // The letter representation of the units
            string[] units = { "K", "M", "G" };
            int i = 0;
            // Starting by converting to kilobytes
            value = value / 1024;
            // Continue converting as long as the value is over 1024
            while (value > 1024)
            {
                value = value / 1024;
                i++;
                if (i == 2)
                {
                    // Stop calculating if value is in gigabyte.
                    break; 
                }
            }

            return value.ToString("N1") + units[i];
        }
    }
}
