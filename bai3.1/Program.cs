using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap phep toan (+, -, *, /, %): ");
        char op = Console.ReadLine()[0];

        string result = op switch
        {
            '+' => $"{a + b:F2}",
            '-' => $"{a - b:F2}",
            '*' => $"{a * b:F2}",
            '/' when b == 0 => "Loi, khong the chia cho 0!",
            '/' => $"{a / b:F2}",
            '%' when b == 0 => "Loi, khong the chia cho 0!",
            '%' => $"{a % b:F2}",
            _ => "Loi, phep toan khong hop le!"
        };

        Console.WriteLine($"ket qua: {result}");
    }
}