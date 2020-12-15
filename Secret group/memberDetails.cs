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
        public static GroupMember MemberAndrei()
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

        public static GroupMember MemberJesper()
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

        public static GroupMember MemberLeroy()
        {
            return new GroupMember(
            "Leroy",
            32,
            "22nd of October",
            "Pizza",
            "We the best music",
            "Matrix",
            "Chocolate",
            "Caviar",
            "Libra",
            "Flying",
            "Dynamic");
        }

        public static GroupMember MemberMalin()
        {
            return new GroupMember(
            "Malin",
            29,
            "13th of March",
            "Rårakor",
            "Modest Mouse",
            "Snatch",
            "Autumn/Winter",
            "Banana",
            "Pisces",
            "Mrs. Hindsight",
            "To be able to create");
        }

        public static GroupMember MemberJonna()
        {
            return new GroupMember(
            "Jonna",
            30,
            "5th of February",
            "Pizza",
            "Full of hell",
            "Interstellar",
            "Music",
            "Meat",
            "Aquarius",
            "Immortal",
            "Bull-headed");
        }

        public static GroupMember MemberGurra()
        {
            return new GroupMember(
            "Gurra",
            33,
            "17th of November",
            "Tacos",
            "Berliner Philharmoniker",
            "Star wars",
            "J.S. Bach",
            "Eurovision song contest",
            "Scorpio",
            "Talk with dog puppies",
            "Creativity");
        }

        public static GroupMember MemberLinus()
        {
            return new GroupMember(
            "Linus",
            27,
            "17th of July",
            "Fish soup",
            "Jack moy",
            "The secret life of walter mitty",
            "Banana",
            "Mustard",
            "Cancer",
            "Breathe under water",
            "To get a really fun job");
        }

        public static GroupMember MemberNils()
        {
            return new GroupMember(
            "Nils",
            21,
            "15th of March",
            "Pancakes",
            "Beach Boys",
            "American Psycho",
            "Snow",
            "Wet snow",
            "Pisces",
            "Count with your fingers",
            "Fun");
        }

        public static GroupMember MemberYulrok()
        {
            return new GroupMember(
            "Yulrok",
            38,
            "23rd of April",
            "Musli",
            "Morcheeba",
            "The green book",
            "Cheese",
            "Wastefullness",
            "Taurus",
            "Transfer of thoughts",
            "A ticket to the digital nomad life");
        }

    }
}
