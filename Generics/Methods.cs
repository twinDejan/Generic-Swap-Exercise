using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class Methods <T>
    {
        public static void Swap(ref T right,ref T left)
        {
            T temp;
            temp = right;
            right = left;
            left = temp;
        }

        public static bool Equal(T first, T second)
        {
            if (first.Equals(second))
                return true;
            return false;
        }
    }
}
