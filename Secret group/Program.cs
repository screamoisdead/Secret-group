using System;
using System.Collections.Generic;

namespace Secret_group
{
    
    class Program
    {
        static void Main(string[] args)
        {

            //Intro message
            WelcomeMessage.IntroMessage();

            //Login
            LoginClass.LoginTry();

            //Member list
            MemberList.listOfMembers();



        }
    }
}
