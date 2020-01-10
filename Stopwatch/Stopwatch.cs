using System;

namespace Stopwatch
{
    class Stopwatch
    {
        private bool _isRunning;
        private DateTime _startTime;

        public TimeSpan ElapsedTime { get; private set; }

        public Stopwatch()
        {
            _startTime = DateTime.MinValue;
            _isRunning = false;
        }

        public void Start()
        {
            if (_isRunning == true)
            {
                throw new InvalidOperationException("Stopwatch already running");
            }

            _startTime = DateTime.Now;
            _isRunning = true;

        }

        public void Stop()
        {
            ElapsedTime = ElapsedTime.Add(DateTime.Now - _startTime);
            _isRunning = false;
        }

    }

}

