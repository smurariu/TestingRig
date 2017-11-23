using System;
using System.Collections.Generic;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var testResults = TestingRig.Do.ABTest(
                a: () => { IEnumerable<int> e = new List<int> { 42 }; },
                b: () => { IEnumerable<int> e = new[] { 42 }; });

            Console.WriteLine("Elapsed microseconds: " + testResults.T1);
            Console.WriteLine("Elapsed microseconds: " + testResults.T2);
        }
    }
}
