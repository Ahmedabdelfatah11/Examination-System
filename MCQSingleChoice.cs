using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class MCQSingleChoice : FinalExam
    {
        string s1, s2, s3,s4,s5;
        public override void HeaderOfTheQuestion()
        {
            Console.WriteLine("Choose one Answer Question");
        }

            int Answer;
        public void ChoicesOfQuestion()
        {
            bool flag1 = false, flag2 = false;
            Console.WriteLine("The Choices Of Question");
            Console.Write("Please Enter the Choise Number 1: ");
           s1= Console.ReadLine();
            Console.Write("Please Enter the Choise Number 2: ");
           s2=  Console.ReadLine();
            Console.Write("Please Enter the Choise Number 3: ");
           s3=  Console.ReadLine();
            s4 = ($"{s1}         {s2}           {s3}");
            do
            {
                Console.WriteLine("Please Specify the right answer of the Question in Numbers");
                flag1 = int.TryParse(Console.ReadLine(), out Answer);
            }
            while (!flag1||Answer>3||Answer<1);
            if (Answer == 1)
                s5 = s1;
            else if (Answer == 2)
                s5 = s2;
            else
                s5 = s3;
        }

        public string GetTheChoices { get {return s4; } }
        public string GetTheRightAnswerinName { get {return s5; } }
        public int GetTheRightAnswer { get { return Answer; } }

    }
}
