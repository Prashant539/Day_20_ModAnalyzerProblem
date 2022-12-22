using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerAppWithCore
{
    public class MoodAnalyser
    {
       
        public string AnalyseMood(string mood)
        {
            if (mood.Contains("Sad"))
            {
                Console.WriteLine("Sad");
                return "Sad";
               
            }
            else
            {
                return "HAPPY";
            }
                

        
        }

         
    }
}

        


     



    

