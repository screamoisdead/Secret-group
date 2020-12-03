using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_group
{
    class GroupMember
    {
        //Fields
        private string name;
        private int age;

        //Properties
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

        //Constructor
        public GroupMember()
        {

        }

        public GroupMember(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
   
    }
}
