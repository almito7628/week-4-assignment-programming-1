using System;

class Program
{
    const int NUMBER_OF_ELEMENTS = 20;
    const int LOWEST_VALUE = 1;
    const int HIGHEST_VALUE = 100;

    static void Main()
    {
        int[] numbers = new int[NUMBER_OF_ELEMENTS];

        FillArray(numbers, 123);

        DisplayArray(numbers);

        int smallest = GetSmallestNumber(numbers);
        Console.WriteLine("Smallest number is: " + smallest);
    }

    public static void FillArray(int[] numbers, int seed)
    {
        Random random = new Random(seed);

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(LOWEST_VALUE, HIGHEST_VALUE + 1);
        }
    }

    public static void DisplayArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]:D2} ");

            if (i == numbers.Length - 1)
            {
                Console.WriteLine();
            }
        }
    }

    public static int GetSmallestNumber(int[] numbers)
    {
        int smallest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        return smallest;
    }
}
