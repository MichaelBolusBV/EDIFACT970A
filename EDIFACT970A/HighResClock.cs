using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EDIFACT970A
{
    public class HighResClock
    {
        #region Dll Import

        [DllImport("kernel32", EntryPoint = "QueryPerformanceCounter")]
        private static extern uint K32QueryPerformanceCounter(ref long t);

        [DllImport("kernel32", EntryPoint = "QueryPerformanceFrequency")]
        private static extern uint K32QueryPerformanceFrequency(ref long t);

        #endregion

        #region Fields

        static long perfFreq = 0;

        static long overheadTicks;

        static long k32TicksOffset;

        #endregion

        #region Properties

        public static long NowTicks
        {
            get
            {
                if (perfFreq == 0)
                    throw new NotSupportedException("This system does not have a high performance counter.");

                long t = 0;
                K32QueryPerformanceCounter(ref t);

                long ticks = (long)(t / ((float)perfFreq / 1e7));
                return (ticks);
            }
        }

        public static DateTime Now
        {
            get
            {
                return (new DateTime(NowTicks - k32TicksOffset));
            }
        }

        public static long OverheadTicks
        {
            get { return (overheadTicks); }
        }

        public static long Frequency
        {
            get { return (perfFreq); }
        }

        #endregion

        #region Constructor

        private HighResClock() { }

        static HighResClock()
        {
            Calibrate();
        }

        #endregion

        #region Main Public API

        public static void Calibrate()
        {
            K32QueryPerformanceFrequency(ref perfFreq);

            ThreadPriority oldThreadPriority = Thread.CurrentThread.Priority;
            Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;

            Process proc = Process.GetCurrentProcess();
            ProcessPriorityClass oldProcPriorityClass = proc.PriorityClass;
            proc.PriorityClass = ProcessPriorityClass.RealTime;

            try
            {
                k32TicksOffset = NowTicks - DateTime.Now.Ticks;

                long start, stop = 0;
                overheadTicks = Int64.MaxValue;

                for (int i = 0; i < 10; i++)
                {
                    start = NowTicks;
                    stop = NowTicks;
                    long ticks = stop - start;
                    if (ticks > 0 && ticks < overheadTicks) overheadTicks = ticks;
                }

                if (overheadTicks == Int64.MaxValue) overheadTicks = 0;
            }
            finally
            {
                Thread.CurrentThread.Priority = oldThreadPriority;
                proc.PriorityClass = oldProcPriorityClass;
            }
        }

        public static float TicksToMs(long ticks)
        {
            return ((float)ticks / 10000);
        }

        public static TimeSpan CalcTimeSpan(long startTicks, long stopTicks)
        {
            long ticks = stopTicks - startTicks;
            ticks -= overheadTicks;
            ticks = Math.Max(0, ticks);
            return (new TimeSpan(ticks));
        }

        public static TimeSpan CalcTimeSpan(long startTicks)
        {
            return (CalcTimeSpan(startTicks, NowTicks));
        }

        public static TimeSpan CalcTimeSpan(DateTime startTime)
        {
            return (CalcTimeSpan(startTime.Ticks, NowTicks));
        }

        public static TimeSpan CalcTimeSpan(DateTime startTime, DateTime stopTime)
        {
            return (CalcTimeSpan(startTime.Ticks, stopTime.Ticks));
        }

        #endregion
    }
}
