using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoVol.Info;
using AutoVol.Res;
using AutoVol.Tools;
using AutoVol.Windows;

namespace AutoVol
{
    public partial class MainWindow : Form
    {
        bool isClosable = false;
        List<App> apps = new();
        public MainWindow()
        {
            InitializeComponent();
            apps = AVFile.ReadApps();
            RefreshAndSaveForm();
            Opacity = 0;
        }
        private void RefreshAndSaveForm()
        {
            appListBox.Items.Clear();
            foreach (App app in apps)
            {
                appListBox.Items.Add(app.ToString());
            }
            AVFile.SaveApps(apps);
        }
        private void AddAppButton_Click(object sender, EventArgs e)
        {
            AppEdit appEdit = new();
            if (appEdit.ShowDialog() == DialogResult.OK)
            {
                apps.Add(AppEdit.ReturnApp);
            }
            RefreshAndSaveForm();
        }

        private void RemoveAppButton_Click(object sender, EventArgs e)
        {
            if (appListBox.SelectedIndex >= 0)
            {
                apps.RemoveAt(appListBox.SelectedIndex);
            }
            RefreshAndSaveForm();
        }

        private void CheckTimer_Tick(object sender, EventArgs e)
        {
            Core.SetVolume(apps);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isClosable = true;
            Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClosable == false)
            {
                e.Cancel = true;
                Hide();
                return;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void ShowMainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void HideMainWindowWhenOpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.AutoHide =
                hideMainWindowWhenOpeningToolStripMenuItem.Checked;
            Settings.Default.Save();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.AutoHide)
            {
                hideMainWindowWhenOpeningToolStripMenuItem.Checked = true;
                Hide();
            }
            Opacity = 1D;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }
    }
}
