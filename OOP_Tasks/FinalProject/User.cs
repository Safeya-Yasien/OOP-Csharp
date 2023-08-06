using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallProject
{
    internal static class User
    {
        private static string[] UserNames = { "user1", "user2", "user3", "user4", "user5" };
        private static string[] Passwords = { "pass1", "pass2", "pass3", "pass4", "pass5" };

        public static bool Login(string username, string password)
        {
            for (int i = 0; i < UserNames.Length; i++)
            {
                if (UserNames[i] == username && Passwords[i] == password)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
