using System;
using System.Text;

namespace ProjectHome2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyArrayInt arr = new();
            MyArrayInt arr1 = new(new int[] { 12, 3, 1, 1, 1, 1, 1, 1, 4, 1 });
            Console.WriteLine("Масив arr:");
            Console.WriteLine(arr);
            Console.WriteLine("\nМасив arr1:");
            Console.WriteLine(arr1);

            Console.WriteLine("\nПеревірка інтерфейсу IOutput2:");
            IOutput2 output = arr1;

            output.ShowEven();
            output.ShowOdd();

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
