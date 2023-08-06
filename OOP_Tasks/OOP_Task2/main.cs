using System;

// namespace Task2
// {
    class Program
    {
        static void Main(string[] args)
        {
            int t = 1, id, total;
            string name;
            
            while (t < 4)
            {
                Console.Write("Enter ID of s" + t + ": ");
                id = int.Parse(Console.ReadLine());
                
                Console.Write("Enter name of s" + t + ": ");
                name = Console.ReadLine();
                
                Console.Write("Enter total of s" + t + ": ");
                total = int.Parse(Console.ReadLine());
                
                // Create a new Student object
                Students student = new Students(id, name, total);

                // Calculate the evaluation for the student
                student.CalcEval();

                // Print the student data
                student.PrintData();
                // or
                // Console.WriteLine(student.PrintData());

                t++;
                
            }
        }
    }
// }