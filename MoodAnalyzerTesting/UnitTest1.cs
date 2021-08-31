using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser analyse = new MoodAnalyser();
            string actual = analyse.AnalyseMood();
            Assert.AreEqual("Happy", actual);
        }
    }
}