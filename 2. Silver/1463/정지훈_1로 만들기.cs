namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N;
            List<int> listCounts = new List<int>();

            if (int.TryParse(sr.ReadLine(), out N))
            {
                for (int i = 0; i <= N; ++i)
                    listCounts.Add(0);

                for (int i = 2; i <= N; ++i)
                {
                    listCounts[i] = listCounts[i - 1] + 1;

                    if (0 == (i % 3))
                        listCounts[i] = Math.Min(listCounts[i], listCounts[i / 3] + 1);
                    if (0 == (i % 2))
                        listCounts[i] = Math.Min(listCounts[i], listCounts[i / 2] + 1);
                }
            }

            sw.WriteLine(listCounts[N]);

            sr.Close();
            sw.Close();
        }
    }
}

