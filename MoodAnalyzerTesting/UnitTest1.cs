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
            MoodAnalyser mood = new MoodAnalyser();
            string actual = mood.AnalyseMood();
            Assert.AreEqual("Sad", actual);
        }
        [TestMethod]
        public void GivenMessage_WhenAnalyse_ShouldReturnSadOrHappy()
        {
            MoodAnalyser mood = new MoodAnalyser();
            string actual = mood.AnalyseMood();
            Assert.AreEqual("Happy", actual);
        }
        [TestMethod]
        public void GivenNullMessage_WhenAnalyseShouldReturnException()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("Happy", actual);
        }
    }
}