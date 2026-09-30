using System;

class Program
{
    const int NUMBER_OF_ELEMENTS = 20;
    const int LOWEST_VALUE = 1;
    const int HIGHEST_VALUE = 500;

    static void Main()
    {
        int[] numbers = new int[NUMBER_OF_ELEMENTS];

        FillArray(numbers, 123);

        DisplayNumbers(numbers);

        Console.Write("Enter a comparison value: ");
        int comparisonNumber = Convert.ToInt32(Console.ReadLine());

        UpdateNumbers(numbers, comparisonNumber);

        DisplayNumbers(numbers);
    }

    public static void FillArray(int[] numbers, int seed)
    {
        Random random = new Random(seed);

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(LOWEST_VALUE, HIGHEST_VALUE + 1);
        }
    }

    public static void DisplayNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i],3} ");
        }

        Console.WriteLine();
    }

    public static void UpdateNumbers(int[] numbers, int comparisonNumber)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= comparisonNumber)
            {
                numbers[i] += 10;
            }
            else
            {
                numbers[i] -= 5;
            }
        }
    }
}
