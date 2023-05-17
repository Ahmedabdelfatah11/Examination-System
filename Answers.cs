using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPExam
{
    class Answers
    {
        int id;
        string answer;
        string[] Answerslist;
        string[] Answerslist2;
        int[] Numbers;
        int size;
        public Answers(int _size)
            {
            size= _size;
            Answerslist = new string[size];
            }
        public int this[string Name]
        {
            get
            {
                for (int i = 0; i < Answerslist.Length; i++)
                {
                    if (Name == Answerslist[i])
                        return Numbers[i];
                }
                return -1;
            }
            set
            {
                if (Answerslist is not null)
                {
                    for (int i = 0; i < Answerslist.Length; i++)
                    {
                        if (Answerslist[i] == Name)
                        {
                            Numbers[i] = value;
                            break;
                        }
                    }
                }
            }
        } 
    }
}
