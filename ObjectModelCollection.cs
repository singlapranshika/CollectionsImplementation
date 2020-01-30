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
            list.Add(1);
            list.Add(11);
            list.Add(0);
            ReadOnlyCollection<int> read = new ReadOnlyCollection<int>(list);
            foreach(int i in read)
            {
                Console.WriteLine(i);
            }
            int[] arr = new int[6];
            read.CopyTo(arr,0);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
