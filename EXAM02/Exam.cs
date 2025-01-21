using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal abstract class Exam
    {
        public string Time { get; set; }
        public int NumberOfQ { get; set; }
        public Question[] Questions { get; set; }// array of qusstions from [Question] class for each Exam
        public Subject ExSubject { get; set; }

        public Exam(string time, int numberOfQ)
        {
            Time = time;
            NumberOfQ = numberOfQ;
            Questions = new Question[NumberOfQ];
        }

        public abstract void ShowEx();
    }
}
