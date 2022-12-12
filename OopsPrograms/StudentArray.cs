using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class StudentArray
    {
         public int id;
         public string name;
         public StudentArray(int id,string name)
        {
            this.id=id;
            this.name = name;
        }

        public static void Main(string[] args)
        {
            StudentArray[] studentArrays = new StudentArray[]
           {

                new StudentArray(123, "vaishnavi"),
                new StudentArray(135,"Payal"),
                new StudentArray(145,"kajal")
                  

            };

            foreach(StudentArray studentArray in studentArrays) 
            {
                Console.WriteLine("Student id: "+studentArray.id+"  " +"Student Name: " +studentArray.name);
               
            }
        }
    }
}
