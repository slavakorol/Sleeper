namespace Sleeper
{
    public partial class MainForm : Form
    {
        Sleeper sleeper;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SleepButton_Click(object sender, EventArgs e)
        {
            sleeper = new Sleeper();
        }
    }
}