using System.ComponentModel.Design;
using System.Text;
using System.Xml.Schema;

namespace Algorithm
{
    internal class Program
    {
        static void DFS(int index, List<int>[] array, List<bool> visit)
        {
            visit[index] = true;

            for (int i = 0; i < array[index].Count; ++i)
            {
                if (!visit[array[index][i]])
                    DFS(array[index][i], array, visit);
            }
        }

        static void Main(string[] args)
        {
            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] strInput = sr.ReadLine().Split();

            int N, M, u, v, count = 0;
            if (int.TryParse(strInput[0], out N))
            {
                if (int.TryParse(strInput[1], out M))
                {
                    List<int>[] listArray = new List<int>[N + 1];
                    List<bool> listVisit = new List<bool>(new bool[N + 1]);

                    for (int i = 0; i <= N; ++i)
                        listArray[i] = new List<int>();

                    for (int i = 0; i < M; ++i)
                    {
                        strInput = sr.ReadLine().Split();

                        u = int.Parse(strInput[0]);
                        v = int.Parse(strInput[1]);

                        listArray[u].Add(v);
                        listArray[v].Add(u);
                    }

                    for (int i = 1; i <= N; ++i)
                    {
                        if (!listVisit[i])
                        {
                            ++count;
                            DFS(i, listArray, listVisit);
                        }
                    }

                    sw.WriteLine(count);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}

