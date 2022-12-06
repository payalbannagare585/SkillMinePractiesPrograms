using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public  class StudentInfo
    {
        public string studName;
        public int studRollNo;
        public int maths;
        public int physics;
        public int chemistry;
        public int biology;
        public int english;

        public StudentInfo(string studName,int studRollNo,int maths,int physics,int chemistry,int biology,int english) 
        { 
            this.studName = studName;
            this.studRollNo= studRollNo;    
            this.maths = maths;
            this.physics = physics; 
            this.chemistry = chemistry;
            this.biology = biology;
            this.english = english;


        }

        public int CalculatePercentage()
        {
            int totalMarks=maths+physics+chemistry+biology+english;
            int percentage = (totalMarks * 100) / 500;

            Console.WriteLine($"Student Name is: {studName}");
            Console.WriteLine($"Student Roll Number is: {studRollNo}");

            Console.WriteLine($"Obtain marks in Maths subject is: {maths}");
            Console.WriteLine($"Obtain marks in Physics subject is: {physics}");
            Console.WriteLine($"Obtain marks in chemistry subject is: {chemistry}");
            Console.WriteLine($"Obtain marks in Biology subject is: {biology}");
            Console.WriteLine($"Obtain marks in English subject is: {english}");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine($"Total Marks is: {totalMarks}");
            Console.WriteLine($"Obtain Percentage is: ");
            return percentage;
             

        }


    }
}
