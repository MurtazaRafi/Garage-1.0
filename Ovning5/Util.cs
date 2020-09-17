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

                if (!string.IsNullOrEmpty(answer))
                {
                    success = true;
                }

            } while (!success); 

            return answer; 
        }

      

        internal static string AskForAlphabets(string prompt, UI ui) 
        {
            bool success = false;
            string answer;

            do
            {
                ui.Print(prompt);
                answer = ui.GetInput();

                if (!string.IsNullOrEmpty(answer) && Regex.IsMatch(answer, @"^[a-zA-Z]+$"))
                {
                    
                    success = true;
                }

            } while (!success); 

            return answer; 
        }

        internal static int AskForPositiveInt(string prompt, UI ui) 
        {
            bool success = false;
            int answer;

            do
            {
                
                string input = AskForString(prompt, ui);

                success = int.TryParse(input, out answer);
                if (!success || answer < 0)
                    ui.Print("You must give a postive integer"); 

            } while (!success || answer < 0);

            return answer;
        }

        internal static double AskForPositiveDouble(string prompt, UI ui)
        {
            bool success = false;
            double answer;

            do
            {
                
                string input = AskForString(prompt, ui);

                success = double.TryParse(input, out answer);
                if (!success || answer <= 0)
                    ui.Print("You must give a postive decimal number"); 

            } while (!success || answer <= 0);

            return answer;
        }
    }
}
