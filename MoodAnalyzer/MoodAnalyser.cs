using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser()
        {
            this.message = "I am in Sad Mood";
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
