using System.Collections.Generic;
using System.Text;

namespace ProjectHome1
{
    internal class Class1 : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}
