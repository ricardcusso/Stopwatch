using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        public bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch already running!");

            _isRunning = true;
            _startTime = DateTime.Now;
            
        }

        public void Stop()
        {
            if(!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running!");

            _stopTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan CalculateTime()
        {
            return _stopTime - _startTime;
        }
    }
}
