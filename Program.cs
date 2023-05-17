using System.Diagnostics;

namespace OOPExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10, "c#");
            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want To Start The Exam (y | n): ");

             if (char.Parse(Console.ReadLine()) == 'y')
             {
                 Stopwatch sw = Stopwatch.StartNew();
                 sw.Start();
                subject.showExam();
                 Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
             }
            
        }
    }
}