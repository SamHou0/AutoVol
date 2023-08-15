using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoVol.Info;

namespace AutoVol
{
    public partial class AppEdit : Form
    {
        internal static App? ReturnApp;
        public AppEdit()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please go to GitHub Wiki for more information!", "Info"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer.exe", "https://github.com/SamHou0/AutoVol/wiki");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            App app = App.Create(appNameBox.Text, (int)volumeBox.Value);
            if (app != null)
            {
                DialogResult = DialogResult.OK;
                ReturnApp = app;
                Close();
            }
            else MessageBox.Show("Invalid input", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
