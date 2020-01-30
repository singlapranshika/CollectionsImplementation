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
            ArrayList arr = new ArrayList();
            arr.Add("hyderabad");
            arr.Add("delhi");
            arr.Add("mumbai");
            arr.Add("chandigarh");
            arr.Add("amritsar");
            Console.WriteLine("****This is System.Collections ArrayList ****");
            foreach (string i in arr)
            {

                Console.WriteLine(i);
            }

        }
    }
}
