using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne
{
    class UserInput
    {
        public string In()
        {
            string UserIn = Console.ReadLine().ToLower(); //Make sure all input is the same capitalisation

            if (UserIn == "a") //Check using a, b, c for the user's choice
            {
                return "NetOne";
            }
            else if (UserIn == "b")
            {
                return "NetTwo";
            }
            else if (UserIn == "c")
            {
                return "NetThree";
            }
            else if (UserIn == "d")
            {
                return "NetOne2048";
            }
            else if (UserIn == "e")
            {
                return "NetTwo2048";
            }
            else if (UserIn == "f")
            {
                return "NetThree2048";
            }
            else //If it isn't any of the valid inputs
            {
                Console.WriteLine("You didn't enter a valid input. Please enter either A, B or C.");
                return In(); //Show an error message and restart until correct input provided
            }
        }
    }
}
