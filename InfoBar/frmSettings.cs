using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dk.reptail.infobar.Modules;
using System.Xml;

namespace dk.reptail.infobar 
{
    public partial class frmSettings : Form
    {
        private frmMain _parent;

        // Module Indexes - 99 indicates that the module is not active
        private int _mCpu = 99;
        private int _mMemory = 99;
        private int _mBattery = 99;
        private int _mNetwork = 99;
        private int _mUptime = 99;
        private int _mWinamp = 99;
        
        public frmSettings(frmMain parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        

        #region .Private Methods.

        private void LoadSettings()
        {
            // Loading Modules
            foreach (int i in _parent.Modules)
            {
                Module m = (Module)_parent.Panel.Controls[i];
                string type = m.GetType().ToString().Split(new char[] {'.'})[1];
                switch (type)
                {
                    case "BatteryMonitor":
                        cbBattery.Checked = true;
                        cbBattery.CheckedChanged += new EventHandler(cbBattery_CheckedChanged);
                        bBatteryLeft.Enabled = true;
                        bBatteryRight.Enabled = true;
                        _mBattery = i;
                        break;
                    case "CPUMonitor":
                        cbCPU.Checked = true;
                        cbCPU.CheckedChanged +=new EventHandler(cbCPU_CheckedChanged);
                        bCpuLeft.Enabled = true;
                        bCpuRight.Enabled = true;
                        _mCpu = i;
                        break;
                    case "MemoryMonitor":
                        cbMemory.Checked = true;
                        cbMemory.CheckedChanged += new EventHandler(cbMemory_CheckedChanged);
                        bMemoryLeft.Enabled = true;
                        bMemoryRight.Enabled = true;
                        _mMemory = i;
                        break;
                    case "NetworkMonitor":
                        cbNetwork.Checked = true;
                        cbNetwork.CheckedChanged += new EventHandler(cbNetwork_CheckedChanged);
                        bNetworkLeft.Enabled = true;
                        bNetworkRight.Enabled = true;
                        _mNetwork = i;
                        break;
                    case "Uptime":
                        cbUptime.Checked = true;
                        cbUptime.CheckedChanged += new EventHandler(cbUptime_CheckedChanged);
                        bUptimeLeft.Enabled = true;
                        bUptimeRight.Enabled = true;
                        _mUptime = i;
                        break;
                    case "VolumeControl":
                        throw new NotImplementedException("This module has not yet been implemented!");
                    case "WinampControl":
                        cbWinamp.Checked = true;
                        cbWinamp.CheckedChanged += new EventHandler(cbWinamp_CheckedChanged);
                        bWinampLeft.Enabled = true;
                        bWinampRight.Enabled = true;
                        gbWinamp.Enabled = true;
                        _mWinamp = i;
                        break;
                }

                // Loading Global Settings
                lblBackgroundColorBox.BackColor = _parent.BackColor;
                lblGraphBox.BackColor = _parent.GraphColor;
                
                // Setting location
                //   Not implemented!
            }
        }

        private void UpdateSettings()
        {
            string file = "Settings.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            // Updating Global Settings


            // Removing all modules
            XmlNodeList nodeList = doc.GetElementsByTagName("modules");
            XmlNode global = nodeList[0];
            global.RemoveAll();

            // Adding modules
            

            // Saving file
            doc.Save(file);
        }

        private void UpdateIndex(string type, int newIndex)
        {
            switch (type)
            {
                case "BatteryMonitor":
                    _mBattery = newIndex;
                    break;
                case "CPUMonitor":
                    _mCpu = newIndex;
                    break;
                case "MemoryMonitor":
                    _mMemory = newIndex;
                    break;
                case "NetworkMonitor":
                    _mNetwork = newIndex;
                    break;
                case "Uptime":
                    _mUptime = newIndex;
                    break;
                case "WinampControl":
                    _mWinamp = newIndex;
                    break;
            }
        }

        private enum MoveDirections { Left, Right };
        private enum ModuleType { BatteryMonitor, CPUMonitor, MemoryMonitor, NetworkMonitor, Uptime, WinampControl, RSSFeed, GoogleSearch };

        /*private void MoveModule(int index, MoveDirections dir)
        {
            int newIndex = index;
            if (dir == MoveDirections.Left)
            {
                newIndex -= 2;
            }
            else
            {
                newIndex += 2;
            }

            //MessageBox.Show(oldIndex.ToString() + " - " + newIndex.ToString());
            bool totalLeftMove = false;
            bool totalRightMove = false;
            int lastIndex = _parent.Panel.Controls.Count - 1;
            int temp;

            if (index > newIndex) // Left move
            {
                if (newIndex < 0) // Move as last module
                {                    
                    newIndex = lastIndex;
                    totalLeftMove = true;
                }
            }
            else // Right move
            {

                if (newIndex > lastIndex) // Move as first module
                {
                    newIndex = 0;
                    totalRightMove = true;
                }
            }

            //MessageBox.Show(index.ToString() + " - " + newIndex.ToString());

            if (totalLeftMove)
            {
                temp = _parent.Modules[index];
                for (int i = index; i < lastIndex; i += 2)
                {
                    UpdateIndex(ModuleType(i + 2), i);
                    _parent.Modules[i] = _parent.Modules[i + 2];
                }
                UpdateIndex(ModuleType(temp), newIndex);
                _parent.Modules[newIndex] = temp;
            }
            else if (totalRightMove)
            {
                temp = _parent.Modules[index];
                for (int i = index; i > newIndex; i -= 2)
                {
                    string ty = ModuleType(i - 2);
                    UpdateIndex(ty, i);
                    _parent.Modules[i] = _parent.Modules[i - 2];
                }
                UpdateIndex(ModuleType(temp), newIndex);
                _parent.Modules[newIndex] = temp;
            }
            else
            {
                UpdateIndex(ModuleType(index), newIndex);
                UpdateIndex(ModuleType(newIndex), index);

                temp = _parent.Modules[newIndex];
                _parent.Modules[newIndex] = _parent.Modules[index];
                _parent.Modules[index] = temp;
            }

            _parent.RunTick();
            //string asdf = "asdf";
        }*/

        private void MoveModule(ModuleType mod, MoveDirections dir)
        {
            int position = 99;
            int destination = 99;
            Type type = null;
            int lastIndex = _parent.Panel.Controls.Count - 1;
            bool totalLeftMove = false;
            bool totalRightMove = false;
            int temp = 99;

            switch (mod)
            {
                case ModuleType.BatteryMonitor:
                    type = typeof(BatteryMonitor);
                    break;
                case ModuleType.CPUMonitor:
                    type = typeof(CPUMonitor);
                    break;
                case ModuleType.MemoryMonitor:
                    type = typeof(MemoryMonitor);
                    break;
                case ModuleType.NetworkMonitor:
                    type = typeof(NetworkMonitor);
                    break;
                case ModuleType.Uptime:
                    type = typeof(Uptime);
                    break;
                case ModuleType.WinampControl:
                    type = typeof(WinampControl);
                    break;
                /*case ModuleType.RSSFeed:
                    break;
                case ModuleType.GoogleSearch:
                    break;*/
            }

            for (int i = 0; i < _parent.Panel.Controls.Count; i++)
            {
                if (_parent.Panel.Controls[i].GetType() == type)
                {
                    Module m = (Module)_parent.Panel.Controls[i];
                    position = m.Index;
                }
            }

            if (position != 99)
            {
                destination = position;
                if (dir == MoveDirections.Left)
                {
                    destination -= 2;
                }
                else
                {
                    destination += 2;
                }

                if (position > destination)         // Left move
                {
                    if (destination < 0)            // Move as last module
                    {
                        destination = lastIndex;
                        totalLeftMove = true;
                    }
                }
                else                                // Right move
                {
                    if (destination > lastIndex)    // Move as first module
                    {
                        destination = 0;
                        totalRightMove = true;
                    }
                }

                if (totalLeftMove)                  // Move module as last module
                {
                    Module module;
                    temp = _parent.Modules[position];
                    for (int i = position; i < lastIndex; i += 2)
                    {
                        module = (Module)_parent.Panel.Controls[i + 2];
                        module.Index = i;
                        _parent.Modules[i] = _parent.Modules[i + 2];
                    }
                    module = (Module)_parent.Panel.Controls[temp];
                    module.Index = lastIndex;
                    _parent.Modules[lastIndex] = temp;
                }
                else if (totalRightMove)            // Move module as first module
                {
                    Module module;
                    temp = _parent.Modules[position];
                    for (int i = lastIndex; i > 0; i -= 2)
                    {
                        module = (Module)_parent.Panel.Controls[i - 2];
                        module.Index = i;
                        _parent.Modules[i] = _parent.Modules[i - 2];
                    }
                    module = (Module)_parent.Panel.Controls[temp];
                    module.Index = 0;
                    _parent.Modules[0] = temp;
                }
                else                                // Move module
                {
                    temp = _parent.Modules[position];
                    Module mod1 = (Module)_parent.Panel.Controls[temp];
                    Module mod2 = (Module)_parent.Panel.Controls[_parent.Modules[destination]];
                    mod1.Index = destination;
                    mod2.Index = position;
                    _parent.Modules[position] = _parent.Modules[destination];
                    _parent.Modules[destination] = temp;
                }

                _parent.RunTick();
            }
        }

        private void AddRemove(bool active, string type, int index)
        {
            if (active)
            {
                ShowModule(type);
            }
            else
            {
                RemoveModule(type, index); 
            }

            switch (type)
            {
                case "BatteryMonitor":
                    bBatteryLeft.Enabled = active;
                    bBatteryRight.Enabled = active;
                    lblBatteryConf.Enabled = active;
                    break;
                case "CPUMonitor":
                    bCpuLeft.Enabled = active;
                    bCpuRight.Enabled = active;
                    lblCpuConf.Enabled = active;
                    break;
                case "MemoryMonitor":
                    bMemoryLeft.Enabled = active;
                    bMemoryRight.Enabled = active;
                    lblMemoryConf.Enabled = active;
                    break;
                case "NetworkMonitor":
                    bNetworkLeft.Enabled = active;
                    bNetworkRight.Enabled = active;
                    lblNetworkConf.Enabled = active;
                    break;
                case "Uptime":
                    bUptimeLeft.Enabled = active;
                    bUptimeRight.Enabled = active;
                    cbUptimeHideDays.Enabled = active;
                    break;
                case "Uptime-hideDays":

                    break;
                case "WinampControl":
                    bWinampLeft.Enabled = active;
                    bWinampRight.Enabled = active;
                    bWinampLocationBrowse.Enabled = active;
                    lblWinampLocation.Enabled = active;
                    break;
            }
        }

        private void RemoveModule(string type, int index)
        {
            _parent.TimerStop();
            int index2 = _parent.Modules[index];
            //MessageBox.Show(index.ToString() + " " + index2.ToString());
            if (index != 0)
            {
                _parent.Panel.Controls.RemoveAt(index2 - 1);
                _parent.Modules.RemoveAt(index - 1);
                index -= 1;
                index2 -= 1;
            }
            _parent.Panel.Controls.RemoveAt(index2);
            _parent.Modules.RemoveAt(index);
            UpdateIndex(type, 99);
            _parent.TimerStart();
        }

        private void ShowModule(string type)
        {
            switch (type)
            {
                case "BatteryMonitor":
                    _parent.AddModule(new BatteryMonitor());
                    _mBattery = _parent.Modules[_parent.Modules.Count - 1];
                    break;
                case "CPUMonitor":
                    _parent.AddModule(new CPUMonitor(_parent._systemData));
                    _mCpu = _parent.Modules[_parent.Modules.Count - 1];
                    break;
                case "MemoryMonitor":
                    _parent.AddModule(new MemoryMonitor(_parent._systemData));
                    _mMemory = _parent.Modules[_parent.Modules.Count - 1];
                    break;
                case "NetworkMonitor":
                    _parent.AddModule(new NetworkMonitor(_parent._systemData));
                    _mNetwork = _parent.Modules[_parent.Modules.Count - 1];
                    break;
                case "Uptime":
                    _parent.AddModule(new Uptime());
                    _mUptime = _parent.Modules[_parent.Modules.Count - 1];
                    break;
                case "Uptime-hideDays":
                    _parent.AddModule(new Uptime(true));
                    _mUptime = _parent.Modules[_parent.Modules.Count - 1];
                    break;
                case "WinampControl":
                    _parent.AddModule(new WinampControl(null));
                    _mWinamp = _parent.Modules[_parent.Modules.Count - 1];
                    break;
            }
        }

        #endregion
        


        #region .Event Methods.

        #region .Misc.
        
        private void frmSettings_Load(object sender, EventArgs e)
        {
            // Loading Settings
            LoadSettings();
            //UpdateSettings();
        }

        private void lblBackgroundColorBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = lblBackgroundColorBox.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblBackgroundColorBox.BackColor = colorDialog.Color;
                foreach (Module m in _parent.Panel.Controls)
                {
                    m.SetBackgroundColor(colorDialog.Color);
                }
                _parent.BackColor = colorDialog.Color;
            }
        }

        private void lblGraphBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = lblGraphBox.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblGraphBox.BackColor = colorDialog.Color;
                foreach (Module m in _parent.Panel.Controls)
                {
                    m.SetGraphColor(colorDialog.Color);
                }
            }
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings to XML
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region .Battery.
        private void cbBattery_CheckedChanged(object sender, EventArgs e)
        {
            AddRemove(cbBattery.Checked, "BatteryMonitor", _mBattery);
        }
        private void bBatteryLeft_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.BatteryMonitor, MoveDirections.Left);
        }
        private void bBatteryRight_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.BatteryMonitor, MoveDirections.Right);
        }
        #endregion

        #region .CPU.
        private void cbCPU_CheckedChanged(object sender, EventArgs e)
        {
            AddRemove(cbCPU.Checked, "CPUMonitor", _mCpu);
        }
        private void bCpuLeft_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.CPUMonitor, MoveDirections.Left);
        }
        private void bCpuRight_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.CPUMonitor, MoveDirections.Right);
        }
        #endregion

        #region .Memory. 
        private void cbMemory_CheckedChanged(object sender, EventArgs e)
        {
            AddRemove(cbMemory.Checked, "MemoryMonitor", _mMemory);
        }
        private void bMemoryLeft_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.MemoryMonitor, MoveDirections.Left);
        }
        private void bMemoryRight_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.MemoryMonitor, MoveDirections.Right);
        }
        #endregion

        #region .Network.
        private void cbNetwork_CheckedChanged(object sender, EventArgs e)
        {
            AddRemove(cbNetwork.Checked, "NetworkMonitor", _mNetwork);
        }
        private void bNetworkLeft_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.NetworkMonitor, MoveDirections.Left);
        }
        private void bNetworkRight_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.NetworkMonitor, MoveDirections.Right);
        }
        #endregion

        #region .Uptime.
        private void cbUptime_CheckedChanged(object sender, EventArgs e)
        {
            AddRemove(cbUptime.Checked, "Uptime", _mUptime);
        }
        private void bUptimeLeft_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.Uptime, MoveDirections.Left);
        }
        private void bUptimeRight_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.Uptime, MoveDirections.Right);
        }
        #endregion

        #region .Winamp.
        private void cbWinamp_CheckedChanged(object sender, EventArgs e)
        {
            AddRemove(cbWinamp.Checked, "WinampControl", _mWinamp);
        }
        private void bWinampLeft_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.WinampControl, MoveDirections.Left);
        }
        private void bWinampRight_Click(object sender, EventArgs e)
        {
            MoveModule(ModuleType.WinampControl, MoveDirections.Right);
        }
        private void bWinampLocationBrowse_Click(object sender, EventArgs e)
        {
            WinampControl w = (WinampControl)_parent.Panel.Controls[_parent.Modules[_mWinamp]];
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.SpecialFolder.ProgramFiles.ToString();
            file.Filter = "Winamp (winamp.exe)|winamp.exe|All files (*.*)|*.*";
            
            if (file.ShowDialog() == DialogResult.OK)
            {
                w.WinampPath = file.FileName;
                lblWinampLocation.Text = file.FileName;
            }
        }
        #endregion


        
        #endregion

        

        

        
    }
}
