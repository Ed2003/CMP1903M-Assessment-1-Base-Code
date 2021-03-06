using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.Write(" Enter Text ");
            //Tells the user to input text
            while (!text.EndsWith('*'))
            // User has to put an * at the end to end the text
            {
                text += Console.ReadLine();
            }

            return text;
        }

        //Method: fileTextInput

        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string filePath)
        {
            Console.WriteLine(" Enter Address To File ");
            // Tells the user to input the address path
            
            text = File.ReadAllText(filePath);

            text = text.Split('*')[0];
            // Ends the text with an *
            return text;

        }


    }
}
