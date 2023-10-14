namespace KBSzamlalo
{
    partial class PentathlonForm
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
            pentathlonLabel = new Label();
            countLabel = new Label();
            timeLabel = new Label();
            timeTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            exerciseTimer = new System.Windows.Forms.Timer(components);
            restTimeLabel = new Label();
            restTextLabel = new Label();
            cleanResultLabel = new Label();
            cleanAndPressLabel = new Label();
            jerkResultLabel = new Label();
            halfSnatchResultLabel = new Label();
            pushPressResultLabel = new Label();
            exerciseLabel = new Label();
            pentathlonNewButton = new Button();
            pentathlonCloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pentathlonLabel
            // 
            pentathlonLabel.AutoSize = true;
            pentathlonLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pentathlonLabel.ForeColor = Color.Red;
            pentathlonLabel.Location = new Point(36, 31);
            pentathlonLabel.Name = "pentathlonLabel";
            pentathlonLabel.Size = new Size(200, 32);
            pentathlonLabel.TabIndex = 1;
            pentathlonLabel.Text = "Pentathlon - 6'/5'";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Segoe UI", 200F, FontStyle.Regular, GraphicsUnit.Point);
            countLabel.ForeColor = Color.White;
            countLabel.Location = new Point(623, 81);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(293, 355);
            countLabel.TabIndex = 2;
            countLabel.Text = "0";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 120F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(535, 398);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(468, 212);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "00:05";
            // 
            // timeTimer
            // 
            timeTimer.Enabled = true;
            timeTimer.Interval = 1000;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.play_button2;
            pictureBox1.Location = new Point(535, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 367);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // exerciseTimer
            // 
            exerciseTimer.Enabled = true;
            exerciseTimer.Interval = 1000;
            exerciseTimer.Tick += exerciseTimer_Tick;
            // 
            // restTimeLabel
            // 
            restTimeLabel.AutoSize = true;
            restTimeLabel.Font = new Font("Segoe UI", 120F, FontStyle.Regular, GraphicsUnit.Point);
            restTimeLabel.ForeColor = Color.Red;
            restTimeLabel.Location = new Point(416, 201);
            restTimeLabel.Name = "restTimeLabel";
            restTimeLabel.Size = new Size(0, 212);
            restTimeLabel.TabIndex = 5;
            // 
            // restTextLabel
            // 
            restTextLabel.AutoSize = true;
            restTextLabel.Font = new Font("Segoe UI", 80F, FontStyle.Regular, GraphicsUnit.Point);
            restTextLabel.ForeColor = Color.Gold;
            restTextLabel.Location = new Point(653, 436);
            restTextLabel.Name = "restTextLabel";
            restTextLabel.Size = new Size(234, 142);
            restTextLabel.TabIndex = 6;
            restTextLabel.Text = "rest";
            // 
            // cleanResultLabel
            // 
            cleanResultLabel.AutoSize = true;
            cleanResultLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cleanResultLabel.ForeColor = SystemColors.ButtonHighlight;
            cleanResultLabel.Location = new Point(36, 100);
            cleanResultLabel.Name = "cleanResultLabel";
            cleanResultLabel.Size = new Size(144, 31);
            cleanResultLabel.TabIndex = 8;
            cleanResultLabel.Text = "Clean Result:";
            // 
            // cleanAndPressLabel
            // 
            cleanAndPressLabel.AutoSize = true;
            cleanAndPressLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cleanAndPressLabel.ForeColor = SystemColors.ButtonHighlight;
            cleanAndPressLabel.Location = new Point(36, 180);
            cleanAndPressLabel.Name = "cleanAndPressLabel";
            cleanAndPressLabel.Size = new Size(248, 31);
            cleanAndPressLabel.TabIndex = 9;
            cleanAndPressLabel.Text = "Clean and Press Result:";
            // 
            // jerkResultLabel
            // 
            jerkResultLabel.AutoSize = true;
            jerkResultLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            jerkResultLabel.ForeColor = SystemColors.ButtonHighlight;
            jerkResultLabel.Location = new Point(36, 260);
            jerkResultLabel.Name = "jerkResultLabel";
            jerkResultLabel.Size = new Size(126, 31);
            jerkResultLabel.TabIndex = 10;
            jerkResultLabel.Text = "Jerk Result:";
            // 
            // halfSnatchResultLabel
            // 
            halfSnatchResultLabel.AutoSize = true;
            halfSnatchResultLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            halfSnatchResultLabel.ForeColor = SystemColors.ButtonHighlight;
            halfSnatchResultLabel.Location = new Point(36, 340);
            halfSnatchResultLabel.Name = "halfSnatchResultLabel";
            halfSnatchResultLabel.Size = new Size(203, 31);
            halfSnatchResultLabel.TabIndex = 11;
            halfSnatchResultLabel.Text = "Half Snatch Result:";
            // 
            // pushPressResultLabel
            // 
            pushPressResultLabel.AutoSize = true;
            pushPressResultLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            pushPressResultLabel.ForeColor = SystemColors.ButtonHighlight;
            pushPressResultLabel.Location = new Point(36, 420);
            pushPressResultLabel.Name = "pushPressResultLabel";
            pushPressResultLabel.Size = new Size(195, 31);
            pushPressResultLabel.TabIndex = 12;
            pushPressResultLabel.Text = "Push Press Result:";
            // 
            // exerciseLabel
            // 
            exerciseLabel.AutoSize = true;
            exerciseLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            exerciseLabel.ForeColor = Color.Gold;
            exerciseLabel.Location = new Point(36, 482);
            exerciseLabel.Name = "exerciseLabel";
            exerciseLabel.Size = new Size(99, 45);
            exerciseLabel.TabIndex = 13;
            exerciseLabel.Text = "Clean";
            // 
            // pentathlonNewButton
            // 
            pentathlonNewButton.BackColor = SystemColors.ActiveCaptionText;
            pentathlonNewButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pentathlonNewButton.ForeColor = SystemColors.ButtonHighlight;
            pentathlonNewButton.Location = new Point(36, 553);
            pentathlonNewButton.Name = "pentathlonNewButton";
            pentathlonNewButton.Size = new Size(141, 45);
            pentathlonNewButton.TabIndex = 14;
            pentathlonNewButton.Text = "New";
            pentathlonNewButton.UseVisualStyleBackColor = false;
            pentathlonNewButton.Click += pentathlonNewButton_Click;
            // 
            // pentathlonCloseButton
            // 
            pentathlonCloseButton.BackColor = SystemColors.ActiveCaptionText;
            pentathlonCloseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pentathlonCloseButton.ForeColor = SystemColors.ButtonHighlight;
            pentathlonCloseButton.Location = new Point(245, 553);
            pentathlonCloseButton.Name = "pentathlonCloseButton";
            pentathlonCloseButton.Size = new Size(141, 45);
            pentathlonCloseButton.TabIndex = 15;
            pentathlonCloseButton.Text = "Close";
            pentathlonCloseButton.UseVisualStyleBackColor = false;
            pentathlonCloseButton.Click += pentathlonCloseButton_Click;
            // 
            // PentathlonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1284, 641);
            Controls.Add(pentathlonCloseButton);
            Controls.Add(pentathlonNewButton);
            Controls.Add(exerciseLabel);
            Controls.Add(pushPressResultLabel);
            Controls.Add(halfSnatchResultLabel);
            Controls.Add(jerkResultLabel);
            Controls.Add(cleanAndPressLabel);
            Controls.Add(cleanResultLabel);
            Controls.Add(restTextLabel);
            Controls.Add(restTimeLabel);
            Controls.Add(pictureBox1);
            Controls.Add(timeLabel);
            Controls.Add(countLabel);
            Controls.Add(pentathlonLabel);
            Name = "PentathlonForm";
            Text = "PentathlonForm";
            FormClosing += PentathlonForm_FormClosing;
            KeyDown += PentathlonForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pentathlonLabel;
        private Label countLabel;
        private Label timeLabel;
        private System.Windows.Forms.Timer timeTimer;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer exerciseTimer;
        private Label restTimeLabel;
        private Label restTextLabel;
        private Label cleanResultLabel;
        private Label cleanAndPressLabel;
        private Label jerkResultLabel;
        private Label halfSnatchResultLabel;
        private Label pushPressResultLabel;
        private Label exerciseLabel;
        private Button pentathlonNewButton;
        private Button pentathlonCloseButton;
    }
}