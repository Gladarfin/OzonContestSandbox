namespace OzonContestSandbox.App;

public class ProblemJ
{
    public void Solve()
    {
        var dictLength = int.Parse(Console.ReadLine());
        var dict = new List<string>(dictLength);
        var allPossibilities = new Dictionary<string, HashSet<string>>();
        for (var j = 0; j < dictLength; j++)
        {
            var w = Console.ReadLine();
            if (!allPossibilities.ContainsKey(w))
            {
                allPossibilities[w] = new HashSet<string>();
            }
        
            allPossibilities[w].Add(w);
            dict.Add(w);
        
            for (var i = 1; i < w.Length; i++)
            {
                var tmp = w[i..];
                if (!allPossibilities.ContainsKey(tmp))
                {
                    allPossibilities[tmp] = new HashSet<string>();
                }
        
                allPossibilities[tmp].Add(w);
            }
        }
        var queryNumber = int.Parse(Console.ReadLine());
        
        for (var j = 0; j < queryNumber; j++)
        {
            var curWord = Console.ReadLine();
            var bestRhyme = "";
        
            foreach (var word in dict)
            {
                if (word != curWord)
                {
                    bestRhyme = word;
                    break;
                }
            }
        
            var isFind = false;
        
            for (var i = 0; i < curWord.Length; i++)
            {
                var tmp = curWord[i..];
                if (allPossibilities.TryGetValue(tmp, out var possibility))
                {
                    foreach (var word in possibility)
                    {
                        if (curWord != word)
                        {
                            bestRhyme = word;
                            isFind = true;
                            break;
                        }
                    }
                }
        
                if (isFind)
                    break;
            }
            
            Console.WriteLine(bestRhyme);
        }
    }
}