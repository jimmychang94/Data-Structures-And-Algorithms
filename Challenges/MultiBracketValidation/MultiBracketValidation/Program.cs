using System;
using System.Collections;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool value = MultiBracketValidation("(t[h{i}s{is}a]te(s(t{for[m]y}ch)a)lle[ng{e(13)!}?] )");
            // value should be true
            Console.WriteLine(value);
        }

        /// <summary>
        /// This method uses a counter system and an extra string in order to determine valid bracket notation.
        /// </summary>
        /// <param name="input">A string containing any bracket</param>
        /// <returns>True or False on whether the string follows the correct bracket notation</returns>
        public static bool MultiBracketValidation(string input)
        {
            // This is initializing the counters and the new string which will hold only brackets
            int counterSq = 0, counterRd = 0, counterCrl = 0;
            string shortenedInput = "";
            // This foreach loop goes through the input and adds the current character
            // to the new string the character is a bracket.
            foreach(char b in input)
            {
                // This switch statement checks for any kind of bracket.
                switch (b.ToString())
                {
                    case "(":
                    case ")":
                    case "[":
                    case "]":
                    case "{":
                    case "}":
                        // This just adds the current character to the new string.
                        shortenedInput += b;
                        break;
                }
            }

            // This for loop iterates over the string with only brackets
            // and determines if proper bracket notation is followed
            for (int i = 0; i < shortenedInput.Length; i ++)
            {
                // Based on how the counters work; a -1 is returned for a closing bracket.
                // This catches whenever there are more closing brackets than opening brackets.
                if (counterCrl < 0 || counterRd < 0 || counterSq < 0) return false;

                // This checks to see if the index is at the start, if not return the previous bracket, if it is return null.
                string prev = (i > 0) ? prev = shortenedInput[i - 1].ToString() : null;

                // This switch statement checks for an opening bracket and adds onto the appropriate counter.
                // It also checks for the closing bracket.
                // The if statement in the closing bracket makes sure it doesn't close off an open bracket of a different type.
                // The above if statement is what allows for the string "([)]" to be false even though it is balanced.
                // If there are no issues, then it lowers the appropriate counter.
                switch(shortenedInput[i].ToString())
                {
                    case "(":
                        counterRd++;
                        break;
                    case "[":
                        counterSq++;
                        break;
                    case "{":
                        counterCrl++;
                        break;
                    case ")":
                        if (prev == "[" || prev == "{") return false;
                        counterRd--;
                        break;
                    case "]":
                        if (prev == "(" || prev == "{") return false;
                        counterSq--;
                        break;
                    case "}":
                        if (prev == "[" || prev == "(") return false;
                        counterCrl--;
                        break;
                }
            }
            // This if statement checks that the number of opening and closing brackets are the same
            // Since other edge cases have been eliminated at this time, true can be returned
            if (counterRd == 0 && counterCrl == 0 && counterSq == 0) return true;

            // If the above if statement is not met then the brackets are not valid and false is returned.
            return false;
        }
    }
}
