using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        public DateTime _startTime;
        public DateTime _stopTime;
        public bool isRunning = false;

        public void Start()
        {
            if (!isRunning)
            {
                isRunning = true;
                _startTime = DateTime.Now;
            }
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
            isRunning = false;

        }

        public TimeSpan CalculateTime()
        {
            var duration = _stopTime - _startTime;
            return duration;
        }

    }
}
