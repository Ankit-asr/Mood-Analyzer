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
            MoodAnalyser analyse = new MoodAnalyser();
            string actual = analyse.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual("Sad", actual);
        }
    }
}
