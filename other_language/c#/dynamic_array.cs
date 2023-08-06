using System;
class HelloWorld
{
  static void Main()
  {
    int n, sum= 0;

    // take n from user
    Console.Write("enter a number: ");
    n = int.Parse(Console.ReadLine());
      
    //we not have a pointer in c# so we use []
    int []arr = new int[n];
    
    for (int i = 0; i < n; i++)
    {
        arr[i] = (i + 1) * 10;
        sum += arr[i];
    }
    
    Console.Write("sum: " + sum);
      
  }
}
 
