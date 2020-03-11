using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne
{
    class binarySearch
    {
        public List<int> search(List<int> array, int number) //Takes a list and a number to be searched
        {
            int lower = 0; //Lower boundry of the list
            int higher = array.Count - 1; //Higher boundry of the list (-1 from the total index value)
            int midpoint = (higher-lower)/2; //The middle of the two boundaries
            int counter1 = 0;

            List<int> found = new List<int>(); //Create an empty list to hold the values indexs

            while (lower <= higher) //Whilst there is list left to search,
            {
                counter1++;
                midpoint = (higher + lower) / 2; //Reset the midpoint

                if (array[midpoint] == number) //If the midpoint is the number we want
                {
                    if (found.Contains(midpoint)) //And we have already found that value's location
                    {
                        lower = midpoint; //Reset the lower
                        higher = array.Count; //And the higher boundaries to avoid finding the same value again
                        break;
                    }
                    else
                    {
                        found.Add(midpoint); //If its not already been found, add it to the list
                        lower = 0; //Set the lower
                        higher = array.Count; //And higher boundaries
                        midpoint = (higher + lower) / 2; //And reset the midpoint
                    }
                }
                else if (number < array[midpoint])
                {
                    higher = midpoint - 1; //If the number searched is less than the midpoint value, set the higher to less than the midpoint
                }
                else if (number > array[midpoint])
                {
                    lower = midpoint + 1; //If the number searched is more than the midpoint value, set the lower to higher than the midpoint
                }
            }
            
            if (found.Count > 0) //If we've found something, return it
            {
                Console.WriteLine($"Counter 1: {counter1}");
                return found;
            }
            else
            {
                Console.WriteLine($"Counter 1: {counter1}");
                Console.WriteLine("Error. No value was found."); //Else, return an error message
                return null;
            }
        }
    }
}
