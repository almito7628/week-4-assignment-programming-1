using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter course name: ");
        string courseName = Console.ReadLine();

        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        string[] names = new string[numberOfStudents];
        int[] grades = new int[numberOfStudents];

        ReadNames(names);
        ReadGrades(grades, names);

        int highestGradeIndex = GetHighestGradeIndex(grades);

        Console.WriteLine(
            $"Student {names[highestGradeIndex]} has the highest grade: {grades[highestGradeIndex]}"
        );
    }

    public static void ReadNames(string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Enter name of student {i + 1}: ");
            names[i] = Console.ReadLine();
        }
    }

    public static void ReadGrades(int[] grades, string[] names)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Enter grade of {names[i]}: ");
            grades[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public static int GetHighestGradeIndex(int[] grades)
    {
        int highestIndex = 0;

        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] > grades[highestIndex])
            {
                highestIndex = i;
            }
        }

        return highestIndex;
    }
}
