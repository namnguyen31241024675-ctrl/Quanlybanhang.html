// Thành viên 1 - feature-member1

using System;

public class Calculator
{
    // Hàm cộng 2 số
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Tổng của 2 và 3 là: " + calc.Add(2, 3));
    }
}
