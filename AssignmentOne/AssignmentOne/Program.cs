using System;
using System.Collections.Generic;

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read in the files to arrays
            List<string> NetOne = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_1_256.txt"));
            List<string> NetTwo = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_2_256.txt"));
            List<string> NetThree = new List<string>(System.IO.File.ReadAllLines(@"..\..\..\..\..\Net_3_256.txt"));

            List<int> NetOneInt = new List<int>();
            List<int> NetTwoInt = new List<int>();
            List<int> NetThreeInt = new List<int>();

            List<int> UseArray;

            foreach (string value in NetOne)
            {
                NetOneInt.Add(int.Parse(value));
            }
            foreach (string value in NetTwo)
            {
                NetTwoInt.Add(int.Parse(value));
            }
            foreach (string value in NetThree)
            {
                NetThreeInt.Add(int.Parse(value));
            }

            //Ask the user which array to analyse
            UserInput userInput = new UserInput();
            Console.WriteLine("Which array would you like to analyse?");
            Console.WriteLine("A for Net_1_256, B for Net_2_256 and C for Net_3_256. Input is not case sensitive.");
            string answer = userInput.In();
            if (answer == "NetOne")
            {
                UseArray = NetOneInt;
            }
            else if (answer == "NetTwo")
            {
                UseArray = NetTwoInt;
            }
            else
            {
                UseArray = NetThreeInt;
            }

            //Sort in ascending order
            Console.WriteLine("\n");
            Console.WriteLine("Ascending Order:");
            bubbleSort bubble = new bubbleSort();
            List<int> sorted = bubble.sort(UseArray);
            foreach (int number in sorted)
            {
                Console.WriteLine(number);
            }

            //Sort in descending order
            Console.WriteLine("\n");
            Console.WriteLine("Descending Order:");
            List<int> sortedDesc = bubble.sortDesc(UseArray);
            foreach (int number in sortedDesc)
            {
                Console.WriteLine(number);
            }

            //Display tength values
            Console.WriteLine("\n");
            Console.WriteLine("Every tength value:");
            int counter = 0;
            foreach (int value in sorted)
            {
                counter++;

                if (counter % 10 == 0)
                {
                    Console.WriteLine(value);
                }
            }

            //Search for a given value
            binarySearch binary = new binarySearch();
            List<int> arrayNum = new List<int> { 1,2,3,4,4,5,6 };

            Console.WriteLine("\n");
            Console.WriteLine("Enter a value to search for:");
            int numberSearch = int.Parse(Console.ReadLine());
            List<int> locations = binary.search(bubble.sort(UseArray), numberSearch);

            Console.WriteLine("\nThe value is located at the following places:");
            foreach (int value in locations)
            {
                Console.WriteLine(value);
            }

        }
    }
}
