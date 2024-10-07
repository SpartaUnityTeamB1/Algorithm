namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int zeroCount = 0, oneCount = 0;
            string strInput = sr.ReadLine();

            if ('0' == strInput[0])
                ++zeroCount;
            else
                ++oneCount;

            for (int i = 1; i < strInput.Length; ++i)
            {
                if (strInput[i] != strInput[i - 1])
                {
                    if ('0' == strInput[i])
                        ++zeroCount;
                    else
                        ++oneCount;
                }        
            }

            sw.WriteLine(MathF.Min(zeroCount, oneCount));

            sr.Close();
            sw.Close();
        }
    }
}

