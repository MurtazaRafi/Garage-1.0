using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ovning5
{
    internal static class Util
    {
        internal static string AskForString(string prompt, UI ui) //ToDo Gör om UI till IUI 
            //?? VArför apsserar ui i askforstring??
        {
            bool success = false;
            string answer; 

            do 
            {
                ui.Print(prompt);           //?? För att kunna använda här ??
                answer = ui.GetInput();

                //If answer is not null or empty string
                if (!string.IsNullOrEmpty(answer))
                {
                    //Set bool success to true to exit loop
                    success = true;
                }

            } while (!success); //until we have get a correct value

            return answer; //return value
        }

      

        internal static string AskForAlphabets(string prompt, UI ui) //ToDo Gör om UI till IUI
        {
            bool success = false;
            string answer;

            do
            {
                ui.Print(prompt);
                answer = ui.GetInput();

                //If answer is not null or empty string and only alphabets
                if (!string.IsNullOrEmpty(answer) && Regex.IsMatch(answer, @"^[a-zA-Z]+$"))
                {
                    //Set bool success to true to exit loop
                    success = true;
                }

            } while (!success); //until we have get a correct value

            return answer; //return value
        }

        internal static int AskForPositiveInt(string prompt, UI ui) //ToDo Gör om UI till IUI
        {
            bool success = false;
            int answer;

            do
            {
                //Try to parse string to int returns bool
                //If true exit loop
                string input = AskForString(prompt, ui);

                success = int.TryParse(input, out answer);
                if (!success || answer < 0)
                    ui.Print("You must give a postive integer"); //Write error message

            } while (!success || answer < 1);

            //Returns parsed string
            return answer;
        }

        internal static double AskForPositiveDouble(string prompt, UI ui) //ToDo Gör om UI till IUI
        {
            bool success = false;
            double answer;

            do
            {
                //Try to parse string to int returns bool
                //If true exit loop
                string input = AskForString(prompt, ui);

                success = double.TryParse(input, out answer);
                if (!success || answer < 0)
                    ui.Print("You must give a postive decimal number"); //Write error message

            } while (!success || answer < 1);

            //Returns parsed string
            return answer;
        }
    }
}
