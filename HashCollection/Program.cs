// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace hash
{
    class Hashcollection
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid",1011);
            ht.Add("EName","Scott");
            ht.Add("job","Manager");
            ht.Add("Salary","25422500  ");
            ht.Add("Mgrid",1002);
            ht.Add("Phone","2345677689");
            ht.Add("Email","scott@gmail.com");
            ht.Add("Dname","Sales");
            ht.Add("Location","Mumbai");
            ht.Add("Did",23);
            //Console.WriteLine(ht["Email"]);
           //Console.WriteLine("hello".GetHashCode());
            foreach(object key in ht.Keys)
                Console.WriteLine(key +":" +ht[key]);
            Console.ReadLine();
        }
    }
}