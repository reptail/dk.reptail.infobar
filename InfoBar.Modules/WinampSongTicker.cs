using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using WinampFrontEndLib;
using System.Threading;
using System.IO;

namespace dk.reptail.infobar.Modules
{
    public partial class WinampSongTicker : Module
    {
        private string _winampLocation = @"c:\Program Files\Winamp\winamp.exe";
        private string _64bitLocation = @"c:\Program Files (x86)\Winamp\winamp.exe";
        private bool _isRunning = false;

        public WinampSongTicker(string path)
        {
            InitializeComponent();
            if (path != null)
            {
                _winampLocation = path;
            }
            UpdateData();
            this.Focus();
        }

        public WinampSongTicker() : this(null) { }

        private void UpdateWinampStatus()
        {
            Process[] winamp = Process.GetProcessesByName("winamp");
            if (winamp.Length > 0)
            {
                //this.Visible = true;
                _isRunning = true;
            }
            else
            {
                _isRunning = false;
                //this.Visible = false;
            }

        }

        public override void UpdateData()
        {
            UpdateWinampStatus();
            ttImg.SetToolTip(this.imgWinamp, SongTitle());
            lblSongName.Text = SongTitle(40);
        }

        private string SongTitle(int limit)
        {
            string title = WinampLib.GetCurrentSongTitle();
            if (title == "N/A")
            {
                title = "Winamp is not running!";
            }
            else
            {
                if (limit > 0 && title.Length > limit)
                {
                    string[] t = title.Split(new char[] {' '});
                    string str = "";
                    foreach (string s in t)
                    {
                        if ((str + " " + s).Length < limit)
                        {
                            str += " " + s;
                        }
                        else
                        {
                            title = str.Trim() + "...";
                            break;
                        }
                    }
                }
            }

            if (title.StartsWith("Winamp") | title == "Paused" | title == "Stopped")
            {
                lblSongName.Font = new Font(lblSongName.Font.FontFamily, lblSongName.Font.Size, FontStyle.Italic);
            }
            else
            {
                lblSongName.Font = new Font(lblSongName.Font.FontFamily, lblSongName.Font.Size, FontStyle.Regular);
            }

            return title;
        }

        private string SongTitle()
        {
            return SongTitle(-1);
        }

        private void imgWinamp_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                RunWinamp();
            }
        }

        private void RunWinamp()
        {
            bool cont = false;
            bool x64 = false;
            FileInfo info = new FileInfo(_winampLocation);
            if (info.Exists)
            {
                cont = true;
            }
            else
            {
                info = new FileInfo(_64bitLocation);
                if (info.Exists)
                {
                    cont = true;
                }
            }

            if (cont)
            {
                Process p = new Process();
                if (x64) { p.StartInfo.FileName = _64bitLocation; }
                else { p.StartInfo.FileName = _winampLocation; }
                p.Start();
                _isRunning = true;
                Thread.Sleep(400);
            }
            else
            {
                MessageBox.Show("Winamp not found... " + Environment.NewLine + "Please check the path in the configuration file!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private enum WinampCommand { Play, Pause, Stop, Prev, Next };

        private void DoCommand(WinampCommand cmd)
        {
            this.Focus();
            if (!_isRunning)
            {
                RunWinamp();
            }
            switch (cmd)
            {
                case WinampCommand.Play:
                    WinampLib.Play();
                    break;
                case WinampCommand.Pause:
                    WinampLib.Pause();
                    break;
                case WinampCommand.Stop:
                    WinampLib.Stop();
                    break;
                case WinampCommand.Prev:
                    WinampLib.PrevTrack();
                    break;
                case WinampCommand.Next:
                    WinampLib.NextTrack();
                    break;
            }
            this.Focus();
        }



        #region .Properties.
        public string WinampPath
        {
            get { return _winampLocation; }
            set { _winampLocation = value; }
        }

        public string WinampPathX64
        {
            get { return _64bitLocation; }
            set { _64bitLocation = value; }
        }
        #endregion

    }
}
