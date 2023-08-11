namespace OzonContestSandbox.App;

public class ProblemA
{
    public void Solve()
    {
        var count = int.Parse(Console.ReadLine());
        for (var i = 0; i < count; i++)
        {
            var result = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Sum();
            Console.WriteLine(result);
        }
    }
}