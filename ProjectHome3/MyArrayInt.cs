using System;
using System.Linq;

namespace ProjectHome3
{
    internal class MyArrayInt : IComparable<MyArrayInt>, ICalc2
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
            set { array = value ?? array; }
        }
        public int this[int index]
        {
            get { return index >= 0 && index < array.Length ? array[index] : -1; }
            set { array[index] = value; }
        }
        public int CountDistinct()
        {
            return array.Distinct().Count();
        }
        public int EqualToValue(int valueToCompare)
        {
            return array.Count(x => x == valueToCompare);
        }
        public override bool Equals(object? obj)
        {
            return obj is MyArrayInt arrayInt && ToString().Equals(arrayInt.ToString());
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
            return other is null ? 1 : array.Length - other.ArrayInt.Length;
        }
    }
}
