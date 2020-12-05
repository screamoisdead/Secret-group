using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_group
{
    class MemberDetails
    {
        //Details about all the members
        //Name, Age, Birthday, Favorite food, Favorite band, Favorite movie, What you love, What you hate
        //Zodiac sign, Superpower, What drives your programming
        public static GroupMember memberAndrei()
        {
            return new GroupMember(
            "Andrei",
            26,
            "12th of January",
            "Carbonara",
            "Two steps from hell",
            "The lord of the rings",
            "Travelling",
            "Olives",
            "Capricorn",
            "Instant olive detection",
            "Problem solving");
        }

        static GroupMember memberJesper()
        {
            return new GroupMember(
            "Jesper",
            28,
            "29th of May",
            "Lambracks",
            "Lars Winnerbäck",
            "Catch me if you can",
            "The simple stuff",
            "People who film at concerts",
            "Gemini",
            "Teleportation",
            "Freedom");
        }

    }
}
