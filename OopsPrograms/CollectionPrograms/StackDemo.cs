using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.CollectionPrograms
{
    public class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(5);
            stack.Push(30);
            stack.Push(40);
            stack.Push("hello");
           // stack.Push(new Emp { Id = 1, Name = "test", Salary = 2000 });


            //stack.Pop();
            //stack.Pop();
            Console.WriteLine("top element on stack " + stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
        }
    }
