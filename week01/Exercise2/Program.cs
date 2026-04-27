using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string userGrade = Console.ReadLine();
        int userGradeInt = int.Parse(userGrade);
        if (userGradeInt >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (userGradeInt >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (userGradeInt >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (userGradeInt >= 60)
        {
            Console.WriteLine("You got an F");
        }
        else
        {
            Console.WriteLine("You failed the course");
        }
    }
}

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60