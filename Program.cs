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
            //SList<string> strList = new SList<string>();
            //strList.AddFirst("MSP");//MSP
            //strList.AddFirst("newest");//newest MSP
            //strList.AddLast("BOS");//newest MSP BOS

            //try
            //{
            //    string removed = strList.RemoveFirst();//MSP BOS
            //    Console.WriteLine("Remove: {0}", removed);
            //    Console.WriteLine(strList.First());
            //    string removed1 = strList.RemoveFirst();//BOS
            //    Console.WriteLine("Remove: {0}", removed1);
            //    Console.WriteLine(strList.First());
            //    string removed2 = strList.RemoveFirst();//BOS
            //    Console.WriteLine("Remove: {0}", removed2);
            //    Console.WriteLine(strList.First());
            //}
            //catch (EmptyListException e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            Person p1 = new Person("Enubs", "Ron", "Ibo",
                38, "Samal Island");
            Person p2 = new Person("Li", "Jet", "Hua",
                55, "China");
            Person p3 = new Person("Chan", "Jacky", "Chu",
                60, "Hollywoord");
            Person p4 = new Person("Musk", "Elon", "William",
                50, "America");
            Person p5 = new Person("Putin", "Vladimir", "Jou",
                60, "Russia");

            SList<Person> personsList = new SList<Person>();
            
            personsList.AddFirst(p1);
            DisplayFirst(personsList);
            DisplayLast(personsList);
            Console.WriteLine();

            personsList.AddFirst(p2);
            DisplayFirst(personsList);
            DisplayLast(personsList);
            Console.WriteLine();

            personsList.AddFirst(p3);
            DisplayFirst(personsList);
            DisplayLast(personsList);
            Console.WriteLine();

            personsList.AddLast(p4);
            DisplayFirst(personsList);
            DisplayLast(personsList);
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void DisplayFirst(SList<Person> pList)
        {
            Console.WriteLine("Head: {0}, {1} {2}",
                pList.First().Lastname,
                pList.First().Firstname,
                pList.First().Middlename);
        }

        private static void DisplayLast(SList<Person> pList)
        {
            Console.WriteLine("Last: {0}, {1} {2}",
                pList.Last().Lastname,
                pList.Last().Firstname,
                pList.Last().Middlename);
        }
        
    }
}
