using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerApp
{
    public class MoodAnalyser
    {
        public string Analyser(string mood)
        {
            if (mood.Contains("Happy"))
            {
                Console.WriteLine("Happy");
                return "Happy";
            }
            else
            {
                return "Sad";
            }

        }
    }
}
