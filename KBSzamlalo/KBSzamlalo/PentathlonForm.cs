using System.Media;

namespace KBSzamlalo
{
    public partial class PentathlonForm : Form
    {
        private int TotalSeconds;
        private int MaxSeconds;
        private bool CanPressKey;
        private bool Exercise;
        private int ExerciseNumber;
        private bool IsFull;
        private int DivideNumber;
        private bool FirstCountdown;
        private bool IsRest;

        int[] scores = new int[5];
        string[] exerciseName = new string[] { "clean", "clean and press", "jerk", "half snatch", "push press" };

        public PentathlonForm(bool type)
        {
            InitializeComponent();

            IsFull = type;
            if (IsFull)
            {
                DivideNumber = 1;
            }
            else
            {
                DivideNumber = 2;
            }

            LoadDefaultPage(IsFull);
        }

        private void PentathlonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (CanPressKey)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        switch (ExerciseNumber)
                        {
                            case 0:
                                if (Convert.ToInt32(countLabel.Text) < 120 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;

                            case 1:
                                if (Convert.ToInt32(countLabel.Text) < 60 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;

                            case 2:
                                if (Convert.ToInt32(countLabel.Text) < 120 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;

                            case 3:
                                if (Convert.ToInt32(countLabel.Text) < 108 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;

                            case 4:
                                if (Convert.ToInt32(countLabel.Text) < 120 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;
                        }
                        break;

                    case Keys.Space:
                        switch (ExerciseNumber)
                        {
                            case 0:
                                if (Convert.ToInt32(countLabel.Text) < 120 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;

                            case 1:
                                if (Convert.ToInt32(countLabel.Text) < 60 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;

                            case 2:
                                if (Convert.ToInt32(countLabel.Text) < 120 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;

                            case 3:
                                if (Convert.ToInt32(countLabel.Text) < 108 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;

                            case 4:
                                if (Convert.ToInt32(countLabel.Text) < 120 / DivideNumber)
                                {
                                    countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) + 1);
                                }
                                break;
                        }
                        break;
                    case Keys.Down:
                        if (countLabel.Text != "0")
                        {
                            countLabel.Text = Convert.ToString(Convert.ToInt32(countLabel.Text) - 1);
                        }
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            countLabel.Show();
            timeLabel.ForeColor = Color.Yellow;
            timeLabel.Text = "0:05";
            timeLabel.Show();
            exerciseTimer.Start();
        }

        // Timer
        private void exerciseTimer_Tick(object sender, EventArgs e)
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
                        if (Exercise)
                        {
                            timeLabel.Text = "0:0" + TotalSeconds.ToString();
                        }
                        else
                        {
                            restTimeLabel.Text = TotalSeconds.ToString();
                        }
                    }

                    if (TotalSeconds == 0)
                    {
                        FirstCountdown = false;
                        StartExercise();
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

                                switch (IsRest)
                                {
                                    case true:
                                        restTimeLabel.Text = mins.ToString() + ":" + secsString;
                                        break;

                                    case false:
                                        timeLabel.Text = mins.ToString() + ":" + secsString;
                                        break;
                                }
                            }
                            else
                            {
                                exerciseTimer.Stop();

                                if (IsRest)
                                {
                                    StartExercise();
                                }
                                else
                                {
                                    StartRest();
                                }
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

                                switch (IsRest)
                                {
                                    case true:
                                        restTimeLabel.Text = mins.ToString() + ":" + secsString;
                                        break;

                                    case false:
                                        timeLabel.Text = mins.ToString() + ":" + secsString;
                                        break;
                                }
                            }
                            else
                            {
                                exerciseTimer.Stop();

                                if (IsRest)
                                {
                                    StartExercise();
                                }
                                else
                                {
                                    StartRest();
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        private void StartExercise()
        {
            EndRest();

            exerciseLabel.Text = exerciseName[ExerciseNumber];
            exerciseLabel.Show();
            timeLabel.Text = "0:00";
            timeLabel.Show();
            countLabel.Show();
            timeLabel.ForeColor = Color.White;
            CanPressKey = true;
            IsRest = false;

            if (IsFull)
            {
                if (!Settings.StopWatch)
                {
                    TotalSeconds = 360;
                    timeLabel.Text = "6:00";
                }
                else
                {
                    TotalSeconds = 0;
                    MaxSeconds = 360;
                    timeLabel.Text = "0:00";
                }
            }
            else
            {
                if (!Settings.StopWatch)
                {
                    TotalSeconds = 180;
                    timeLabel.Text = "3:00";
                }
                else
                {
                    TotalSeconds = 0;
                    MaxSeconds = 180;
                    timeLabel.Text = "0:00";
                }
            }

            if (Settings.SoundOn)
            {
                PlaySound();
            }

            exerciseTimer.Start();
        }

        private void ExerciseEnd()
        {
            scores[ExerciseNumber] = Convert.ToInt32(countLabel.Text);
            exerciseLabel.Text = exerciseLabel.Text + " result: " + scores[ExerciseNumber];
            CanPressKey = false;
            ExerciseNumber++;
            countLabel.Hide();
            countLabel.Text = "0";
            timeLabel.Hide();
        }

        private void StartRest()
        {
            ExerciseEnd();

            if (ExerciseNumber == 5)
            {
                FinishExercise();
            }
            else
            {
                Exercise = false;
                IsRest = true;
                restTextLabel.Show();
                restTimeLabel.Show();

                if (IsFull)
                {
                    if (!Settings.StopWatch)
                    {
                        TotalSeconds = 300;
                        restTimeLabel.Text = "5:00";
                    }
                    else
                    {
                        TotalSeconds = 0;
                        MaxSeconds = 300;
                        restTimeLabel.Text = "0:00";
                    }
                }
                else
                {
                    if (!Settings.StopWatch)
                    {
                        TotalSeconds = 120;
                        restTimeLabel.Text = "2:00";
                    }
                    else
                    {
                        TotalSeconds = 0;
                        MaxSeconds = 120;
                        restTimeLabel.Text = "0:00";
                    }
                }

                exerciseTimer.Start();
            }
        }

        private void EndRest()
        {
            restTextLabel.Hide();
            restTimeLabel.Hide();
            exerciseTimer.Stop();
        }

        private void FinishExercise()
        {
            timeLabel.Hide();
            countLabel.Hide();
            exerciseLabel.Hide();

            cleanResultLabel.Text = cleanResultLabel.Text + " " + scores[0];
            cleanAndPressLabel.Text = cleanAndPressLabel.Text + " " + scores[1];
            jerkResultLabel.Text = jerkResultLabel.Text + " " + scores[2];
            halfSnatchResultLabel.Text = halfSnatchResultLabel.Text + " " + scores[3];
            pushPressResultLabel.Text = pushPressResultLabel.Text + " " + scores[4];

            cleanResultLabel.Show();
            cleanAndPressLabel.Show();
            jerkResultLabel.Show();
            halfSnatchResultLabel.Show();
            pushPressResultLabel.Show();

            pentathlonNewButton.Show();
            pentathlonCloseButton.Show();
        }

        private void pentathlonNewButton_Click(object sender, EventArgs e)
        {
            if (IsFull)
            {
                PentathlonForm pForm = new PentathlonForm(true);
                pForm.Show();
            }
            else
            {
                PentathlonForm pForm = new PentathlonForm(false);
                pForm.Show();
            }

            this.Close();
        }

        private void LoadDefaultPage(bool IsFull)
        {
            if (IsFull)
            {
                pentathlonLabel.Text = "Pentathlon - 6'/5'";
            }
            else
            {
                pentathlonLabel.Text = "Half pentathlon - 3'/2'";
            }

            exerciseLabel.Hide();

            cleanResultLabel.Hide();
            cleanAndPressLabel.Hide();
            jerkResultLabel.Hide();
            halfSnatchResultLabel.Hide();
            pushPressResultLabel.Hide();

            timeLabel.Hide();
            countLabel.Hide();
            exerciseTimer.Stop();

            restTimeLabel.Hide();
            restTextLabel.Hide();
            exerciseTimer.Stop();

            pentathlonCloseButton.Hide();
            pentathlonNewButton.Hide();

            pictureBox1.Show();

            ExerciseNumber = 0;
            TotalSeconds = 5;
            CanPressKey = false;
            Exercise = true;
            FirstCountdown = true;
            IsRest = false;

            Array.Clear(scores, 0, scores.Length);
        }

        private void pentathlonCloseButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void PentathlonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (ForceClose)
            {
                Form1 form = new Form1();
                form.Show();
            } */
        }

        private void PlaySound()
        {
            SoundPlayer simpleSound = new SoundPlayer("whistle.wav");
            simpleSound.Play();
        }
    }
}
