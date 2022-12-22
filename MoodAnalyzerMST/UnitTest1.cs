using MoodAnalyzerApp;

namespace MoodAnalyzerMST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnHAPPY()
        
        {
            MoodAnalyser moodobj = new MoodAnalyser();
            string Expectedresult = "Happy";
            string Actualresult = moodobj.Analyser("Happy");
            Assert.AreEqual(Expectedresult, Actualresult);
        }
    }
}