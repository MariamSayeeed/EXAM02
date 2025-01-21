using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal class PracticalExam :Exam
    {

        public PracticalExam(string examTime, int numberOfQ) : base(examTime, numberOfQ) { }

        public override void ShowEx()
        {
            Console.WriteLine("---------------- Practical Exam --------------");
            Console.WriteLine($"Time: {Time} --- Number of Questions: {NumberOfQ}");

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].ShowQ();
                Console.WriteLine($"Answer) {Questions[i].RightAnswer}");
                            // ex-> Right Answer)  3

            }
        }
    }
}
