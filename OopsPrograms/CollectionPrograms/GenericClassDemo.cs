using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.CollectionPrograms
{
   
    
        public class GenericClassDemo<T>
        {
            private T data;

            public void Add(T data)
            {
                this.data = data;
            }

            public T Print()
            {
                return data;
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
               GenericClassDemo<int> obj1 = new GenericClassDemo<int>();
                obj1.Add(100);

                Console.WriteLine(obj1.Print());


           
            }


        }




    }

