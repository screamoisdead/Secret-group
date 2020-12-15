using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_group
{
    class MenuList
    {
        //This method creates the whole menu
        public static void MenuOfActions()
        {
            //Logical argument that keeps the menu repeating after each choice
            //Until you decide to log out.
            bool loggedIn = true;

            //Calls method that will add all the members with their details into a list
            List<GroupMember> listOfMembers = AddMembersToList();

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
                        DisplayMembers(listOfMembers);
                        //Asks user to press enter to return to main screen
                        returnToMenu();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║---Which one of the people in the group---║");
                        Console.WriteLine("║----Would you like to read more about?----║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");

                        //Calls method that will show all the members
                        DisplayMembers(listOfMembers);

                        //Ask user to choose which person to read about
                        int readMore = Convert.ToInt32(Console.ReadLine());

                        //Select the member to show
                        //Has to be with -1 to sync with the index, since list index
                        //Starts at 0
                        GroupMember personToShow = listOfMembers[readMore - 1];

                        //Displays the chosen person with help from ToString();
                        Console.WriteLine(personToShow);

                        //Asks the user to press enter to return to the menu
                        //I think this creates a bit of more useability feel
                        returnToMenu();

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║--------Which person from the list--------║");
                        Console.WriteLine("║---------Would you like to remove?--------║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");

                        //Calls function that displays all members
                        DisplayMembers(listOfMembers);

                        //Ask user to choose which person to read about
                        int deletePerson = Convert.ToInt32(Console.ReadLine());

                        //Chose person to delete from the list
                        //Once again you need to sync with the list index with a -1
                        GroupMember personToDelete = listOfMembers[deletePerson - 1];

                        //Remove the chosen member from the list
                        listOfMembers.Remove(personToDelete);

                        //Asks user to press enter to return to the menu
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
                        
                        
                        //Sets loggedIn to false gets you out of the loop
                        //And thereby exits the program
                        loggedIn = false;
                        break;

                    //setting a default switch case if you type something else than
                    //1,2,3 or 4. So that it forces you to type any of those choices
                    default:
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║------------Invalid choice----------------║");
                        Console.WriteLine("║------Please chose between 1,2,3 or 4-----║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");
                        break;

                }
            }
        }

        //Method that will ask the user to press enter to return to the main menu
        //After the chosen menu choice flow has ended
        private static void returnToMenu()
        {
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║-----Press ENTER to return to the menu----║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();
        }

        //Method that will put every GroupMember into a list with their details
        private static List<GroupMember> AddMembersToList()
        {
            //Define every member with the info from class MemberDetails
            GroupMember andrei = MemberDetails.MemberAndrei();
            GroupMember jesper = MemberDetails.MemberJesper();
            GroupMember leroy = MemberDetails.MemberLeroy();
            GroupMember malin = MemberDetails.MemberMalin();
            GroupMember jonna = MemberDetails.MemberJonna();
            GroupMember gurra = MemberDetails.MemberGurra();
            GroupMember linus = MemberDetails.MemberLinus();
            GroupMember nils = MemberDetails.MemberNils();
            GroupMember yulrok = MemberDetails.MemberYulrok();

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

        //Method that works to display all the Groupmembers in numerical order
        private static void DisplayMembers(List<GroupMember> listOfMembers)
        {
            Console.WriteLine("════════════════════════════════════════════");
            int i = 1;
            foreach (var member in listOfMembers)
            {
                
                Console.WriteLine($"{i}. {member.Name}");

                i++;
            }
            Console.WriteLine("════════════════════════════════════════════");
        }
    }
}
