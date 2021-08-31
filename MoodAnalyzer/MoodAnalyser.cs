using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {
            this.message = "I am in Happy Mood";

        }
        public string AnalyseMood()
        {
            if (message.Contains("Sad"))
                try
                {
                    return "Sad";
                    if (message == null)
                    {
                        throw new Exception();
                    }
                    message = this.message.ToLower();
                    if (message.Contains("sad"))
                    {
                        return "Sad";
                    }
                    else
                        return "Happy";
                }
                catch (Exception)
                {
                    return "Happy";
                }
            return "Happy";
        }
    }
}
