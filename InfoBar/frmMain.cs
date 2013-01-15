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
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;
using dk.reptail.infobar.Properties;
using System.Net.NetworkInformation;
using SystemMonitor;

namespace dk.reptail.infobar
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    public partial class frmMain : ShellLib.ApplicationDesktopToolbar
    {
        private frmMain _form = null;
        private frmSettings _settings = null;
        public List<int> Modules { get; set; }
        private int _nextControlStart = 0;
        private bool _focusOnTick = true;
        private bool _isHidden = false;

        public SystemData _systemData;

        // Settings variables
        public Color BackgroundColor { get; set; }
        public Color GraphColor { get; set; }
        public AppBarEdges DockEdge { get; set; }

        public frmMain()
        {
            InitializeComponent();

            // Used to hide from Alt+Tab Window
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;

        }

        #region . Misc Methods .
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            _form = this;
            _form.Size = new Size(_form.Size.Width, 23);
            Modules = new List<int>();

            // Loading Settings File
            _systemData = new SystemData();
            LoadSettings();

            lblTop.Size = new Size(lblTop.Size.Height + 1, _form.Size.Width);
            lblTop.Location = _form.Location;

            updateTimer.Start();

            // Moving Right Buttons to edge of screen
            //bRightCollapse.Location = new Point(_form.Size.Width - bRightCollapse.Size.Width, bRightCollapse.Location.Y);
            //bMenu.Location = new Point(_form.Size.Width - bRightCollapse.Size.Width - bMenu.Size.Width, bMenu.Location.Y);
            bReset.Location = new Point(_form.Size.Width - bHide.Size.Width - bReset.Size.Width - 5 - 5, bReset.Location.Y);
            bHide.Location = new Point(_form.Size.Width - bHide.Size.Width - 5, bReset.Location.Y);

            // Resizing main Panal
            Panel.Size = new Size(_form.Size.Width - 15, _form.Size.Height);

            
        }

        public void AddModule(Module module)
        {
            if (module != null)
            {
                if (Panel.Controls.Count > 0)
                {
                    // Adding Seperator
                    Seperator sep = new Seperator();
                    sep.SetLocation(_nextControlStart);
                    _nextControlStart += sep.GetWidth();

                    Modules.Add(Panel.Controls.Count);
                    Panel.Controls.Add(sep);
                }
                module.SetLocation(_nextControlStart);
                module.Index = Modules.Count;
                _nextControlStart += module.GetWidth();
                Modules.Add(Panel.Controls.Count);
                Panel.Controls.Add(module);
            }
        }

        private void LoadSettings()
        {
            string file = "Settings.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            // Loading Modules
            XmlNodeList nodeList = doc.GetElementsByTagName("Modules");
            XmlNode modules = nodeList[0];
            foreach (XmlNode n in modules)
            {
                string type = n.Name;
                switch (type)
                {
                    case "BatteryMonitor":
                        AddModule(new BatteryMonitor());
                        break;
                    case "CPUMonitor":
                        AddModule(new CPUMonitor(_systemData));
                        break;
                    case "MemoryMonitor":
                        AddModule(new MemoryMonitor(_systemData));
                        break;
                    case "NetworkMonitor":
                        AddModule(new NetworkMonitor(_systemData));
                        break;
                    case "Uptime":
                        try
                        {
                            AddModule(new Uptime(bool.Parse(n.ChildNodes[0].FirstChild.Value)));
                        }
                        catch
                        {
                            AddModule(new Uptime());
                        }
                        break;
                    case "WinampControl":
                        AddModule(new WinampControl(n.ChildNodes[0].FirstChild.Value));
                        break;
                    case "WinampSongTicker":
                        AddModule(new WinampSongTicker(n.ChildNodes[0].FirstChild.Value));
                        break;
                    case "Spotify":

                        break;
                }

                //
                // Loading Global Settings
                //
                nodeList = doc.GetElementsByTagName("Global");
                XmlNode global = nodeList[0];

                // Setting colors
                Color backColor;
                Color graphColor;
                try
                {
                    backColor = Color.FromName(global.ChildNodes[0].FirstChild.Value);
                }
                catch
                {
                    backColor = Color.Gainsboro;
                }

                try
                {
                    graphColor = Color.FromName(global.ChildNodes[1].FirstChild.Value);
                }
                catch
                {
                    graphColor = Color.DarkBlue;
                }
                SetColors(backColor, graphColor);

                // Setting Bar Location
                string location = global.ChildNodes[2].FirstChild.Value;
                if (location == "Top")
                {
                    _form.Edge = AppBarEdges.Top;
                    _form.DockEdge = AppBarEdges.Top;
                }
                else
                {
                    _form.Edge = AppBarEdges.Bottom;
                    _form.DockEdge = AppBarEdges.Bottom;
                }
            }
        }

        public void SetColors(Color backColor, Color graphColor)
        {
            _form.BackColor = backColor;
            foreach (Module m in Panel.Controls)
            {
                m.SetBackgroundColor(backColor);
                m.SetGraphColor(graphColor);
                _form.BackgroundColor = backColor;
                _form.GraphColor = graphColor;
            }
        }
        
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (_focusOnTick)
            {
                this.Focus();
            }            
            int nextStart = 0;
            /*foreach (Module m in Panel.Controls)
            {
                m.UpdateData();
                m.SetLocation(nextStart);
                nextStart = m.Location.X + m.Size.Width;
            }*/
            foreach (int i in Modules)
            {
                try
                {
                    Module m = (Module)Panel.Controls[i];
                    m.UpdateData();
                    m.SetLocation(nextStart);
                    nextStart = m.Location.X + m.Size.Width;
                }
                catch { Console.WriteLine("ERROR: Could not recive module data!"); }
            }
        }

        public void RunTick()
        {
            _form.updateTimer_Tick(this, new EventArgs());
        }

        public void TimerStop()
        {
            updateTimer.Stop();
        }

        public void TimerStart()
        {
            updateTimer.Start();
        }

        private void DoReset()
        {
            dummy.Focus();
            this.Edge = AppBarEdges.Float;
            this.Edge = DockEdge;
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bMenu.Enabled = false;
            _focusOnTick = false;
            _settings = new frmSettings(_form);
            _settings.FormClosing +=new FormClosingEventHandler(Settings_Closing);
            _settings.Show();

        }

        private void Settings_Closing(object sender, EventArgs e)
        {
            _settings = null;
            //bMenu.Enabled = true;
            _focusOnTick = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _form.Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoReset();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            DoReset();
        }

        private void bHide_Click(object sender, EventArgs e)
        {
            //string val = "";
            //NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            //foreach (var i in interfaces)
            //{
            //    string str = i.Description + "\n";
            //    str += i.NetworkInterfaceType + "\n";
            //    NetworkInterfaceType.

            //    val += str + "\n";
            //}
            //MessageBox.Show(val);

            this.Focus();
        }

        private void bReset_MouseEnter(object sender, EventArgs e)
        {
            bReset.BackgroundImage = Resources.reset_w_bg_hover;
        }

        private void bReset_MouseLeave(object sender, EventArgs e)
        {
            bReset.BackgroundImage = Resources.reset_w_bg;
        }
    }
}
