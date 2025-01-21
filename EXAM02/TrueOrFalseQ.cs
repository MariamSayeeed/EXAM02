using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal class TrueOrFalseQ : Question
    {
        public TrueOrFalseQ(string header, string body, int mark) : base( header, body, mark)  // chinning
        {
            // already assigned in Question (Base) class
        }

        public override void ShowQ()
        {
            Console.Write($"{Header}) {Body} ?   ");     
            Console.WriteLine(" Answer 1 for True || 2 for False");
                                                
                                    // Q1) dmnklsnkdndnk
                                    // 
        }
    }
}
