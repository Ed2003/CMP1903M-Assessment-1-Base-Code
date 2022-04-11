using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        string text;
        public Analyse(string input)
        {
            text = input;
        }
       
        public void run()
        {
            //Console.WriteLine("Number of Vowels " + TextAnalysis(text)[0]);
            //Console.WriteLine("Number of Consonant " + TextAnalysis(text)[1]);
            //Console.WriteLine("Number of Uppercase Characters  " + TextAnalysis(text)[2]);
            //Console.WriteLine("Number of Lowercase Characters " + TextAnalysis(text)[3]);
            //Console.WriteLine("Total Number of Letters " + TextAnalysis(text)[4]);
           

            // testDictionary (
            //  (key: "key1", value: 1), 
            //  (key: "key2", value: 2)
            // )

            // foreach(KeyValuePair<char, int> item in testDictionary)
            //Dictionary<char, int > frequencyCharacters = frequencyLetters(text);
            //foreach (var letter in frequencyCharacters) {
                // do something
                //Console.WriteLine(letter.Key.ToString() + "=" + letter.Value);
               
            //}

        }
        ////Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public int[] analyseText(string text)
        {
            char tempLetter;
            int countVowel = 0;
            int countConsonant = 0;
            int countUpper = 0;
            int countLower = 0;
            int countLetters = 0;
            

            for (int i = 0; i < text.Length; i++)
            {
                tempLetter = char.ToUpper(text[i]);
                if (tempLetter == 'A' || tempLetter == 'E' || tempLetter == 'I' || tempLetter == 'O' || tempLetter == 'U')
                {
                    countVowel++;
                }
                else if (char.IsLetter(tempLetter))
                {
                    countConsonant++;
                }
                if (char.IsUpper(text[i]))
                {
                    countUpper++;
                }
                if (char.IsLower(text[i]))
                {
                    countLower++;
                }
                if (char.IsLetter(text[i]))
                {
                    countLetters++;
                }


            }
            int[] returns = new int[5] { countVowel, countConsonant, countUpper, countLower, countLetters };
            return returns;
        }


        public static Dictionary<char, int> frequencyLetters(string input)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (!letters.ContainsKey(char.ToLower(letter)))
                {
                    letters.Add(char.ToLower(letter), 0);
                }

                letters[char.ToLower (letter)]++;
            }

            return letters;
        }
    }
}



