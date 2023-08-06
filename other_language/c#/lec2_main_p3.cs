using System;

namespace OOP_Lec2
{
    class Object1
    {
      static void Main()
      {
            /*
                when we create object the constructor is called directly and default

            */
            Employee e1 = new Employee();

            //we know if we not write any values will put  default values which = 0
            // what if we want to put default values if user not entered??
            // create constructor in class
            Console.WriteLine(e1.ID);     

            // after adding constructor
            Employee e2 = new Employee(1);

            Console.WriteLine(e2.id + ' ' + e2.name + ' ' + e2.salary);

            // after adding constructor overload
            Employee e3 = new Employee(2, "Ahmed");

            Console.WriteLine(e3.id + ' ' + e3.name + ' ' + e3.salary);

            // we can chagne any value by
            // if we want not to change value we can modify proparity and delete set
            e3.id = 5;

                
      }
    }
    
}
