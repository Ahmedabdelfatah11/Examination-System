using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
     class PracticalExam:QuestionBase
    {
        int marks;
        string s1;
        public override void HeaderOfTheQuestion()
        {
            Console.WriteLine("Multiple Choices");
        }
        public override void BodyOfTheQuestion()
        {
            Console.WriteLine("Please Enter The Body Of The Question");
           s1= Console.ReadLine();
        }
        public string GetTheBody { get { return s1; } }

        public override int Marks()
        {
            bool Flag = false;
            do
            {
                Console.WriteLine("Please Enter The Marks Of The Question");

                Flag = int.TryParse(Console.ReadLine(), out marks);
            }
            while (!Flag||marks<=0);
            return marks;
        }
        public int GetTheMarks { get { return marks; } }

    }
}
