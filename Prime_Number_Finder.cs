```CSharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsPrime(num) ? $"{num} is a prime number." : $"{num} is not a prime number.");
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(num));

        for (int i = 3; i <= boundary; i += 2)
            if (num % i == 0)
                return false;

        return true;
    }
}
```