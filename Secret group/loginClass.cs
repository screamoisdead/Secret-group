using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace Secret_group
{
    class LoginClass
    {

        //Method for the login functionality
        public static void LoginTry()
        {
            //Initialize some variables
            string secretPassword = "götebuggare";
            bool loginSuccess = true;
            int loginTries = 0;

            //Create a loop that will keep running either until you manage to provide the correct password
            //Or that you provided the wrong password too many times
            //And the program will exit
            while (loginSuccess)
            {

                string loginTry = Console.ReadLine();

                
                if(loginTry != secretPassword)
                {

                    if(loginTries < 3)
                    {

                        Console.WriteLine("Please try agian");
                        Console.WriteLine("You entered the pasword wrong {0} times", loginTries);
                        loginTries++;

                    } else if( loginTries == 3)
                    {
                        Console.WriteLine("You entered the password wrong too many times");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("You made it!");
                    loginSuccess = false;
                }
            } 
        }
    }
}
