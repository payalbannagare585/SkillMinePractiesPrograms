using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.Crud_collections
{
    public class StudentCollection
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
    }
    public class StudentTransaction
    {
        private List<StudentCollection> StudentList = null;
        private object stud1;

        public StudentTransaction()
        {
            StudentList = new List<StudentCollection>();
        }

        public void AddStudent(StudentCollection stud)
        {
            StudentList.Add(stud);
        }

        public void UpdateStudent(StudentCollection stud)
        {
            foreach (StudentCollection item in StudentList)
            {
                if (item.Id == stud.Id)
                {
                    item.Name = stud.Name;
                    item.Fees = stud.Fees;
                    break;
                }
            }
        }

        public void RemoveStudent(int id)
        {
            foreach (StudentCollection item in StudentList)
            {
                if (item.Id == id)
                {
                    StudentList.Remove(item);
                    break;
                }
            }
        }
        public List<StudentCollection> List()
        {
            return StudentList;
        }



        public void UpdateStudent(int id)
        {
            foreach (StudentCollection item in StudentList)
            {
                if (item.Id == stud1.id)
                {
                    item.Name = stud1.Name;
                    item.Fees = stud1.Fees;

                }
            }
        }

    }
}




