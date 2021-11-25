using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class List
    {
        public static void ListDemo()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Insert(2, 11);
            primeNumbers.Remove(3);
            primeNumbers.Contains(5);
            Console.WriteLine("list contains element  ", primeNumbers);
            foreach (int element in primeNumbers)
            {
                Console.WriteLine("The prime numbers are " + element);
            }







        }
    }
}