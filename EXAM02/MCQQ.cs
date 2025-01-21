using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal class MCQQ : Question
    {
        public MCQQ(string header, string body, int mark): base(header, body, mark)   // chinning
        { 
            // already assigned in Question (Base) class
        }

        public override void ShowQ()
        {
            Console.WriteLine($"({Header}) {Body}");    //-> Q1 : bla bla bla?
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"({i + 1}) {AnswerList[i].AnswerText}");  // (1) ghfhg
                                                                             // (2) ssss
                                                                             // (3) llll
                                                                             
            }
        }

    }
}
