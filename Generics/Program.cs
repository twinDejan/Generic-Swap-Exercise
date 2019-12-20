using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(5);
            myArray.SetValue(1, 0);
            myArray.SetValue(2, 1);
            myArray.SetValue(3, 2);
            myArray.SetValue(4, 3);
            myArray.SetValue(5, 4);

            //Console.WriteLine(myArray.GetValue(3));

            //MyGenericArray<string> myGenericArray = new MyGenericArray<string>(5);

            MyGenericArray<Car> myCars = new MyGenericArray<Car>(10);

            Car car = new Car();
            car.Name = "Volkswagen";

            //myGenericArray.SetValue("Dejan", 0);

            //Here the value of Volkswagen is set to myCar(0)
            myCars.SetValue(car, 0);
            //Console.WriteLine(myGenericArray.GetValue(0));
            Console.WriteLine(myCars.GetValue(0).Name);

            int a = 1;
            int b = 2;

            Car newCar = new Car();
            newCar.Name = "Audi";

            Console.WriteLine("Cars Before Swap");
            Console.WriteLine("1. {0} 2. {1}",car.Name,newCar.Name);
            Console.WriteLine("Integers Before Swap");
            Console.WriteLine("1. {0} 2. {1}", a,b);

            Methods<Car>.Swap(ref car,ref newCar);
            Methods<int>.Swap(ref a,ref b);

            Console.WriteLine("Cars After Swap");
            Console.WriteLine("1. {0} 2. {1}", car.Name, newCar.Name);
            Console.WriteLine("Integers After Swap");
            Console.WriteLine("1. {0} 2. {1}", a, b);

            if(Methods<Car>.Equal(car,newCar))
                Console.WriteLine("That means cars are still the same");
            else
                Console.WriteLine("That means cars are changed ");

            Console.ReadLine();
        }
    }
}
