using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecializedCollection
{
    class SpecializedCollection
    {
        static void Main(string[] args)
        {
            StringCollection name = new StringCollection();
            string[] text = new string[] { "hello", "and", "welcome", "to", "epam" };
            name.Add("Name-Pranshika");
            name.Add("College-Chitkara");
            name.Add("State-Punjab");
            name.Add("Degree-B.Tech");
            name.AddRange(text);
            name.Insert(3, "*text Inserted*");
            Console.WriteLine("****This is System.Collections.Specialized StringCollection ****");
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }

            HybridDictionary hyb = new HybridDictionary();
            hyb.Add("name", "Pranshika");
            hyb.Add("degree", "btech");
           hyb.Add("company", "epam");
           ICollection key1 = hyb.Keys;
            Console.WriteLine("****This is System.Collections.Specialized  HybridDictionary ****");
            foreach (string i in key1)
            {
                Console.WriteLine(i);
            }

            OrderedDictionary myOrdered= new OrderedDictionary();
            myOrdered.Add("name", "Pranshika");
            myOrdered.Add("degree", "btech");
            myOrdered.Add("company", "epam");
            ICollection keyCollection = myOrdered.Keys;
            ICollection valueCollection = myOrdered.Values;
            Console.WriteLine("****This is System.Collections.Specialized  OrderedDictionary ****");
            foreach (string i in keyCollection)
            {
                Console.WriteLine(i);
            }

            NameValueCollection namevalue = new NameValueCollection();
            namevalue.Add("name", "Pranshika");
            namevalue.Add("degree", "btech");
            namevalue.Add("company", "epam");
            Console.WriteLine("****This is System.Collections.Specialized  NameValueCollection ****");
            foreach (string i in namevalue.AllKeys)
            {
                Console.WriteLine(i+"   "+namevalue[i]);
            }
        }
    }
}
