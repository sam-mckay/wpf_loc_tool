using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loc.Core
{
    public static class LocRecords
    {
        public static List<LocString> LocStrings;

        public static void Load()
        {
            LocStrings = new List<LocString>()
            {
                { new LocString("TEST_1","Test String", "This is a test") },
                { new LocString("TEST_2","Test String", "This is also a test") },
                { new LocString("TEST_3","Test String", "This is another test") },
                { new LocString("TEST_4","Test String", "This is yet another test") },
            };
        }
    }
}
