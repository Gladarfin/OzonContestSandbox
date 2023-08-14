namespace OzonContestSandbox.App;

public class ProblemE
{
    public void Solve()
    {
        var count = int.Parse(Console.ReadLine());

        for (var i = 0; i < count; i++)
        {
            var result = new HashSet<int>();
            Console.ReadLine(); //just skip the number of days
            var report = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var isCorrect = true;

            for (var j = 0; j < report.Length; j++)
            {
                if (result.Contains(report[j]))
                {
                    isCorrect = false;
                    break;
                }

                result.Add(report[j]);
                while (j < report.Length - 1 && report[j] == report[j + 1])
                {
                    j++;
                }
            }
    
            Console.WriteLine(isCorrect ? "YES" : "NO");
        }
    }
}