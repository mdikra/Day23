using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class SortedList
    {
        //Adding values to sorted list
        public static void SortedListDemo()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");
            Console.WriteLine("SortedList are ", numberNames);


            //sorted list default sorting order
            SortedList<int, string> numberName = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberName)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberName.Add(6, "Six");
            numberName.Add(2, "Two");
            numberName.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberName)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


        }
    }
}