using System;

class Program
{
    static void Main()
    {
        int[] diceCounts = new int[6];

        ThrowDice(diceCounts, 6000);

        for (int i = 0; i < diceCounts.Length; i++)
        {
            Console.WriteLine(
                $"Number of throws of value {i + 1} = {diceCounts[i]}"
            );
        }
    }

    public static void ThrowDice(int[] diceCounts, int numberOfThrows)
    {
        Random random = new Random();

        for (int i = 0; i < numberOfThrows; i++)
        {
            int diceValue = random.Next(1, 7);

            diceCounts[diceValue - 1]++;
        }
    }
}
