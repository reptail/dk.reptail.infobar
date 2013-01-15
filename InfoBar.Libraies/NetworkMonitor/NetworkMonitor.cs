using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Echevil.NetworkMonitor
{
    /// <summary>
    /// The NetworkMonitor class monitors network speed for each network adapter on the computer,
    /// using classes for Performance counter in .NET library.
    /// </summary>
    public class NetworkMonitor
    {
        private Timer timer;						// The timer event executes every second to refresh the values in adapters.
        private ArrayList adapters;					// The list of adapters on the computer.
        private ArrayList monitoredAdapters;		// The list of currently monitored adapters.

        // My network adapters in Laptop and Stationary computers
        private List<string> _myNetworkAdapters = new List<string>();

        public NetworkMonitor(List<string> adapters = null)
        {
            // Check if predefined list of adapters was provided.
            if (adapters == null)
            {
                // Otherwise, try to determine default network adapters automatically:
                // Define adapter types
                NetworkInterfaceType[] types = {
                    NetworkInterfaceType.Ethernet, 
                    NetworkInterfaceType.Ethernet3Megabit, 
                    NetworkInterfaceType.FastEthernetFx,
                    NetworkInterfaceType.FastEthernetT,
                    NetworkInterfaceType.GigabitEthernet,
                    NetworkInterfaceType.Wireless80211 
                };

                // Load adapters on machine
                NetworkInterface[] ni = NetworkInterface.GetAllNetworkInterfaces();
                foreach (var i in ni)
                {
                    if (i.OperationalStatus == OperationalStatus.Up && Array.IndexOf(types, i.NetworkInterfaceType) != -1)
                    {
                        // Add interface to adapter list if interface is up and has one of the defined types.
                        _myNetworkAdapters.Add(i.Description);
                    }
                }
            }
            else
            {
                _myNetworkAdapters = adapters;
            }

            this.adapters = new ArrayList();
            this.monitoredAdapters = new ArrayList();
            EnumerateNetworkAdapters();

            timer = new Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
        }

        /// <summary>
        /// Enumerates network adapters installed on the computer.
        /// </summary>
        private void EnumerateNetworkAdapters()
        {
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");

            string[] temp = category.GetInstanceNames();

            foreach (string name in temp)
            {
                string found = _myNetworkAdapters.Find(delegate(string s) { if (name.StartsWith(s)) { return true; } return false; });
                if (found == null | found == "")
                {
                    continue;
                }

                // Create an instance of NetworkAdapter class, and create performance counters for it.
                NetworkAdapter adapter = new NetworkAdapter(name);
                adapter.dlCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", name);
                adapter.ulCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", name);
                this.adapters.Add(adapter);			// Add it to ArrayList adapter
            }
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (NetworkAdapter adapter in this.monitoredAdapters)
                adapter.refresh();
        }

        /// <summary>
        /// Get instances of NetworkAdapter for installed adapters on this computer.
        /// </summary>
        public NetworkAdapter[] Adapters
        {
            get
            {
                return (NetworkAdapter[])this.adapters.ToArray(typeof(NetworkAdapter));
            }
        }

        // Enable the timer and add all adapters to the monitoredAdapters list, unless the adapters list is empty.
        public void StartMonitoring()
        {
            if (this.adapters.Count > 0)
            {
                foreach (NetworkAdapter adapter in this.adapters)
                    if (!this.monitoredAdapters.Contains(adapter))
                    {
                        this.monitoredAdapters.Add(adapter);
                        adapter.init();
                    }

                timer.Enabled = true;
            }
        }

        // Enable the timer, and add the specified adapter to the monitoredAdapters list
        public void StartMonitoring(NetworkAdapter adapter)
        {
            if (!this.monitoredAdapters.Contains(adapter))
            {
                this.monitoredAdapters.Add(adapter);
                adapter.init();
            }
            timer.Enabled = true;
        }

        // Disable the timer, and clear the monitoredAdapters list.
        public void StopMonitoring()
        {
            this.monitoredAdapters.Clear();
            timer.Enabled = false;
        }

        // Remove the specified adapter from the monitoredAdapters list, and disable the timer if the monitoredAdapters list is empty.
        public void StopMonitoring(NetworkAdapter adapter)
        {
            if (this.monitoredAdapters.Contains(adapter))
                this.monitoredAdapters.Remove(adapter);
            if (this.monitoredAdapters.Count == 0)
                timer.Enabled = false;
        }

        /* 
         *    Methods by RepTail 
         *    
         */

        // Make the monitor able to return DL and UL rates for all adapters
        public double GetDownloadRate()
        {
            double dl = 0.0;
            foreach (NetworkAdapter na in adapters)
            {
                dl += IsAcceptedInterface(na, Type.Download);
            }
            return dl;
        }

        public double GetUploadRate()
        {
            double ul = 0.0;
            foreach (NetworkAdapter na in adapters)
            {
                ul += IsAcceptedInterface(na, Type.Upload);
            }
            return ul;
        }

        private double IsAcceptedInterface(NetworkAdapter na, Type type)
        {

            if (type == Type.Download)
            {
                return na.DownloadSpeed;
            }
            else if (type == Type.Upload)
            {
                return na.UploadSpeed;
            }
            else
            {
                return 0.0;
            }

        }

        private enum Type { Download, Upload }

    }
}
