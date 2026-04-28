using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        int numToAdd = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (numToAdd != 0)
        {
            Console.Write("Enter number: ");
            numToAdd = int.Parse(Console.ReadLine());
            if (numToAdd != 0)
            {
                numbersList.Add(numToAdd);
            }
        }
        int numSum = 0;
        float numAverage = 0;
        int numLargest = 0;

        for (int i = 0; i < numbersList.Count; i++)
        {
            numSum = numSum + numbersList[i];
            if (numbersList[i] > numLargest)
            {
                numLargest = numbersList[i];
            }
        }
        numAverage = ((float)numSum) / numbersList.Count;
        Console.WriteLine($"The sum is: {numSum}");
        Console.WriteLine($"The average is: {numAverage}");
        Console.WriteLine($"The largest number is: {numLargest}");

        numbersList.Sort();
        foreach (var number in numbersList)
        {
            Console.WriteLine(number);
        } 

    }
}