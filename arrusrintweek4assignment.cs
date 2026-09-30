using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[3];

        FillArray(numbers);

        int sum = CalculateSum(numbers);
        double average = CalculateAverage(numbers);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine($"Average: {average:F2}");
    }

    public static void FillArray(int[] numbers)
    {
        Console.WriteLine("Enter 3 integers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static double CalculateAverage(int[] numbers)
    {
        return (double)CalculateSum(numbers) / numbers.Length;
    }
}
