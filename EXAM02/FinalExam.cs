using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal class FinalExam: Exam
    {
        public FinalExam(string time, int numberOfQ) : base(time, numberOfQ)
        { }

        public override void ShowEx()
        {
            Console.WriteLine("--------------- Final Exam --------------");
            Console.WriteLine($"Time: {Time} --- Number of Questions: {NumberOfQ}");
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].ShowQ();  
                Console.WriteLine($"Grade: {Questions[i].Mark}");
            }
        }
    }
}
