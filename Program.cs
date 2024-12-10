using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 32, 22, 55, 48, 26, 54, 98 };

        // Сума чисел
        int sum = numbers.Sum();
        Console.WriteLine($"Сума чисел: {sum}");

        // Різниця чисел
        int difference = numbers.Aggregate((a, b) => a - b);
        Console.WriteLine($"Різниця чисел: {difference}");
    }
}
