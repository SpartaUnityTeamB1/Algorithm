string[] input = Console.ReadLine().Split();

int y;

y = int.Parse(input[0]);

if( y % 4 == 0 && y % 100 != 0 )
{
    Console.WriteLine("1");
}
else if( y % 400 == 0)
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}