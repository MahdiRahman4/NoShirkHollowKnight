using Modding;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace NoShirkHK
{
    public class NoShirkHK : Mod
    {
        public NoShirkHK() : base("NoShirkHK") { }

        public override string GetVersion() => "1.0.0";

        public override void Initialize()
        {
            ModHooks.LanguageGetHook += OnLanguageGet;
            Log("NoShirkHK loaded successfully.");
        }

        private static readonly Dictionary<string, string> Replacements = new Dictionary<string, string>
        {
            { "Godhome",     "Elderhome"  },
            { "God Home",    "Elder Home" },
            { "Godseeker",   "Seeker"     },
            { "godseeker",   "seeker"     },
            { "Gods",        "Elders"     },
            { "gods",        "elders"     },
            { "God",         "Elder"      },
            { "god",         "elder"      },
            { "Pantheons",   "Gauntlets"  },
            { "pantheons",   "gauntlets"  },
            { "Pantheon",    "Gauntlet"   },
            { "pantheon",    "gauntlet"   },
            { "Souls",       "Essences"   },
            { "souls",       "essences"   },
            { "Soul",        "Essence"    },
            { "soul",        "essence"    },
            { "Divine",      "Ancient"    },
            { "divine",      "ancient"    },
            { "Sacred",      "Hallowed"   },
            { "sacred",      "hallowed"   },
            { "Holy",        "Pure"       },
            { "holy",        "pure"       },
            { "Blessed",     "Gifted"     },
            { "blessed",     "gifted"     },
            { "Worship",     "Revere"     },
            { "worship",     "revere"     },
            { "Worshipped",  "Revered"    },
            { "worshipped",  "revered"    },
            { "Prayers",     "Calls"      },
            { "prayers",     "calls"      },
            { "Prayer",      "Call"       },
            { "prayer",      "call"       },
            { "Pray",        "Call"       },
            { "pray",        "call"       },
            { "Temples",     "Halls"      },
            { "temples",     "halls"      },
            { "Temple",      "Hall"       },
            { "temple",      "hall"       },
            { "Altars",      "Pedestals"  },
            { "altars",      "pedestals"  },
            { "Altar",       "Pedestal"   },
            { "altar",       "pedestal"   },
            { "Rituals",     "Ceremonies" },
            { "rituals",     "ceremonies" },
            { "Ritual",      "Ceremony"   },
            { "ritual",      "ceremony"   },
        };

        private static readonly Regex _pattern = BuildPattern();

        private static Regex BuildPattern()
        {
            var keys = new List<string>(Replacements.Keys);
            keys.Sort((a, b) => b.Length.CompareTo(a.Length));
            string joined = string.Join("|", keys.ConvertAll(Regex.Escape));
            return new Regex($@"\b({joined})\b", RegexOptions.None);
        }

        private string OnLanguageGet(string key, string sheet, string orig)
        {
            if (string.IsNullOrEmpty(orig)) return orig;
            return _pattern.Replace(orig, m => Replacements[m.Value]);
        }
    }
}