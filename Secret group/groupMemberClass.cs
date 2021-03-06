﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_group
{
    class GroupMember
    {
        //Fields
        private string name;
        private int age;
        private string birthday;
        private string food;
        private string band;
        private string movie;
        private string ilove;
        private string ihate;
        private string zodiac;
        private string superpower;
        private string drivenbywhat;


        //Properties
        //Name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //Age
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        //Birthday
        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        //Food
        public string Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }

        //Favorite band
        public string Band
        {
            get
            {
                return band;
            }
            set
            {
                band = value;
            }
        }

        //Favorite movie
        public string Movie
        {
            get
            {
                return movie;
            }
            set
            {
                movie = value;
            }
        }

        //What you love the most
        public string ILove
        {
            get
            {
                return ilove;
            }
            set
            {
                ilove = value;
            }
        }

        //What you hate the most
        public string IHate
        {
            get
            {
                return ihate;
            }
            set
            {
                ihate = value;
            }
        }

        //Whats your zodiac sign
        public string Zodiac
        {
            get
            {
                return zodiac;
            }
            set
            {
                zodiac = value;
            }
        }

        //Whats your superpower
        public string Superpower
        {
            get
            {
                return superpower;
            }
            set
            {
                superpower = value;
            }
        }

        //What keeps you driven with programing
        public string Drivenbywhat
        {
            get
            {
                return drivenbywhat;
            }
            set
            {
                drivenbywhat = value;
            }
        }



        //Naked constructor
        public GroupMember()
        {

        }

        //Constructor where all fields must be applied
        public GroupMember(
            string name,
            int age,
            string birthday,
            string food,
            string band,
            string movie,
            string ilove,
            string ihate,
            string zodiac,
            string superpower,
            string drivenbywhat)
        {
            this.name = name;
            this.age = age;
            this.birthday = birthday;
            this.food = food;
            this.band = band;
            this.movie = movie;
            this.ilove = ilove;
            this.ihate = ihate;
            this.zodiac = zodiac;
            this.superpower = superpower;
            this.drivenbywhat = drivenbywhat;
        }

        public override string ToString()
        {
            //To string override that will show all the info about a specific member that can be called through
            //Console.WriteLine(listOfMember[Their index number]);
            //The \r\n helps to add a new line to make the design output look better
            return $"════════════════════════════════════════════\r\n" +
                   $"{name} is {age} years old.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"Birthday: {birthday}.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"Favorite food: {food}.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"Favorite band: {band}.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"Favorite movie: {movie}.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"They love: {ilove}.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"They hate: {ihate}.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"Zodiac sign: {zodiac}.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"Desired superpower: {superpower}.\r\n" +
                   $"════════════════════════════════════════════\r\n" +
                   $"Their programing is driven by: {drivenbywhat}\r\n" +
                   $"════════════════════════════════════════════\r\n";
        }
    }
}
