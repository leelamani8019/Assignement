using System;
using System.Collections;

public class States
{
    public static void Main()
    {
        ArrayList mylist = new ArrayList();
        mylist.Add("Delhi");
        mylist.Add("Mumbai");
        mylist.Add("Kolkota");
        mylist.Add("chennai");

        // ArrayList before sorting
        Console.WriteLine("ArrayList before sort:");
        foreach (string i in mylist)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("ArrayList after sort:");

        // sort the ArrayList
        mylist.Sort();

        // ArrayList after sort
        foreach (string i in mylist)
        {
            Console.WriteLine(i);
        }
    }
}