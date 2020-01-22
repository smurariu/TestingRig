using System;
using System.Diagnostics;

namespace TestingRig
{
    public static class Do
    {
        /// <summary>
        ///     Performs an A/B test between two actions.
        /// </summary>
        /// <param name="a">The first action to time.</param>
        /// <param name="b">The second actoin to time.</param>
        /// <param name="iterations">The number of times to execute each action (1.000.000 by default).</param>
        /// <returns>
        ///     A tuple containing the execution times in microseconds for the two actions.
        /// </returns>
        public static (long T1, long T2) ABTest(Action a, Action b, int iterations = 1000000)
        {
            long t1, t2;

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < iterations; i++)
            {
                a();
            }
            t1 = sw.ElapsedMicroSeconds();

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                b();
            }
            t2 = sw.ElapsedMicroSeconds();

            sw.Stop();

            return (t1, t2);
        }
    }

    internal static class Utility
    {
        public static long ElapsedNanoSeconds(this Stopwatch watch)
        {
            return watch.ElapsedTicks * 1000000000 / Stopwatch.Frequency;
        }
        public static long ElapsedMicroSeconds(this Stopwatch watch)
        {
            return watch.ElapsedTicks * 1000000 / Stopwatch.Frequency;
        }
    }
}
