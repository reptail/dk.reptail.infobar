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
    public partial class WinampControl : Module
    {
        private string _winampLocation = @"c:\Program Files\Winamp\winamp.exe";
        private string _64bitLocation = @"c:\Program Files (x86)\Winamp\winamp.exe";
        private bool _isRunning = false;

        public WinampControl(string path)
        {
            InitializeComponent();
            if (path != null)
            {
                _winampLocation = path;
            }
            UpdateData();
            this.Focus();
        }

        private void UpdateWinampStatus()
        {
            Process[] winamp = Process.GetProcessesByName("winamp");
            if (winamp.Length > 0)
            {
                _isRunning = true;
            }
            else
            {
                _isRunning = false;
            }

        }

        public override void UpdateData()
        {
            UpdateWinampStatus();
            ttImg.SetToolTip(this.imgWinamp, SongTitle());
        }

        private string SongTitle()
        {
            string s = WinampLib.GetCurrentSongTitle();
            if (s == "N/A")
            {
                s = "Winamp is not running!";
            }
            return s;
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
                p.StartInfo.FileName = _winampLocation;
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

        private void bPrev_Click(object sender, EventArgs e)
        {
            DoCommand(WinampCommand.Prev);
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            DoCommand(WinampCommand.Play);
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            DoCommand(WinampCommand.Pause);
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            DoCommand(WinampCommand.Stop);
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            DoCommand(WinampCommand.Next);
        }

        #region .Properties.
        public string WinampPath
        {
            get { return _winampLocation; }
            set { _winampLocation = value; }
        }
        #endregion

    }
}
