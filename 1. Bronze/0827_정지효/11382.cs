string[] input = Console.ReadLine().Split();

double a, b, c;
a = double.Parse(input[0]);
b = double.Parse(input[1]);
c = double.Parse(input[2]);

double result = a + b + c;
Console.Write(result);