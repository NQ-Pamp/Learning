using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLord.Classes
{
    class Config
    {
        //Lvl 1 heroes
        public const string tiny = "Tiny";
        public const string tusk = "Tusk";
        public const string axe = "Axe";
        public const string razor = "Razor";
        public const string ogre = "Ogre Magi";
        public const string batRider = "BatRider";
        public const string shadowShaman = "Shadow Shaman";
        public const string bloodseeker = "Bloodseeker";
        public const string enchantress = "Enchantress";
        public const string warlockName = "Warlock";
        public const string bounty = "Bounty Hunter";
        public const string antimage = "Antimage";
        public const string venomancer = "Venomancer";
        public const string drow = "Drow Ranger";

        //Lvl2 heroes
        public const string lina = "Lina";
        public const string beastMaster = "BeastMaster";
        public const string jugg = "Juggernaut";
        public const string puck = "Puck";
        public const string mistress = "Queen of Pain";
        public const string prophet = "Nature's Prophet";
        public const string timber = "Timbersaw";
        public const string ck = "ChaosKnight";
        public const string luna = "Luna";
        public const string morphling = "Morphling";
        public const string pudge = "Pudge";
        public const string slardar = "Slardar";
        public const string windRanger = "Wind Ranger";
        public const string witchDoctor = "WitchDoctor";

        //Lvl3 heroes
        public const string fiend = "Demon Fiend";
        public const string crystal = "Crystal Maiden";
        public const string lycan = "Lycan";
        public const string tinker = "Tinker";
        public const string sniper = "Sniper";
        public const string abaddon = "Abaddon";
        public const string clockwerk = "Clockwerk";
        public const string omni = "Omniknight";
        public const string phantom = "Phantom Assassin";
        public const string slark = "Slark";
        public const string terror = "Terror Blade";
        public const string treant = "Treant Protector";
        public const string viper = "Viper";

        //Alliances
        public const string savages = "Savages";
        public const string warriors = "Warriors";
        public const string mages = "Mages";
        public const string assassins = "Assassins";
        public const string druids = "Druids";
        public const string humans = "Humans";
        public const string archers = "Archers";
        public const string warlocks = "Warlocks";
        public const string knights = "Knights";


        //Lvl heroes arrays
        public static readonly string[] Lvl1Heroes = new string[14] { tiny, tusk, axe, razor, ogre, batRider,
                shadowShaman, bloodseeker,enchantress, warlockName, bounty, antimage,
                venomancer, drow};
        public static readonly string[] Lvl2Heroes = new string[14] { lina, beastMaster, jugg, puck, mistress,
                prophet, timber, ck, luna, morphling, pudge, slardar, windRanger,
                witchDoctor };
        public static readonly string[] Lvl3Heroes = new string[13] { fiend, crystal, lycan, tinker, sniper, abaddon, clockwerk,
                omni, phantom, slark, terror, treant, viper };


        public static readonly List<string> heroWarriors = new List<string> {tiny, tusk, axe, jugg, pudge, slardar };
        public static readonly List<string> heroSavages = new List<string> { enchantress, venomancer, tusk };
        public static readonly List<string> heroMages = new List<string> { ogre, razor, lina, puck, crystal };
        public static readonly List<string> heroAssassins = new List<string> { bloodseeker, bounty, mistress, morphling, phantom,
            slark, viper};
        public static readonly List<string> heroDruids = new List<string> { enchantress, prophet, treant };
        public static readonly List<string> heroHumans = new List<string> { bloodseeker, lina, lycan, omni };
        public static readonly List<string> heroWarlocks = new List<string> { warlockName, venomancer, fiend };
        public static readonly List<string> heroArchers = new List<string> { beastMaster, drow, windRanger, lycan, sniper };
        public static readonly List<string> heroKnights = new List<string> { luna, omni, abaddon, batRider, ck };
    }
}
