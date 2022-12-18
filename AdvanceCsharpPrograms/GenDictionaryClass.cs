using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms
{
    public class GenDictionaryClass
    {
        public static void Main(string[]args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            //add elements in dictionary in the key value pair
            dic.Add(3, "mango");
            dic.Add(4, "banana");
            dic.Add(5, "berry");
            dic.Add(7, "Stawberry");
            dic.Add(8, "guva");

       

            dic.Remove(5);//Remove element of 5 value

            if (dic.ContainsValue("guva"))//use element value is present in the dictionary or not 
                Console.WriteLine("guva is present");
            else
                Console.WriteLine("guva is not present");

            Console.WriteLine("-------------------------------------------");

            if (dic.ContainsKey(5))//Containskey is use to find key is present or not 
                Console.WriteLine("Element 5 is present");
            else
                Console.WriteLine("Element 5 is not present");


            Console.WriteLine(dic.TryGetValue( 8, out string str));//get the value of specific key

        


            foreach(var item in dic)
            {
                Console.WriteLine(item);
            }
            dic.Clear();//remove all pairs from the dictionary 

        }
    }
}
