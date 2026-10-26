using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyArrayInt arr = new();
            MyArrayInt arr1 = new(new int[] { 12, 3, 1, 1, 1, 1, 1, 1, 4, 1 });

            Console.WriteLine("Масив arr:");
            Console.WriteLine(arr);
            Console.WriteLine("\nМасив arr1:");
            Console.WriteLine(arr1);

            ICalc calc = arr1;
            int valueToCompare = 3;

            Console.WriteLine
            (
                $"\nКількість елементів, менших за {valueToCompare}: " +
                calc.Less(valueToCompare)
            );
            Console.WriteLine
            (
                $"Кількість елементів, більших за {valueToCompare}: " +
                calc.Greater(valueToCompare)
            );
            Console.WriteLine("\nПеревірка CompareTo:");
            Console.WriteLine
            (
                arr.CompareTo(arr1) == 0
                    ? "arr == arr1 (Length)"
                    : "Довжини масивів відрізняються"
            );
            Console.WriteLine("\nСортування масиву за спаданням:");
            Array.Sort(arr1.ArrayInt, new Class1());
            Console.WriteLine(arr1);
        }
    }
}
