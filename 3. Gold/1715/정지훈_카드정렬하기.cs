namespace Algorithm
{
    public class PriorityQueue
    {
        private List<int> listHeap = new List<int>();

        private int curIndex, nextIndex, Temp, ret, lastIndex, left, right;

        public void Push(int value)
        {
            listHeap.Add(value);

            curIndex = listHeap.Count - 1;

            while (0 < curIndex)
            {
                nextIndex = (curIndex - 1) / 2;

                if (listHeap[curIndex] > listHeap[nextIndex])
                    break;

                Temp = listHeap[curIndex];
                listHeap[curIndex] = listHeap[nextIndex];
                listHeap[nextIndex] = Temp;

                curIndex = nextIndex;
            }
        }

        public int Pop()
        {
            ret = listHeap[0];

            lastIndex = listHeap.Count - 1;
            listHeap[0] = listHeap[lastIndex];
            listHeap.RemoveAt(lastIndex);
            --lastIndex;

            curIndex = 0;

            while (true)
            {
                left = (2 * curIndex) + 1;
                right = (2 * curIndex) + 2;

                nextIndex = curIndex;

                if ((left <= lastIndex) && (listHeap[nextIndex] > listHeap[left]))
                    nextIndex = left;
                if ((right <= lastIndex) && (listHeap[nextIndex] > listHeap[right]))
                    nextIndex = right;

                if (curIndex == nextIndex)
                    break;

                Temp = listHeap[curIndex];
                listHeap[curIndex] = listHeap[nextIndex];
                listHeap[nextIndex] = Temp;

                curIndex = nextIndex;
            }

            return ret;
        }

        public int Count()
        {
            return listHeap.Count();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int A, B, Sum = 0, N = int.Parse(sr.ReadLine());

            PriorityQueue pq = new PriorityQueue();

            for (int i = 0; i < N; ++i)
                pq.Push(int.Parse(sr.ReadLine()));

            while (1 < pq.Count())
            {
                A = pq.Pop();
                B = pq.Pop();

                Sum += (A + B);

                pq.Push(A + B);
            }

            sw.WriteLine(Sum);

            sr.Close();
            sw.Close();
        }
    }
}

