string[] input = Console.ReadLine().Split();

int a, b, c;

a = int.Parse(input[0]);
b = int.Parse(input[1]);
c = int.Parse(Console.ReadLine());

b += c;

while (b >= 60)
{
    a++;
    b -= 60;
}

if (a >= 24)
{
    a -= 24;
}

Console.WriteLine(a + " " + b);