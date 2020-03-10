using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne
{
    class bubbleSort
    {
        public List<int> sort(List<int> array)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int n = 0; n < array.Count - 1 - i; n++)
                {
                    if (array[n + 1] < array[n])
                    {
                        int temp = array[n];
                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }
                }
            }

            return array;
        }

        public List<int> sortDesc(List<int> array)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int n = 0; n < array.Count - 1 - i; n++)
                {
                    if (array[n + 1] > array[n])
                    {
                        int temp = array[n];
                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
