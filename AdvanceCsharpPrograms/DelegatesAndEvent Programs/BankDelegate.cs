using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.DelegatesAndEvent_Programs
{
    public delegate void MyDel5();
    public class BankDelegate
    {

        public event MyDel5 Insufficient;
        public event MyDel5 Zerobalance;
        public int accbalance;
      
        public int amount;

        public BankDelegate(int accbalance)
        {
            this.accbalance = accbalance;
            
        }

        public void Debit(int amount)
        {
            if (amount>accbalance)
            {
                Insufficient();

            }
            else
            {
                accbalance = accbalance - amount;

                if (accbalance == 0)
                {

                    Zerobalance();
                }

               

              
            }
        }

        public void Credit(int amount)
        {
            accbalance = accbalance + amount;
           
        }
        public override string ToString()
        {
            return $"Current Balance is{accbalance}";
        }

        public static class Message
        {
            public static void InsufficientMessage()
            {
                Console.WriteLine("Insufficient Balance....");
            }

            public static void ZerobalanceMessage()
            {
                Console.WriteLine("Zero Balance....");
            }
        }

        public static void Main(String[] args)
        {
            BankDelegate b = new BankDelegate(5000);
            b.Insufficient += new MyDel5(Message.InsufficientMessage);
            b.Zerobalance += new MyDel5(Message.ZerobalanceMessage);

            Console.WriteLine("Credit of 1000");
            b.Credit(1000);

            Console.WriteLine("Debit of 15000");
            b.Debit(15000);

            Console.WriteLine("debit of 6000");
            b.Debit(6000);

        }

    }
}
