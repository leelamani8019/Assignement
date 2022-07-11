using System;
using System.Collections.Generic;

public class cricket
{

    // Main Method 
    static public void Main()
    {

        // Creating a dictionary
        // using Dictionary<TKey,TValue> class
        Dictionary<int, string> My_dict1 =
                       new Dictionary<int, string>();

        // Adding key/value pairs 
        // in the Dictionary
        // Using Add() method
        My_dict1.Add(1, "viratkohili");
        My_dict1.Add(2, "sachin");
        My_dict1.Add(3, "GowthamGambir");
        My_dict1.Add(4, "rohith sharama");
        My_dict1.Add(5, "rishabh pant");
        My_dict1.Add(6, "Bhuvneshwar kumar");
        My_dict1.Add(7, "dhoni");
        My_dict1.Add(8, "kl rahul");
        My_dict1.Add(9, "kuldeep");
        My_dict1.Add(10, "jasprit");
        My_dict1.Add(11, "mohammed shami");
        foreach (KeyValuePair<int, string> ele1 in My_dict1)
        {
            Console.WriteLine("{0}.{1}",
                      ele1.Key, ele1.Value);
        }
    }
}