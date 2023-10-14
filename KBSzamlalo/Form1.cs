using System.Runtime;

namespace KBSzamlalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Main form closing
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        // Pentathlon form open
        private void pentathlonButton_Click_1(object sender, EventArgs e)
        {
            PentathlonForm pForm = new PentathlonForm(true);
            pForm.Show();
            this.Hide();
        }

        // Half pentathlon form open
        private void halfPentathlonButton_Click_1(object sender, EventArgs e)
        {
            PentathlonForm pForm = new PentathlonForm(false);
            pForm.Show();
            this.Hide();
        }

        // Settings form open (picture click)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SettingsForm pForm = new SettingsForm();
            pForm.Show();
            this.Hide();
        }

        // Pentathlon form open (text click)
        private void settingsLabel_Click(object sender, EventArgs e)
        {
            SettingsForm pForm = new SettingsForm();
            pForm.Show();
            this.Hide();
        }

        // Spint 3' form open
        private void sprint3Button_Click(object sender, EventArgs e)
        {
            SprintForm sForm = new SprintForm(3);
            sForm.Show();
            this.Hide();
        }

        // Spint 5' form open
        private void sprint5Button_Click(object sender, EventArgs e)
        {
            SprintForm sForm = new SprintForm(5);
            sForm.Show();
            this.Hide();
        }

        // Spint 10' form open
        private void sprint10Button_Click(object sender, EventArgs e)
        {
            SprintForm sForm = new SprintForm(10);
            sForm.Show();
            this.Hide();
        }

        // Spint 12' form open
        private void sprint12Button_Click(object sender, EventArgs e)
        {
            SprintForm sForm = new SprintForm(12);
            sForm.Show();
            this.Hide();
        }

        // Spint 30' form open
        private void sprint30Button_Click(object sender, EventArgs e)
        {
            SprintForm sForm = new SprintForm(30);
            sForm.Show();
            this.Hide();
        }

        // Spint 60' form open
        private void sprint60Button_Click(object sender, EventArgs e)
        {
            SprintForm sForm = new SprintForm(60);
            sForm.Show();
            this.Hide();
        }

        // Custom plan form open
        private void customButton_Click(object sender, EventArgs e)
        {
            CustomForm cForm = new CustomForm();
            cForm.Show();
            this.Hide();
        }
    }
}