using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
     class TFQuestion:FinalExam
    {
        string s;
        int Answer;
        public override void HeaderOfTheQuestion()
        {
            Console.WriteLine("TRUE or False Question");
        }
     
        public void RightAnswerForTheQuestion()
        {
            bool flag1 = false;
            do
            {
            Console.WriteLine("Please Enter the Right Answer of Question (1 For True and 2 For False) ");
                flag1 = int.TryParse(Console.ReadLine(), out Answer);
            }
            while (!flag1||Answer>2||Answer<1);
            if (Answer == 1)
                s = "True";
            else
                s = "false";
        }
        public int GetTheAnswer { get { return Answer; }  }
        public string GetTheRightAnswerInName { get { return s; } }
    }
}
