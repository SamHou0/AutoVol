using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoVol.Windows
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void NAudioLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/naudio/NAudio");
        }

        private void FeatherIconLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://feathericons.com/");
        }
    }
}
