using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyGenericArray<T> where T:Car
    {

        T[] array;
        //U[] array2;

        public MyGenericArray(int size)
        {
            array = new T[size];
            //array2 = new U[size];
        }

        public T GetValue(int index)
        {
            return array[index];
        }

        public void SetValue(T value, int index)
        {
            array[index] = value;
        }
    }
}
