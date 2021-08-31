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

        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message == null)
                {
                    throw new Exception();
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "mood is null");
                }
                if (message.Length == 0)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "mood is empty");
                }
                message = this.message.ToLower();
                if (message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                    return "Happy";
            }
            catch (MoodAnalyserException e)
            {
                Console.WriteLine(e.Message);
                return "Happy";
            }

        }
    }
}