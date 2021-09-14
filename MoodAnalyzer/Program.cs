using System;
using MoodAnalyser;
namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalysers moodAnalyser = new MoodAnalysers("");
            Console.WriteLine("Mood : " + moodAnalyser.AnalyserMood());
        }
    }
}