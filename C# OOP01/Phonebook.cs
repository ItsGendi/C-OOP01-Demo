using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP01
{
    internal struct Phonebook
    {
        string[] names;
        long[] numbers;


        public Phonebook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }

        //public void AddPerson(string name, long number, int Index)
        //{
        //    names[Index] = name;
        //    numbers[Index] = number;
        //}

        //public long GetNumber(string name)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i] == name)
        //            return numbers[i];
        //    }
        //    return -1;
        //}

        //public void UpdateNumbers(string name, long newNumber)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i] == name)
        //            numbers[i] = newNumber;
        //    }

        //}

        // Using Indexers
        //public long this[int name] {
        //    get {
        //        for (int i =0; i <names.Length; i++)
        //        {
        //            if (names[i] == name)
        //                return numbers[i];

        //        }
        //        return -1;
        //    }

        //    set {

        //        for (int i = 0; i < names.Length; i++) 
        //        {
        //            if (names[i] ==name)
        //                numbers[i] = value;
        //        }
            
        //    }
        
        //} 
    }
}
