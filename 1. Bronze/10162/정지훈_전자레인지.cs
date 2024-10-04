namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine());

            if (0 != T % 10)
                sw.WriteLine(-1);
            else
            {
                int A = T / 300;
                int B = (T % 300) / 60;
                int C = ((T % 300) % 60) / 10;

                sw.WriteLine($"{A} {B} {C}");
            }

            sr.Close();
            sw.Close();
        }
    }
}

