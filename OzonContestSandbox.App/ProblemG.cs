namespace OzonContestSandbox.App;

public class ProblemG
{
    public void Solve()
    {
        var friendsAndPairs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var numUsers = friendsAndPairs[0];
        var numPairs = friendsAndPairs[1];
        var users = Enumerable.Range(0, numUsers).Select(_ => new HashSet<int>()).ToList();

        for (var i = 0; i < numPairs; i++)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstUser = input[0] - 1;
            var secondUser = input[1] - 1;
            users[firstUser].Add(secondUser + 1);
            users[secondUser].Add(firstUser + 1);
        }

        for (var i = 0; i < numUsers; i++)
        {
            var maxMatch = 0;
            var possibleFriends = new SortedDictionary<int, int>();

            foreach (var friend in users[i])
            {
                foreach (var pos in users[friend - 1].Except(users[i]).Where(pos => pos != i + 1))
                {
                    possibleFriends[pos] = possibleFriends.GetValueOrDefault(pos, 0) + 1;
                    maxMatch = Math.Max(maxMatch, possibleFriends[pos]);
                }
            }

            if (possibleFriends.Count > 0)
            {
                foreach (var pair in possibleFriends)
                {
                    if (pair.Value == maxMatch)
                    {
                        Console.Write(pair.Key + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(0);
            }
        }

    }
}