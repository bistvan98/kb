namespace KBSzamlalo
{
    partial class CustomForm
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
            customLabel = new Label();
            customLoadButton = new Button();
            customNewLabel = new Label();
            customTimeLabel = new Label();
            customHourTextBox = new TextBox();
            customMinutesTextBox = new TextBox();
            doublePointLabel = new Label();
            xPictureBox = new PictureBox();
            intervallLabel = new Label();
            roundsLabel = new Label();
            roundsTextBox = new TextBox();
            plusRestButton = new Button();
            plusWorkButton = new Button();
            nameLabel = new Label();
            saveLabel = new Label();
            saveNameTextBox = new TextBox();
            rowCounterLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)xPictureBox).BeginInit();
            SuspendLayout();
            // 
            // customLabel
            // 
            customLabel.AutoSize = true;
            customLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customLabel.ForeColor = Color.Red;
            customLabel.Location = new Point(50, 31);
            customLabel.Name = "customLabel";
            customLabel.Size = new Size(96, 32);
            customLabel.TabIndex = 3;
            customLabel.Text = "Custom";
            // 
            // customLoadButton
            // 
            customLoadButton.BackColor = SystemColors.ActiveCaptionText;
            customLoadButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customLoadButton.ForeColor = SystemColors.ButtonHighlight;
            customLoadButton.Location = new Point(50, 84);
            customLoadButton.Name = "customLoadButton";
            customLoadButton.Size = new Size(141, 45);
            customLoadButton.TabIndex = 16;
            customLoadButton.Text = "Load";
            customLoadButton.UseVisualStyleBackColor = false;
            // 
            // customNewLabel
            // 
            customNewLabel.AutoSize = true;
            customNewLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customNewLabel.ForeColor = Color.White;
            customNewLabel.Location = new Point(50, 156);
            customNewLabel.Name = "customNewLabel";
            customNewLabel.Size = new Size(62, 32);
            customNewLabel.TabIndex = 17;
            customNewLabel.Text = "New";
            // 
            // customTimeLabel
            // 
            customTimeLabel.AutoSize = true;
            customTimeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            customTimeLabel.ForeColor = Color.White;
            customTimeLabel.Location = new Point(50, 214);
            customTimeLabel.Name = "customTimeLabel";
            customTimeLabel.Size = new Size(57, 25);
            customTimeLabel.TabIndex = 18;
            customTimeLabel.Text = "Time:";
            // 
            // customHourTextBox
            // 
            customHourTextBox.BackColor = Color.Black;
            customHourTextBox.Location = new Point(130, 214);
            customHourTextBox.Name = "customHourTextBox";
            customHourTextBox.Size = new Size(32, 23);
            customHourTextBox.TabIndex = 19;
            customHourTextBox.TextChanged += customHourTextBox_TextChanged;
            // 
            // customMinutesTextBox
            // 
            customMinutesTextBox.BackColor = Color.Black;
            customMinutesTextBox.Location = new Point(187, 214);
            customMinutesTextBox.Name = "customMinutesTextBox";
            customMinutesTextBox.Size = new Size(32, 23);
            customMinutesTextBox.TabIndex = 20;
            customMinutesTextBox.TextChanged += customMinutesTextBox_TextChanged;
            // 
            // doublePointLabel
            // 
            doublePointLabel.AutoSize = true;
            doublePointLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            doublePointLabel.ForeColor = Color.White;
            doublePointLabel.Location = new Point(168, 205);
            doublePointLabel.Name = "doublePointLabel";
            doublePointLabel.Size = new Size(19, 32);
            doublePointLabel.TabIndex = 21;
            doublePointLabel.Text = ":";
            doublePointLabel.Click += doublePointLabel_Click;
            // 
            // xPictureBox
            // 
            xPictureBox.BorderStyle = BorderStyle.FixedSingle;
            xPictureBox.Image = Properties.Resources.black;
            xPictureBox.Location = new Point(385, 214);
            xPictureBox.Name = "xPictureBox";
            xPictureBox.Size = new Size(25, 25);
            xPictureBox.TabIndex = 22;
            xPictureBox.TabStop = false;
            xPictureBox.Click += xPictureBox_Click;
            // 
            // intervallLabel
            // 
            intervallLabel.AutoSize = true;
            intervallLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            intervallLabel.ForeColor = Color.White;
            intervallLabel.Location = new Point(299, 214);
            intervallLabel.Name = "intervallLabel";
            intervallLabel.Size = new Size(80, 25);
            intervallLabel.TabIndex = 23;
            intervallLabel.Text = "Intervall";
            // 
            // roundsLabel
            // 
            roundsLabel.AutoSize = true;
            roundsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            roundsLabel.ForeColor = Color.White;
            roundsLabel.Location = new Point(50, 275);
            roundsLabel.Name = "roundsLabel";
            roundsLabel.Size = new Size(78, 25);
            roundsLabel.TabIndex = 24;
            roundsLabel.Text = "Rounds:";
            // 
            // roundsTextBox
            // 
            roundsTextBox.BackColor = Color.Black;
            roundsTextBox.Location = new Point(134, 277);
            roundsTextBox.Name = "roundsTextBox";
            roundsTextBox.Size = new Size(32, 23);
            roundsTextBox.TabIndex = 25;
            // 
            // plusRestButton
            // 
            plusRestButton.BackColor = SystemColors.ActiveCaptionText;
            plusRestButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            plusRestButton.ForeColor = SystemColors.ButtonHighlight;
            plusRestButton.Location = new Point(201, 269);
            plusRestButton.Name = "plusRestButton";
            plusRestButton.Size = new Size(118, 37);
            plusRestButton.TabIndex = 26;
            plusRestButton.Text = "+ Rest";
            plusRestButton.UseVisualStyleBackColor = false;
            plusRestButton.Click += plusRestButton_Click;
            // 
            // plusWorkButton
            // 
            plusWorkButton.BackColor = SystemColors.ActiveCaptionText;
            plusWorkButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            plusWorkButton.ForeColor = SystemColors.ButtonHighlight;
            plusWorkButton.Location = new Point(347, 269);
            plusWorkButton.Name = "plusWorkButton";
            plusWorkButton.Size = new Size(118, 37);
            plusWorkButton.TabIndex = 27;
            plusWorkButton.Text = "+ Work";
            plusWorkButton.UseVisualStyleBackColor = false;
            plusWorkButton.Click += plusWorkButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(50, 536);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(66, 25);
            nameLabel.TabIndex = 28;
            nameLabel.Text = "Name:";
            // 
            // saveLabel
            // 
            saveLabel.AutoSize = true;
            saveLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            saveLabel.ForeColor = Color.White;
            saveLabel.Location = new Point(50, 583);
            saveLabel.Name = "saveLabel";
            saveLabel.Size = new Size(51, 25);
            saveLabel.TabIndex = 29;
            saveLabel.Text = "Save";
            // 
            // saveNameTextBox
            // 
            saveNameTextBox.BackColor = Color.Black;
            saveNameTextBox.Location = new Point(134, 541);
            saveNameTextBox.Name = "saveNameTextBox";
            saveNameTextBox.Size = new Size(331, 23);
            saveNameTextBox.TabIndex = 30;
            // 
            // rowCounterLabel
            // 
            rowCounterLabel.AutoSize = true;
            rowCounterLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rowCounterLabel.ForeColor = Color.White;
            rowCounterLabel.Location = new Point(483, 277);
            rowCounterLabel.Name = "rowCounterLabel";
            rowCounterLabel.Size = new Size(59, 25);
            rowCounterLabel.TabIndex = 31;
            rowCounterLabel.Text = "Rows:";
            // 
            // CustomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1284, 641);
            Controls.Add(rowCounterLabel);
            Controls.Add(saveNameTextBox);
            Controls.Add(saveLabel);
            Controls.Add(nameLabel);
            Controls.Add(plusWorkButton);
            Controls.Add(plusRestButton);
            Controls.Add(roundsTextBox);
            Controls.Add(roundsLabel);
            Controls.Add(intervallLabel);
            Controls.Add(xPictureBox);
            Controls.Add(doublePointLabel);
            Controls.Add(customMinutesTextBox);
            Controls.Add(customHourTextBox);
            Controls.Add(customTimeLabel);
            Controls.Add(customNewLabel);
            Controls.Add(customLoadButton);
            Controls.Add(customLabel);
            Name = "CustomForm";
            Text = "CustomForm";
            ((System.ComponentModel.ISupportInitialize)xPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customLabel;
        private Button customLoadButton;
        private Label customNewLabel;
        private Label customTimeLabel;
        private TextBox customHourTextBox;
        private TextBox customMinutesTextBox;
        private Label doublePointLabel;
        private PictureBox xPictureBox;
        private Label intervallLabel;
        private Label roundsLabel;
        private TextBox roundsTextBox;
        private Button plusRestButton;
        private Button plusWorkButton;
        private Label nameLabel;
        private Label saveLabel;
        private TextBox saveNameTextBox;
        private Label rowCounterLabel;
    }
}