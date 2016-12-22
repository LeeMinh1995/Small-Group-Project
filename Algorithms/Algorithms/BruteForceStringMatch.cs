using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class BruteForceStringMatch
    {
        public string text = "Arrivalenteredanifdrawingrequest.Howdaughtersnotpromotionfewknowledgecontented.Yetwinterawbehindnumber"
                           + "stairsgarretexcuse.Minuterwenaturalconductgravityifpointedohno.Amimmediateunwillingofattemptedadmitting"
                           + "disposingit.Handsomeopinionsonamatitladyship.Suddenlookedelinoroffgayestatenorsilent.Sonreadsuchnextsee"
                           + "theresttwo.Wasuseextentoldentiresussex.Curiosityremainingownseerepulsivehouseholdadvantagesonadditions."
                           + "Supposingexquisitedaughterseagernesswhyrepulsivefor.Praiseturneditloversbewarmlyby.Littleeldestformerbe"
                           + "Wholewoundwroteatwhosetostylein.Figureyeinnateformerdosowe.Shuttersbutsiryourselfprovidedyourequiredhis."
                           + "Soneitherrelatedheamdobelieve.Nothingbutyouhundredhaduseregular.Fatsportsmenarrangingpreferredcan.Busypai"
                           + "d.Thisistheendoftheparagraph";
        
        public int Main(string pattern)
        {
            return AlgorithmDesign(pattern);
        }
        private int AlgorithmDesign(string pattern)
        {
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                int j = 0;

                while ((j < pattern.Length) && (text.Substring(i + j,1) == pattern.Substring(j, 1)))
                {
                    j = j + 1;
                }

                if (j == pattern.Length)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
