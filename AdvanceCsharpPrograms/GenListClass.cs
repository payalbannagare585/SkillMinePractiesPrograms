using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms
{
    public class GenListClass
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            //use of Add element method in List
            li.Add("Mango");
            li.Add("Bannana");
            li.Add("pears");
            li.Add("Apple");

            //adding another list
            List<string> fruits=new List<string>();
            fruits.Add("red berry");
            fruits.Add("black berry");
            fruits.Add("stawberry");

            //use of AddRange method in list

            li.AddRange(fruits);//AddRange use to merge collection in the list

            li.Insert(2, "Watermelleon");//Insert use to insert element in middle of list
            li.Insert(0, "Guva");

            li.Remove("Bannana");//Remove element by value
            li.Remove("Guva");

            li.RemoveAt(4);//Remove element by index

            Console.WriteLine(li.Count());//count current element in the list

            Console.WriteLine(li.Capacity);//count element capacity in the list 

            foreach (string s in li)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("-------------------------------------------------------");
            //use of Contains method

            if (li.Contains("Mango"))
                Console.WriteLine("Mango Present ");
            else
                Console.WriteLine("Mango Not-Present");


            li.Clear();//clear is use to clear all elements from list
        }
    }
}
