using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");
            MoodAnalyser mood = new MoodAnalyser();
            Console.WriteLine(mood.AnalyseMood());
        }
    }
}
