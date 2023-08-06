using System;
// using namespace Task3
// {
    class Hospital
    {
      static void Main()
      {
        // Docotr d1 = new Docotr(1, "ahmed", "cairo", 5000, 5);
        // Docotr d2 = new Docotr(2, "mohamed", "alx", 2000, 11);
        // Nurse n1 = new Nurse(2, "mohamed", "alx", 2000, 2);
        // Nurse n2 = new Nurse(1, "ahmed", "cairo", 4000, 5);
    
    
        // Console.WriteLine(d1.printData());
        // Console.WriteLine(d2.printData());
        // Console.WriteLine(n1.printData());
        // Console.WriteLine(n2.printData());
        

        int n = 1;
        int id, overtime, patient_number;
        string name, address;
        float salary;
        
        while (n < 3)
        {
            Console.Write("Enter Doctor" + n + " ID" + n + " : ");
            id = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Doctor" + n + " name" + n + " : ");
            name = Console.ReadLine();
            
            Console.Write("Enter Doctor" + n + " address" + n + " : ");
            address = Console.ReadLine();
            
            Console.Write("Enter Doctor" + n + " salary" + n + " : ");
            salary = float.Parse(Console.ReadLine());
            
            Console.Write("Enter Doctor" + n + " patient number" + n + " : ");
            patient_number = int.Parse(Console.ReadLine());
            
            Doctor d1 = new Doctor(id, name, address, salary, patient_number);
            
            Console.Write("Doctor" + n + " data: ");
            Console.WriteLine(d1.printData());
            
            n++;
        }
        
        n = 1;
        while (n < 3)
        {
            Console.Write("Enter Nurse" + n + " ID" + n + " : ");
            id = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Nurse" + n + " name" + n + " : ");
            name = Console.ReadLine();
            
            Console.Write("Enter Nurse" + n + " address" + n + " : ");
            address = Console.ReadLine();
            
            Console.Write("Enter Nurse" + n + " salary" + n + " : ");
            salary = float.Parse(Console.ReadLine());
            
            Console.Write("Enter Nurse" + n + " overtime" + n + " : ");
            overtime = int.Parse(Console.ReadLine());
            
            Nurse n1 = new Nurse(id, name, address, salary, overtime);
            
            Console.Write("Nurse" + n + " data: ");
            Console.WriteLine(n1.printData());
            
            n++;
        }
      }
    }
// }