using System;

class Program
{
    static void Bai1_Calculator()
    {
        Console.Clear();

        Console.Write("Nhap so thu nhat a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap phep toan (+, -, *, /, %): ");
        char op = char.Parse(Console.ReadLine());

        try
        {
            double result = 0;

            // Sử dụng switch-case truyền thống để tương thích C# 7.3
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0) throw new DivideByZeroException();
                    result = a / b;
                    break;
                case '%':
                    if (b == 0) throw new DivideByZeroException();
                    result = a % b;
                    break;
                default:
                    throw new ArgumentException("phep toan KHONG hop le!");
            }

            Console.WriteLine($"Ket qua: {result:F2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Loi: KHONG the chia cho 0!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Loi: {ex.Message}");
        }

        Console.WriteLine("\nNhan phim bat ki de ve Menu...");
        Console.ReadKey();
    }

    static void Bai2_PhuongTrinhBac2()
    {
        Console.Clear();

        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                else
                    Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phuong trinh co nghiem x = {x:F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1:F2}");
                Console.WriteLine($"x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"nghiem kep x = {x:F2}");
            }
            else
            {
                Console.WriteLine("vo nghiem.");
            }
        }

        Console.WriteLine("\nNhan phim bat ki de ve Menu...");
        Console.ReadKey();
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n <= 1)
            return false;

        int sum = 1;
        int i = 2;

        while (i <= n / 2)
        {
            if (n % i == 0)
                sum += i;

            i++;
        }

        return sum == n;
    }

    static void Bai3_SoNguyenToFibonacci()
    {
        Console.Clear();

        int N;

        do
        {
            Console.Write("Nhap so N nguyen duong: ");
            N = int.Parse(Console.ReadLine());
        }
        while (N <= 0);

        if (IsPerfectNumber(N))
            Console.Write($"{N} la so hoan hao! ");
        else
            Console.Write($"{N} KHONG la so hoan hao! ");

        if (IsPrime(N))
            Console.WriteLine($"{N} la so nguyen to.");
        else
            Console.WriteLine($"{N} KHONG la so nguyen to.");

        Console.Write($"Day Fibonacci {N} so: ");

        long f1 = 0;
        long f2 = 1;

        for (int i = 1; i <= N; i++)
        {
            Console.Write(f1);

            if (i < N)
                Console.Write(", ");

            long next = f1 + f2;
            f1 = f2;
            f2 = next;
        }

        Console.WriteLine();

        Console.WriteLine("\nNhan phim bat ki de ve Menu...");
        Console.ReadKey();
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU BAI TAP C# ===");
            Console.WriteLine("1. Chon bai tap 1 (Calculator)");
            Console.WriteLine("2. Chon bai tap 2 (Phuong trinh bac 2)");
            Console.WriteLine("3. Chon bai tap 3 (So nguyen to & Fibonacci)");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.Write("Nhap lua chon: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

            switch (choice)
            {
                case 1:
                    Bai1_Calculator();
                    break;

                case 2:
                    Bai2_PhuongTrinhBac2();
                    break;

                case 3:
                    Bai3_SoNguyenToFibonacci();
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine("Da thoat chuong trinh.");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    Console.WriteLine("\nNhan phim bat ki de thu lai...");
                    Console.ReadKey();
                    break;
            }

        } while (choice != 0);
    }
}