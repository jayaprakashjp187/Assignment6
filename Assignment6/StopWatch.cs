using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Assignment6
{
    internal class StopWatch
    {
        public static void CheckingStopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();

          
            System.Timers.Timer timer = new System.Timers.Timer(500); 


            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            stopwatch.Start();


      
            timer.Elapsed += OnTimedEvent;

            
            timer.Interval = 500;
            timer.Enabled = true;


            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

           
            stopwatch.Stop();

           
            timer.Stop();
            timer.Dispose();

            Console.WriteLine("Total Time elapsed: {0}", stopwatch.Elapsed);

           void OnTimedEvent(Object source, ElapsedEventArgs e)
            {
                Console.WriteLine( stopwatch.Elapsed.ToString("hh//mm//ss"));
            }
        }
    }
}
   
