using System;

class Program
{
    const int NUMBER_OF_ELEMENTS = 20;
    const int LOWEST_VALUE = 1;
    const int HIGHEST_VALUE = 100;

    public void FillArray(int[] numbers, int seed)
    {
        Random random = new Random(seed);

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(LOWEST_VALUE, HIGHEST_VALUE + 1);
        }
    }

    public void DisplayArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element " + (i + 1) + " is: " + numbers[i]);
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = new int[NUMBER_OF_ELEMENTS];

        Program p = new Program();

        p.FillArray(numbers, 123);
        p.DisplayArray(numbers);

        Console.ReadKey();
    }
}
