namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            bool isTen = false;
            int Sum = 0;
            string Input = sr.ReadLine();

            List<char> listInputs = new List<char>();

            foreach (var chr in Input)
            {
                if ('0' == chr)
                    isTen = true;

                Sum += (chr - '0');
                listInputs.Add(chr);
            }

            if (isTen && (0 == Sum % 3))
            {
                listInputs.Sort();
                listInputs.Reverse();

                foreach (var chr in listInputs)
                    sw.Write(chr);
            }
            else
                sw.WriteLine(-1);
            
            sr.Close();
            sw.Close();
        }
    }
}

