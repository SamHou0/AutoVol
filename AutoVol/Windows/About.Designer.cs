namespace AutoVol.Windows
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            nAudioLinkLabel = new LinkLabel();
            featherIconLinkLabel = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(600, 337);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(nAudioLinkLabel);
            flowLayoutPanel1.Controls.Add(featherIconLinkLabel);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(303, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(294, 331);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 34);
            label1.TabIndex = 0;
            label1.Text = "This app is created by @SamHou0 and other contributors. Free and Open Source forever.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 1;
            label2.Text = "Special Thanks:";
            // 
            // nAudioLinkLabel
            // 
            nAudioLinkLabel.AutoSize = true;
            nAudioLinkLabel.Location = new Point(3, 51);
            nAudioLinkLabel.Name = "nAudioLinkLabel";
            nAudioLinkLabel.Size = new Size(154, 17);
            nAudioLinkLabel.TabIndex = 2;
            nAudioLinkLabel.TabStop = true;
            nAudioLinkLabel.Text = "NAudio's Core Audio Api";
            nAudioLinkLabel.LinkClicked += NAudioLinkLabel_LinkClicked;
            // 
            // featherIconLinkLabel
            // 
            featherIconLinkLabel.AutoSize = true;
            featherIconLinkLabel.Location = new Point(3, 68);
            featherIconLinkLabel.Name = "featherIconLinkLabel";
            featherIconLinkLabel.Size = new Size(86, 17);
            featherIconLinkLabel.TabIndex = 3;
            featherIconLinkLabel.TabStop = true;
            featherIconLinkLabel.Text = "Feather Icons";
            featherIconLinkLabel.LinkClicked += FeatherIconLinkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 85);
            label3.Name = "label3";
            label3.Size = new Size(30, 17);
            label3.TabIndex = 4;
            label3.Text = "You";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 102);
            label4.Name = "label4";
            label4.Size = new Size(160, 17);
            label4.TabIndex = 5;
            label4.Text = "Open Source License: MIT";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 337);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "About";
            Text = "About";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private LinkLabel nAudioLinkLabel;
        private LinkLabel featherIconLinkLabel;
        private Label label3;
        private Label label4;
    }
}