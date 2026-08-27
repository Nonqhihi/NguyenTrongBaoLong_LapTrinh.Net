using System;

class BaiTap3_3
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n <= 0) return false;
        int sum = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0) sum += i;
        }
        return sum == n;
    }

    static void Main()
    {
        Console.Write("Nhap so nguyen duong N: ");
        int N = int.Parse(Console.ReadLine());


        string perfectResult = IsPerfectNumber(N) ? $"{N} La so hoan hao!" : $"{N} KHONG la so hoan hao";


        string primeResult = IsPrime(N) ? $"{N} La so nguyen to" : $"{N} KHONG la so nguyen to.";

        Console.WriteLine($"{perfectResult} {primeResult}");

     
        Console.Write($"Day Fibonacci {N} so: ");
        int f0 = 0, f1 = 1;
        for (int i = 0; i < N; i++)
        {
            if (i == 0)
                Console.Write(f0);
            else if (i == 1)
                Console.Write(", " + f1);
            else
            {
                int fn = f0 + f1;
                Console.Write(", " + fn);
                f0 = f1;
                f1 = fn;
            }
        }
        Console.WriteLine();
    }
}