using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
     class MCQMultipleChoices:PracticalExam
    {
        string s1, s2,s3,s4,s5,s6;
            int Answer1, Answer2=-1;
        public void ChoicesOfQuestion()
        {
            bool flag1 = false, flag2 = false;
            Console.WriteLine("The Choices Of Question");
            Console.Write("Please Enter the Choise Number 1: ");
            s1 = Console.ReadLine();
            Console.Write("Please Enter the Choise Number 2: ");
            s2 = Console.ReadLine();
            Console.Write("Please Enter the Choise Number 3: ");
            s3 = Console.ReadLine();
            s4 = ($"{s1}         {s2}           {s3}");
            do
            {
                Console.WriteLine("Please Specify the right answers of the Question in Numbers");
                flag1 = int.TryParse(Console.ReadLine(), out Answer1);
            }
            while (!flag1||Answer1>3||Answer1<1);
            if (Answer1 == 1)
                s5 = s1;
            else if (Answer1 == 2)
                s5 = s2;
            else
                s5 = s3;
            Console.WriteLine("Do you want to choose another answer y|n");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                do
                {
                    Console.WriteLine("Please Specify the second right answers of the Question in numbers");
                    flag2 = int.TryParse(Console.ReadLine(), out Answer2);
                }
                while (!flag2 || Answer2 > 3 || Answer2 < 1||Answer2==Answer1);
                if (Answer2 == 1)
                    s6 = s1;
                else if (Answer2 == 2)
                    s6 = s2;
                else
                    s6 = s3;
            }
        }


        public string GetTheChoices { get { return s4; } }
        public string GetTheRightAnswerinname1 { get { return s5; } }
        public string GetTheRightAnswerinname2 { get { return s6; } }

        public int GetTheRightAnswer { get { return Answer1; } }
            public int GetTheRightAnswer2 { get { if (Answer2 != -1) return Answer2; else return -1; } }

    }
    }

