using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCollections
{
    class OCollections
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList();
            arrayList.Add("hyderabad");
            arrayList.Add("delhi");
            arrayList.Add("mumbai");
            arrayList.Add("chandigarh");
            arrayList.Add("amritsar");
            Console.WriteLine("****This is System.Collections ArrayList ****");
            foreach (string i in arrayList)
            {

                Console.WriteLine(i);
            }

            Hashtable hash = new Hashtable();
            hash.Add("One", 1);
            hash.Add("Two", 2);
            hash.Add("Three", 3);
            hash.Add("Four", 4);
            Console.WriteLine("****This is System.Collections HashTable ****");
            ICollection key = hash.Keys;
            foreach(string i in key)
            {
                Console.WriteLine(i);
            }

            SortedList sortl = new SortedList();
            sortl.Add("Two", 2);
            sortl.Add("Three", 3);
            sortl.Add("zero", 0);
            sortl.Add("Eleven", 11);
           sortl.Add("Ten", 10);
            Console.WriteLine("****This is System.Collections SortedList ****");
            ICollection key1 = sortl.Keys;
            foreach (string i in key1)
            {
                Console.WriteLine(i);
            }

            Stack st = new Stack();
            st.Push("hello");
            st.Push("and");
            st.Push("welcome");
            st.Push("to");
            st.Push("epam");
            st.Pop();
            st.Pop();
            Console.WriteLine("****This is System.Collections Stack ****");
            foreach (string c in st)
            {
                Console.WriteLine(c);
            }

            Queue q = new Queue();
            q.Enqueue('E');
            q.Enqueue('P');
            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('S');
            q.Dequeue();
            Console.WriteLine("****This is System.Collections Queue ****");
            foreach (char c in q)
            {
                Console.WriteLine(c);
            }

            BitArray b = new BitArray(5);
            BitArray ab = new BitArray(5);
            byte[] b1 = { 10 };
            byte[] b2 = { 40 };
            b= new BitArray(b1);
            ab = new BitArray(b2);

            BitArray bAND = new BitArray(5);
            bAND=b.And (ab);
            Console.WriteLine("****This is System.Collections BitArray ****");
            for (int i=0;i<ab.Count;i++)
            {
                Console.WriteLine(bAND[i]);
                Console.WriteLine(b.Length+" "+b.Count);
            }

        }
    }
}
