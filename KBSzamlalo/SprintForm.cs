using System.Media;

namespace KBSzamlalo
{
    public partial class SprintForm : Form
    {
        int SprintType;
        int TotalSeconds;
        bool FirstCountdown;
        int MaxSeconds;
        bool CanUseKey;
        public SprintForm(int type)
        {
            InitializeComponent();

            sprintTimer.Stop();
            SprintType = type;

            LoadDefault(type);
        }

        private void sprintPictureBox_Click(object sender, EventArgs e)
        {
            sprintPictureBox.Hide();
            sprintCountLabel.Show();
            sprintTimeLabel.ForeColor = Color.Yellow;
            sprintTimeLabel.Text = "0:05";
            sprintTimeLabel.Show();
            sprintTimer.Start();
        }

        private void LoadDefault(int type)
        {
            sprintNameLabel.Text = "Sprint - " + type + "'";
            sprintCloseButton.Hide();
            sprintNewButton.Hide();
            sprintCountLabel.Hide();
            sprintTimeLabel.Hide();
            FirstCountdown = true;
            CanUseKey = false;
            TotalSeconds = 5;
        }

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
                            sprintTimeLabel.Text = "0:00";
                            break;

                        case 5:
                            TotalSeconds = 0;
                            MaxSeconds = 300;
                            sprintTimeLabel.Text = "0:00";
                            break;

                        case 10:
                            TotalSeconds = 0;
                            MaxSeconds = 600;
                            sprintTimeLabel.Text = "0:00";
                            break;

                        case 12:
                            TotalSeconds = 0;
                            MaxSeconds = 720;
                            sprintTimeLabel.Text = "0:00";
                            break;

                        case 30:
                            TotalSeconds = 0;
                            MaxSeconds = 1800;
                            sprintTimeLabel.Text = "0:00";
                            break;

                        case 60:
                            TotalSeconds = 0;
                            MaxSeconds = 3600;
                            sprintTimeLabel.Text = "0:00";
                            break;
                    }
                    break;
                // Countdown
                case false:
                    switch (type)
                    {
                        case 3:
                            TotalSeconds = 180;
                            sprintTimeLabel.Text = type + ":00";
                            break;

                        case 5:
                            TotalSeconds = 300;
                            sprintTimeLabel.Text = type + ":00";
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

            if(Settings.SoundOn)
            {
                PlaySound();
            }
            
            sprintTimer.Start();
        }

        private void FinishExercise()
        {
            CanUseKey = false;
            sprintTimeLabel.Hide();
            sprintCloseButton.Show();
            sprintNewButton.Show();
        }

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

                        sprintTimeLabel.Text = "0:0" + TotalSeconds.ToString();
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

                                if (secs < 10)
                                {
                                    secsString = "0" + secs;
                                }

                                sprintTimeLabel.Text = mins.ToString() + ":" + secsString;
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

                                if (secs < 10)
                                {
                                    secsString = "0" + secs;
                                }

                                sprintTimeLabel.Text = mins.ToString() + ":" + secsString;
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

        private void PlaySound()
        {
            SoundPlayer simpleSound = new SoundPlayer("whistle.wav");
            simpleSound.Play();
        }

        private void sprintNewButton_Click(object sender, EventArgs e)
        {
            SprintForm sForm = new SprintForm(SprintType);
            sForm.Show();
            this.Close();
        }

        private void sprintCloseButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void SprintForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(CanUseKey)
            {
                switch(e.KeyCode)
                {
                    case Keys.Up:
                        sprintCountLabel.Text = Convert.ToString(Convert.ToInt32(sprintCountLabel.Text) + 1);
                        break;

                    case Keys.Space:
                        sprintCountLabel.Text = Convert.ToString(Convert.ToInt32(sprintCountLabel.Text) + 1);
                        break;

                    case Keys.Down:
                        if(sprintCountLabel.Text != "0")
                        {
                            sprintCountLabel.Text = Convert.ToString(Convert.ToInt32(sprintCountLabel.Text) - 1);
                        }
                        break;
                }
            }
        }
    }
}
