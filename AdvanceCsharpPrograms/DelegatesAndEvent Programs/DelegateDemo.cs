using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.DelegatesAndEvent_Programs
{
    public class DelegateDemo
    {
        public delegate int Mydel1(int n1, int n2);
        public delegate string Mydel2(string s);

        public class Test
        {
            public int M1(int a, int b)
            {
                return a + b;
            }

            public int M3(int a, int b)
            {
                return a * b;
            }

            public int M4(int a, int b)
            {
                return a - b;
            }
            public string M2(string name)
            {
                return name.ToUpper();
            }


            public static void Main(string[] args)
            {

                Test t1 = new Test();
                Mydel1 d1 = new Mydel1(t1.M1);//added the method referance

                d1 += new Mydel1(t1.M1);
                d1 += new Mydel1(t1.M4);

                Delegate[] list = d1.GetInvocationList();

                foreach(Delegate items in list)
                {
                    Console.WriteLine(items.Method);
                    Console.WriteLine(items.DynamicInvoke(76, 32));
                }

                Mydel2 d2 = new Mydel2(t1.M2);

                string str = d2.Invoke("THINK QUEOTIENT");

                Console.WriteLine(str);
            }
        }
    }
}
