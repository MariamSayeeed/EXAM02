using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal class Subject
    {

        public int SubjectId { get; set; }
 
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        public Subject(int subId , string subName) 
        {
            SubjectId = subId;
            SubjectName = subName;
        }

        public void CreateEx(Exam exam)
        {
            Exam = exam;
        }

        public void DisplaySubInfo()
        {
            Console.WriteLine($"Subject ID: {SubjectId}  --- Subject NAme: {SubjectName}");
            Exam.ShowEx();
        }

    }
}
