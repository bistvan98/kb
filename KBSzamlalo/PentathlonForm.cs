using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBSzamlalo
{
    public partial class PentathlonForm : Form
    {
        private Stopwatch stopWatch;
        int seconds;
        public PentathlonForm()
        {
            InitializeComponent();

            pentathlonCloseButton.Hide();
            pentathlonNewButton.Hide();
            cleanAndPressLabel.Hide();
            cleanResultLabel.Hide();
            jerkResultLabel.Hide();
            halfSnatchResultLabel.Hide();
            pushPressResultLabel.Hide();
            exerciseLabel.Hide();
            restLabel.Hide();
            restTimeLabel.Hide();
            timeLabel.Hide();

            stopWatch = new Stopwatch();
        }

        private void pentathlonLabel_Click(object sender, EventArgs e)
        {

        }

        private void pentathlonStartButton_Click(object sender, EventArgs e)
        {
            pentathlonStartButton.Hide();

            countLabel.Show();

            timeLabel.ForeColor = Color.Yellow;
            timeLabel.Show();

            timer1.Start();

            bool timerEnd = false;

            while (!timerEnd)
            {
                if (seconds < 0)
                {
                    timerEnd = true;
                }
            }

            timeLabel.Text = "jo";
        }

        private void pentathlonStartButoon_Click(object sender, EventArgs e)
        {
            pentathlonStartButoon.Hide();
            timeLabel.ForeColor = Color.Yellow;
            timeLabel.Text = "5";
            timeLabel.Show();
            seconds = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer1.Stop();
                seconds = 0;
                StartExec();
            }
        }

        private void StartExec()
        {
            for (int i = 0; i < 5; i++)
            {
                timeLabel.ForeColor = Color.White;
                timer1.Enabled = false;
                timer2.Enabled = true;
                stopWatch.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = stopWatch.Elapsed.ToString(@"mm\:ss");
            seconds++;
            if (seconds == 5)
            {
                timer2.Enabled = false;
                stopWatch.Stop();
                stopWatch.Reset();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 1);
            }
        }
    }
}
