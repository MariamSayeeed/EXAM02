using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; } // array of answers from [Answer] class for each qusetion
       // public Answer RightAnswer { get; set; }
        public int RightAnswer { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void ShowQ();

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Question? other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Header ({Header}) , Body: {Body}, Mark: {Mark}";
        }
    }
}
