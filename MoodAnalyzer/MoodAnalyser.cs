using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad") || message.Contains("sad"))
                    return "Sad";
            else
                return "Happy";
        }

    }
}