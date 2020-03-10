using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne
{
    class binarySearch
    {
        public List<int> search(List<int> array, int number)
        {
            int lower = 0;
            int higher = array.Count - 1;
            int midpoint = (higher-lower)/2;

            List<int> found = new List<int>();

            while (lower <= higher)
            {
                midpoint = (higher + lower) / 2;

                if (array[midpoint] == number)
                {
                    if (found.Contains(midpoint))
                    {
                        lower = midpoint;
                        higher = array.Count;
                        break;
                    }
                    else
                    {
                        found.Add(midpoint);
                        lower = 0;
                        higher = array.Count;
                        midpoint = (higher + lower) / 2;
                    }
                }
                else if (number < array[midpoint])
                {
                    higher = midpoint - 1;
                }
                else if (number > array[midpoint])
                {
                    lower = midpoint + 1;
                }
            }
            
            if (found.Count > 0)
            {
                return found;
            }
            else
            {
                Console.WriteLine("Error. No value was found.");
                return null;
            }
        }
    }
}
