using System;
using TestIComparable.Models;

namespace TestIComparable
{
    // The System.IComparable interface specifies a behavior that allows an object to be sorted based on some
    // specified key.Here is the formal definition:
    // This interface allows an object to specify its relationship between other like objects.
    //public interface IComparable
    //{
    //    int CompareTo(object o);
    //}

    class Program
    {
        static void Main()
        {
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);

            PrintCars(myAutos);

            // The System.Array class defines a static method named Sort().
            // When you invoke this method on an array of intrinsic types (int, short, string, etc.),
            // you can sort the items in the array in numeric/alphabetic order,
            // as these intrinsic data types implement IComparable.            
            Array.Sort(myAutos);
            PrintCars(myAutos);

            // Now sort by pet name.
            Array.Sort(myAutos, new PetNameComparer());
            PrintCars(myAutos);

            Console.ReadLine();
        }

        static public void PrintCars(Car[] cars)
        {
            Console.WriteLine("List of cars:");
            foreach (Car c in cars)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            }
            Console.WriteLine();
        }
    }
}
