using Lec4_T2;
using System;

class Hospital
{
    static void Main()
    {
        int n = 1;
        int id, age, n_days, overtime, patient_number, exp_years;
        string name, address, gender, choice;
        float salary;

        while (true)
        {
            Console.Write("Doctor or Nurse: ");
            choice = Console.ReadLine();
            choice = choice.ToLower();

            if (choice == "d" ||  choice == "doctor" )
            {
                Console.Write("Enter Doctor" + n + " ID" + n + " : ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Enter Doctor" + n + " name" + n + " : ");
                name = Console.ReadLine();

                Console.Write("Enter Doctor" + n + " age" + n + " : ");
                age = int.Parse(Console.ReadLine());

                Console.Write("Enter Doctor" + n + " address" + n + " : ");
                address = Console.ReadLine();

                Console.Write("Enter Doctor" + n + " gender" + n + " : ");
                gender = Console.ReadLine();

                Console.Write("Enter Doctor" + n + " number of days" + n + " : ");
                n_days = int.Parse(Console.ReadLine());

                Console.Write("Enter Doctor" + n + " experience years" + n + " : ");
                exp_years = int.Parse(Console.ReadLine());

                Console.Write("Enter Doctor" + n + " patient number" + n + " : ");
                patient_number = int.Parse(Console.ReadLine());

                Console.Write("Enter Doctor" + n + " salary" + n + " : ");
                salary = float.Parse(Console.ReadLine());

                Doctor d1 = new Doctor(id, age, n_days, salary, name, address, gender, exp_years, patient_number);

                d1.SetNoDays();
                d1.SetExperience();
                d1.SetNoPatient();
                d1.CalcSalary();

                Console.WriteLine("Doctor" + n + " data: ");
                Console.WriteLine(d1.PrintData());
                n++;

            }
            else if (choice == "n" || choice == "nurse")
            {
                Console.Write("Enter Nurse" + n + " ID" + n + " : ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Enter Nurse" + n + " name" + n + " : ");
                name = Console.ReadLine();

                Console.Write("Enter Nurse" + n + " age" + n + " : ");
                age = int.Parse(Console.ReadLine());

                Console.Write("Enter Nurse" + n + " address" + n + " : ");
                address = Console.ReadLine();

                Console.Write("Enter Nurse" + n + " gender" + n + " : ");
                gender = Console.ReadLine();

                Console.Write("Enter Nurse" + n + " number of days" + n + " : ");
                n_days = int.Parse(Console.ReadLine());

                Console.Write("Enter Nurse" + n + " overtime" + n + " : ");
                overtime = int.Parse(Console.ReadLine());

                Console.Write("Enter Nurse" + n + " salary" + n + " : ");
                salary = float.Parse(Console.ReadLine());

                Nurse n1 = new Nurse(id, age, n_days, salary, name, address, gender, overtime);

                n1.AddOverTime();
                n1.CalcSalary();

                Console.WriteLine("Nurse" + n + " data: ");
                Console.WriteLine(n1.PrintData());
                n++;
            }
            else
            {
                string flag = "no";

                Console.WriteLine("Invalid Choice");
                Console.Write("if you want to add another person enter yes: ");
                flag = Console.ReadLine();
                
                if (flag != "yes")
                {
                    break;
                }
            }
        }
    }
}
// }