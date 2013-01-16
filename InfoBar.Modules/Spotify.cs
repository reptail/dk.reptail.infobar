using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using JariZ;
//using InfoBar.Libraries;

namespace dk.reptail.infobar.Modules
{
    public partial class Spotify : Module
    {
        private bool _error = false;
        SpotifyAPI api = null;
        Responses.CFID cfid = null;

        public Spotify()
        {
            InitializeComponent();
            // Setup API
            api = new SpotifyAPI(SpotifyAPI.GetOAuth(), "reptail.dk");
            cfid = api.CFID;
            if (cfid.error != null)
            {
                UpdateData();
                this.Focus();
            }
            else
            {
                _error = true;
                lblSongName.Text = "Unknown error...";
            }
        }
                
        public override void UpdateData()
        {
            if (!_error)
            {
                ttImg.SetToolTip(this.imgSpotify, SongTitle());
                lblSongName.Text = SongTitle(40);
            }
        }

        private string SongTitle(int limit)
        {
            string title = "fail??";

            // Get status
            Responses.Status status = api.Status;
            if (status.running)
            {
                if (status.track == null)
                {
                    title = "No song playing!";
                }
                else
                {
                    title = status.track.artist_resource.name + " - " + status.track.track_resource.name;
                    if (limit > 0 && title.Length > limit)
                    {
                        title = title.Substring(0, limit).Trim() + "...";
                    }
                }
            }
            else
            {
                title = "Spotify is not running!";
            }

            return title;
        }

        private string SongTitle()
        {
            return SongTitle(-1);
        }

        private enum SpotifyCommand { Pause, Resume };

        private void DoCommand(SpotifyCommand cmd)
        {
            this.Focus();
            switch (cmd)
            {
                case SpotifyCommand.Pause:
                    break;
                case SpotifyCommand.Resume:
                    break;
                default:
                    break;
            }
        }



        #region .Properties.



        #endregion

    }
}
