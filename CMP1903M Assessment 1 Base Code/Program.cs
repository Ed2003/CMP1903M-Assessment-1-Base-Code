//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main(string[]args)
        {
            string userinput = "";

            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            Input input = new Input();
            string choice1 = "";
            while (true)
            {
                try
                {
                    Console.WriteLine(" Select Which Choice\n manual or file ");
                    choice1 = (Console.ReadLine()!).ToLower();
                    if (choice1 == "manual")
                    {
                        userinput = input.manualTextInput();
                        break;
                    }
                    else if (choice1 == "file")
                    {
                        string filePath = Console.ReadLine();
                        userinput = input.fileTextInput(filePath);
                        Console.WriteLine("");
                        Console.WriteLine("Input read from file:");
                        Console.WriteLine("----------");
                        Console.WriteLine(userinput);
                        Console.WriteLine("----------");
                        Console.WriteLine("");
                        break;

                    }
                    else
                    {
                        throw new Exception("You have not selected a valid choice");
                    }
                }
                catch (Exception exceptionChoiceinput)
                {
                    Console.WriteLine(exceptionChoiceinput.Message);
                }
            }
            Analyse analysis = new Analyse(userinput);
            int[] analysedText = analysis.analyseText(userinput);
            Report report = new Report();
            report.reportAnalyseText(analysedText);

            Dictionary<char, int> frequencyCharacters = Analyse.frequencyLetters(userinput);
            report.reportFrequencyLetters(frequencyCharacters);






            //Get either manually entered text, or text from a file


            //Create an 'Analyse' object

            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
