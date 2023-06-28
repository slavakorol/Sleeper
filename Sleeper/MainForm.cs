using System.Diagnostics;

namespace Sleeper
{
    public partial class MainForm : Form
    {
        private int _initialMinutes;    // начальный наймер
        private int _remainingSeconds;  // оставшееся количество минут
        private bool _isRunning;        // запущен ли таймер

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
                        MessageBox.Show($"Таймер был запущен извне на {_initialMinutes} минут");
                    }
                    else
                        MessageBox.Show($"Попытка запустить наймер с некорректным параметром {System.Environment.GetCommandLineArgs()[i + 1]}");
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
                    throw new ArgumentException("Таймер не может быть отрицательным");

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
            Debug.WriteLine($"{textTime} Таймер остановлен!");
        }

        private void StartTimer()
        {
            timer1.Enabled = true;
            timer1.Start();

            var textTime = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}";
            Debug.WriteLine($"{textTime} Таймер запущен!");
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
            Debug.WriteLine($"{textTime}: Тик! {_remainingSeconds} с. осталось!");
        }
    }
}