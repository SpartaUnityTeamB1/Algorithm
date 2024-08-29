using System.Text;
using System.Xml.Schema;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] strInput = sr.ReadLine().Split();

            int a, b, count = 0;
            if (int.TryParse(strInput[0], out a))
            {
                if (int.TryParse(strInput[1], out b))
                {
                    while (a < b)
                    {
                        if (0 == (b % 2))
                            b /= 2;
                        else if (1 == (b % 10))
                            b /= 10;
                        else
                            break;

                        ++count;
                    }

                    if (a == b)
                        sw.WriteLine(count + 1);
                    else
                        sw.WriteLine(-1);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}

