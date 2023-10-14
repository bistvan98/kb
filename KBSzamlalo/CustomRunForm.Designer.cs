namespace KBSzamlalo
{
    partial class CustomRunForm
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
            customRunPicBox = new PictureBox();
            customRunLabel = new Label();
            roundsLabel = new Label();
            typeLabel4 = new Label();
            typeLabel3 = new Label();
            typeLabel2 = new Label();
            typeLabel1 = new Label();
            time4Label = new Label();
            time3Label = new Label();
            time2Label = new Label();
            time1Label = new Label();
            typeLabel6 = new Label();
            typeLabel5 = new Label();
            time6Label = new Label();
            time5Label = new Label();
            id4Label = new Label();
            id3Label = new Label();
            id2Label = new Label();
            id1Label = new Label();
            id6Label = new Label();
            id5Label = new Label();
            customRestTextLabel = new Label();
            customTimeLabel = new Label();
            customCountLabel = new Label();
            customRestTimeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            roundCounterTextLabel = new Label();
            roundCountLabel = new Label();
            customMoveListUp = new PictureBox();
            customMoveListDown = new PictureBox();
            closeLabel = new Label();
            customNewLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)customRunPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customMoveListUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customMoveListDown).BeginInit();
            SuspendLayout();
            // 
            // customRunPicBox
            // 
            customRunPicBox.Image = Properties.Resources.play_button2;
            customRunPicBox.Location = new Point(533, 80);
            customRunPicBox.Name = "customRunPicBox";
            customRunPicBox.Size = new Size(361, 367);
            customRunPicBox.TabIndex = 76;
            customRunPicBox.TabStop = false;
            customRunPicBox.Click += customRunPicBox_Click;
            // 
            // customRunLabel
            // 
            customRunLabel.AutoSize = true;
            customRunLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customRunLabel.ForeColor = Color.Red;
            customRunLabel.Location = new Point(67, 49);
            customRunLabel.Name = "customRunLabel";
            customRunLabel.Size = new Size(96, 32);
            customRunLabel.TabIndex = 77;
            customRunLabel.Text = "Custom";
            // 
            // roundsLabel
            // 
            roundsLabel.AutoSize = true;
            roundsLabel.BorderStyle = BorderStyle.FixedSingle;
            roundsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            roundsLabel.ForeColor = Color.White;
            roundsLabel.Location = new Point(67, 132);
            roundsLabel.Name = "roundsLabel";
            roundsLabel.Size = new Size(100, 34);
            roundsLabel.TabIndex = 78;
            roundsLabel.Text = "Rounds:";
            roundsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // typeLabel4
            // 
            typeLabel4.AutoSize = true;
            typeLabel4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel4.ForeColor = Color.White;
            typeLabel4.Location = new Point(106, 347);
            typeLabel4.Name = "typeLabel4";
            typeLabel4.Size = new Size(53, 25);
            typeLabel4.TabIndex = 87;
            typeLabel4.Text = "work";
            // 
            // typeLabel3
            // 
            typeLabel3.AutoSize = true;
            typeLabel3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel3.ForeColor = Color.White;
            typeLabel3.Location = new Point(106, 297);
            typeLabel3.Name = "typeLabel3";
            typeLabel3.Size = new Size(53, 25);
            typeLabel3.TabIndex = 86;
            typeLabel3.Text = "work";
            // 
            // typeLabel2
            // 
            typeLabel2.AutoSize = true;
            typeLabel2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel2.ForeColor = Color.White;
            typeLabel2.Location = new Point(106, 247);
            typeLabel2.Name = "typeLabel2";
            typeLabel2.Size = new Size(53, 25);
            typeLabel2.TabIndex = 85;
            typeLabel2.Text = "work";
            // 
            // typeLabel1
            // 
            typeLabel1.AutoSize = true;
            typeLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel1.ForeColor = Color.White;
            typeLabel1.Location = new Point(106, 197);
            typeLabel1.Name = "typeLabel1";
            typeLabel1.Size = new Size(53, 25);
            typeLabel1.TabIndex = 84;
            typeLabel1.Text = "work";
            // 
            // time4Label
            // 
            time4Label.AutoSize = true;
            time4Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            time4Label.ForeColor = Color.White;
            time4Label.Location = new Point(190, 347);
            time4Label.Name = "time4Label";
            time4Label.Size = new Size(46, 25);
            time4Label.TabIndex = 83;
            time4Label.Text = "0:00";
            // 
            // time3Label
            // 
            time3Label.AutoSize = true;
            time3Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            time3Label.ForeColor = Color.White;
            time3Label.Location = new Point(190, 297);
            time3Label.Name = "time3Label";
            time3Label.Size = new Size(46, 25);
            time3Label.TabIndex = 82;
            time3Label.Text = "0:00";
            // 
            // time2Label
            // 
            time2Label.AutoSize = true;
            time2Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            time2Label.ForeColor = Color.White;
            time2Label.Location = new Point(190, 247);
            time2Label.Name = "time2Label";
            time2Label.Size = new Size(46, 25);
            time2Label.TabIndex = 81;
            time2Label.Text = "0:00";
            // 
            // time1Label
            // 
            time1Label.AutoSize = true;
            time1Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            time1Label.ForeColor = Color.White;
            time1Label.Location = new Point(192, 197);
            time1Label.Name = "time1Label";
            time1Label.Size = new Size(46, 25);
            time1Label.TabIndex = 80;
            time1Label.Text = "0:00";
            // 
            // typeLabel6
            // 
            typeLabel6.AutoSize = true;
            typeLabel6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel6.ForeColor = Color.White;
            typeLabel6.Location = new Point(106, 447);
            typeLabel6.Name = "typeLabel6";
            typeLabel6.Size = new Size(53, 25);
            typeLabel6.TabIndex = 91;
            typeLabel6.Text = "work";
            // 
            // typeLabel5
            // 
            typeLabel5.AutoSize = true;
            typeLabel5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel5.ForeColor = Color.White;
            typeLabel5.Location = new Point(106, 397);
            typeLabel5.Name = "typeLabel5";
            typeLabel5.Size = new Size(53, 25);
            typeLabel5.TabIndex = 90;
            typeLabel5.Text = "work";
            // 
            // time6Label
            // 
            time6Label.AutoSize = true;
            time6Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            time6Label.ForeColor = Color.White;
            time6Label.Location = new Point(190, 447);
            time6Label.Name = "time6Label";
            time6Label.Size = new Size(46, 25);
            time6Label.TabIndex = 89;
            time6Label.Text = "0:00";
            // 
            // time5Label
            // 
            time5Label.AutoSize = true;
            time5Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            time5Label.ForeColor = Color.White;
            time5Label.Location = new Point(190, 397);
            time5Label.Name = "time5Label";
            time5Label.Size = new Size(46, 25);
            time5Label.TabIndex = 88;
            time5Label.Text = "0:00";
            // 
            // id4Label
            // 
            id4Label.AutoSize = true;
            id4Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            id4Label.ForeColor = Color.White;
            id4Label.Location = new Point(42, 347);
            id4Label.Name = "id4Label";
            id4Label.Size = new Size(38, 25);
            id4Label.TabIndex = 95;
            id4Label.Text = "id4";
            // 
            // id3Label
            // 
            id3Label.AutoSize = true;
            id3Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            id3Label.ForeColor = Color.White;
            id3Label.Location = new Point(42, 297);
            id3Label.Name = "id3Label";
            id3Label.Size = new Size(38, 25);
            id3Label.TabIndex = 94;
            id3Label.Text = "id3";
            // 
            // id2Label
            // 
            id2Label.AutoSize = true;
            id2Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            id2Label.ForeColor = Color.White;
            id2Label.Location = new Point(42, 247);
            id2Label.Name = "id2Label";
            id2Label.Size = new Size(38, 25);
            id2Label.TabIndex = 93;
            id2Label.Text = "id2";
            // 
            // id1Label
            // 
            id1Label.AutoSize = true;
            id1Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            id1Label.ForeColor = Color.White;
            id1Label.Location = new Point(42, 197);
            id1Label.Name = "id1Label";
            id1Label.Size = new Size(38, 25);
            id1Label.TabIndex = 92;
            id1Label.Text = "id1";
            // 
            // id6Label
            // 
            id6Label.AutoSize = true;
            id6Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            id6Label.ForeColor = Color.White;
            id6Label.Location = new Point(42, 447);
            id6Label.Name = "id6Label";
            id6Label.Size = new Size(38, 25);
            id6Label.TabIndex = 97;
            id6Label.Text = "id4";
            // 
            // id5Label
            // 
            id5Label.AutoSize = true;
            id5Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            id5Label.ForeColor = Color.White;
            id5Label.Location = new Point(42, 397);
            id5Label.Name = "id5Label";
            id5Label.Size = new Size(38, 25);
            id5Label.TabIndex = 96;
            id5Label.Text = "id3";
            // 
            // customRestTextLabel
            // 
            customRestTextLabel.AutoSize = true;
            customRestTextLabel.Font = new Font("Segoe UI", 80F, FontStyle.Regular, GraphicsUnit.Point);
            customRestTextLabel.ForeColor = Color.Gold;
            customRestTextLabel.Location = new Point(615, 433);
            customRestTextLabel.Name = "customRestTextLabel";
            customRestTextLabel.Size = new Size(234, 142);
            customRestTextLabel.TabIndex = 100;
            customRestTextLabel.Text = "rest";
            // 
            // customTimeLabel
            // 
            customTimeLabel.AutoSize = true;
            customTimeLabel.Font = new Font("Segoe UI", 120F, FontStyle.Regular, GraphicsUnit.Point);
            customTimeLabel.ForeColor = Color.White;
            customTimeLabel.Location = new Point(496, 398);
            customTimeLabel.Name = "customTimeLabel";
            customTimeLabel.Size = new Size(468, 212);
            customTimeLabel.TabIndex = 99;
            customTimeLabel.Text = "00:05";
            // 
            // customCountLabel
            // 
            customCountLabel.AutoSize = true;
            customCountLabel.Font = new Font("Segoe UI", 200F, FontStyle.Regular, GraphicsUnit.Point);
            customCountLabel.ForeColor = Color.White;
            customCountLabel.Location = new Point(588, 49);
            customCountLabel.Name = "customCountLabel";
            customCountLabel.Size = new Size(293, 355);
            customCountLabel.TabIndex = 98;
            customCountLabel.Text = "0";
            // 
            // customRestTimeLabel
            // 
            customRestTimeLabel.AutoSize = true;
            customRestTimeLabel.Font = new Font("Segoe UI", 120F, FontStyle.Regular, GraphicsUnit.Point);
            customRestTimeLabel.ForeColor = Color.Red;
            customRestTimeLabel.Location = new Point(496, 147);
            customRestTimeLabel.Name = "customRestTimeLabel";
            customRestTimeLabel.Size = new Size(468, 212);
            customRestTimeLabel.TabIndex = 101;
            customRestTimeLabel.Text = "00:05";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // roundCounterTextLabel
            // 
            roundCounterTextLabel.AutoSize = true;
            roundCounterTextLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            roundCounterTextLabel.ForeColor = Color.Gold;
            roundCounterTextLabel.Location = new Point(153, 511);
            roundCounterTextLabel.Name = "roundCounterTextLabel";
            roundCounterTextLabel.Size = new Size(83, 32);
            roundCounterTextLabel.TabIndex = 102;
            roundCounterTextLabel.Text = "Round";
            // 
            // roundCountLabel
            // 
            roundCountLabel.AutoSize = true;
            roundCountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            roundCountLabel.ForeColor = Color.Gold;
            roundCountLabel.Location = new Point(170, 569);
            roundCountLabel.Name = "roundCountLabel";
            roundCountLabel.Size = new Size(49, 32);
            roundCountLabel.TabIndex = 103;
            roundCountLabel.Text = "1/8";
            // 
            // customMoveListUp
            // 
            customMoveListUp.BorderStyle = BorderStyle.FixedSingle;
            customMoveListUp.Image = Properties.Resources.upArrow;
            customMoveListUp.Location = new Point(259, 197);
            customMoveListUp.Name = "customMoveListUp";
            customMoveListUp.Size = new Size(25, 25);
            customMoveListUp.TabIndex = 104;
            customMoveListUp.TabStop = false;
            customMoveListUp.Click += customMoveListUp_Click;
            // 
            // customMoveListDown
            // 
            customMoveListDown.BorderStyle = BorderStyle.FixedSingle;
            customMoveListDown.Image = Properties.Resources.downArrow;
            customMoveListDown.Location = new Point(259, 447);
            customMoveListDown.Name = "customMoveListDown";
            customMoveListDown.Size = new Size(25, 25);
            customMoveListDown.TabIndex = 105;
            customMoveListDown.TabStop = false;
            customMoveListDown.Click += customMoveListDown_Click;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeLabel.ForeColor = Color.White;
            closeLabel.Location = new Point(67, 543);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(72, 32);
            closeLabel.TabIndex = 79;
            closeLabel.Text = "Close";
            closeLabel.Click += closeLabel_Click;
            // 
            // customNewLabel
            // 
            customNewLabel.AutoSize = true;
            customNewLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customNewLabel.ForeColor = Color.White;
            customNewLabel.Location = new Point(1082, 543);
            customNewLabel.Name = "customNewLabel";
            customNewLabel.Size = new Size(62, 32);
            customNewLabel.TabIndex = 106;
            customNewLabel.Text = "New";
            customNewLabel.Click += customNewLabel_Click;
            // 
            // CustomRunForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1284, 641);
            Controls.Add(customNewLabel);
            Controls.Add(customMoveListDown);
            Controls.Add(customMoveListUp);
            Controls.Add(roundCountLabel);
            Controls.Add(roundCounterTextLabel);
            Controls.Add(customRestTimeLabel);
            Controls.Add(customRestTextLabel);
            Controls.Add(customTimeLabel);
            Controls.Add(customCountLabel);
            Controls.Add(id6Label);
            Controls.Add(id5Label);
            Controls.Add(id4Label);
            Controls.Add(id3Label);
            Controls.Add(id2Label);
            Controls.Add(id1Label);
            Controls.Add(typeLabel6);
            Controls.Add(typeLabel5);
            Controls.Add(time6Label);
            Controls.Add(time5Label);
            Controls.Add(typeLabel4);
            Controls.Add(typeLabel3);
            Controls.Add(typeLabel2);
            Controls.Add(typeLabel1);
            Controls.Add(time4Label);
            Controls.Add(time3Label);
            Controls.Add(time2Label);
            Controls.Add(time1Label);
            Controls.Add(closeLabel);
            Controls.Add(roundsLabel);
            Controls.Add(customRunLabel);
            Controls.Add(customRunPicBox);
            Name = "CustomRunForm";
            Text = "CustomRunForm";
            FormClosing += CustomRunForm_FormClosing;
            KeyDown += CustomRunForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)customRunPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)customMoveListUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)customMoveListDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox customRunPicBox;
        private Label customRunLabel;
        private Label roundsLabel;
        private Label typeLabel4;
        private Label typeLabel3;
        private Label typeLabel2;
        private Label typeLabel1;
        private Label time4Label;
        private Label time3Label;
        private Label time2Label;
        private Label time1Label;
        private Label typeLabel6;
        private Label typeLabel5;
        private Label time6Label;
        private Label time5Label;
        private Label id4Label;
        private Label id3Label;
        private Label id2Label;
        private Label id1Label;
        private Label id6Label;
        private Label id5Label;
        private Label customRestTextLabel;
        private Label customTimeLabel;
        private Label customCountLabel;
        private Label customRestTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private Label roundCounterTextLabel;
        private Label roundCountLabel;
        private PictureBox customMoveListUp;
        private PictureBox customMoveListDown;
        private Label closeLabel;
        private Label customNewLabel;
    }
}