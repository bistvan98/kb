namespace KBSzamlalo
{
    partial class SprintForm
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
            sprintNameLabel = new Label();
            sprintPictureBox = new PictureBox();
            sprintTimeLabel = new Label();
            sprintCountLabel = new Label();
            sprintNewButton = new Button();
            sprintCloseButton = new Button();
            sprintTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sprintPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sprintNameLabel
            // 
            sprintNameLabel.AutoSize = true;
            sprintNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sprintNameLabel.ForeColor = Color.Red;
            sprintNameLabel.Location = new Point(51, 48);
            sprintNameLabel.Name = "sprintNameLabel";
            sprintNameLabel.Size = new Size(120, 32);
            sprintNameLabel.TabIndex = 2;
            sprintNameLabel.Text = "Sprint - 3'";
            // 
            // sprintPictureBox
            // 
            sprintPictureBox.Image = Properties.Resources.play_button2;
            sprintPictureBox.Location = new Point(436, 111);
            sprintPictureBox.Name = "sprintPictureBox";
            sprintPictureBox.Size = new Size(361, 367);
            sprintPictureBox.TabIndex = 5;
            sprintPictureBox.TabStop = false;
            sprintPictureBox.Click += sprintPictureBox_Click;
            // 
            // sprintTimeLabel
            // 
            sprintTimeLabel.AutoSize = true;
            sprintTimeLabel.Font = new Font("Segoe UI", 120F, FontStyle.Regular, GraphicsUnit.Point);
            sprintTimeLabel.ForeColor = Color.White;
            sprintTimeLabel.Location = new Point(416, 386);
            sprintTimeLabel.Name = "sprintTimeLabel";
            sprintTimeLabel.Size = new Size(468, 212);
            sprintTimeLabel.TabIndex = 6;
            sprintTimeLabel.Text = "00:05";
            // 
            // sprintCountLabel
            // 
            sprintCountLabel.AutoSize = true;
            sprintCountLabel.Font = new Font("Segoe UI", 200F, FontStyle.Regular, GraphicsUnit.Point);
            sprintCountLabel.ForeColor = Color.White;
            sprintCountLabel.Location = new Point(504, 64);
            sprintCountLabel.Name = "sprintCountLabel";
            sprintCountLabel.Size = new Size(293, 355);
            sprintCountLabel.TabIndex = 7;
            sprintCountLabel.Text = "0";
            sprintCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sprintNewButton
            // 
            sprintNewButton.BackColor = SystemColors.ActiveCaptionText;
            sprintNewButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sprintNewButton.ForeColor = SystemColors.ButtonHighlight;
            sprintNewButton.Location = new Point(436, 513);
            sprintNewButton.Name = "sprintNewButton";
            sprintNewButton.Size = new Size(141, 45);
            sprintNewButton.TabIndex = 15;
            sprintNewButton.Text = "New";
            sprintNewButton.UseVisualStyleBackColor = false;
            sprintNewButton.Click += sprintNewButton_Click;
            // 
            // sprintCloseButton
            // 
            sprintCloseButton.BackColor = SystemColors.ActiveCaptionText;
            sprintCloseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sprintCloseButton.ForeColor = SystemColors.ButtonHighlight;
            sprintCloseButton.Location = new Point(701, 513);
            sprintCloseButton.Name = "sprintCloseButton";
            sprintCloseButton.Size = new Size(141, 45);
            sprintCloseButton.TabIndex = 16;
            sprintCloseButton.Text = "Close";
            sprintCloseButton.UseVisualStyleBackColor = false;
            sprintCloseButton.Click += sprintCloseButton_Click;
            // 
            // sprintTimer
            // 
            sprintTimer.Enabled = true;
            sprintTimer.Interval = 1000;
            sprintTimer.Tick += sprintTimer_Tick;
            // 
            // SprintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1284, 641);
            Controls.Add(sprintCloseButton);
            Controls.Add(sprintNewButton);
            Controls.Add(sprintCountLabel);
            Controls.Add(sprintTimeLabel);
            Controls.Add(sprintPictureBox);
            Controls.Add(sprintNameLabel);
            Name = "SprintForm";
            Text = "SprintForm";
            FormClosing += SprintForm_FormClosing;
            KeyDown += SprintForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)sprintPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sprintNameLabel;
        private PictureBox sprintPictureBox;
        private Label sprintTimeLabel;
        private Label sprintCountLabel;
        private Button sprintNewButton;
        private Button sprintCloseButton;
        private System.Windows.Forms.Timer sprintTimer;
    }
}