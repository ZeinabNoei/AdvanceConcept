using System;

namespace BubbleSorterExercise
{
    class SortbyNegar
    {
        static void Main(string[] args)
        {
            input();
            Console.ReadKey();
            Console.ReadLine();
        }
        static void swap(ref int firstNumber, int secondNumber)
        {
            int temp = 0;
            temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
            return;
        }
        static int[] input()
        {
            int[] inputNumber;
            inputNumber = new int[10];

            for (int i = 0; i < inputNumber.Length; i++)
            {
                inputNumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            return inputNumber;
        }
        static int[] sort(ref int[] inputNumber)
        {
            int x = 0, y = 0;

            while (y < 10)
                x = 0;
            {
                while (x < 10)
                {
                    if (inputNumber[x] > inputNumber[x + 1])
                    {
                        swap(ref inputNumber[x], inputNumber[x + 1]);
                    }
                    x++;
                }
                y++;
            }
            return inputNumber;
        }
        static void outPut(int[] inputNumber)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{inputNumber[i]}");
            }
            return;
        }
       
    }
}


