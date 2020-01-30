using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsImplementation
{
    class GenericCollection
    {
       
        public static void Display(List<int> list)
        {
            Console.WriteLine("****This is System.Collections.Generic List<> ****");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
           
            List<int> list = new List<int>();
            list.Add( 3);
            list.Add( 5);
            list.Add( 9);
            list.Add( 1);
            list.Add( 11);
            list.Add( 0);

          
            Display(list);

        }
    }
}
