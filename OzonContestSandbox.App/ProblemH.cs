namespace OzonContestSandbox.App;

public class ProblemH
{
    public void Solve()
    {
        var count = int.Parse(Console.ReadLine());

        for (var i = 0; i < count; i++)
        {
            var isTraversedColor = new Dictionary<char, bool>();

            var mapSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var map = new char[mapSize[0], mapSize[1]];
            var visited = new bool[mapSize[0], mapSize[1]];
            var isCorrect = true;
            for (var r = 0; r < mapSize[0]; r++)
            {
                var curRow = Console.ReadLine().ToCharArray();
                for (var c = 0; c < mapSize[1]; c++)
                {
                    map[r, c] = curRow[c];
                    if (curRow[c] != '.' && !isTraversedColor.ContainsKey(curRow[c]))
                    {
                        isTraversedColor.Add(curRow[c], false);
                    }
                }
            }

            for (var r = 0; r < mapSize[0]; r++)
            {
                if (!isCorrect)
                    break;
                for (var c = 0; c < mapSize[1]; c++)
                {
                    if (map[r, c] == '.')
                        continue;

                    if (!visited[r, c])
                    {
                        if (isTraversedColor[map[r, c]])
                        {
                            isCorrect = false;
                            break;
                        }

                        isTraversedColor[map[r, c]] = true;

                        CheckNeighbours(map, visited, r, c, map[r, c]);
                    }
                }
            }

            Console.WriteLine(isCorrect ? "YES" : "NO");
        }

        void CheckNeighbours(char[,] map, bool[,] isVisited, int row, int col, char currentChar)
        {
            isVisited[row, col] = true;

            if (col - 2 >= 0)
            {
                if (map[row, col - 2] == currentChar && !isVisited[row, col - 2])
                {
                    CheckNeighbours(map, isVisited, row, col - 2, currentChar);
                }
            }

            if (col + 2 <= map.GetLength(1) - 1)
            {
                if (map[row, col + 2] == currentChar && !isVisited[row, col + 2])
                {
                    CheckNeighbours(map, isVisited, row, col + 2, currentChar);
                }
            }

            if (row - 1 >= 0)
            {
                if (col - 1 >= 0)
                {
                    if (map[row - 1, col - 1] == currentChar && !isVisited[row - 1, col - 1])
                    {
                        CheckNeighbours(map, isVisited, row - 1, col - 1, currentChar);
                    }
                }

                if (col + 1 <= map.GetLength(1) - 1)
                {
                    if (map[row - 1, col + 1] == currentChar && !isVisited[row - 1, col + 1])
                    {
                        CheckNeighbours(map, isVisited, row - 1, col + 1, currentChar);
                    }
                }
            }

            if (row + 1 <= map.GetLength(0) - 1)
            {
                if (col - 1 >= 0)
                {
                    if (map[row + 1, col - 1] == currentChar && !isVisited[row + 1, col - 1])
                    {
                        CheckNeighbours(map, isVisited, row + 1, col - 1, currentChar);
                    }
                }

                if (col + 1 <= map.GetLength(1) - 1)
                {
                    if (map[row + 1, col + 1] == currentChar && !isVisited[row + 1, col + 1])
                    {
                        CheckNeighbours(map, isVisited, row + 1, col + 1, currentChar);
                    }
                }
            }
        }
    }
}