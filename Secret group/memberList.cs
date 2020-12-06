using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_group
{
    class MemberList
    {

        public static void listOfMembers()
        {
            // Grab the members
            GroupMember andrei = MemberDetails.memberAndrei();
            GroupMember jesper = MemberDetails.memberJesper();

            //Add the members to the list
            List<GroupMember> listOfMembers = new List<GroupMember> { jesper, andrei };

            //Display all the names of the members in the group;
            int i = 1;
            foreach(var member in listOfMembers)
            {
                Console.WriteLine($"{i}. {member.Name}");
                i++;
            }

            /*
            GroupMember Jonna = MemberDetails.memberJonna();
            Console.WriteLine($"{Jonna.Name} is the name and {Jonna.Age} is the age");

            GroupMember Nils = MemberDetails.memberNils();
            Console.WriteLine($"{Nils.Name} is the name and {Nils.Age} is the age");
            */
        }

    }
}
