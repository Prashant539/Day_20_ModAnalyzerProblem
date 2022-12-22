using MoodAnalyzerAppWithCore;
using System;

namespace MoodAnalyzerMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {

            // arrange
            MoodAnalyser moodobj = new MoodAnalyser();
            string Expectedresult = "Sad";
            //act
            string Actualresult = moodobj.AnalyseMood("Sad");

            //assert
            Assert.AreEqual(Expectedresult, Actualresult);

        }
    }
}