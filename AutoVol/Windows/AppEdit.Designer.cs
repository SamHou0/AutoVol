namespace AutoVol
{
    partial class AppEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppEdit));
            appNameBox = new TextBox();
            volumeBox = new NumericUpDown();
            okButton = new Button();
            label1 = new Label();
            helpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)volumeBox).BeginInit();
            SuspendLayout();
            // 
            // appNameBox
            // 
            appNameBox.Location = new Point(12, 12);
            appNameBox.Name = "appNameBox";
            appNameBox.Size = new Size(148, 23);
            appNameBox.TabIndex = 0;
            // 
            // volumeBox
            // 
            volumeBox.Location = new Point(12, 112);
            volumeBox.Name = "volumeBox";
            volumeBox.Size = new Size(148, 23);
            volumeBox.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.Location = new Point(194, 12);
            okButton.Name = "okButton";
            okButton.Size = new Size(185, 68);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(148, 71);
            label1.TabIndex = 3;
            label1.Text = "Type the name of the process in the textbox, the choose the value of volume below.";
            // 
            // helpButton
            // 
            helpButton.Location = new Point(194, 86);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(185, 68);
            helpButton.TabIndex = 4;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += HelpButton_Click;
            // 
            // AppEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 167);
            Controls.Add(helpButton);
            Controls.Add(label1);
            Controls.Add(okButton);
            Controls.Add(volumeBox);
            Controls.Add(appNameBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AppEdit";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)volumeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox appNameBox;
        private NumericUpDown volumeBox;
        private Button okButton;
        private Label label1;
        private Button helpButton;
    }
}