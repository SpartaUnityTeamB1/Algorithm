string[] input = Console.ReadLine().Split();

int a, b, c;

a = int.Parse(input[0]);
b = int.Parse(input[1]);
c = int.Parse(input[2]);

Console.WriteLine((a + b) % c);
Console.WriteLine(((a % c) + (b % c)) % c);
Console.WriteLine((a * b) % c);
Console.WriteLine(((a % c) * (b % c)) % c);