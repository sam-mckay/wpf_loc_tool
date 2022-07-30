using System;

namespace Loc.Core
{
    public class LocString
    {
        public string StringID { get; set; }
        public string Context { get; set; }
        public string EnglishText { get; set; }
        //public string FrenchText { get; set; }
        //public string SpanishText { get; set; }

        public LocString(string stringID, string context, string englishText)
        {
            StringID = stringID;
            Context = context;
            EnglishText = englishText;
        }
    }
}
