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
            exerciseLabel = new Label();
            timeLabel = new Label();
            restLabel = new Label();
            restTimeLabel = new Label();
            cleanResultLabel = new Label();
            cleanAndPressLabel = new Label();
            jerkResultLabel = new Label();
            halfSnatchResultLabel = new Label();
            pushPressResultLabel = new Label();
            pentathlonNewButton = new Button();
            pentathlonCloseButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pentathlonStartButoon = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // pentathlonLabel
            // 
            pentathlonLabel.AutoSize = true;
            pentathlonLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pentathlonLabel.ForeColor = Color.Red;
            pentathlonLabel.Location = new Point(43, 38);
            pentathlonLabel.Name = "pentathlonLabel";
            pentathlonLabel.Size = new Size(200, 32);
            pentathlonLabel.TabIndex = 0;
            pentathlonLabel.Text = "Pentathlon - 6'/5'";
            pentathlonLabel.Click += pentathlonLabel_Click;
            // 
            // exerciseLabel
            // 
            exerciseLabel.AutoSize = true;
            exerciseLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exerciseLabel.ForeColor = Color.Gold;
            exerciseLabel.Location = new Point(43, 508);
            exerciseLabel.Name = "exerciseLabel";
            exerciseLabel.Size = new Size(74, 32);
            exerciseLabel.TabIndex = 2;
            exerciseLabel.Text = "Clean";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 120F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ForeColor = SystemColors.ButtonHighlight;
            timeLabel.Location = new Point(484, 420);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(382, 212);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "0:00";
            // 
            // restLabel
            // 
            restLabel.AutoSize = true;
            restLabel.Font = new Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point);
            restLabel.ForeColor = Color.Gold;
            restLabel.Location = new Point(519, 420);
            restLabel.Name = "restLabel";
            restLabel.Size = new Size(294, 177);
            restLabel.TabIndex = 5;
            restLabel.Text = "rest";
            // 
            // restTimeLabel
            // 
            restTimeLabel.AutoSize = true;
            restTimeLabel.Font = new Font("Segoe UI", 200F, FontStyle.Regular, GraphicsUnit.Point);
            restTimeLabel.ForeColor = Color.Red;
            restTimeLabel.Location = new Point(359, 224);
            restTimeLabel.Name = "restTimeLabel";
            restTimeLabel.Size = new Size(639, 355);
            restTimeLabel.TabIndex = 6;
            restTimeLabel.Text = "5:00";
            // 
            // cleanResultLabel
            // 
            cleanResultLabel.AutoSize = true;
            cleanResultLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cleanResultLabel.ForeColor = SystemColors.ButtonHighlight;
            cleanResultLabel.Location = new Point(43, 193);
            cleanResultLabel.Name = "cleanResultLabel";
            cleanResultLabel.Size = new Size(144, 31);
            cleanResultLabel.TabIndex = 7;
            cleanResultLabel.Text = "Clean Result:";
            // 
            // cleanAndPressLabel
            // 
            cleanAndPressLabel.AutoSize = true;
            cleanAndPressLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cleanAndPressLabel.ForeColor = SystemColors.ButtonHighlight;
            cleanAndPressLabel.Location = new Point(43, 253);
            cleanAndPressLabel.Name = "cleanAndPressLabel";
            cleanAndPressLabel.Size = new Size(248, 31);
            cleanAndPressLabel.TabIndex = 8;
            cleanAndPressLabel.Text = "Clean and Press Result:";
            // 
            // jerkResultLabel
            // 
            jerkResultLabel.AutoSize = true;
            jerkResultLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            jerkResultLabel.ForeColor = SystemColors.ButtonHighlight;
            jerkResultLabel.Location = new Point(43, 306);
            jerkResultLabel.Name = "jerkResultLabel";
            jerkResultLabel.Size = new Size(126, 31);
            jerkResultLabel.TabIndex = 9;
            jerkResultLabel.Text = "Jerk Result:";
            // 
            // halfSnatchResultLabel
            // 
            halfSnatchResultLabel.AutoSize = true;
            halfSnatchResultLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            halfSnatchResultLabel.ForeColor = SystemColors.ButtonHighlight;
            halfSnatchResultLabel.Location = new Point(43, 365);
            halfSnatchResultLabel.Name = "halfSnatchResultLabel";
            halfSnatchResultLabel.Size = new Size(203, 31);
            halfSnatchResultLabel.TabIndex = 10;
            halfSnatchResultLabel.Text = "Half Snatch Result:";
            // 
            // pushPressResultLabel
            // 
            pushPressResultLabel.AutoSize = true;
            pushPressResultLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            pushPressResultLabel.ForeColor = SystemColors.ButtonHighlight;
            pushPressResultLabel.Location = new Point(43, 427);
            pushPressResultLabel.Name = "pushPressResultLabel";
            pushPressResultLabel.Size = new Size(195, 31);
            pushPressResultLabel.TabIndex = 11;
            pushPressResultLabel.Text = "Push Press Result:";
            // 
            // pentathlonNewButton
            // 
            pentathlonNewButton.BackColor = SystemColors.ActiveCaptionText;
            pentathlonNewButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pentathlonNewButton.ForeColor = SystemColors.ButtonHighlight;
            pentathlonNewButton.Location = new Point(28, 555);
            pentathlonNewButton.Name = "pentathlonNewButton";
            pentathlonNewButton.Size = new Size(141, 45);
            pentathlonNewButton.TabIndex = 12;
            pentathlonNewButton.Text = "New";
            pentathlonNewButton.UseVisualStyleBackColor = false;
            // 
            // pentathlonCloseButton
            // 
            pentathlonCloseButton.BackColor = SystemColors.ActiveCaptionText;
            pentathlonCloseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pentathlonCloseButton.ForeColor = SystemColors.ButtonHighlight;
            pentathlonCloseButton.Location = new Point(212, 555);
            pentathlonCloseButton.Name = "pentathlonCloseButton";
            pentathlonCloseButton.Size = new Size(141, 45);
            pentathlonCloseButton.TabIndex = 13;
            pentathlonCloseButton.Text = "Close";
            pentathlonCloseButton.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pentathlonStartButoon
            // 
            pentathlonStartButoon.Location = new Point(1044, 84);
            pentathlonStartButoon.Name = "pentathlonStartButoon";
            pentathlonStartButoon.Size = new Size(75, 23);
            pentathlonStartButoon.TabIndex = 14;
            pentathlonStartButoon.Text = "Start";
            pentathlonStartButoon.UseVisualStyleBackColor = true;
            pentathlonStartButoon.Click += pentathlonStartButoon_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 250F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(537, -55);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(554, 444);
            textBox1.TabIndex = 15;
            textBox1.Text = "0";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // PentathlonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1284, 641);
            Controls.Add(textBox1);
            Controls.Add(pentathlonStartButoon);
            Controls.Add(pentathlonCloseButton);
            Controls.Add(pentathlonNewButton);
            Controls.Add(pushPressResultLabel);
            Controls.Add(halfSnatchResultLabel);
            Controls.Add(jerkResultLabel);
            Controls.Add(cleanAndPressLabel);
            Controls.Add(cleanResultLabel);
            Controls.Add(restTimeLabel);
            Controls.Add(restLabel);
            Controls.Add(timeLabel);
            Controls.Add(exerciseLabel);
            Controls.Add(pentathlonLabel);
            Name = "PentathlonForm";
            Text = "PentathlonForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pentathlonLabel;
        private PictureBox pentathlonStartButton;
        private Label exerciseLabel;
        private Label countLabel;
        private Label timeLabel;
        private Label restLabel;
        private Label restTimeLabel;
        private Label cleanResultLabel;
        private Label cleanAndPressLabel;
        private Label jerkResultLabel;
        private Label halfSnatchResultLabel;
        private Label pushPressResultLabel;
        private Button pentathlonNewButton;
        private Button pentathlonCloseButton;
        private System.Windows.Forms.Timer timer1;
        private Button pentathlonStartButoon;
        private System.Windows.Forms.Timer timer2;
        private TextBox textBox1;
    }
}