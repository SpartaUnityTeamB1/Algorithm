string[] input = Console.ReadLine().Split();

int a, b;

a = int.Parse(input[0]);
b = int.Parse(input[1]);

if(a == b)
{
    Console.Write("==");
}
else if(a < b)
{
    Console.Write("<");
}
else
{
    Console.Write(">");
}