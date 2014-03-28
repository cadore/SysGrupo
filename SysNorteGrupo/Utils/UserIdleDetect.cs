using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace UserIdle
{
    public sealed class UserIdleDetect
    {
        [DllImport("user32.dll")]
        private static extern Boolean GetLastInputInfo(ref tagLASTINPUTINFO plii);
        private struct tagLASTINPUTINFO
        {
            public uint cbSize;
            public Int32 dwTime;
        }

        // fields
        private Timer _timer;
        private bool _inIdle;
        private int _idleIndicator = 10000; // 10 seconds
        private int timeOfTimer = 50;

        //events
        public event EventHandler UserIdleDetected;
        public event EventHandler UserIdleInterrupted;

        // constructor
        private UserIdleDetect()
        {
            _timer = new Timer(timeOfTimer);
            _timer.Elapsed += timer_Elapsed;
            _timer.Enabled = true;
        }

        // public
        public UserIdleDetect SetIdleIndicator(int idleIndicatorSeconds)
        {
            _idleIndicator = idleIndicatorSeconds;
            return this;
        }
        public static UserIdleDetect StartDetection(int secondsForIdleIndication)
        {
            var idleDetect = new UserIdleDetect();
            idleDetect.SetIdleIndicator(secondsForIdleIndication);

            return idleDetect;
        }
        public void StopDetection()
        {
            if (_timer == null)
            {
                throw new InvalidOperationException("Idle detection is not started.");
            }

            _timer.Enabled = false;
            _timer.Elapsed -= timer_Elapsed;
            _timer.Dispose();
            _timer = null;
        }


        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            tagLASTINPUTINFO lastInput = new tagLASTINPUTINFO();
            lastInput.cbSize = (uint)Marshal.SizeOf(lastInput);
            lastInput.dwTime = 0;

            if (GetLastInputInfo(ref lastInput))
            {
                int idleTime = Environment.TickCount - lastInput.dwTime;

                if (idleTime > 50)
                {
                    if (idleTime > _idleIndicator)
                    {
                        bool shouldLaunchEvent = !_inIdle && UserIdleDetected != null;
                        if (shouldLaunchEvent)
                        {
                            UserIdleDetected(this, EventArgs.Empty);
                        }

                        _inIdle = true;
                    }
                }
                else
                {
                    bool shouldLaunchEvent = _inIdle && UserIdleInterrupted != null;
                    if (shouldLaunchEvent)
                    {
                        UserIdleInterrupted(this, EventArgs.Empty);
                    }

                    _inIdle = false;
                }
            }
        }

        public static int seconds(int second)
        {
            return second * 1000;
        }

        public static int minutes(int minute)
        {
            return (minute * 1000) * 60;
        }

        public static int hours(int hour)
        {
            return ((hour * 1000) * 60) * 60;
        }

        public static int days(int day)
        {
            return (((day * 1000) * 60) * 60) * 24;
        }
    }
}
