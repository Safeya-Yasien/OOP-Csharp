using System;

namespace OOP_Lec2
{
    class Object1
    {
      static void Main()
      {
        
        Employee e1 = new Employee();
        e1.SetID(1);
        e1.SetName("Ahmed");
        e1.SetSalary(1000);

        Console.WriteLine(e1.GetID());
        Console.WriteLine(e1.GetName());
        Console.WriteLine(e1.GetSalary());


        // after adding proparity
        Employee e2 = new Employee();
        e2.id = 10;
        e2.NAME = "Mostafa";
        e2.SALARY = 5000;

        Console.WriteLine(e2.id);
        Console.WriteLine(e2.NAME);
        Console.WriteLine(e2.SALARY);



        
      }
    }
    
}
