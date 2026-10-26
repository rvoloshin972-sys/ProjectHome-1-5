using System.Collections.Generic;

namespace ProjectHome2
{
    internal class Class1 : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}
