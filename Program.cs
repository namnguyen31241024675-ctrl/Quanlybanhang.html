// Thành viên 2 - feature-member2

using System;

public class TimeDisplayer
{
    // Hàm hiển thị thời gian hiện tại
    public void DisplayTime()
    {
        Console.WriteLine("Thời gian hiện tại: " + DateTime.Now);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TimeDisplayer timeDisplayer = new TimeDisplayer();
        timeDisplayer.DisplayTime(); // Hiển thị thời gian hiện tại
    }
}
