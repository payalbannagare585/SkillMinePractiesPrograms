using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.CollectionPrograms
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue("payal");
            queue.Enqueue(34.09);
            queue.Enqueue(89457958459);


            queue.Dequeue();

            Console.WriteLine("first element in queue " + queue.Peek());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

    }
}
