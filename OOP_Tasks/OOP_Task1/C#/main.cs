using System;
class MainProgram
{
  static void Main()
  {
      char o;
      int x, y;
      
      while (true)
      {
          Console.Write("Enter first number: ");
          x = int.Parse(Console.ReadLine());
          
          Console.Write("Enter operation: ");
          o = Console.ReadLine()[0];
          
          Console.Write("Enter second number: ");
          y = int.Parse(Console.ReadLine());
          
          switch (o)
          {
              case '+':
                Console.WriteLine("sum is " + MyMath.Sum(x, y));
                break;
              case '-':
                Console.WriteLine("sub is " + MyMath.Sub(x, y));
                break;
              case '*':
                Console.WriteLine("mul is " + MyMath.Mul(x, y));
                break;
              case '/':
                Console.WriteLine("div is " + MyMath.Div(x, y));
                break;
              case '%':
                Console.WriteLine("rem is " + MyMath.Rem(x, y));
                break;
              default:
                Console.WriteLine("Inavalid Operation");
                break;
          }
          Console.Write("Another Operation? ");
          o = Console.ReadLine()[0];
          
          if (o != 'T')
            break;
      }
      
      
  }
}
