using System;
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

            foreach(string i in name)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
