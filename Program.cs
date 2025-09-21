// Thành viên 3 - feature-member3

using System;

public class Calculator
{
    // Hàm tính tổng của hai số
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(5, 3); // Tính tổng của 5 và 3
        Console.WriteLine("Tổng của 5 và 3 là: " + result); // Hiển thị kết quả
    }
}
