using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModelCollection
{
    class ObjectModelCollection
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(5);
            list.Add(9);
            list.Add(4);
            list.Add(11);
            list.Add(0);
            ReadOnlyCollection<int> read = new ReadOnlyCollection<int>(list);
            Console.WriteLine("****This is System.Collections.ObjectModel ReadOnlyCollection ****");
            foreach (int i in read)
            {
                Console.WriteLine(i);
            }
            //int[] arr = new int[6];
            //read.CopyTo(arr,0);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            ObservableCollection<int> observe = new ObservableCollection<int>(list);
            Console.WriteLine("****This is System.Collections.ObjectModel ObservableCollection ****");
         
                foreach (int i in observe)
            {
                Console.WriteLine(i);
            }

            ReadOnlyObservableCollection<int> readobserve = new ReadOnlyObservableCollection<int>(observe);
            Console.WriteLine("****This is System.Collections.ObjectModel ReadOnlyObservableCollection ****");

            foreach (int i in readobserve)
            {
                Console.WriteLine(i);
            }
        }
    }
}
