namespace KBSzamlalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pentathlonButton_Click(object sender, EventArgs e)
        {
            new PentathlonForm().Show();
            this.Hide();
        }
    }
}