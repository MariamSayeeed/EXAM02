using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal class Answer: ICloneable
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"->AnswerId: ({AnswerId}) AnswerText: {AnswerText}";
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
