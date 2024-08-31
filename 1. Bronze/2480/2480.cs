string[] input = Console.ReadLine().Split();

int a, b, c;

a = int.Parse(input[0]);
b = int.Parse(input[1]);
c = int.Parse(input[2]);

if (a == b &&  b == c)
{
    Console.WriteLine(10000 + (a * 1000));
}
else if (a == b)
{
    Console.WriteLine(1000 + a * 100);
}
else if (a == c)
{
    Console.WriteLine(1000 + a * 100);
}
else if (b == c)
{
    Console.WriteLine(1000 + b * 100);
}
else
{
    if (a > b && a > c)
    {
        Console.WriteLine(100 * a);
    }
    else if (b > c)
    {
        Console.WriteLine(100 * b);
    }
    else
    {
        Console.WriteLine(100 * c);
    }
}