namespace KBSzamlalo
{
    partial class SettingsForm
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
            settingsNameLabel = new Label();
            soundLabel = new Label();
            timingLabel = new Label();
            shortcutLabel = new Label();
            shortcutLongLabel = new Label();
            offLabel = new Label();
            countdownLabel = new Label();
            onLabel = new Label();
            stopwatchLabel = new Label();
            pictureBox1 = new PictureBox();
            timingPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timingPictureBox).BeginInit();
            SuspendLayout();
            // 
            // settingsNameLabel
            // 
            settingsNameLabel.AutoSize = true;
            settingsNameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            settingsNameLabel.ForeColor = Color.Red;
            settingsNameLabel.Location = new Point(88, 76);
            settingsNameLabel.Name = "settingsNameLabel";
            settingsNameLabel.Size = new Size(112, 37);
            settingsNameLabel.TabIndex = 0;
            settingsNameLabel.Text = "Settings";
            // 
            // soundLabel
            // 
            soundLabel.AutoSize = true;
            soundLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            soundLabel.ForeColor = Color.White;
            soundLabel.Location = new Point(88, 195);
            soundLabel.Name = "soundLabel";
            soundLabel.Size = new Size(83, 32);
            soundLabel.TabIndex = 1;
            soundLabel.Text = "Sound";
            // 
            // timingLabel
            // 
            timingLabel.AutoSize = true;
            timingLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timingLabel.ForeColor = Color.White;
            timingLabel.Location = new Point(88, 264);
            timingLabel.Name = "timingLabel";
            timingLabel.Size = new Size(88, 32);
            timingLabel.TabIndex = 2;
            timingLabel.Text = "Timing";
            // 
            // shortcutLabel
            // 
            shortcutLabel.AutoSize = true;
            shortcutLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shortcutLabel.ForeColor = Color.White;
            shortcutLabel.Location = new Point(88, 456);
            shortcutLabel.Name = "shortcutLabel";
            shortcutLabel.Size = new Size(109, 32);
            shortcutLabel.TabIndex = 3;
            shortcutLabel.Text = "Shortcut:";
            // 
            // shortcutLongLabel
            // 
            shortcutLongLabel.AutoSize = true;
            shortcutLongLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            shortcutLongLabel.ForeColor = Color.White;
            shortcutLongLabel.Location = new Point(88, 517);
            shortcutLongLabel.Name = "shortcutLongLabel";
            shortcutLongLabel.Size = new Size(446, 32);
            shortcutLongLabel.TabIndex = 4;
            shortcutLongLabel.Text = "Ctrl+c : Terminate and quit from counter";
            // 
            // offLabel
            // 
            offLabel.AutoSize = true;
            offLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            offLabel.ForeColor = Color.White;
            offLabel.Location = new Point(288, 195);
            offLabel.Name = "offLabel";
            offLabel.Size = new Size(48, 32);
            offLabel.TabIndex = 5;
            offLabel.Text = "Off";
            // 
            // countdownLabel
            // 
            countdownLabel.AutoSize = true;
            countdownLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            countdownLabel.ForeColor = Color.White;
            countdownLabel.Location = new Point(288, 264);
            countdownLabel.Name = "countdownLabel";
            countdownLabel.Size = new Size(138, 32);
            countdownLabel.TabIndex = 6;
            countdownLabel.Text = "Countdown";
            // 
            // onLabel
            // 
            onLabel.AutoSize = true;
            onLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            onLabel.ForeColor = Color.White;
            onLabel.Location = new Point(442, 195);
            onLabel.Name = "onLabel";
            onLabel.Size = new Size(46, 32);
            onLabel.TabIndex = 7;
            onLabel.Text = "On";
            // 
            // stopwatchLabel
            // 
            stopwatchLabel.AutoSize = true;
            stopwatchLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            stopwatchLabel.ForeColor = Color.White;
            stopwatchLabel.Location = new Point(511, 264);
            stopwatchLabel.Name = "stopwatchLabel";
            stopwatchLabel.Size = new Size(124, 32);
            stopwatchLabel.TabIndex = 8;
            stopwatchLabel.Text = "Stopwatch";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.offSwitch;
            pictureBox1.Location = new Point(353, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 41);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timingPictureBox
            // 
            timingPictureBox.Image = Properties.Resources.offSwitch;
            timingPictureBox.Location = new Point(432, 264);
            timingPictureBox.Name = "timingPictureBox";
            timingPictureBox.Size = new Size(73, 41);
            timingPictureBox.TabIndex = 10;
            timingPictureBox.TabStop = false;
            timingPictureBox.Click += timingPictureBox_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1284, 641);
            Controls.Add(timingPictureBox);
            Controls.Add(pictureBox1);
            Controls.Add(stopwatchLabel);
            Controls.Add(onLabel);
            Controls.Add(countdownLabel);
            Controls.Add(offLabel);
            Controls.Add(shortcutLongLabel);
            Controls.Add(shortcutLabel);
            Controls.Add(timingLabel);
            Controls.Add(soundLabel);
            Controls.Add(settingsNameLabel);
            Name = "SettingsForm";
            Text = "SettingsForm";
            FormClosing += SettingsForm_FormClosing;
            KeyDown += SettingsForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)timingPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label settingsNameLabel;
        private Label soundLabel;
        private Label timingLabel;
        private Label shortcutLabel;
        private Label shortcutLongLabel;
        private Label offLabel;
        private Label countdownLabel;
        private Label onLabel;
        private Label stopwatchLabel;
        private PictureBox pictureBox1;
        private PictureBox timingPictureBox;
    }
}