using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.Crud_collections
{
    public class StudentProgramStart
    {
        public static void Main(string[] args)
        {
            StudentTransaction stud=new StudentTransaction();
            StudentCollection std1= new StudentCollection();
            Console.WriteLine("Enter Student Id: ,Student Name: ,Student Fees: ");

       

            StudentCollection s1= new StudentCollection();  
            s1.Id=Convert.ToInt32(Console.ReadLine());  
            s1.Name=Convert.ToString(Console.ReadLine());
            s1.Fees=Convert.ToInt32(Console.ReadLine());

            stud.AddStudent(s1);

            Console.WriteLine("Enter Student Id: ,Student Name: ,Student Fees: ");
            StudentCollection e2= new StudentCollection();
            e2.Id=Convert.ToInt32(Console.ReadLine());
            e2.Name=Convert.ToString(Console.ReadLine());   
            e2.Fees=Convert.ToInt32(Console.ReadLine());    

            stud.AddStudent(e2);

            List<StudentCollection> studlist = stud.List();
            foreach(StudentCollection item in studlist)
            {
                Console.WriteLine($"{item.Id}  {item.Name} {item.Fees}");

            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Enter Student Id to Remove");
            int id=Convert.ToInt32(Console.ReadLine());
            stud.RemoveStudent(id);

            studlist=stud.List();
            foreach(StudentCollection item in studlist)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Fees}");
            }

            Console.WriteLine("Enter student Id to modify: ");

            id = Convert.ToInt32(Console.ReadLine());
            stud.UpdateStudent(id);

            studlist = stud.List();

            foreach (StudentCollection item in studlist)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Fees}");
            }


        }
    }
}
