using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string userGrade = Console.ReadLine();
        int userGradeInt = int.Parse(userGrade);
        string letter = "";
        if (userGradeInt >= 90)
        {
            letter = "A";
        }
        else if (userGradeInt >= 80)
        {
            letter = "B";
        }
        else if (userGradeInt >= 70)
        {
            letter = "C";
        }
        else if (userGradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}");

        if (userGradeInt >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You will do better next time. Good luck!");
        }
    
    }
}

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60