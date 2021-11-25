using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Collections
{
    class Dictionary
    {
        public static void DictionaryDemo()
        {
            //Creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                                          {"UK", "London, Manchester"},
                                          {"USA", " New York, San Franciso"},
                                          {"India", "Chennai, New Delhi"}
        };
            //ElementAt-Get a KeyValuePair from the specified index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
            }

            //Modified the value with the help of key 
            cities["USA"] = "Los Angeles, Boston";

            Console.WriteLine("\nThe modified key-value pair of USA\n");
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
            }
        }

    }
}