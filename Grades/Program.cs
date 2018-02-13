using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is the grade book program");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            synth.Speak("The Average Grade is" + stats.AverageGrade);
            Console.WriteLine(stats.AverageGrade);
            synth.Speak("The Highest Grade is" + stats.HighestGrade);
            Console.WriteLine(stats.HighestGrade);
            synth.Speak("The Lowest Grade is" + stats.LowestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.ReadKey();

        }
    }
}
