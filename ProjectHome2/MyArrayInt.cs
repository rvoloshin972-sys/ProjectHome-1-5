using System;
using System.Linq;

namespace ProjectHome2
{
    internal class MyArrayInt : IComparable<MyArrayInt>, IOutput2
    {
        private int[] array;
        public MyArrayInt()
        {
            array = new int[10];
        }
        public MyArrayInt(int[] array)
        {
            this.array = array;
        }
        public int[] ArrayInt
        {
            get { return array; }
            set {array = value ?? array;}
        }
        public int this[int index]
        {
            get
            {
                return (index >= 0 && index < array.Length)
                    ? array[index]
                    : -1;
            }
            set
            {
                array[index] = value;
            }
        }
        public void ShowEven()
        {
            Console.WriteLine("Парні елементи: " +string.Join(", ", array.Where(x => x % 2 == 0)));
        }
        public void ShowOdd()
        {
            Console.WriteLine("Непарні елементи: " +string.Join(", ", array.Where(x => x % 2 != 0)));
        }
        public override bool Equals(object? obj)
        {
            return obj is MyArrayInt arrayInt&& ToString().Equals(arrayInt.ToString());
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
            return "Array: " + string.Join(", ", array);
        }
        public int CompareTo(MyArrayInt? other)
        {
            return other == null
                ? 1
                : array.Length - other.ArrayInt.Length;
        }
    }
}
