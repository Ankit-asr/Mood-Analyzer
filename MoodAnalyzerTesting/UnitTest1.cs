using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual("Sad", actual);
        }
        [TestMethod]
        public void GivenAnyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.AnalyseMood("I am in any Mood");
            Assert.AreEqual("Happy", actual);
        }
    }
}
