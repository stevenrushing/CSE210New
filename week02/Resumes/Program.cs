using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "US Air Force";
        job1._jobTitle = "Telecommunications Specialist";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Koniag Government Services";
        job2._jobTitle = "IT Operations Manager";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume steven = new Resume();
        steven._name = "Steven Rushing";
        steven._jobs.Add(job1);
        steven._jobs.Add(job2);

        steven.Display();

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        // job1.Display();
        // job2.Display();
    }
}