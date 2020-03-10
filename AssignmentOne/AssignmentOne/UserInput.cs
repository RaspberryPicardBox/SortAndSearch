using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne
{
    class UserInput
    {
        public string In()
        {
            string UserIn = Console.ReadLine().ToLower();

            if (UserIn == "a")
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
            else
            {
                Console.WriteLine("You didn't enter a valid input. Please enter either A, B or C.");
                return In();
            }
        }
    }
}
