using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> Score = new Dictionary<string, double>
        {
            { "Alice", 3 },
            { "Bob", 7.87 },
            { "Charlie", 9.001 },
            { "David", 11 },
            { "Eve", 13 },
            { "Frank", 8 },
            { "Grace", 9 },
            { "Hannah", 9.2 },
            { "Isaac", 8.86 }
        };

        // مرور دیکشنری و بررسی امتیازات
        var keys = new List<string>(Score.Keys);
        foreach (var key in keys)
        {
            double value = Score[key];

            // گرد کردن اعداد بین 9 و کمتر از 10 به 10
            if (value >= 9 && value < 10)
            {
                Score[key] = 10; // مقدار را به 10 تغییر می‌دهیم
                Console.WriteLine($"Name: {key}, Score: {Score[key]} - Ba Enfagh ghabool Shodi!");
            }
            else if (value >= 10)
            {
                // حذف اعشار برای اعداد 10 و بالاتر
                Console.WriteLine($"Name: {key}, Score: {Math.Round(value)} - Eyvaal ghabool Shodi!");
            }
        }

        Console.ReadKey();
    }
}
