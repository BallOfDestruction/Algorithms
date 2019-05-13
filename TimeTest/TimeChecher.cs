using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace TimeTest
{
    public class WorkStopWatch
    {
        /// <returns>In millisecond</returns>
        public long CheckTime<T>([NotNull] Func<T> preWork, [NotNull] Action<T> work, int count)
        {
            var stopWatch = new Stopwatch();

            for (var i = 0; i < count; i++)
            {
                var preWorkItems = preWork.Invoke();
                
                stopWatch.Start();

                work.Invoke(preWorkItems);
                
                stopWatch.Stop();
            }
            
            return stopWatch.ElapsedMilliseconds;
        }
    }
}
