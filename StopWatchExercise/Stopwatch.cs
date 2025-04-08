using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchExercise
{
    public class Stopwatch
    {
        #region Fields
        private DateTime _initialStartTime;
        private DateTime _startTime;
        private bool _isStart = false;
        private TimeSpan _totalTimeSpan;
        #endregion Fields


        #region Methods
        public void Start()
        {
            if (!_isStart)
            {
                _isStart = true;
                _startTime = DateTime.Now;

                if (_initialStartTime.Equals(default(DateTime)))
                {
                    _initialStartTime = _startTime;
                }

                Console.WriteLine("Time started at {0}", _startTime.ToString("HH:mm:ss.fff"));
                Console.WriteLine("Choose desired operation from the options above.");
            }
            else
            {
                throw new InvalidOperationException("The stopwatch is currently running...");
            }
        }

        public void Stop()
        {
            if (_isStart)
            {
                _isStart = false;

                DateTime stopTime = DateTime.Now;

                TimeSpan timeSpan = stopTime.Subtract(_startTime);
                _totalTimeSpan += timeSpan;

                Console.WriteLine("Time stopped at: {0}", stopTime.ToString("HH:mm:ss.fff"));
                Console.WriteLine("Lap Time: {0}", timeSpan.ToString(@"hh\:mm\:ss\.fff"));
                Console.WriteLine("Total Timespan: {0} \n", _totalTimeSpan.ToString(@"hh\:mm\:ss\.fff"));
            }
            else
            {
                throw new InvalidOperationException("The stopwatch is currently on standby...");
            }
        }

        public void Reset()
        {
            _isStart = false;
            _initialStartTime = default(DateTime);
            _startTime = _initialStartTime;
            _totalTimeSpan = TimeSpan.Zero;

            Console.WriteLine("Stopwatch has been reset. Choose another operation.");
        }
        #endregion Methods

    }
}
