namespace AOC_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var path = "C:\\Users\\Alex\\source\\repos\\AOC-2024-1\\input.txt";
            string[] allLines = File.ReadAllLines(path);

            int[] leftColumn = allLines.Select(line => Convert.ToInt32(line.Split(" ").First())).ToArray();
            int[] rightColumn = allLines.Select(line => Convert.ToInt32(line.Split(" ").Last())).ToArray();

            Array.Sort(leftColumn);
            Array.Sort(rightColumn);

            int sum = 0;

            for (int i = 0; i < leftColumn.Length; i++)
            {
                if(leftColumn[i] > rightColumn[i])
                {
                    sum += leftColumn[i] - rightColumn[i];
                }
                else
                {
                    sum += rightColumn[i] - leftColumn[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
