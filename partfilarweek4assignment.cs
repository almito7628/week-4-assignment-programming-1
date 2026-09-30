using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];

        ReadNumbers(numbers);

        Console.Write("Enter a search value: ");
        int searchValue = Convert.ToInt32(Console.ReadLine());

        int occurrences = CountSearchValue(numbers, searchValue);

        Console.WriteLine(
            $"Number of occurrences of search value ({searchValue}) is: {occurrences}"
        );
    }

    public static void ReadNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number (0=stop): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers[i] = number;
        }
    }

    public static int CountSearchValue(int[] numbers, int searchValue)
    {
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 0 && numbers[i] == searchValue)
            {
                count++;
            }
        }

        return count;
    }
}
