using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleeper
{
    internal class Sleeper
    {
        private int minutes;

        /// <summary>
        /// Создает слипер с таймером по умолчанию
        /// </summary>
        public Sleeper() : this(30)
        {

        }

        /// <summary>
        /// Создает слипер с таймером на введённое время
        /// </summary>
        /// <param name="minutes">Количество минут, через которое выключится компьютер</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Sleeper(int minutes)
        {
            if (minutes < 0)
                throw new ArgumentOutOfRangeException("The time to turn off connot be negative");

            this.minutes = minutes;

            Shutdown(minutes);
        }

        /// <summary>
        /// Процесс выключения устройства
        /// </summary>
        private void Shutdown(int seconds)
        {
            var minutes = seconds * 60;

            var arguments = new List<string>() { "/s", "/t", minutes.ToString()};

            var psi = new ProcessStartInfo($"shutdown", string.Join(' ', arguments))
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        private void StopShutdown()
        {
            var psi = new ProcessStartInfo($"shutdown", "/a")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
        }
    }
}
