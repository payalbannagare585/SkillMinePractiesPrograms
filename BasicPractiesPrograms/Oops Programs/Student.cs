using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.Oops_Programs
{
    internal class Student
    {
        public int studId;
        public string studName;
        protected string clgName;
        protected string branchName;
        private string studResult;

        public Student(int studId, string studName, string clgName, string branchName, string studResult)
        {
            this.studId = studId;
            this.studName = studName;
            this.clgName = clgName;
            this.branchName = branchName;
            this.studResult = studResult;
        }

        public void Display()
        {
            Console.WriteLine("Student Id:"+studId + "\nStudent Name: " + studName+"\nCollege Name:"+ clgName+"\nBranch Name: "+ branchName+"\nStudent Result: "+ studResult);
        }

    
    }
    public class StudentInfo
    {
        static void Main(String[]args)
        {
           Student s = new Student(101,"payal Bannagare","PRMIT&R","MCA","Pass");
            s.Display();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("**PUBLIC DATA MEMBER ACCESS OUTSIDE THE CLASS**");
            Console.WriteLine(s.studName);
            Console.WriteLine(s.studId);


        }
    }
}
