using System;
class HelloWorld
{
  static void Main()
  {    
        int x, y, sum;
        
        //write or writeline 
        Console.Write("Enter first number: ");

        //take input from user will be only string such python
        string st = Console.ReadLine();

        // so to convert string to integer we use parse function
        x = int.Parse(st);
        
        Console.Write("Enter second number: ");

        //take second number
        st = Console.ReadLine();
        
        //convert second numbert to int
        y = int.Parse(st);
        
        //add two numbers
        sum = x + y;

        //we print by concatenate
        Console.WriteLine("Sum is = " + sum);
  }
}
