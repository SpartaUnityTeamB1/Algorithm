string[] input = Console.ReadLine().Split(" ");

int result = int.Parse(input[1]);

int i = 0;

while(result > int.Parse(input[0]))
{
    if (result % 2 == 0)
        result /= 2;
    else if (result % 10 == 1)
        result = (result) / 10;
    else
        break;
    i++;
}

if (result == int.Parse(input[0]))
    Console.WriteLine(i + 1);
else
    Console.WriteLine(-1);