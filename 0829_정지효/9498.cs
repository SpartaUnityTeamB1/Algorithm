string[] input = Console.ReadLine().Split();

int a;

a = int.Parse(input[0]);

if(90 <= a)
{
    Console.Write("A");
}
else if(80 <= a)
{
    Console.Write("B");
}
else if(70 <= a) 
{
    Console.Write("C");
}
else if (60 <= a)
{
    Console.Write("D");
}
else
{
    Console.Write("F");
}