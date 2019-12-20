using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyArray
    {
        int[] array;

        public MyArray(int size)
        {
            array = new int[size];
        }

        public int GetValue(int index)
        {
            return array[index];
        }

        public void SetValue(int value,int index)
        {
            array[index] = value;
        }
    }
}
