namespace KBSzamlalo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pentathlonButton = new Button();
            halfPentathlonButton = new Button();
            pictureBox1 = new PictureBox();
            settingsLabel = new Label();
            pictureBox2 = new PictureBox();
            sprint3Button = new Button();
            sprint5Button = new Button();
            sprint10Button = new Button();
            sprint12Button = new Button();
            sprint30Button = new Button();
            sprint60Button = new Button();
            customButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pentathlonButton
            // 
            pentathlonButton.BackColor = SystemColors.ActiveCaptionText;
            pentathlonButton.FlatAppearance.BorderColor = Color.White;
            pentathlonButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            pentathlonButton.FlatAppearance.MouseOverBackColor = Color.Black;
            pentathlonButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            pentathlonButton.ForeColor = SystemColors.ButtonHighlight;
            pentathlonButton.Location = new Point(83, 84);
            pentathlonButton.Name = "pentathlonButton";
            pentathlonButton.Size = new Size(259, 46);
            pentathlonButton.TabIndex = 1;
            pentathlonButton.Text = "Pentathlon - 6'/5'";
            pentathlonButton.UseVisualStyleBackColor = false;
            pentathlonButton.Click += pentathlonButton_Click_1;
            // 
            // halfPentathlonButton
            // 
            halfPentathlonButton.BackColor = SystemColors.ActiveCaptionText;
            halfPentathlonButton.FlatAppearance.BorderColor = Color.White;
            halfPentathlonButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            halfPentathlonButton.FlatAppearance.MouseOverBackColor = Color.Black;
            halfPentathlonButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            halfPentathlonButton.ForeColor = SystemColors.ButtonHighlight;
            halfPentathlonButton.Location = new Point(83, 166);
            halfPentathlonButton.Name = "halfPentathlonButton";
            halfPentathlonButton.Size = new Size(259, 46);
            halfPentathlonButton.TabIndex = 2;
            halfPentathlonButton.Text = "Half pentathlon - 3'/2'";
            halfPentathlonButton.UseVisualStyleBackColor = false;
            halfPentathlonButton.Click += halfPentathlonButton_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(735, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 459);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            settingsLabel.ForeColor = Color.FromArgb(255, 255, 128);
            settingsLabel.Location = new Point(136, 506);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(112, 37);
            settingsLabel.TabIndex = 4;
            settingsLabel.Text = "Settings";
            settingsLabel.Click += settingsLabel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.settings_picture;
            pictureBox2.Location = new Point(60, 481);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 71);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // sprint3Button
            // 
            sprint3Button.BackColor = SystemColors.ActiveCaptionText;
            sprint3Button.FlatAppearance.BorderColor = Color.White;
            sprint3Button.FlatAppearance.MouseDownBackColor = Color.Gray;
            sprint3Button.FlatAppearance.MouseOverBackColor = Color.Black;
            sprint3Button.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sprint3Button.ForeColor = SystemColors.ButtonHighlight;
            sprint3Button.Location = new Point(83, 247);
            sprint3Button.Name = "sprint3Button";
            sprint3Button.Size = new Size(259, 46);
            sprint3Button.TabIndex = 6;
            sprint3Button.Text = "Sprint - 3'";
            sprint3Button.UseVisualStyleBackColor = false;
            sprint3Button.Click += sprint3Button_Click;
            // 
            // sprint5Button
            // 
            sprint5Button.BackColor = SystemColors.ActiveCaptionText;
            sprint5Button.FlatAppearance.BorderColor = Color.White;
            sprint5Button.FlatAppearance.MouseDownBackColor = Color.Gray;
            sprint5Button.FlatAppearance.MouseOverBackColor = Color.Black;
            sprint5Button.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sprint5Button.ForeColor = SystemColors.ButtonHighlight;
            sprint5Button.Location = new Point(435, 84);
            sprint5Button.Name = "sprint5Button";
            sprint5Button.Size = new Size(166, 46);
            sprint5Button.TabIndex = 7;
            sprint5Button.Text = "5'";
            sprint5Button.UseVisualStyleBackColor = false;
            sprint5Button.Click += sprint5Button_Click;
            // 
            // sprint10Button
            // 
            sprint10Button.BackColor = SystemColors.ActiveCaptionText;
            sprint10Button.FlatAppearance.BorderColor = Color.White;
            sprint10Button.FlatAppearance.MouseDownBackColor = Color.Gray;
            sprint10Button.FlatAppearance.MouseOverBackColor = Color.Black;
            sprint10Button.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sprint10Button.ForeColor = SystemColors.ButtonHighlight;
            sprint10Button.Location = new Point(435, 166);
            sprint10Button.Name = "sprint10Button";
            sprint10Button.Size = new Size(166, 46);
            sprint10Button.TabIndex = 8;
            sprint10Button.Text = "10'";
            sprint10Button.UseVisualStyleBackColor = false;
            sprint10Button.Click += sprint10Button_Click;
            // 
            // sprint12Button
            // 
            sprint12Button.BackColor = SystemColors.ActiveCaptionText;
            sprint12Button.FlatAppearance.BorderColor = Color.White;
            sprint12Button.FlatAppearance.MouseDownBackColor = Color.Gray;
            sprint12Button.FlatAppearance.MouseOverBackColor = Color.Black;
            sprint12Button.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sprint12Button.ForeColor = SystemColors.ButtonHighlight;
            sprint12Button.Location = new Point(435, 247);
            sprint12Button.Name = "sprint12Button";
            sprint12Button.Size = new Size(166, 46);
            sprint12Button.TabIndex = 9;
            sprint12Button.Text = "12'";
            sprint12Button.UseVisualStyleBackColor = false;
            sprint12Button.Click += sprint12Button_Click;
            // 
            // sprint30Button
            // 
            sprint30Button.BackColor = SystemColors.ActiveCaptionText;
            sprint30Button.FlatAppearance.BorderColor = Color.White;
            sprint30Button.FlatAppearance.MouseDownBackColor = Color.Gray;
            sprint30Button.FlatAppearance.MouseOverBackColor = Color.Black;
            sprint30Button.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sprint30Button.ForeColor = SystemColors.ButtonHighlight;
            sprint30Button.Location = new Point(435, 328);
            sprint30Button.Name = "sprint30Button";
            sprint30Button.Size = new Size(166, 46);
            sprint30Button.TabIndex = 10;
            sprint30Button.Text = "30'";
            sprint30Button.UseVisualStyleBackColor = false;
            sprint30Button.Click += sprint30Button_Click;
            // 
            // sprint60Button
            // 
            sprint60Button.BackColor = SystemColors.ActiveCaptionText;
            sprint60Button.FlatAppearance.BorderColor = Color.White;
            sprint60Button.FlatAppearance.MouseDownBackColor = Color.Gray;
            sprint60Button.FlatAppearance.MouseOverBackColor = Color.Black;
            sprint60Button.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sprint60Button.ForeColor = SystemColors.ButtonHighlight;
            sprint60Button.Location = new Point(435, 405);
            sprint60Button.Name = "sprint60Button";
            sprint60Button.Size = new Size(166, 46);
            sprint60Button.TabIndex = 11;
            sprint60Button.Text = "60'";
            sprint60Button.UseVisualStyleBackColor = false;
            sprint60Button.Click += sprint60Button_Click;
            // 
            // customButton
            // 
            customButton.BackColor = SystemColors.ActiveCaptionText;
            customButton.FlatAppearance.BorderColor = Color.White;
            customButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            customButton.FlatAppearance.MouseOverBackColor = Color.Black;
            customButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customButton.ForeColor = SystemColors.ButtonHighlight;
            customButton.Location = new Point(83, 405);
            customButton.Name = "customButton";
            customButton.Size = new Size(259, 46);
            customButton.TabIndex = 12;
            customButton.Text = "Custom";
            customButton.UseVisualStyleBackColor = false;
            customButton.Click += customButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1284, 641);
            Controls.Add(customButton);
            Controls.Add(sprint60Button);
            Controls.Add(sprint30Button);
            Controls.Add(sprint12Button);
            Controls.Add(sprint10Button);
            Controls.Add(sprint5Button);
            Controls.Add(sprint3Button);
            Controls.Add(pictureBox2);
            Controls.Add(settingsLabel);
            Controls.Add(pictureBox1);
            Controls.Add(halfPentathlonButton);
            Controls.Add(pentathlonButton);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pentathlonButton;
        private Button halfPentathlonButton;
        private PictureBox pictureBox1;
        private Label settingsLabel;
        private PictureBox pictureBox2;
        private Button sprint3Button;
        private Button sprint5Button;
        private Button sprint10Button;
        private Button sprint12Button;
        private Button sprint30Button;
        private Button sprint60Button;
        private Button customButton;
    }
}