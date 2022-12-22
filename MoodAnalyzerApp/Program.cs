using System;
namespace MoodAnalyzerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            moodAnalyser.Analyser("I am in Happy Mood");
        }
    }
        

        

}
