namespace EXAM02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter Subject ID: ");
            int subId;
            while (!int.TryParse(Console.ReadLine(), out subId) || subId < 0)
            {
                Console.WriteLine("Invalid, please enter integer for Subject ID");
            }

            Console.Write($"Enter Subject Name: ");
            string subName = Console.ReadLine();

            Subject sub01 = new Subject(subId, subName);

            Console.WriteLine("Select Type of the Exam: ");
            Console.WriteLine("1 | for Final");
            Console.WriteLine("2 | for Practical");
            int TypeExamchoice;
            while (!int.TryParse(Console.ReadLine(), out TypeExamchoice) || (TypeExamchoice != 1 && TypeExamchoice != 2))
            {
                Console.WriteLine("Invalid, please enter integer 1 for Final Exam and 2 for Practical one");
            }

            Console.Write($"Enter Time of the Exam: ");
            string time = Console.ReadLine();

            Console.Write($"Enter Number of Questions in the Exam: ");
            int numOfQ;
            while (!int.TryParse(Console.ReadLine(), out numOfQ) || numOfQ <= 0)
            {
                Console.WriteLine("Invalid, please enter integer for Number of Questions");
            }

            Exam exam = TypeExamchoice == 1 ? new FinalExam(time, numOfQ) : new PracticalExam(time, numOfQ);


            for (int i = 0; i < numOfQ; i++)
            {
                Console.WriteLine($"Prepare Question {i + 1}");

                int TypeQuestion = 2; 
                if (TypeExamchoice == 1)  // if Final exam , can be MCQ or T/F Questions
                {
                    Console.WriteLine($"Select type of the question: ");
                    Console.WriteLine("1 | for MCQ Q");
                    Console.WriteLine("2 | for True or False Q");
                    while (!int.TryParse(Console.ReadLine(), out TypeQuestion) || (TypeQuestion != 1 && TypeQuestion != 2))
                    {
                        Console.WriteLine("Invalid, Please enter 1 for MCQ, 2 for True or False");
                    }
                }

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();
                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();
                Console.Write("Enter Question Mark: ");
                int mark;
                while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
                {
                    Console.WriteLine("Invalid, Please enter integer number");
                }

                Question question;
                if (TypeQuestion == 1) // if MCQ
                {
                    question = new MCQQ(header, body, mark);   
                    Console.Write("Enter Number of Answer for this Question: ");
                    int NumAnswers;
                    while (!int.TryParse(Console.ReadLine(), out NumAnswers) || NumAnswers <= 0)
                    {
                        Console.WriteLine("Invalid, Please enter integer for number of Answers");
                    }

                    Answer[] answers = new Answer[NumAnswers];

                    for (int j = 0; j < NumAnswers; j++)
                    {
                        Console.Write($"Enter Answer {j + 1}: ");
                        string answerText = Console.ReadLine();
                        answers[j] = new Answer(j + 1, answerText);
                    }

                    question.AnswerList = answers;
                    Console.Write($"Enter ID of the Right Answer: ");
                    int rightAns;
                    while (!int.TryParse(Console.ReadLine(), out rightAns) || rightAns <= 0 || rightAns > NumAnswers)
                    {
                        Console.WriteLine("Invalid, Please enter a valid integer for ID of the right Answer");
                    }

                    question.RightAnswer = rightAns;
                }
                else
                {
                    question = new TrueOrFalseQ(header, body, mark);  // no need for Num of Answers -> alwayes T or F
                    question.AnswerList = new Answer[] { new Answer(1, "True"), new Answer(2, "False") };

                    Console.Write($"Enter ID of the Right Answer 1| for True, 2| for False: ");
                    int rightAns;
                    while (!int.TryParse(Console.ReadLine(), out rightAns) || (rightAns != 1 && rightAns != 2))
                    {
                        Console.WriteLine("Invalid, Please enter integer 1 or 2 for ID of the right Answer");
                    }

                    question.RightAnswer = rightAns;
                }
                exam.Questions[i] = question;
            }

            sub01.CreateEx(exam);
            Console.WriteLine("--------------------------------------------");
            sub01.DisplaySubInfo();
           // exam.ShowEx();

            Console.WriteLine("************************************************************");
            Console.WriteLine("Do you want to start the Exam? Y for Yes , N for No.");
            char choice = char.Parse(Console.ReadLine());

            if (choice == 'Y' || choice == 'y')
            {
                int totalMarks = 0;

                for (int i = 0; i < exam.Questions.Length; i++)
                {
                    Question question = exam.Questions[i];
                    Console.WriteLine($"({question.Header}) {question.Body}");
                    for (int j = 0; j < question.AnswerList.Length; j++)
                    {
                        Answer answer = question.AnswerList[j];
                        Console.WriteLine($"    ({answer.AnswerId}) {answer.AnswerText}");
                    }
                    Console.Write("Enter Your Answer ID: ");
                    int SelectedAnswer;
                    while (!int.TryParse(Console.ReadLine(), out SelectedAnswer) || SelectedAnswer <= 0 || SelectedAnswer > question.AnswerList.Length)
                    {
                        Console.WriteLine("Invalid, please enter ccorrect answer ID");
                    }

                    if (SelectedAnswer == question.RightAnswer)
                    {
                        totalMarks += question.Mark;
                    }
                }

                Console.WriteLine("========================================================");
                Console.WriteLine("Correct Answers:");

                for (int i = 0; i < exam.Questions.Length; i++)
                {
                    Question question = exam.Questions[i];
                    Console.WriteLine($"({question.Header}) {question.Body}");
                    Console.WriteLine($"    Right Answer is : {question.AnswerList[question.RightAnswer - 1].AnswerText}");
                    Console.WriteLine($"Mark: {question.Mark}");
                }

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Exam Time: {exam.Time}");
                Console.WriteLine($"Total Marks: {totalMarks}");
            }
            else
            {
                Console.WriteLine("Good Bye!");
            }
        }
    }
}
