namespace OzonContestSandbox.App;

public class ProblemI
{
    public void Solve()
    {
        var nm = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        var n = nm[0];
        var m = nm[1];

        var processors = new Processor[n];
        var procValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (var i = 0; i < procValues.Length; i++)
        {
            processors[i] = new Processor { Number = i + 1, Energy = procValues[i] };
        }

        var freeProc = new PriorityQueue<Processor, int>(processors.Select(x => (x, x.Energy)));
        var usedProc = new PriorityQueue<Processor, int>();

        ulong result = 0;

        for (var i = 0; i < m; i++)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (usedProc.Count != 0 && usedProc.Peek().Free <= input[0])
            {
                var freed = usedProc.Dequeue();
                freeProc.Enqueue(freed, freed.Energy);
            }

            if (freeProc.Count == 0) continue;
            var proc = freeProc.Dequeue();
            proc.Free = input[0] + input[1];
            usedProc.Enqueue(proc, proc.Free);
            result += (ulong)input[1] * (ulong)proc.Energy;

        }

        Console.WriteLine(result);

    }
    
    class Processor
    {
        public int Number { get; set; }
        public int Energy { get; set; }
        public int Free { get; set; }
    }
    
}