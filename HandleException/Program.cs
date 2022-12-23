using System;
namespace HandleException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message1 = "I am in Sad mood";
            Console.WriteLine(message1);
            MoodAnalyser mood1 = new MoodAnalyser(message1);
            Console.WriteLine(mood1.Analyser());

            string message2 = "I am in any mood";
            Console.WriteLine(message2);
            MoodAnalyser mood2 = new MoodAnalyser(message2);
            Console.WriteLine(mood2.Analyser());
        }
    }
}