using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne
{
    class bubbleSort
    {
        public List<int> sort(List<int> array) //argument of a single list
        {
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 0; i < array.Count - 1; i++) //For every element in the list
            {
                counter1++;
                for (int n = 0; n < array.Count - 1 - i; n++) //For every element in the list - the already sorted sections
                {
                    counter2++;
                    if (array[n + 1] < array[n]) //If the element in from of the current one is bigger
                    {
                        int temp = array[n]; //Put the current value into a temporary variable
                        array[n] = array[n + 1]; //Swap them
                        array[n + 1] = temp; //And then place the temporary back
                    }
                }
            }
            Console.WriteLine($"Counter 1: {counter1}");
            Console.WriteLine($"Counter 2: {counter2}");
            return array; //Return the sorted list
        }

        public List<int> sortDesc(List<int> array)
        {
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 0; i < array.Count - 1; i++)
            {
                counter1++;
                for (int n = 0; n < array.Count - 1 - i; n++)
                {
                    counter2++;
                    if (array[n + 1] > array[n]) //Exactly the same as the previous sort, but checks for the opposite. If the next value is smaller, swap them.
                    {
                        int temp = array[n];
                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"Counter 1: {counter1}");
            Console.WriteLine($"Counter 2: {counter2}");
            return array;
        }
    }
}
