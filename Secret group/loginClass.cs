using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace Secret_group
{
    public static class LoginClass
    {

        //Method for the login functionality
        public static void LoginTry()
        {
            //The password needed to pass the login
            string secretPassword = "götebuggare";
            //Creating a logical argument to check if you are allowed to pass the login screen
            bool loginSuccess = true;

            //Create a loop where you will be stuck until you type the correct password
            //Else you will just be asked to try type the password again
            while (loginSuccess)
            {
                string loginTry = Console.ReadLine();
                switch (loginTry)
                {
                    case "götebuggare":
                       loginSuccess = false;
                        Console.Clear();
                       break;

                    default:
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║------You entered the wrong password------║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");
                        break;
                }
            } 
        }
    }
}
