namespace KBSzamlalo
{
    public partial class SettingsForm : Form
    {
        private bool defSoundSettings = Settings.SoundOn;
        private bool defTimingSettings = Settings.StopWatch;

        public SettingsForm()
        {
            InitializeComponent();

            // Turn on/off the sound
            if (Settings.SoundOn)
            {
                pictureBox1.Image = KBSzamlalo.Properties.Resources.onSwitch;
            }
            else
            {
                pictureBox1.Image = KBSzamlalo.Properties.Resources.offSwitch;
            }

            // Switch between stopwatch and countdown
            if (Settings.StopWatch)
            {
                timingPictureBox.Image = KBSzamlalo.Properties.Resources.onSwitch;
            }
            else
            {
                timingPictureBox.Image = KBSzamlalo.Properties.Resources.offSwitch;
            }
        }

        // Sound switch button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!Settings.SoundOn)
            {
                Settings.SoundOn = true;
                pictureBox1.Image = KBSzamlalo.Properties.Resources.onSwitch;
            }
            else
            {
                Settings.SoundOn = false;
                pictureBox1.Image = KBSzamlalo.Properties.Resources.offSwitch;
            }
        }

        // Timing switch button
        private void timingPictureBox_Click(object sender, EventArgs e)
        {
            if (!Settings.StopWatch)
            {
                Settings.StopWatch = true;
                timingPictureBox.Image = KBSzamlalo.Properties.Resources.onSwitch;
            }
            else
            {
                Settings.StopWatch = false;
                timingPictureBox.Image = KBSzamlalo.Properties.Resources.offSwitch;
            }
        }

        // Closes the form, loads the main form
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        // Shortcut to close the form without saving
        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                Settings.SoundOn = defSoundSettings;
                Settings.StopWatch = defTimingSettings;

                this.Close();
            }
        }
    }
}
