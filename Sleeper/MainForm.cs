using System.Diagnostics;

namespace Sleeper
{
    public partial class MainForm : Form
    {
        private int _initialMinutes;    // ��������� ������
        private int _remainingSeconds;  // ���������� ���������� �����
        private bool _isRunning;        // ������� �� ������

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < System.Environment.GetCommandLineArgs().Length; i++)
            {
                if (System.Environment.GetCommandLineArgs()[i] == "-t")
                {
                    var isPars = Int32.TryParse(System.Environment.GetCommandLineArgs()[i + 1], out _initialMinutes);

                    if (isPars)
                    {
                        timerUpDown.Value = _initialMinutes;
                        Shutdown();
                        MessageBox.Show($"������ ��� ������� ����� �� {_initialMinutes} �����");
                    }
                    else
                        MessageBox.Show($"������� ��������� ������ � ������������ ���������� {System.Environment.GetCommandLineArgs()[i + 1]}");
                }
            }
        }

        private void SleepButton_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void Shutdown()
        {
            _remainingSeconds = (int)timerUpDown.Value * 60;
            if (_isRunning)
            {
                StopTimer();
                _isRunning = false;
                SleepButton.Text = "SLEEP";
            }
            else
            {
                _initialMinutes = (int)timerUpDown.Value;
                if (_initialMinutes < 0)
                    throw new ArgumentException("������ �� ����� ���� �������������");

                StartTimer();
                _isRunning = true;
                SleepButton.Text = "STOP";
            }
        }

        private void StopTimer()
        {
            timer1.Stop();
            timer1.Enabled = false;
            
            var textTime = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}";
            Debug.WriteLine($"{textTime} ������ ����������!");
        }

        private void StartTimer()
        {
            timer1.Enabled = true;
            timer1.Start();

            var textTime = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}";
            Debug.WriteLine($"{textTime} ������ �������!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_remainingSeconds-- < 0)
            {
                var psi = new ProcessStartInfo($"shutdown", "/s /t 0")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process.Start(psi);
            }

            timerUpDown.Value = _remainingSeconds / 60;

            var textTime = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}";
            Debug.WriteLine($"{textTime}: ���! {_remainingSeconds} �. ��������!");
        }
    }
}