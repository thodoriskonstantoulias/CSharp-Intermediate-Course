﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Stopwatch
{ 
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;
        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Stopwatch is still running");
            }
            _startTime = DateTime.Now;
            _running = true;
        }
        public void Stop()
        {
            if (!_running)
            {
                throw new InvalidOperationException("Stopwatch is not running");
            }
            _endTime = DateTime.Now;
            _running = false;
        }
        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}
