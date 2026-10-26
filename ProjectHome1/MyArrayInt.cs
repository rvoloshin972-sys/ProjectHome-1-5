using System;

namespace ProjectHome1
{
    internal class MyArrayInt : IComparable<MyArrayInt>, ICalc
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
        public int Less(int valueToCompare)
        {
            return Array.FindAll(array, x => x < valueToCompare).Length;
        }
        public int Greater(int valueToCompare)
        {
            return Array.FindAll(array, x => x > valueToCompare).Length;
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
