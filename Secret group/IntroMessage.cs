using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Secret_group
{
    class WelcomeMessage
    {
        //Creates a method that will be displayed at first in the program
        public static void IntroMessage()
        {
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║----Welcome to the secret member group----║");
            Console.WriteLine("║------------------------------------------║");
            Console.WriteLine("║------------Enter your password-----------║");
            Console.WriteLine("╚══════════════════════════════════════════╝");

        }
    }
}
