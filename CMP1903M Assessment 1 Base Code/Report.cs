using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public void reportAnalyseText(int[] analyseText)
        {
            Console.WriteLine("Number of Vowels " + analyseText[0]);
            Console.WriteLine("Number of Consonant " + analyseText[1]);
            Console.WriteLine("Number of Uppercase Characters  " + analyseText[2]);
            Console.WriteLine("Number of Lowercase Characters " + analyseText[3]);
            Console.WriteLine("Total Number of Letters " + analyseText[4]);

        }
        public void reportFrequencyLetters(Dictionary<char, int> letters)
        {
            foreach (var letter in letters)
               Console.WriteLine(letter.Key.ToString() + "=" + letter.Value);  
        }



    }
}