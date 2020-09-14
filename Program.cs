using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SList<string> strList = new SList<string>();
            strList.AddFirst("MSP");//MSP
            strList.AddFirst("newest");//newest MSP
            strList.AddLast("BOS");//newest MSP BOS
            
            try
            {
                string removed = strList.RemoveFirst();//MSP BOS
                Console.WriteLine("Remove: {0}", removed);
                Console.WriteLine(strList.First());
                string removed1 = strList.RemoveFirst();//BOS
                Console.WriteLine("Remove: {0}", removed1);
                Console.WriteLine(strList.First());
                string removed2 = strList.RemoveFirst();//BOS
                Console.WriteLine("Remove: {0}", removed2);
                Console.WriteLine(strList.First());
            }
            catch(EmptyListException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
