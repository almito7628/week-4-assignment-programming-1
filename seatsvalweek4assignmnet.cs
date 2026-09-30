using System;

class Program
{
    static void Main()
    {
        bool[] seats = new bool[10];

        InitializeSeats(seats);

        Console.WriteLine("Current seating arrangement:");
        DisplaySeatingArrangement(seats);

        Console.Write("Enter the seat number to book (1-10): ");
        int seatNumber = Convert.ToInt32(Console.ReadLine());

        BookSeat(seats, seatNumber);

        Console.WriteLine("Current seating arrangement:");
        DisplaySeatingArrangement(seats);
    }

    public static void InitializeSeats(bool[] seats)
    {
        Random random = new Random();

        for (int i = 0; i < seats.Length; i++)
        {
            seats[i] = random.Next(2) == 1;
        }
    }

    public static void DisplaySeatingArrangement(bool[] seats)
    {
        for (int i = 0; i < seats.Length; i++)
        {
            if (seats[i])
            {
                Console.WriteLine($"Seat {i + 1}: Available");
            }
            else
            {
                Console.WriteLine($"Seat {i + 1}: Booked");
            }
        }
    }

    public static void BookSeat(bool[] seats, int seatNumber)
    {
        int index = seatNumber - 1;

        if (seats[index])
        {
            seats[index] = false;
            Console.WriteLine($"Seat {seatNumber} has been successfully booked.");
        }
        else
        {
            Console.WriteLine($"Warning: Seat {seatNumber} is already booked.");
        }
    }
}
