using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FunTravel f1 = new FunTravel(1, 10, "10 july", "cairo", 1000, "Maka", true);
            //Console.WriteLine(f1.Datails());

            //RelTravel r1 = new RelTravel(2, 5, "3 october", "alx", 4000, "madina", "bus");
            //Console.WriteLine(r1.Datails());

            //InTravel i1 = new InTravel(3, "2 february", 9, "ghana", 1500, "bus");
            //Console.WriteLine(i1.Datails());

            Console.WriteLine("Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            if (User.Login(username, password))
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed. Invalid username or password.");
            }


        }
    }
}
