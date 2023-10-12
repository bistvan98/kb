using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBSzamlalo
{
    public partial class SettingsForm : Form
    {
        bool defSoundSettings = Settings.SoundOn;
        bool defTimingSettings = Settings.StopWatch;

        public SettingsForm()
        {
            InitializeComponent();

            if (Settings.SoundOn)
            {
                pictureBox1.Image = KBSzamlalo.Properties.Resources.onSwitch;
            }
            else
            {
                pictureBox1.Image = KBSzamlalo.Properties.Resources.offSwitch;
            }

            if (Settings.StopWatch)
            {
                timingPictureBox.Image = KBSzamlalo.Properties.Resources.onSwitch;
            }
            else
            {
                timingPictureBox.Image = KBSzamlalo.Properties.Resources.offSwitch;
            }
        }

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

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

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
