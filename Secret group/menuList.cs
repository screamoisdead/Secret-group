using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_group
{
    class MenuList
    {

        public static void menuOfActions()
        {

            bool loggedIn = true;

            List<GroupMember> listOfMembers = addMembersToList();

            while (loggedIn)
            {

                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║----Chose one of the following actions----║");
                Console.WriteLine("║---------1. Show all members names--------║");
                Console.WriteLine("║-2. Show all information about one person-║");
                Console.WriteLine("║----3. Remove one person from the list----║");
                Console.WriteLine("║----------------4. Log out----------------║");
                Console.WriteLine("╚══════════════════════════════════════════╝");

                int menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        //Calls for method to show member list
                        displayMembers(listOfMembers);
                        //Asks user to press enter to return to main screen
                        returnToMenu();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║---Which one of the people in the group---║");
                        Console.WriteLine("║----Would you like to read more about?----║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");

                        displayMembers(listOfMembers);

                        //Ask user to choose which person to read about
                        int readMore = Convert.ToInt32(Console.ReadLine());

                        GroupMember personToShow = listOfMembers[readMore - 1];

                        Console.WriteLine(personToShow);

                        returnToMenu();

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║--------Which person from the list--------║");
                        Console.WriteLine("║---------Would you like to remove?--------║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");

                        displayMembers(listOfMembers);

                        //Ask user to choose which person to read about
                        int deletePerson = Convert.ToInt32(Console.ReadLine());

                        GroupMember personToDelete = listOfMembers[deletePerson - 1];

                        listOfMembers.Remove(personToDelete);

                        returnToMenu();

                        break;

                    case 4:
                        //Program exits
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║------You have sucessfully logged out-----║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");
                        //Who doesnt love a good ASCII art.
                        //Especially a goose.

                        Console.WriteLine("                                                        _...--.");
                        Console.WriteLine("                                        _____......----'     .'");
                        Console.WriteLine("                                  _..-''                   .'");
                        Console.WriteLine("                                .'                       ./");
                        Console.WriteLine("                        _.--._.'                       .' |");
                        Console.WriteLine("                     .-'                           .-.'  /");
                        Console.WriteLine("                   .'   _.-.                     .  \\   '");
                        Console.WriteLine("                 .'  .'   .'    _    .-.        / `./  :");
                        Console.WriteLine("               .'  .'   .'  .--' `.  |  \\  |`. |     .'");
                        Console.WriteLine("            _.'  .'   .' `.'       `-'   \\ / |.'   .'");
                        Console.WriteLine("         _.'  .-'   .'     `-.            `      .'");
                        Console.WriteLine("       .'   .'    .'          `-.._ _ _ _ .-.    :");
                        Console.WriteLine("     /    /o _.-'               .--'   .'   \\   |");
                        Console.WriteLine("    .'-.__..-'                  /..    .`    / .'");
                        Console.WriteLine("  .'   . '                       /.'/.'     /  |");
                        Console.WriteLine(" `---'                                   _.'   '");
                        Console.WriteLine("                                       /.'    .'");
                        Console.WriteLine("                                        /.'/.'");
                        loggedIn = false;
                        break;

                    default:
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║------------Invalid choice----------------║");
                        Console.WriteLine("║------Please chose between 1,2,3 or 4-----║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");
                        break;

                }
            }
        }

        private static void returnToMenu()
        {
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║-----Press ENTER to return to the menu----║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();
        }

        private static List<GroupMember> addMembersToList()
        {
            //Define every member with the info from class MemberDetails
            GroupMember andrei = MemberDetails.memberAndrei();
            GroupMember jesper = MemberDetails.memberJesper();
            GroupMember leroy = MemberDetails.memberLeroy();
            GroupMember malin = MemberDetails.memberMalin();
            GroupMember jonna = MemberDetails.memberJonna();
            GroupMember gurra = MemberDetails.memberGurra();
            GroupMember linus = MemberDetails.memberLinus();
            GroupMember nils = MemberDetails.memberNils();
            GroupMember yulrok = MemberDetails.memberYulrok();

            //Add every above member to the list
            List<GroupMember> listOfMembers = new List<GroupMember> { 
                jesper, 
                andrei, 
                leroy, 
                malin, 
                jonna,
                gurra,
                linus,
                nils,
                yulrok
            };

            //Return the list of members
            return listOfMembers;
        }

        private static void displayMembers(List<GroupMember> listOfMembers)
        {
            Console.WriteLine("╔══════════════════════════════════════════╗");
            int i = 1;
            foreach (var member in listOfMembers)
            {
                
                Console.WriteLine($"{i}. {member.Name}");

                i++;
            }
            Console.WriteLine("╚══════════════════════════════════════════╝");
        }
    }
}
