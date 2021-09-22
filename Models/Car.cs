using System;
using System.Collections;

namespace TestIComparable.Models
{
    public class Car : IComparable
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int CarID { get; set; }

        public Car(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            PetName = name;
            CarID = id;
        }

        // Version 1
        // IComparable implementation.
        //int IComparable.CompareTo(object obj)
        //{
        //    if (obj is Car temp)
        //    {
        //        if (this.CarID > temp.CarID)
        //        {
        //            return 1;
        //        }
        //        if (this.CarID < temp.CarID)
        //        {
        //            return -1;
        //        }
        //        return 0;
        //    }
        //    throw new ArgumentException("Parameter is not a Car!");
        //}

        // Version 2
        int IComparable.CompareTo(object obj)
        {
            if (obj is Car temp)
            {
                return this.CarID.CompareTo(temp.CarID);
            }
            throw new ArgumentException("Parameter is not a Car!");
        }
    }

    ///////////////////////////////////////////////////////////////////////////////
    // A general way to compare two objects.
    ///////////////////////////////////////////////////////////////////////////////
    //interface IComparer
    //{
    //    int Compare(object o1, object o2);
    //}
    ///////////////////////////////////////////////////////////////////////////////
    
    public class PetNameComparer : IComparer
    {
        // Test the pet name of each object.
        int IComparer.Compare(object o1, object o2)
        {
            if (o1 is Car t1 && o2 is Car t2)
            {
                return string.Compare(t1.PetName, t2.PetName, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
        }
    }
}