﻿using System.Diagnostics;

int result = Fibonacci(6);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"We are looking for the {n}th number");

    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLine(sum == 1, $"sum is {sum}, n1 is {n1}, n2 is {n2}");
    }

    Debug.Assert(n2 == 5, "The returned value is not 5 and it should be.");
    return n == 0 ? n1 : n2;
}
