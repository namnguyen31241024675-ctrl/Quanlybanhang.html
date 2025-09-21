// Thành viên 1 - feature-member1

using System;

public class Greeter
{
    // Hàm hiển thị thông điệp chào mừng
    public void Greet(string name)
    {
        Console.WriteLine("Chào mừng, " + name + "!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Greeter greeter = new Greeter();
        greeter.Greet("Minh"); // Gửi tên của người dùng để chào mừng
    }
}
