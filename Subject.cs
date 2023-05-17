using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public void Exam { get; set; }


     

        public Subject(int _id,string _name)
        {
            ID = _id;
            Name = _name;   
        }
            int IDOfQuestion;
            int Typeofquestion;
            int timeofexam;
            int numberofquestion;
            int typeofexam;
        public int TypeOfExam()
        {
            Console.Write("Please Enter the Type Of exam You want to create (1 For Practical 2 for final): ");
            bool Flag = false;
            do
            {
                Flag = int.TryParse(Console.ReadLine(), out IDOfQuestion);
            }
            while (!Flag || (IDOfQuestion < 1 || IDOfQuestion > 2));

            return IDOfQuestion;
        }

        public  void CreateExam()
        {
            Exam exam = new Exam(timeofexam,numberofquestion,numberofquestion, typeofexam, Typeofquestion);
            typeofexam = TypeOfExam();
            int TheChoosenQuestion;
            
            ExamQuestionNumberAndTime();
            Console.Clear();
            if (typeofexam == 1)
            {
                TheChoosenQuestion = TypeOfQuestionForPractical();
            }
            else
                TheChoosenQuestion = TypeOfQuestionForFinal();  
            
        }
        Exam Exam2;

        public int TypeOfQuestionForFinal()
        {
            int[] arr;
            bool Flag = false;
            Exam exam = new Exam(timeofexam,numberofquestion,numberofquestion, typeofexam, Typeofquestion);
            Exam2= exam;
            TFQuestion tFQuestion = new TFQuestion();
            MCQSingleChoice mCQSingle = new MCQSingleChoice();
            for (int i = 0; i <numberofquestion; i++)
            {
                Console.Clear();
                Console.Write($"Please Enter the Type Of Question number ({i+1}) You want to create (1 For TrueOrFalse 2 for MCQ): ");
                do
                {
                    Flag = int.TryParse(Console.ReadLine(), out Typeofquestion);
                }
                while (!Flag || (Typeofquestion < 1 || Typeofquestion > 2));
                if (typeofexam == 2)
                {
                    if (Typeofquestion == 1)
                    {
                        string s;
                        Console.Clear();
                        tFQuestion.HeaderOfTheQuestion();
                            tFQuestion.BodyOfTheQuestion();
                        tFQuestion.Marks();
                        tFQuestion.RightAnswerForTheQuestion();
                        exam.AddTFQuestion(i,tFQuestion.GetTheBody,tFQuestion.GetTheMarks,tFQuestion.GetTheAnswer,tFQuestion.GetTheRightAnswerInName);
                    }
                    else
                    {
                        Console.Clear();
                        mCQSingle.HeaderOfTheQuestion();
                        mCQSingle.BodyOfTheQuestion();
                        mCQSingle.Marks();
                        mCQSingle.ChoicesOfQuestion();
                        exam.MCQSingleChoice(i, mCQSingle.GetTheBody, mCQSingle.GetTheMarks, mCQSingle.GetTheRightAnswer,mCQSingle.GetTheChoices,mCQSingle.GetTheRightAnswerinName);
                          
                    }
                }
            }
            //exam.FinalExamQuestions();
            return Typeofquestion;
        }
       
        public int TypeOfQuestionForPractical()
        {
            Exam exam = new Exam(timeofexam, numberofquestion, numberofquestion, typeofexam, Typeofquestion);
            Exam2 = exam;
            int[] arr;
            //bool Flag = false;
            for (int i = 0; i < numberofquestion; i++)
            {
                Console.Clear();
                MCQMultipleChoices mCQMultipleChoices = new MCQMultipleChoices();
                mCQMultipleChoices.HeaderOfTheQuestion();
                mCQMultipleChoices.BodyOfTheQuestion();
                mCQMultipleChoices.Marks();
                mCQMultipleChoices.ChoicesOfQuestion();
                exam.MCQSMultipleChoice(i, mCQMultipleChoices.GetTheBody, mCQMultipleChoices.GetTheMarks, mCQMultipleChoices.GetTheRightAnswer,mCQMultipleChoices.GetTheRightAnswer2 ,mCQMultipleChoices.GetTheChoices,mCQMultipleChoices.GetTheRightAnswerinname1,mCQMultipleChoices.GetTheRightAnswerinname2);

            }
            return Typeofquestion;
        }
        public void showExam()
        {
            if (typeofexam == 1)
            {
                Exam2.PracticalExamQuestions();
                Exam2.showPracticalExam();
            }
            else
            {
                Exam2.FinalExamQuestions();
                Exam2.showFinalExam();
            }
        }

        public void TimeOfExam()
        {
            bool Flag = false;
            do
            {
            Console.Write("Please Enter The Time Of Exam In Minutes: ");
                Flag = int.TryParse(Console.ReadLine(), out timeofexam);
            }
            while (!Flag || (timeofexam <=0));
           
        } 
        public void NumberOfQuestiosn()
        {

            bool Flag = false;
            do
            {
            Console.Write("Please Enter The Number Of Questions You Want To Create: ");
                Flag = int.TryParse(Console.ReadLine(), out numberofquestion);
            }
            while (!Flag || (numberofquestion<=0));
        }
        public void ExamQuestionNumberAndTime()
        {
            TimeOfExam();
            NumberOfQuestiosn();
        }
         
    }
 }

