using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_group
{
    class MemberDetails
    {
        //Details about all the members
        public static GroupMember memberNils()
        {
            return new GroupMember("Nils", 25);
        }

        public static GroupMember memberJonna()
        {
            return new GroupMember("Jonna", 30);
        }

    }
}
