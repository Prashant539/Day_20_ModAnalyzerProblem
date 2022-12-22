using MoodAnalyzerAppWithCore;
using System;
namespace MoodAlalyzerWithCoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            moodAnalyser.AnalyseMood("I am in Sad Mood");
        }
    }
}
