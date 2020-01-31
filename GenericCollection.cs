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
        static void Main(string[] args)
        {
           
            List<int> list = new List<int>();
            list.Add( 3);
            list.Add( 5);
            list.Add( 9);
            list.Add( 1);
            list.Add( 11);
            list.Add( 0);
            int x = list.Count;
            Console.WriteLine("****This is System.Collections.Generic List  ****");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            IDictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("name", "pranshika");
            string result;
            dict.Add(new KeyValuePair<string,string>("college", "chitkara"));
            dict.Add("degree", "btech");
            dict.Add("company", "epam");
            foreach(KeyValuePair<string,string>item in dict )
            {
                Console.WriteLine(item.Key + " " + item.Value);
                dict.TryGetValue("name", out result);
                //Console.WriteLine("result= "+result);
                //Console.WriteLine(dict.ContainsKey("degree"));

            }

            SortedList< string,int?> mySortedList = new SortedList< string,int?>();
            mySortedList.Add("Two", 2);
            mySortedList.Add("Three", 3);
            mySortedList.Add("zero", 0);
            mySortedList.Add("Eleven", 11);
            mySortedList.Add("Ten", null);
            Console.WriteLine("****This is System.Collections.Generic SortedList  ****");
            foreach (KeyValuePair<string, int?> k in mySortedList)
            {
                Console.WriteLine(k.Key, k.Value);
                //Console.WriteLine(mySortedList.Count);

            }


            HashSet<int> hashs = new HashSet<int>();
            hashs.Add(1);
            hashs.Add(2);
            hashs.Add(3);
            hashs.Add(1);
            hashs.Add(2);
            Console.WriteLine("****This is System.Collections.Generic Hashset ****");
            foreach (int i in hashs)
            {
                Console.WriteLine(i);
            }


            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(2);
            q1.Enqueue(4);
            
            Console.WriteLine("****This is System.Collections.Generic Queue ****");
            foreach (int i in q1)
            {
                Console.WriteLine(i);
            }

            Stack<string> st = new Stack<string>();
            st.Push("hello");
            st.Push("and");
            st.Push("welcome");
            st.Push("to");
            st.Push("epam");
            st.Pop();
            st.Pop();
            Console.WriteLine("****This is System.Collections.Generic Stack ****");
            foreach (string c in st)
            {
                Console.WriteLine(c);
            }
        }
    }
}
