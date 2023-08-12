using System;
using System.Collections.Generic;
using System.Linq;

namespace OzonContestSandbox.App;
using System.Globalization;

public class ProblemF
{
    public void Solve()
    {
        var count = int.Parse(Console.ReadLine());
        TimeSpan ts1, ts2;
        for (var i = 0; i < count; i++)
        {
            var timeSpanCount = int.Parse(Console.ReadLine());
            var timespanList = new List<(TimeSpan, TimeSpan)>();
            var isValid = true;
    
            for (var j = 0; j < timeSpanCount; j++)
            {
                var timespans = Console.ReadLine().Split('-').ToArray();
                var ts1IsValid = TimeSpan.TryParseExact(timespans[0], "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out ts1);
                var ts2IsValid = TimeSpan.TryParseExact(timespans[1], "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out ts2);
    
                if ((!ts1IsValid || !ts2IsValid) && isValid)
                {
                    isValid = false;
                    continue;
                }
    
                if (ts1 > ts2 && isValid)
                {
                    isValid = false;
                    continue;
                }
            
                timespanList.Add((ts1, ts2));
            }
    
            if (isValid)
            {
                timespanList.Sort((x, y) => x.Item1.CompareTo(y.Item1));
    
                for (var k = 0; k < timespanList.Count - 1; k++)
                {
                    if (timespanList[k].Item2 >= timespanList[k + 1].Item1)
                    {
                        isValid = false;
                        break;
                    }
                }
            }
    
            Console.WriteLine(isValid ? "YES" : "NO");
        }
    }
}