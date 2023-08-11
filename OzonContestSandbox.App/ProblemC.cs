namespace OzonContestSandbox.App;

public class ProblemC
{
    public void Solve()
    {
        var count = int.Parse(Console.ReadLine());
        for (var i = 0; i < count; i++)
        {
            var devsCount = int.Parse(Console.ReadLine());

            var devsSkillsList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var isAddedDev = new bool[devsSkillsList.Length];

            for (var j = 0; j < devsCount; j++)
            {
                if (isAddedDev[j])
                    continue;

                var min = int.MaxValue;
                var pairIndex = -1;
                for (var k = j + 1; k < devsCount; k++)
                {
                    if (isAddedDev[k])
                        continue;
            
                    var curDiff = Math.Abs(devsSkillsList[j] - devsSkillsList[k]);
                    if (min <= curDiff) 
                        continue;
                    
                    min = curDiff;
                    pairIndex = k;
                }

                isAddedDev[j] = true;
                isAddedDev[pairIndex] = true;
                Console.WriteLine($"{j + 1} {pairIndex  + 1}");
            }
            
            Console.WriteLine();
        }
    }
}