namespace AutoVol
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            appListBox = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            removeAppButton = new Button();
            addAppButton = new Button();
            aboutButton = new Button();
            checkTimer = new System.Windows.Forms.Timer(components);
            notifyIcon = new NotifyIcon(components);
            iconContextMenuStrip = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            showMainWindowToolStripMenuItem = new ToolStripMenuItem();
            hideMainWindowWhenOpeningToolStripMenuItem = new ToolStripMenuItem();
            startUpToolStripMenuItem = new ToolStripMenuItem();
            openWhenUserLoginToolStripMenuItem = new ToolStripMenuItem();
            disableAutoStartToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            iconContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 548);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(975, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(950, 17);
            toolStripStatusLabel1.Text = "Settings will be saved automatically. Do not kill the process. App will hide MainWindow when clicking the close button. Right Click NotifyIcon for more infomation.";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(appListBox, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Size = new Size(975, 548);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // appListBox
            // 
            appListBox.Dock = DockStyle.Fill;
            appListBox.FormattingEnabled = true;
            appListBox.ItemHeight = 17;
            appListBox.Location = new Point(3, 3);
            appListBox.Name = "appListBox";
            appListBox.Size = new Size(969, 452);
            appListBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(removeAppButton);
            flowLayoutPanel1.Controls.Add(addAppButton);
            flowLayoutPanel1.Controls.Add(aboutButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 461);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(969, 84);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // removeAppButton
            // 
            removeAppButton.Location = new Point(758, 3);
            removeAppButton.Name = "removeAppButton";
            removeAppButton.Size = new Size(208, 74);
            removeAppButton.TabIndex = 7;
            removeAppButton.Text = "Remove selected App";
            removeAppButton.UseVisualStyleBackColor = true;
            removeAppButton.Click += RemoveAppButton_Click;
            // 
            // addAppButton
            // 
            addAppButton.Location = new Point(544, 3);
            addAppButton.Name = "addAppButton";
            addAppButton.Size = new Size(208, 74);
            addAppButton.TabIndex = 8;
            addAppButton.Text = "Add one App";
            addAppButton.UseVisualStyleBackColor = true;
            addAppButton.Click += AddAppButton_Click;
            // 
            // aboutButton
            // 
            aboutButton.Location = new Point(330, 3);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(208, 74);
            aboutButton.TabIndex = 9;
            aboutButton.Text = "About";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += AboutButton_Click;
            // 
            // checkTimer
            // 
            checkTimer.Enabled = true;
            checkTimer.Interval = 1000;
            checkTimer.Tick += CheckTimer_Tick;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = iconContextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "AutoVol";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            // 
            // iconContextMenuStrip
            // 
            iconContextMenuStrip.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem, showMainWindowToolStripMenuItem, hideMainWindowWhenOpeningToolStripMenuItem, startUpToolStripMenuItem });
            iconContextMenuStrip.Name = "iconContextMenuStrip";
            iconContextMenuStrip.ShowCheckMargin = true;
            iconContextMenuStrip.ShowImageMargin = false;
            iconContextMenuStrip.Size = new Size(304, 114);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(303, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // showMainWindowToolStripMenuItem
            // 
            showMainWindowToolStripMenuItem.Name = "showMainWindowToolStripMenuItem";
            showMainWindowToolStripMenuItem.Size = new Size(303, 22);
            showMainWindowToolStripMenuItem.Text = "Show MainWindow";
            showMainWindowToolStripMenuItem.Click += ShowMainWindowToolStripMenuItem_Click;
            // 
            // hideMainWindowWhenOpeningToolStripMenuItem
            // 
            hideMainWindowWhenOpeningToolStripMenuItem.CheckOnClick = true;
            hideMainWindowWhenOpeningToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            hideMainWindowWhenOpeningToolStripMenuItem.Name = "hideMainWindowWhenOpeningToolStripMenuItem";
            hideMainWindowWhenOpeningToolStripMenuItem.Size = new Size(303, 22);
            hideMainWindowWhenOpeningToolStripMenuItem.Text = "Auto Hide MainWindow When opening";
            hideMainWindowWhenOpeningToolStripMenuItem.Click += HideMainWindowWhenOpeningToolStripMenuItem_Click;
            // 
            // startUpToolStripMenuItem
            // 
            startUpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openWhenUserLoginToolStripMenuItem, disableAutoStartToolStripMenuItem });
            startUpToolStripMenuItem.Name = "startUpToolStripMenuItem";
            startUpToolStripMenuItem.Size = new Size(303, 22);
            startUpToolStripMenuItem.Text = "StartUp";
            // 
            // openWhenUserLoginToolStripMenuItem
            // 
            openWhenUserLoginToolStripMenuItem.Name = "openWhenUserLoginToolStripMenuItem";
            openWhenUserLoginToolStripMenuItem.Size = new Size(204, 22);
            openWhenUserLoginToolStripMenuItem.Text = "Open when user login";
            openWhenUserLoginToolStripMenuItem.Click += OpenWhenUserLoginToolStripMenuItem_Click;
            // 
            // disableAutoStartToolStripMenuItem
            // 
            disableAutoStartToolStripMenuItem.Name = "disableAutoStartToolStripMenuItem";
            disableAutoStartToolStripMenuItem.Size = new Size(204, 22);
            disableAutoStartToolStripMenuItem.Text = "Disable auto start";
            disableAutoStartToolStripMenuItem.Click += DisableAutoStartToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 570);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "MainWindow";
            FormClosing += MainWindow_FormClosing;
            Shown += MainWindow_Shown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            iconContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox appListBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button removeAppButton;
        private Button addAppButton;
        private System.Windows.Forms.Timer checkTimer;
        private Button aboutButton;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip iconContextMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem showMainWindowToolStripMenuItem;
        private ToolStripMenuItem hideMainWindowWhenOpeningToolStripMenuItem;
        private ToolStripMenuItem startUpToolStripMenuItem;
        private ToolStripMenuItem openWhenUserLoginToolStripMenuItem;
        private ToolStripMenuItem disableAutoStartToolStripMenuItem;
    }
}