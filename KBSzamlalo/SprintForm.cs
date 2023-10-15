using System.Diagnostics;
using System.Media;
using System.Security.Cryptography;

namespace KBSzamlalo
{
    public partial class SprintForm : Form
    {
        private int SprintType;
        private int TotalSeconds;
        private bool FirstCountdown;
        private int MaxSeconds;
        private bool CanUseKey;
        private Point defPoint = new Point();

        public SprintForm(int type)
        {
            InitializeComponent();

            sprintTimer.Stop();
            SprintType = type;

            LoadDefault(type);
        }

        // Starts the sprint
        private void sprintPictureBox_Click(object sender, EventArgs e)
        {
            sprintPictureBox.Hide();
            sprintCountLabel.Show();
            sprintTimeLabel.ForeColor = Color.Yellow;
            sprintTimeLabel.Text = "00:05";
            sprintTimeLabel.Show();
            sprintTimer.Start();
        }

        // Loads the default page
        private void LoadDefault(int type)
        {
            sprintNameLabel.Text = "Sprint - " + type + "'";
            sprintCloseButton.Hide();
            sprintNewButton.Hide();
            sprintCountLabel.Hide();
            sprintTimeLabel.Hide();
            sprintPictureBox.Show();
            sprintCountLabel.Text = "0";
            FirstCountdown = true;
            CanUseKey = false;
            TotalSeconds = 5;
            sprintTimeLabel.Location = defPoint;
        }

        // Starts the sprint
        private void StartExercise(int type)
        {
            CanUseKey = true;
            FirstCountdown = false;
            sprintTimeLabel.ForeColor = Color.White;

            switch (Settings.StopWatch)
            {
                // Stopwatch
                case true:
                    switch (type)
                    {
                        case 3:
                            TotalSeconds = 0;
                            MaxSeconds = 180;
                            sprintTimeLabel.Text = "00:00";
                            break;

                        case 5:
                            TotalSeconds = 0;
                            MaxSeconds = 300;
                            sprintTimeLabel.Text = "00:00";
                            break;

                        case 10:
                            TotalSeconds = 0;
                            MaxSeconds = 600;
                            sprintTimeLabel.Text = "00:00";
                            break;

                        case 12:
                            TotalSeconds = 0;
                            MaxSeconds = 720;
                            sprintTimeLabel.Text = "00:00";
                            break;

                        case 30:
                            TotalSeconds = 0;
                            MaxSeconds = 1800;
                            sprintTimeLabel.Text = "00:00";
                            break;

                        case 60:
                            TotalSeconds = 0;
                            MaxSeconds = 3600;
                            sprintTimeLabel.Text = "00:00";
                            break;
                    }
                    break;
                // Countdown
                case false:
                    switch (type)
                    {
                        case 3:
                            TotalSeconds = 180;
                            sprintTimeLabel.Text = "0" + type + ":00";
                            break;

                        case 5:
                            TotalSeconds = 300;
                            sprintTimeLabel.Text = "0" + type + ":00";
                            break;

                        case 10:
                            TotalSeconds = 600;
                            sprintTimeLabel.Text = type + ":00";
                            break;

                        case 12:
                            TotalSeconds = 720;
                            sprintTimeLabel.Text = type + ":00";
                            break;

                        case 30:
                            TotalSeconds = 1800;
                            sprintTimeLabel.Text = type + ":00";
                            break;

                        case 60:
                            TotalSeconds = 3600;
                            sprintTimeLabel.Text = type + ":00";
                            break;
                    }
                    break;
            }

            if (Settings.SoundOn)
            {
                try
                {
                    PlaySound();
                }
                catch
                {

                }
            }

            sprintTimer.Start();
        }

        // Finishing the sprint
        private void FinishExercise()
        {
            CanUseKey = false;
            sprintTimeLabel.Hide();
            sprintCloseButton.Show();
            sprintNewButton.Show();
        }

        // Timer check
        private void sprintTimer_Tick(object sender, EventArgs e)
        {
            int secs;
            int mins;
            string secsString;

            switch (FirstCountdown)
            {
                case true:
                    if (TotalSeconds > 0)
                    {
                        TotalSeconds = TotalSeconds - 1;

                        sprintTimeLabel.Text = "00:0" + TotalSeconds.ToString();
                    }

                    if (TotalSeconds == 0)
                    {
                        FirstCountdown = false;
                        sprintTimer.Stop();
                        StartExercise(SprintType);
                    }
                    break;

                case false:
                    switch (Settings.StopWatch)
                    {
                        // Stopwatch
                        case true:
                            if (TotalSeconds < MaxSeconds)
                            {
                                TotalSeconds++;
                                mins = TotalSeconds / 60;
                                secs = TotalSeconds - (mins * 60);
                                secsString = secs.ToString();
                                string minsString = mins.ToString();

                                if (secs < 10)
                                {
                                    secsString = "0" + secs;
                                }

                                if (mins < 10)
                                {
                                    minsString = "0" + mins;
                                }

                                sprintTimeLabel.Text = minsString + ":" + secsString;
                            }
                            else
                            {
                                sprintTimer.Stop();
                                FinishExercise();
                            }
                            break;
                        // Countdown
                        case false:
                            if (TotalSeconds > 0)
                            {
                                TotalSeconds--;
                                mins = TotalSeconds / 60;
                                secs = TotalSeconds - (mins * 60);
                                secsString = secs.ToString();
                                string minsString = mins.ToString();

                                if (secs < 10)
                                {
                                    secsString = "0" + secs;
                                }

                                if (mins < 10)
                                {
                                    minsString = "0" + mins;
                                }

                                sprintTimeLabel.Text = minsString + ":" + secsString;
                            }
                            else
                            {
                                sprintTimer.Stop();
                                FinishExercise();
                            }
                            break;
                    }
                    break;
            }
        }

        // Soundplayer
        private void PlaySound()
        {
            SoundPlayer simpleSound = new SoundPlayer("whistle.wav");
            simpleSound.Play();
        }

        // Run the sprint again
        private void sprintNewButton_Click(object sender, EventArgs e)
        {
            SprintForm sform = new SprintForm(SprintType);
            sform.Show();

            this.Hide();
        }

        // Close the form with a button, load the main form
        private void sprintCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Keyboard key reader
        private void SprintForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (CanUseKey)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        sprintCountLabel.Text = Convert.ToString(Convert.ToInt32(sprintCountLabel.Text) + 1);

                        if (Convert.ToInt32(sprintCountLabel.Text) >= 100 && Convert.ToInt32(sprintCountLabel.Text) - 1 < 100)
                        {
                            Point p = new Point(sprintCountLabel.Location.X - 70, sprintCountLabel.Location.Y);
                            sprintCountLabel.Location = p;
                        }
                        else if (Convert.ToInt32(sprintCountLabel.Text) >= 10 && Convert.ToInt32(sprintCountLabel.Text) - 1 < 10)
                        {
                            defPoint = new Point(sprintCountLabel.Location.X, sprintCountLabel.Location.Y);
                            Point p = new Point(sprintCountLabel.Location.X - 70, sprintCountLabel.Location.Y);
                            sprintCountLabel.Location = p;
                        }

                        break;

                    case Keys.Space:
                        sprintCountLabel.Text = Convert.ToString(Convert.ToInt32(sprintCountLabel.Text) + 1);

                        if (Convert.ToInt32(sprintCountLabel.Text) >= 100 && Convert.ToInt32(sprintCountLabel.Text) - 1 < 100)
                        {
                            Point p = new Point(sprintCountLabel.Location.X - 70, sprintCountLabel.Location.Y);
                            sprintCountLabel.Location = p;
                        }
                        else if (Convert.ToInt32(sprintCountLabel.Text) >= 10 && Convert.ToInt32(sprintCountLabel.Text) - 1 < 10)
                        {
                            defPoint = new Point(sprintCountLabel.Location.X, sprintCountLabel.Location.Y);
                            Point p = new Point(sprintCountLabel.Location.X - 70, sprintCountLabel.Location.Y);
                            sprintCountLabel.Location = p;
                        }

                        break;

                    case Keys.Down:
                        if (sprintCountLabel.Text != "0")
                        {
                            sprintCountLabel.Text = Convert.ToString(Convert.ToInt32(sprintCountLabel.Text) - 1);
                        }

                        if (Convert.ToInt32(sprintCountLabel.Text) < 10 && Convert.ToInt32(sprintCountLabel.Text) + 1 >= 10)
                        {
                            Point p = new Point(sprintCountLabel.Location.X + 70, sprintCountLabel.Location.Y);
                            sprintCountLabel.Location = p;
                        }
                        else if (Convert.ToInt32(sprintCountLabel.Text) < 100 && Convert.ToInt32(sprintCountLabel.Text) + 1 >= 100)
                        {
                            Point p = new Point(sprintCountLabel.Location.X + 70, sprintCountLabel.Location.Y);
                            sprintCountLabel.Location = p;
                        }

                        break;
                }
            }
        }

        // When the form closes the main form will load
        private void SprintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Hide();
        }
    }
}
