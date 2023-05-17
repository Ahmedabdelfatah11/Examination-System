using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
     class QuestionList
    {
        public int size;
        public string[] questionlist;
        public int typeOfexam;
        public int typeOfQuestion;
        public int[] marks;
       public string[] Header;
       public int[] AnswersFinal;
       public int[] AnswersPractical1;
       public int[] AnswersPractical2;
       public string[] MCQSingleChoiceChoices;
       public string[] MCQMultipleChoiceChoices;
       public int TotalGrade;
       public int StudentGrade;
        public string[] RightOne;
        public string[] RightOneForPractical1;
        public string[] RightOneForPractical2;

        public QuestionList(int _size,int _Typeofexam,int _TypeOfQuestion) 
        {
            size = _size;
            typeOfQuestion= _TypeOfQuestion;
            typeOfexam = _Typeofexam;
            marks= new int[size];
            questionlist = new string[size];
            AnswersFinal= new int[size ];
            AnswersPractical1= new int[size ];
            AnswersPractical2= new int[size ];
            Header=new string[size];
            MCQSingleChoiceChoices=new string[size];
            MCQMultipleChoiceChoices=new string[size];
            RightOne=new string[size];
            RightOneForPractical1=new string[size];
            RightOneForPractical2=new string[size];
        }

        public void AddTFQuestion(int index,string question,int Marks,int Answers,string rightTF)
        {
            Header[index] = "True | False Question";
                questionlist[index] = question;
                marks[index] = Marks;
                AnswersFinal[index] = Answers;
                RightOne[index]= rightTF;
        } 
        public void MCQSingleChoice(int index, string question, int Marks, int Answers,string choices,string rightone)
        {
            Header[index] = "Choose One Answer Question";
            questionlist[index] = question;
             marks[index] = Marks;
             AnswersFinal[index] = Answers;
            MCQSingleChoiceChoices[index] = choices;
            RightOne[index] = rightone;
        }  
        public void MCQSMultipleChoice(int index, string question, int Marks, int Answers1,int Answers2,string choices,string right1,string right2)
        {
            Header[index] = "Choose the Answers of the Question";
            questionlist[index] = question;
             marks[index] = Marks;
            AnswersPractical1[index] = Answers1;
            AnswersPractical2[index] = Answers2;
            MCQMultipleChoiceChoices[index] = choices;
            RightOneForPractical1[index] = right1;
            RightOneForPractical2[index] = right2;
        }

      
       

    }
}
