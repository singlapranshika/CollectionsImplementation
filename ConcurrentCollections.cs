using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollection
{
    class ConcurrentCollections

    {
        static void Main(string[] args)
        {
            BlockingCollection<int> block = new BlockingCollection<int>(5);
            block.Add(5);
            block.Add(4);
            block.Add(10);
            block.Add(2);
            block.Add(6);
            if (block.TryAdd(7, TimeSpan.FromSeconds(0.1)))
            {
                Console.WriteLine("Item Added");
            }
            else
            {
                Console.WriteLine("Item Failed");
            }
            Console.WriteLine("****This is System.Collections.Concurrent BlockingCollection  ****");
            foreach (int i in block)
            {
                Console.WriteLine(i);
            }

            ConcurrentDictionary<string, int> cd = new ConcurrentDictionary<string, int>();
            cd.TryAdd("One", 1);
            cd.TryAdd("Two", 2);
            cd.TryAdd("Zero", 0);
            cd.TryAdd("Four", 4);
            Console.WriteLine("****This is System.Collections.Concurrent ConcurrentDictionary  ****");
            foreach (string i in cd.Keys)
            {
                Console.WriteLine(i);
            }

            ConcurrentQueue<string> cq = new ConcurrentQueue<string>();
            cq.Enqueue("One");
            cq.Enqueue("Two");
            cq.Enqueue("Three");
            cq.Enqueue("Four");
            Console.WriteLine("****This is System.Collections.Concurrent ConcurrentQueue  ****");
            foreach (string i in cq)
            {
                Console.WriteLine(i);
            }

            ConcurrentStack<string> cs = new ConcurrentStack<string>();
            cs.Push("One");
            cs.Push("Two");
            cs.Push("Three");
            cs.Push("Four");
            Console.WriteLine("****This is System.Collections.Concurrent ConcurrentStack  ****");
            foreach (string i in cs)
            {
                Console.WriteLine(i);
            }

            ConcurrentBag<string> cb = new ConcurrentBag<string>();
            cb.Add("One");
            cb.Add("Two");
            cb.Add("Three");
            cb.Add("Four");
            Console.WriteLine("****This is System.Collections.Concurrent ConcurrentBag ****");
            foreach (string j in cb)
            {
                Console.WriteLine(j);
            }


        }
    }
}
