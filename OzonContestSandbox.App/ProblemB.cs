namespace OzonContestSandbox.App;

public class ProblemB
{
    public void Solve()
    {
        var count = int.Parse(Console.ReadLine());
        for (var i = 0; i < count; i++)
        {
            var goodsCount = int.Parse(Console.ReadLine());
            var totalPrice = Console
                .ReadLine()
                .Split(' ')
                .GroupBy(int.Parse)
                .Select(x => new { price = x.Key, count = x.Count() })
                .Sum(elem => (elem.count - elem.count / 3) * elem.price);
            Console.WriteLine(totalPrice);
        }
    }
}