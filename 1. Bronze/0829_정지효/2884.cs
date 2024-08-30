string[] input = Console.ReadLine().Split();

int a, b;

a = int.Parse(input[0]);
b = int.Parse(input[1]);

b -= 45;

if ( b < 0 )
{
    b += 60;
    a -= 1;

    if( a < 0 )
    {
        a = 23;
    }
}
Console.WriteLine($"{a} {b}");
