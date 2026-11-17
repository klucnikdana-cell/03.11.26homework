using System;
using System.Collections.Generic;
using System.Text;

namespace _03._11._26_homework_
{
    internal class Swap
    {
        public void SwapChange<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
