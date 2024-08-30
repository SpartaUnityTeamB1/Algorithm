string[] input = Console.ReadLine().Split();

int y;

y = int.Parse(input[0]);

if (1000 <= y && y <= 3000) 
{
    Console.WriteLine(y - 543);
}