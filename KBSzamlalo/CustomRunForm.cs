using System.Diagnostics;
using System.Media;

namespace KBSzamlalo
{
    public partial class CustomRunForm : Form
    {
        private bool FirstCountdown;
        private int TotalSeconds = 5;
        private bool CanPressKey;
        private bool Exercise;
        private bool IsRest;
        private int MaxSeconds;
        private int RoundNumber;
        private int Counter;
        private int WorkNumber = 0;
        private List<int> scores = new List<int>();
        private int IterationNumber;
        private bool IsResultListing;
        private Point defPoint = new Point();

        public CustomRunForm()
        {
            InitializeComponent();
            timer1.Stop();
            if (Settings.Lines.Count > 4)
            {
                LoadDefault();
            }
            else
            {
                LoadDefaultSprint();
            }
        }

        #region "Load methods"

        // Loads the default items for an intervall run
        private void LoadDefaultSprint()
        {
            FirstCountdown = true;
            TotalSeconds = 5;
            CanPressKey = false;
            MaxSeconds = 0;

            customNewLabel.Hide();
            customRunPicBox.Show();
            customRunLabel.Show();
            roundCounterTextLabel.Hide();
            roundCountLabel.Hide();
            customCountLabel.Hide();
            customRestTextLabel.Hide();
            customRestTimeLabel.Hide();
            customTimeLabel.Hide();
            customRunLabel.Text = Settings.Lines[Settings.Lines.Count - 1];


            string timeMin = Settings.Lines[Settings.Lines.Count - 3];
            string timeSec = Settings.Lines[Settings.Lines.Count - 2];

            if (Convert.ToInt32(timeMin) < 10)
            {
                timeMin = "0" + timeMin;
            }

            if (Convert.ToInt32(timeSec) < 10)
            {
                timeSec = "0" + timeSec;
            }

            roundsLabel.Text = "Time: " + timeMin + ":" + timeSec;
            roundsLabel.Show();

            customMoveListDown.Hide();
            customMoveListUp.Hide();

            id1Label.Hide(); id2Label.Hide(); id3Label.Hide(); id4Label.Hide(); id5Label.Hide(); id6Label.Hide();

            typeLabel1.Hide(); typeLabel2.Hide(); typeLabel3.Hide(); typeLabel4.Hide(); typeLabel5.Hide(); typeLabel6.Hide();

            time1Label.Hide(); time2Label.Hide(); time3Label.Hide(); time4Label.Hide(); time5Label.Hide(); time6Label.Hide();
        }

        // Loads the default items for a custom sprint run
        private void LoadDefault()
        {
            FirstCountdown = true;
            TotalSeconds = 5;
            CanPressKey = false;
            Exercise = true;
            IsRest = true;
            MaxSeconds = 0;
            RoundNumber = 0;
            Counter = 1;
            WorkNumber = 0;
            scores = new List<int>();
            IterationNumber = 1;
            IsResultListing = false;

            customNewLabel.Hide();
            customRunPicBox.Show();
            customRunLabel.Show();
            roundsLabel.Text = "Rounds: " + Settings.Lines[Settings.Lines.Count - 4];
            roundCounterTextLabel.Hide();
            roundCountLabel.Hide();
            customCountLabel.Hide();
            customRestTextLabel.Hide();
            customRestTimeLabel.Hide();
            customTimeLabel.Hide();
            customRunLabel.Text = Settings.Lines[Settings.Lines.Count - 1];

            if (Settings.LineCounter < 6)
            {
                customMoveListDown.Hide();
                customMoveListUp.Hide();
            }

            id1Label.Hide(); id2Label.Hide(); id3Label.Hide(); id4Label.Hide(); id5Label.Hide(); id6Label.Hide();

            typeLabel1.Hide(); typeLabel2.Hide(); typeLabel3.Hide(); typeLabel4.Hide(); typeLabel5.Hide(); typeLabel6.Hide();

            time1Label.Hide(); time2Label.Hide(); time3Label.Hide(); time4Label.Hide(); time5Label.Hide(); time6Label.Hide();

            if (Settings.Lines.Count > 3)
            {
                LoadList();
            }
        }

        // Loads the list items
        private void LoadList()
        {
            int MaxNum;

            if (Settings.LineCounter > 6)
            {
                MaxNum = 6;
            }
            else
            {
                MaxNum = Settings.LineCounter;
            }

            int ListCounter = 0;

            for (int i = 0; i < MaxNum; i++)
            {
                string name = "id" + (i + 1) + "Label";
                Label lb = (Label)this.Controls[name];
                lb.Text = Settings.Lines[ListCounter];
                lb.Show();
                ListCounter++;

                name = "typeLabel" + (i + 1);
                lb = (Label)this.Controls[name];
                lb.Text = Settings.Lines[ListCounter];
                ListCounter++;

                if (lb.Text == "work")
                {
                    lb.ForeColor = Color.White;
                }
                else
                {
                    lb.ForeColor = Color.Red;
                }

                lb.Show();

                name = "time" + (i + 1) + "Label";
                lb = (Label)this.Controls[name];
                lb.Text = Settings.Lines[ListCounter];
                ListCounter++;
                lb.Show();
            }
        }

        #endregion

        #region "Click methods"

        // Starts the run
        private void customRunPicBox_Click(object sender, EventArgs e)
        {
            if (Settings.Lines.Count > 4)
            {
                LoadList();

                closeLabel.Hide();
                roundCounterTextLabel.Show();
                roundCountLabel.Text = "1/" + Settings.Lines[Settings.Lines.Count - 4];
                roundCountLabel.Show();
                customRunPicBox.Hide();
                customTimeLabel.ForeColor = Color.Yellow;
                customTimeLabel.Text = "00:05";
                customTimeLabel.Show();

                WorkNumber = 0;

                for (int i = 0; i < Settings.Lines.Count; i++)
                {
                    if (Settings.Lines[i] == "work")
                    {
                        WorkNumber++;
                    }
                }

                timer1.Start();
            }
            else
            {
                customRunPicBox.Hide();
                customCountLabel.Text = "0";

                customTimeLabel.Show();
                customTimeLabel.Text = "00:05";
                customTimeLabel.ForeColor = Color.Gold;

                timer1.Start();
            }
        }

        // Closes the form return to the custom creater form
        private void closeLabel_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Settings.LineCounter = 0;
            Settings.Lines.Clear();
            CustomForm cf = new CustomForm();
            cf.Show();
            this.Hide();
        }

        // Reads keyboard key presses
        private void CustomRunForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (CanPressKey)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        customCountLabel.Text = Convert.ToString(Convert.ToInt32(customCountLabel.Text) + 1);

                        if (Convert.ToInt32(customCountLabel.Text) >= 100 && Convert.ToInt32(customCountLabel.Text) - 1 < 100)
                        {
                            Point p = new Point(customCountLabel.Location.X - 70, customCountLabel.Location.Y);
                            customCountLabel.Location = p;
                        }
                        else if (Convert.ToInt32(customCountLabel.Text) >= 10 && Convert.ToInt32(customCountLabel.Text) - 1 < 10)
                        {
                            defPoint = new Point(customCountLabel.Location.X, customCountLabel.Location.Y);
                            Point p = new Point(customCountLabel.Location.X - 70, customCountLabel.Location.Y);
                            customCountLabel.Location = p;
                        }

                        break;

                    case Keys.Space:
                        customCountLabel.Text = Convert.ToString(Convert.ToInt32(customCountLabel.Text) + 1);

                        if (Convert.ToInt32(customCountLabel.Text) >= 100 && Convert.ToInt32(customCountLabel.Text) - 1 < 100)
                        {
                            Point p = new Point(customCountLabel.Location.X - 70, customCountLabel.Location.Y);
                            customCountLabel.Location = p;
                        }
                        else if (Convert.ToInt32(customCountLabel.Text) >= 10 && Convert.ToInt32(customCountLabel.Text) - 1 < 10)
                        {
                            defPoint = new Point(customCountLabel.Location.X, customCountLabel.Location.Y);
                            Point p = new Point(customCountLabel.Location.X - 70, customCountLabel.Location.Y);
                            customCountLabel.Location = p;
                        }

                        break;

                    case Keys.Down:
                        if (customCountLabel.Text != "0")
                        {
                            customCountLabel.Text = Convert.ToString(Convert.ToInt32(customCountLabel.Text) - 1);
                        }

                        if (Convert.ToInt32(customCountLabel.Text) < 10 && Convert.ToInt32(customCountLabel.Text) + 1 >= 10)
                        {
                            Point p = new Point(customCountLabel.Location.X + 70, customCountLabel.Location.Y);
                            customCountLabel.Location = p;
                        }
                        else if (Convert.ToInt32(customCountLabel.Text) < 100 && Convert.ToInt32(customCountLabel.Text) + 1 >= 100)
                        {
                            Point p = new Point(customCountLabel.Location.X + 70, customCountLabel.Location.Y);
                            customCountLabel.Location = p;
                        }

                        break;
                }
            }
        }

        // Moves the list up by one
        private void customMoveListUp_Click(object sender, EventArgs e)
        {
            switch (IsResultListing)
            {
                case true:
                    if (scores.Count > 6)
                    {
                        Label lb = (Label)this.Controls["id1Label"];
                        if (Convert.ToInt32(lb.Text) != 1)
                        {
                            MoveList(1);
                        }
                    }
                    break;

                case false:
                    if (Settings.Lines.Count > 6)
                    {
                        Label lb = (Label)this.Controls["id1Label"];
                        if (Convert.ToInt32(lb.Text) != 1)
                        {
                            MoveList(1);
                        }
                    }
                    break;
            }
        }

        // Moves the list down by one
        private void customMoveListDown_Click(object sender, EventArgs e)
        {
            switch (IsResultListing)
            {
                case true:
                    if (scores.Count > 6)
                    {
                        Label lb = (Label)this.Controls["id6Label"];
                        if (Convert.ToInt32(lb.Text) < scores.Count)
                        {
                            MoveList(6);
                        }
                    }
                    break;

                case false:
                    if (Settings.LineCounter > 6)
                    {
                        Label lb = (Label)this.Controls["id6Label"];
                        if (Convert.ToInt32(lb.Text) < Settings.LineCounter)
                        {
                            MoveList(6);
                        }
                    }
                    break;
            }
        }

        // New run with the same seetings
        private void customNewLabel_Click(object sender, EventArgs e)
        {
            if (Settings.Lines.Count > 4)
            {
                id1Label.ForeColor = Color.White;
                typeLabel1.ForeColor = Color.White;
                time1Label.ForeColor = Color.White;

                id2Label.ForeColor = Color.White;
                typeLabel2.ForeColor = Color.White;
                time2Label.ForeColor = Color.White;

                id3Label.ForeColor = Color.White;
                typeLabel3.ForeColor = Color.White;
                time3Label.ForeColor = Color.White;

                id4Label.ForeColor = Color.White;
                typeLabel4.ForeColor = Color.White;
                time4Label.ForeColor = Color.White;

                id5Label.ForeColor = Color.White;
                typeLabel5.ForeColor = Color.White;
                time5Label.ForeColor = Color.White;

                id6Label.ForeColor = Color.White;
                typeLabel6.ForeColor = Color.White;
                time6Label.ForeColor = Color.White;

                LoadDefault();
            }
            else
            {
                LoadDefaultSprint();
            }
        }

        #endregion

        #region "Phase start, end functions"

        // Starts the custom sprint run
        private void StartCustomSprint()
        {
            customTimeLabel.ForeColor = Color.White;
            customCountLabel.Show();
            CanPressKey = true;

            if (!Settings.StopWatch)
            {
                TotalSeconds = (Convert.ToInt32(Settings.Lines[Settings.Lines.Count - 3]) * 60) + (Convert.ToInt32(Settings.Lines[Settings.Lines.Count - 2]));

                string timeMin = Settings.Lines[Settings.Lines.Count - 3];
                string timeSec = Settings.Lines[Settings.Lines.Count - 2];

                if (Convert.ToInt32(timeMin) < 10)
                {
                    timeMin = "0" + timeMin;
                }

                if (Convert.ToInt32(timeSec) < 10)
                {
                    timeSec = "0" + timeSec;
                }

                customTimeLabel.Text = timeMin + ":" + timeSec;
            }
            else
            {
                TotalSeconds = 0;
                MaxSeconds = (Convert.ToInt32(Settings.Lines[Settings.Lines.Count - 3]) * 60) + (Convert.ToInt32(Settings.Lines[Settings.Lines.Count - 2]));
                customTimeLabel.Text = "00:00";
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

            timer1.Start();
        }

        // Rest ending changes
        private void EndRest()
        {
            RoundNumber++;
            customRestTextLabel.Hide();
            customRestTimeLabel.Hide();
            timer1.Stop();
            IsRest = false;
        }

        // Starts the exercise phase
        private void StartExercise()
        {
            if (!IsRest)
            {
                scores.Add(Convert.ToInt32(customCountLabel.Text));
            }

            EndRest();

            customTimeLabel.Text = "00:00";
            customTimeLabel.Show();
            customCountLabel.Show();
            customCountLabel.Text = "0";
            customTimeLabel.ForeColor = Color.White;
            CanPressKey = true;

            string[] times = Settings.Lines[(Counter * 3) - 1].Split(":");

            if (!Settings.StopWatch)
            {
                TotalSeconds = (Convert.ToInt32(times[0]) * 60) + Convert.ToInt32(times[1]);

                if (Convert.ToInt32(times[0]) < 10)
                {
                    times[0] = "0" + times[0];
                }

                if (Convert.ToInt32(times[1]) < 10)
                {
                    times[1] = "0" + times[1];
                }

                customTimeLabel.Text = times[0] + ":" + times[1];
            }
            else
            {
                TotalSeconds = 0;
                MaxSeconds = (Convert.ToInt32(times[0]) * 60) + Convert.ToInt32(times[1]);
                customTimeLabel.Text = "00:00";
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

            ChangeColor();

            customCountLabel.Location = defPoint;

            timer1.Start();
        }

        // Ends the exercise phase, prepears for the next
        private void ExerciseEnd()
        {
            if (!IsRest)
            {
                scores.Add(Convert.ToInt32(customCountLabel.Text));
            }
            customCountLabel.Location = defPoint;
            CanPressKey = false;
            RoundNumber++;
            customCountLabel.Hide();
            customCountLabel.Text = "0";
            customTimeLabel.Hide();
            customCountLabel.Location = defPoint;
        }

        private void FinishExercise()
        {
            CanPressKey = false;
            customTimeLabel.Hide();
            customCountLabel.Hide();

            closeLabel.Show();

            if (Settings.Lines.Count <= 4)
            {
                roundsLabel.Text = "Final score: " + customCountLabel.Text;
                customNewLabel.Show();

                customNewLabel.Show();
            }
        }

        // Starts the rest phase
        private void StartRest()
        {
            ExerciseEnd();

            if (RoundNumber > Settings.LineCounter * Convert.ToInt32(Settings.Lines[Settings.Lines.Count - 4]))
            {
                FinishExercise();
            }
            else
            {
                Exercise = false;
                IsRest = true;
                customRestTextLabel.Show();
                customRestTimeLabel.Show();

                string[] restTime = Settings.Lines[(Counter * 3) - 1].Split(":");

                if (!Settings.StopWatch)
                {
                    if (Convert.ToInt32(restTime[0]) < 10)
                    {
                        restTime[0] = "0" + restTime[0];
                    }

                    if (Convert.ToInt32(restTime[1]) < 10)
                    {
                        restTime[1] = "0" + restTime[1];
                    }

                    TotalSeconds = (Convert.ToInt32(restTime[0]) * 60) + Convert.ToInt32(restTime[1]);
                    customRestTimeLabel.Text = restTime[0] + ":" + restTime[1];
                }
                else
                {
                    TotalSeconds = 0;
                    MaxSeconds = (Convert.ToInt32(restTime[0]) * 60) + Convert.ToInt32(restTime[1]);
                    customRestTimeLabel.Text = "00:00";
                }

                ChangeColor();

                customCountLabel.Location = defPoint;

                timer1.Start();
            }
        }

        // First phase start (need it so there will be no useless data store)
        private void FirstStart(bool IsWork)
        {
            if (IsWork)
            {
                EndRest();

                customTimeLabel.Text = "00:00";
                customTimeLabel.Show();
                customCountLabel.Show();
                customCountLabel.Text = "0";
                customTimeLabel.ForeColor = Color.White;
                CanPressKey = true;
                IsRest = false;

                string[] times = Settings.Lines[(Counter * 3) - 1].Split(":");

                if (!Settings.StopWatch)
                {
                    if (Convert.ToInt32(times[0]) < 10)
                    {
                        times[0] = "0" + times[0];
                    }

                    if (Convert.ToInt32(times[1]) < 10)
                    {
                        times[1] = "0" + times[1];
                    }

                    TotalSeconds = (Convert.ToInt32(times[0]) * 60) + Convert.ToInt32(times[1]);
                    customTimeLabel.Text = times[0] + ":" + times[1];
                }
                else
                {
                    TotalSeconds = 0;
                    MaxSeconds = (Convert.ToInt32(times[0]) * 60) + Convert.ToInt32(times[1]);
                    customTimeLabel.Text = "00:00";
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

                ChangeColor();

                timer1.Start();
            }
            else
            {
                CanPressKey = false;
                RoundNumber++;
                customCountLabel.Hide();
                customCountLabel.Text = "0";
                customTimeLabel.Hide();

                if (RoundNumber > Settings.LineCounter * Convert.ToInt32(Settings.Lines[Settings.Lines.Count - 4]))
                {
                    FinishExercise();
                }
                else
                {
                    Exercise = false;
                    IsRest = true;
                    customRestTextLabel.Show();
                    customRestTimeLabel.Show();

                    string[] restTime = Settings.Lines[(Counter * 3) - 1].Split(":");

                    if (!Settings.StopWatch)
                    {
                        if (Convert.ToInt32(restTime[0]) < 10)
                        {
                            restTime[0] = "0" + restTime[0];
                        }

                        if (Convert.ToInt32(restTime[1]) < 10)
                        {
                            restTime[1] = "0" + restTime[1];
                        }

                        TotalSeconds = (Convert.ToInt32(restTime[0]) * 60) + Convert.ToInt32(restTime[1]);
                        customRestTimeLabel.Text = restTime[0] + ":" + restTime[1];
                    }
                    else
                    {
                        TotalSeconds = 0;
                        MaxSeconds = (Convert.ToInt32(restTime[0]) * 60) + Convert.ToInt32(restTime[1]);
                        customRestTimeLabel.Text = "00:00";
                    }

                    ChangeColor();

                    timer1.Start();
                }
            }
        }

        // Finishes the current round
        private void FinishCurrent()
        {
            IsResultListing = true;
            CanPressKey = false;

            if (!IsRest)
            {
                scores.Add(Convert.ToInt32(customCountLabel.Text));
            }

            customNewLabel.Show();
            customCountLabel.Hide();
            customRestTextLabel.Hide();
            customTimeLabel.Hide();
            customRestTimeLabel.Hide();
            roundCounterTextLabel.Hide();
            roundCountLabel.Hide();

            for (int i = 1; i < 7; i++)
            {
                string name = "id" + i + "Label";
                Label lb = (Label)this.Controls[name];
                lb.Hide();

                name = "typeLabel" + i;
                lb = (Label)this.Controls[name];
                lb.Hide();

                name = "time" + i + "Label";
                lb = (Label)this.Controls[name];
                lb.Hide();
            }

            roundsLabel.Text = "Final results: ";
            roundsLabel.Show();

            int MaxNum;

            if (scores.Count > 6)
            {
                MaxNum = 6;
            }
            else
            {
                MaxNum = scores.Count;
            }

            for (int i = 0; i < MaxNum; i++)
            {
                string name = "id" + (i + 1) + "Label";
                Label lb = (Label)this.Controls[name];
                lb.Text = (i + 1).ToString();
                lb.Hide();

                name = "typeLabel" + (i + 1);
                lb = (Label)this.Controls[name];
                lb.Text = (i + 1).ToString() + ":";
                lb.ForeColor = Color.White;
                lb.Show();

                name = "time" + (i + 1) + "Label";
                lb = (Label)this.Controls[name];
                lb.Text = scores[i].ToString();
                lb.ForeColor = Color.White;
                lb.Show();
            }

            if (scores.Count <= 6)
            {
                customMoveListDown.Hide();
                customMoveListUp.Hide();
            }

            closeLabel.Show();
        }

        #endregion

        #region "Timer method"

        // Updates the clock, changes the phases
        private void timer1_Tick(object sender, EventArgs e)
        {
            int secs;
            int mins;
            string secsString;

            switch (FirstCountdown)
            {
                // First five second warmup time
                case true:
                    if (Settings.Lines.Count > 4)
                    {
                        customTimeLabel.Show();
                        if (TotalSeconds > 0)
                        {
                            TotalSeconds = TotalSeconds - 1;
                            if (Exercise)
                            {
                                customTimeLabel.Text = "00:0" + TotalSeconds.ToString();
                            }
                            else
                            {
                                customRestTimeLabel.Text = TotalSeconds.ToString();
                            }
                        }

                        if (TotalSeconds == 0)
                        {
                            FirstCountdown = false;


                            if (Settings.Lines.Count > 4)
                            {
                                string decideNext = Settings.Lines[(Counter * 3) - 2];

                                if (decideNext == "work")
                                {
                                    FirstStart(true);
                                }
                                else
                                {
                                    FirstStart(false);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (TotalSeconds > 0)
                        {
                            TotalSeconds = TotalSeconds - 1;

                            customTimeLabel.Text = "00:0" + TotalSeconds.ToString();
                        }

                        if (TotalSeconds == 0)
                        {
                            FirstCountdown = false;
                            timer1.Stop();
                            StartCustomSprint();
                        }
                    }
                    break;

                case false:
                    switch (Settings.StopWatch)
                    {
                        // Stopwatch
                        case true:
                            if (Settings.Lines.Count > 4)
                            {
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

                                    switch (IsRest)
                                    {
                                        case true:
                                            customRestTimeLabel.Text = minsString + ":" + secsString;
                                            break;

                                        case false:
                                            customTimeLabel.Text = minsString + ":" + secsString;
                                            break;
                                    }
                                }
                                else
                                {
                                    timer1.Stop();

                                    Counter++;
                                    if (Settings.Lines[(Counter * 3) - 2] == "work")
                                    {
                                        StartExercise();
                                    }
                                    else if (Settings.Lines[(Counter * 3) - 2] == "rest")
                                    {
                                        StartRest();
                                    }
                                    else if (IterationNumber + 1 <= Convert.ToInt32(Settings.Lines[Settings.Lines.Count - 4]))
                                    {
                                        LoadList();

                                        IterationNumber++;

                                        Counter = 1;
                                        CanPressKey = false;

                                        roundCountLabel.Text = IterationNumber + "/" + Settings.Lines[Settings.Lines.Count - 4];

                                        if (Settings.Lines[(Counter * 3) - 2] == "work")
                                        {
                                            StartExercise();
                                        }
                                        else
                                        {
                                            StartRest();
                                        }
                                    }
                                    else
                                    {
                                        FinishCurrent();
                                    }
                                }
                            }
                            else
                            {
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

                                    customTimeLabel.Text = mins.ToString() + ":" + secsString;
                                }
                                else
                                {
                                    timer1.Stop();
                                    FinishExercise();
                                }
                            }

                            break;
                        // Countdown
                        case false:
                            if (Settings.Lines.Count > 4)
                            {
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

                                    switch (IsRest)
                                    {
                                        case true:
                                            customRestTimeLabel.Text = minsString + ":" + secsString;
                                            break;

                                        case false:
                                            customTimeLabel.Text = minsString + ":" + secsString;
                                            break;
                                    }
                                }
                                else
                                {
                                    timer1.Stop();

                                    Counter++;

                                    ChangeColor();

                                    if (Settings.Lines[(Counter * 3) - 2] == "work")
                                    {
                                        StartExercise();
                                    }
                                    else if (Settings.Lines[(Counter * 3) - 2] == "rest")
                                    {
                                        StartRest();
                                    }
                                    else if (IterationNumber + 1 <= Convert.ToInt32(Settings.Lines[Settings.Lines.Count - 4]))
                                    {
                                        LoadList();

                                        IterationNumber++;
                                        ChangeColor();
                                        Counter = 1;
                                        CanPressKey = false;

                                        roundCountLabel.Text = IterationNumber + "/" + Settings.Lines[Settings.Lines.Count - 4];

                                        if (Settings.Lines[(Counter * 3) - 2] == "work")
                                        {
                                            StartExercise();
                                        }
                                        else
                                        {
                                            StartRest();
                                        }
                                    }
                                    else
                                    {
                                        FinishCurrent();
                                    }
                                }
                            }
                            else
                            {
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

                                    customTimeLabel.Text = minsString + ":" + secsString;
                                }
                                else
                                {
                                    timer1.Stop();
                                    FinishExercise();
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        #endregion

        #region "Other methods"

        // When the form closes it will open the custom form creater form
        private void CustomRunForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Lines.Clear();

            CustomForm cf = new CustomForm();
            cf.Show();

            this.Hide();
        }

        // Plays the whistle sound
        private void PlaySound()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer("whistle.wav");
                simpleSound.Play();
            }
            catch
            {

            }
        }

        // Changes the line colors to follow the current line
        private void ChangeColor()
        {
            switch (Counter)
            {
                case 1:
                    id6Label.ForeColor = Color.White;

                    if (typeLabel6.Text == "work")
                    {
                        typeLabel6.ForeColor = Color.White;
                    }
                    else
                    {
                        typeLabel6.ForeColor = Color.Red;
                    }

                    time6Label.ForeColor = Color.White;



                    id1Label.ForeColor = Color.Gold;
                    typeLabel1.ForeColor = Color.Gold;
                    time1Label.ForeColor = Color.Gold;
                    break;

                case 2:
                    id1Label.ForeColor = Color.White;

                    if (typeLabel1.Text == "work")
                    {
                        typeLabel1.ForeColor = Color.White;
                    }
                    else
                    {
                        typeLabel1.ForeColor = Color.Red;
                    }

                    time1Label.ForeColor = Color.White;

                    id2Label.ForeColor = Color.Gold;
                    typeLabel2.ForeColor = Color.Gold;
                    time2Label.ForeColor = Color.Gold;
                    break;

                case 3:
                    id2Label.ForeColor = Color.White;

                    if (typeLabel2.Text == "work")
                    {
                        typeLabel2.ForeColor = Color.White;
                    }
                    else
                    {
                        typeLabel2.ForeColor = Color.Red;
                    }

                    time2Label.ForeColor = Color.White;

                    id3Label.ForeColor = Color.Gold;
                    typeLabel3.ForeColor = Color.Gold;
                    time3Label.ForeColor = Color.Gold;
                    break;

                case 4:
                    id3Label.ForeColor = Color.White;

                    if (typeLabel3.Text == "work")
                    {
                        typeLabel3.ForeColor = Color.White;
                    }
                    else
                    {
                        typeLabel3.ForeColor = Color.Red;
                    }

                    time3Label.ForeColor = Color.White;

                    id4Label.ForeColor = Color.Gold;
                    typeLabel4.ForeColor = Color.Gold;
                    time4Label.ForeColor = Color.Gold;
                    break;

                case 5:
                    id4Label.ForeColor = Color.White;

                    if (typeLabel4.Text == "work")
                    {
                        typeLabel4.ForeColor = Color.White;
                    }
                    else
                    {
                        typeLabel4.ForeColor = Color.Red;
                    }

                    time4Label.ForeColor = Color.White;

                    id5Label.ForeColor = Color.Gold;
                    typeLabel5.ForeColor = Color.Gold;
                    time5Label.ForeColor = Color.Gold;
                    break;

                case 6:
                    id5Label.ForeColor = Color.White;

                    if (typeLabel5.Text == "work")
                    {
                        typeLabel5.ForeColor = Color.White;
                    }
                    else
                    {
                        typeLabel5.ForeColor = Color.Red;
                    }

                    time5Label.ForeColor = Color.White;

                    id6Label.ForeColor = Color.Gold;
                    typeLabel6.ForeColor = Color.Gold;
                    time6Label.ForeColor = Color.Gold;
                    break;

                default:
                    if (Settings.LineCounter > 6)
                    {
                        if (Convert.ToInt32(id6Label.Text) < Settings.LineCounter)
                        {
                            MoveList(6);

                            id5Label.ForeColor = Color.White;

                            if (typeLabel5.Text == "work")
                            {
                                typeLabel5.ForeColor = Color.White;
                            }
                            else
                            {
                                typeLabel5.ForeColor = Color.Red;
                            }

                            time5Label.ForeColor = Color.White;

                            id6Label.ForeColor = Color.Gold;
                            typeLabel6.ForeColor = Color.Gold;
                            time6Label.ForeColor = Color.Gold;
                        }
                    }
                    break;
            }
        }

        // Moves the list items
        private void MoveList(int ListID)
        {
            string name = "id" + ListID + "Label";
            Label lb = (Label)this.Controls[name];
            if (Settings.LineCounter >= 7)
            {
                if (ListID == 1)
                {
                    for (int i = 5; i > 0; i--)
                    {
                        name = "id" + i + "Label";
                        lb = (Label)this.Controls[name];
                        name = "id" + (i + 1) + "Label";
                        Label lb2 = (Label)this.Controls[name];
                        lb2.Text = lb.Text;

                        name = "typeLabel" + i;
                        lb = (Label)this.Controls[name];
                        name = "typeLabel" + (i + 1);
                        lb2 = (Label)this.Controls[name];
                        lb2.Text = lb.Text;
                        lb2.ForeColor = lb.ForeColor;

                        name = "time" + i + "Label";
                        lb = (Label)this.Controls[name];
                        name = "time" + (i + 1) + "Label";
                        lb2 = (Label)this.Controls[name];
                        lb2.Text = lb.Text;
                    }
                }
                else
                {
                    for (int i = 1; i < 6; i++)
                    {
                        name = "id" + i + "Label";
                        lb = (Label)this.Controls[name];
                        name = "id" + (i + 1) + "Label";
                        Label lb2 = (Label)this.Controls[name];
                        lb.Text = lb2.Text;

                        name = "typeLabel" + i;
                        lb = (Label)this.Controls[name];
                        name = "typeLabel" + (i + 1);
                        lb2 = (Label)this.Controls[name];
                        lb.Text = lb2.Text;
                        lb.ForeColor = lb2.ForeColor;

                        name = "time" + i + "Label";
                        lb = (Label)this.Controls[name];
                        name = "time" + (i + 1) + "Label";
                        lb2 = (Label)this.Controls[name];
                        lb.Text = lb2.Text;
                    }
                }

                switch (IsResultListing)
                {
                    case true:
                        name = "id" + ListID + "Label";
                        lb = (Label)this.Controls[name];

                        int ListIndex;

                        if (ListID == 1)
                        {
                            ListIndex = Convert.ToInt32(lb.Text) - 1;

                            lb.Text = ListIndex.ToString();

                            name = "typeLabel" + ListID;
                            lb = (Label)this.Controls[name];
                            lb.Text = ListIndex.ToString() + ":";
                            lb.ForeColor = Color.White;

                            name = "time" + ListID + "Label";
                            lb = (Label)this.Controls[name];
                            lb.Text = scores[ListIndex - 1].ToString();
                        }
                        else
                        {
                            ListIndex = Convert.ToInt32(lb.Text);

                            lb.Text = (ListIndex + 1).ToString();

                            name = "typeLabel" + ListID;
                            lb = (Label)this.Controls[name];
                            lb.Text = (ListIndex + 1).ToString() + ":";
                            lb.ForeColor = Color.White;

                            name = "time" + ListID + "Label";
                            lb = (Label)this.Controls[name];
                            lb.Text = scores[ListIndex].ToString();
                        }

                        break;

                    case false:
                        name = "id" + ListID + "Label";
                        lb = (Label)this.Controls[name];

                        if (ListID == 1)
                        {
                            ListIndex = (Convert.ToInt32(lb.Text) - 2) * 3;
                        }
                        else
                        {
                            ListIndex = ((Convert.ToInt32(lb.Text) - 1) * 3) + 3;
                        }

                        lb.Text = Settings.Lines[ListIndex];

                        name = "typeLabel" + ListID;
                        lb = (Label)this.Controls[name];
                        lb.Text = Settings.Lines[ListIndex + 1];

                        if (lb.Text == "work")
                        {
                            lb.ForeColor = Color.White;
                        }
                        else
                        {
                            lb.ForeColor = Color.Red;
                        }

                        name = "time" + ListID + "Label";
                        lb = (Label)this.Controls[name];
                        lb.Text = Settings.Lines[ListIndex + 2];
                        break;
                }
            }
        }

        #endregion
    }
}
