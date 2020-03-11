using System;
using System.Collections.Generic;

//Assignment one of Algorithms and Complexity
//A program designed to take three data sets, sort them, and allow for searching of a user defined value

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read in the files to arrays
            List<string> NetOne = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_1_256.txt")); //Read all files into new lists
            List<string> NetTwo = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_2_256.txt"));
            List<string> NetThree = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_3_256.txt"));
            List<string> NetOne2048 = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_1_2048.txt"));
            List<string> NetTwo2048 = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_2_2048.txt"));
            List<string> NetThree2048 = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_3_2048.txt"));

            List<int> NetOneInt = new List<int>(); //And create three empty lists
            List<int> NetTwoInt = new List<int>(); //These will be filled with the integer type content of the text files
            List<int> NetThreeInt = new List<int>();
            List<int> NetOne2048Int = new List<int>();
            List<int> NetTwo2048Int = new List<int>();
            List<int> NetThree2048Int = new List<int>();

            List<int> UseArray = new List<int>(); //And create a final list for the final array to be used at any time

            foreach (string value in NetOne) //For every line "value" in the file,
            {
                NetOneInt.Add(int.Parse(value)); //Parse into an integer
            }
            foreach (string value in NetTwo)
            {
                NetTwoInt.Add(int.Parse(value));
            }
            foreach (string value in NetThree)
            {
                NetThreeInt.Add(int.Parse(value));
            }
            foreach (string value in NetOne2048)
            {
                NetOne2048Int.Add(int.Parse(value));
            }
            foreach (string value in NetTwo2048)
            {
                NetTwo2048Int.Add(int.Parse(value));
            }
            foreach (string value in NetThree2048)
            {
                NetThree2048Int.Add(int.Parse(value));
            }

            //Ask the user which array to analyse
            UserInput userInput = new UserInput();
            Console.WriteLine("Which array would you like to analyse?");
            Console.WriteLine("A for Net_1_256, B for Net_2_256 and C for Net_3_256. D for net_1_2048, E for net_2_2048, F for net_3_2048. Input is not case sensitive.");
            string answer = userInput.In(); //Using the UserInput class to provide error detection for input
            if (answer == "NetOne")
            {
                UseArray = NetOneInt; //And swapping the current used list to the chosen one
            }
            else if (answer == "NetTwo")
            {
                UseArray = NetTwoInt;
            }
            else if (answer == "NetThree")
            {
                UseArray = NetThreeInt;
            }
            else if (answer == "NetOne2048")
            {
                UseArray = NetOne2048Int;
            }
            else if (answer == "NetTwo2048")
            {
                UseArray = NetTwo2048Int;
            }
            else if (answer == "NetThree2048")
            {
                UseArray = NetThree2048Int;
            }

            //Sort in ascending order
            Console.WriteLine("\n");
            Console.WriteLine("Ascending Order:");
            bubbleSort bubble = new bubbleSort(); //Sort the list using the normal bubble sort method
            List<int> sorted = bubble.sort(UseArray);
            foreach (int number in sorted) //And write to console each value
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nTo continue, press any key.");
            Console.ReadLine();

            //Sort in descending order
            Console.WriteLine("\n");
            Console.WriteLine("Descending Order:");
            List<int> sortedDesc = bubble.sortDesc(UseArray); //Sort using the descending variant of the bubble sort method
            foreach (int number in sortedDesc)
            {
                Console.WriteLine(number); //And write to console each value
            }

            Console.WriteLine("\nTo continue, press any key.");
            Console.ReadLine();

            //Display tength values
            Console.WriteLine("\n");
            Console.WriteLine("Every tength value:");
            int counter = 0; //Initialise a counter to count multiples of 10
            foreach (int value in sorted)
            {
                counter++; //Increment the counter

                if (counter % 10 == 0) //And if the counter is currently at a multiple of ten write it to the console
                {
                    Console.WriteLine(value);
                }
            }

            Console.WriteLine("\nTo continue, press any key.");
            Console.ReadLine();

            //Search for a given value
            binarySearch binary = new binarySearch(); //Create a new instance of the binary search method
            List<int> arrayNum = new List<int> { 1,2,3,4,4,5,6 }; //This is a test list to test the search method

            Console.WriteLine("\n");
            Console.WriteLine("Enter a value to search for:");
            int numberSearch = int.Parse(Console.ReadLine()); //Get a number input and parse it to an int for use in the binary search method
            List<int> locations = binary.search(bubble.sort(UseArray), numberSearch); //Call using the sorted current list, and the user input

            Console.WriteLine("\nThe value is located at the following places:");
            foreach (int value in locations) //And loop through every element in the resulting positions list
            {
                Console.WriteLine(value);
            }

        }
    }
}
