﻿int[,,] dp = new int[21, 21, 21];

while (true)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);

    if (a == -1 && b == -1 && c == -1)
    {
        break;
    }

    Console.WriteLine($"w({a}, {b}, {c}) = {W(a, b, c)}");
}

int W(int a, int b, int c)
{
    if (a <= 0 || b <= 0 || c <= 0)
    {
        return 1;
    }
    if (a > 20 || b > 20 || c > 20)
    {
        return W(20, 20, 20);
    }
    if (dp[a, b, c] != 0)
    {
        return dp[a, b, c];
    }
    if (a < b && b < c)
    {
        dp[a, b, c] = W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
    }
    else
    {
        dp[a, b, c] = W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
    }
    return dp[a, b, c];
}