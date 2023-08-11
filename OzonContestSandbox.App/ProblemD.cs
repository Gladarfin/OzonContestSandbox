namespace OzonContestSandbox.App;

public class ProblemD
{
    public void Solve()
    {
        var count = int.Parse(Console.ReadLine());
        for (var i = 0; i < count; i++)
        {
            Console.ReadLine(); //skip empty string
            var sizeOfMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = sizeOfMatrix[0];
            var columns = sizeOfMatrix[1];
            var matrix = new int[rows][];
            for (var r = 0; r < rows; r++)
            {
                matrix[r] = new int[columns];
                var curRow = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (var c = 0; c < columns; c++)
                {
                    matrix[r][c] = curRow[c];
                }
            }
    
            Console.ReadLine(); //number of clicks, just skip it doesn't matter
            var clickedColumns = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x) - 1)
                .ToArray();

            matrix = clickedColumns.Aggregate(matrix, (current, col) => current.OrderBy(x => x[col]).ToArray());

            for (var r = 0; r < rows; r++)
            {
                Console.WriteLine(string.Join(" ",matrix[r]));
            }
            Console.WriteLine();
        }
    }
}