using System;

namespace BubbleSorterExercise
{
    class BubbleSorter
    {
        // Write bubble sort here...
        internal static void Sort<T>(T[] sortArray, Func<T, T, bool> compareSalary)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareSalary(sortArray[i], sortArray[i + 1]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
