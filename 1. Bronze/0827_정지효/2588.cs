//string[] input = Console.ReadLine().Split();

string a = Console.ReadLine();
string b = Console.ReadLine();
char[] c = b.ToCharArray();

int num1 = int.Parse(a);
int[] num2 = new int[c.Length];

for (int i = 0; i < c.Length; i++)
{
    num2[i] = int.Parse(c[i].ToString());
}

Console.WriteLine(num1 * num2[2]);
Console.WriteLine(num1 * num2[1]);
Console.WriteLine(num1 * num2[0]);
Console.WriteLine(num1 * num2[2] + num1 * num2[1] * 10  + num1 * num2[0] * 100);