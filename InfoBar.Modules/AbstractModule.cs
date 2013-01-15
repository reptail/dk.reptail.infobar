using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dk.reptail.infobar.Modules
{
    public class Module : UserControl
    {
        public Module()
        {
            this.Load += new EventHandler(Module_Load);
        }

        private void Module_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        public int Index { get; set; }

        // Creating methods for changing various setting
        public void SetLocation(int newX)
        {
            this.Location = new Point(newX, this.Location.Y);
        }

        public int GetWidth()
        {
            return this.Size.Width;
        }

        /// <summary> 
        ///     Method to update the data in the module. Needs to be implemented in derived modules!
        /// </summary>
        public virtual void UpdateData()
        { 
            
        }

        /// <summary> 
        ///     Method to set a new background color. Needs to be implemented in derived modules!
        /// </summary>
        public virtual void SetBackgroundColor(Color color)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(SystemMonitor.DataChart))
                {
                    c.BackColor = color;
                }                
            }
        }

        /// <summary> 
        ///     Method to set a new graph color. Needs to be implemented in derived modules!
        /// </summary>
        public virtual void SetGraphColor(Color color)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(SystemMonitor.DataChart))
                {
                    SystemMonitor.DataChart dc = (SystemMonitor.DataChart)c;
                    dc.LineColor = color;
                }
            }
        }
    }
}
