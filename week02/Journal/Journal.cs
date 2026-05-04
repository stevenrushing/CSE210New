// public class Journal
// {
//     public string _name;
//     public List<Job> _jobs = new List<Job>();

//     public void Display()
//     {
//         Console.WriteLine(_name);
//         Console.WriteLine("Jobs:");
//         for (int i = 0; i < _jobs.Count; i++)
//         {
//             _jobs[i].Display();
//         }

//         // this is how it is done in the example, and this is probably better
//         // foreach (Job job in _jobs)
//         // {
//         //     // This calls the Display method on each job
//         //     job.Display();
//         // }
//     }
// }