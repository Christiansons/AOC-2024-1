namespace AOC_2024_1_Part2
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

            int sum = 0;

            for (int i = 0; i < allLines.Length; i++) {
                int instances = rightColumn.Where(l => l == leftColumn[i]).Count();
                sum += instances * leftColumn[i];
            }

            Console.WriteLine(sum);
        }
    }
}
