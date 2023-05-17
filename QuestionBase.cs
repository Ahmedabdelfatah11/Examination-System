using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    abstract class QuestionBase
    {
        abstract public void HeaderOfTheQuestion();
        abstract public void BodyOfTheQuestion();
        abstract public int Marks();
    }
}
