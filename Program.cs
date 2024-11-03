using static System.Runtime.InteropServices.JavaScript.JSType;

Dictionary<string, double> Score = new Dictionary<string, double>
        {
            { "Alice", 3 },
            { "Bob", 7.87 },
            { "Charlie", 9.001 },
            { "David", 11 },
            { "Eve", 13 },
            {"Frank",8  },
            { "Grace",9 },
            {"Hannah", 9.2 },
            {"Isaac", 8.86 },
        };

    foreach (var score in Score)
{
    if (score.Value >= 9)
    {
        if (score.Value >= 9 && score.Value < 10)
            Console.WriteLine($"Name:{score.Key} Score{score.Value} Ba Enfagh ghabool Shodi!");
    }
    if (score.Value >= 10)
    {
        Console.WriteLine($"Name:{score.Key} Score{score.Value} Eyvaal ghabool Shodi!");
    }


}
    Console.ReadKey();