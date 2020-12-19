using System;

namespace Stopwatch
{

    // This class is great. Love it! Beers all around :)
    //
    // (future) Check out the built-in Stopwatch class for feature ideas:
    // https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?view=net-5.0

    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        // This probably doesn't need to be a `public`, but if you want it to be accessible outside of this
        // class, I suggest making it a property instead of field. It will make more sense for future you, with
        // binding stuff to UIs, etc. Promise.
        // public bool IsRunning { get; set; }
        public bool _isRunning;

        public void Start()
        {
            // I'm a fan of ALWAYS using braces, even for simple stuff:
            // if (<condition>) {
            //    <stuff>
            // }
            // <clearly not stuff>

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

        // (future) Look into overriding ToString()
    }
}
