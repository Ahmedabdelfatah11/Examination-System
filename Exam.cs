using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
     class Exam:QuestionList
    {

       public int timeofexam;
       public int numberofquestion;
        int grade;

        int size;   
       public Exam(int _Timeofexam,int _NumberOfQuestion,int _size,int _Typeofexam,int _TypeOfQuestion) :base(_size, _Typeofexam, _TypeOfQuestion)
        {
            timeofexam = _Timeofexam;
           numberofquestion = _NumberOfQuestion;
        }



        public virtual void FinalExamQuestions()
        {
            Console.Clear();
            for (int i = 0; i < questionlist.Length; i++)
            {
                int answer1, answer2;
                bool flag1 = false, flag2 = false;
                Answers answers = new Answers(questionlist.Length);
                Console.WriteLine(Header[i]);
                Console.WriteLine(questionlist[i]);
                if (Header[i] == "True | False Question")
                {
                    TotalGrade += marks[i];
                    Console.WriteLine($"1.True      2.False            Marks({marks[i]})   ");
                    do
                    {
                        Console.WriteLine("Please Enter the right Answer");
                        flag1 = int.TryParse(Console.ReadLine(), out answer1);
                    } while (!flag1);
                    answers[Header[i]] = answer1;
                    Console.WriteLine("------------------------");
                    if (answer1 == AnswersFinal[i])
                        StudentGrade += marks[i];
                }
                else
                {
                    TotalGrade += marks[i];
                    Console.WriteLine($"{MCQSingleChoiceChoices[i]}                 Marks({marks[i]})");
                    do
                    {
                        Console.WriteLine("Please Enter the right Answer");
                        flag2 = int.TryParse(Console.ReadLine(), out answer2);
                    } while (!flag2);
                    answers[Header[i]] = answer2;
                    Console.WriteLine("------------------------");
                    if (answer2 == AnswersFinal[i])
                        StudentGrade += marks[i];
                }
                Console.WriteLine("=============================");
            }
        }

        public virtual void PracticalExamQuestions()
        {
            Console.Clear();
            int answer1, answer2;
            int id;
            bool flag = false;
            Answers answers = new Answers(questionlist.Length);
            Answers answers2 = new Answers(questionlist.Length);

            for (int i = 0; i < questionlist.Length; i++)
            {
                id = i;
                Console.WriteLine(Header[i]);
                Console.WriteLine(questionlist[i]);
                Console.WriteLine($"{MCQMultipleChoiceChoices[i]}              marks ({marks[i]}");
                Console.WriteLine("------------------------");
                do
                {
                    Console.WriteLine("Please enter the right Answer");
                    flag = int.TryParse(Console.ReadLine(), out answer1);
                } while (!flag);
                Console.WriteLine("Do you have another choice? (y|n)");
                answers[questionlist[id]] = answer1;
                if (char.Parse(Console.ReadLine()) == 'y')
                {
                    {
                        do
                        {
                            flag = int.TryParse(Console.ReadLine(), out answer2);
                        } while (!flag);
                        answers2[questionlist[id]] = answer2;
                    }
                }
                Console.WriteLine("=============================");
            }
        }


        public void showPracticalExam()
        {

            Console.Clear();
            int f;
            for (int i = 0; i < AnswersPractical1.Length; i++)
            {
                if (AnswersPractical2[i] != -1)
                {

                    Console.WriteLine($"Q){i + 1}        {questionlist[i]} :The Right Answers are:  {RightOneForPractical1[i]}  {RightOneForPractical2[i]}");
                }
                else
                {
                    int F = AnswersPractical2[i] - 1;
                    Console.WriteLine($"Q){i + 1}        {questionlist[i]}: :The Right Answer is: {RightOneForPractical1[i]} ");
                }
            }
        }
        public void showFinalExam()
        {

            Console.Clear();
            int f;
            for (int i = 0; i < AnswersFinal.Length; i++)
            {
                if (AnswersFinal[i] == 1)
                    Console.WriteLine($"Q){i + 1} {questionlist[i]} : {RightOne[i]} ");

            }
                Console.WriteLine($"Your Exam Grade is {StudentGrade} From {TotalGrade}");
        }

    }
}
