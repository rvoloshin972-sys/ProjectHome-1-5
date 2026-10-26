using System;

namespace ProjectHome3
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MyArrayInt arr = new(new int[] { 12, 3, 1, 1, 1, 1, 1, 1, 4, 1 });
            Console.WriteLine("Початковий масив:");
            Console.WriteLine(arr);

            Console.WriteLine();
            Console.WriteLine("Кількість унікальних значень: "+ arr.CountDistinct());
            Console.WriteLine("Кількість елементів, рівних 1: "+ arr.EqualToValue(1));
            Console.WriteLine("Кількість елементів, рівних 12: "+ arr.EqualToValue(12));
            Console.WriteLine("Кількість елементів, рівних 5: "+ arr.EqualToValue(5));

            Console.WriteLine();
            Class1 myClass = new Class1();
            Array.Sort(arr.ArrayInt, myClass);
            Console.WriteLine("Масив за спаданням:");
            Console.WriteLine(arr);
        }
    }
}
