using System;

namespace NpcGeneratorV1
{
    internal static class NameGenerator
    {
        private static readonly Random random = new Random();

        // Menschliche Namen nach Geschlecht
        private static readonly string[] menschlicheMaennlicheVornamen = { "Hans", "Peter", "Karl" };
        private static readonly string[] menschlicheWeiblicheVornamen = { "Maria", "Anna", "Lena" };
        private static readonly string[] menschlicheNachnamen = { "Mueller", "Schmidt", "Schneider" };

        // Elfische Namen nach Geschlecht
        private static readonly string[] elfischeMaennlicheVornamen = { "Legolas", "Elrond", "Thranduil" };
        private static readonly string[] elfischeWeiblicheVornamen = { "Arwen", "Galadriel", "Luthien" };
        private static readonly string[] elfischeNachnamen = { "Thranduilion", "Silmarien", "Eldamar" };

        // Faunische Namen nach Geschlecht
        private static readonly string[] faunischeMaennlicheVornamen = { "Pan", "Frido", "Faunus" };
        private static readonly string[] faunischeWeiblicheVornamen = { "Maia", "Cathy", "Serene" };

        //private static readonly string[] faunischeMaennlicheFellVornamen = { "Pan", "Frido", "Faunus" };
        //private static readonly string[] faunischeWeiblicheFellVornamen = { "Maia", "Cathy", "Serene" };

        //private static readonly string[] faunischeMaennlicheUrVornamen = { "Pan", "Frido", "Faunus" };
        //private static readonly string[] faunischeWeiblicheUrVornamen = { "Maia", "Cathy", "Serene" };

        //private static readonly string[] faunischeMaennlicheSammelVornamen = { "Pan", "Frido", "Faunus" };
        //private static readonly string[] faunischeWeiblicheSammelVornamen = { "Maia", "Cathy", "Serene" };

        //private static readonly string[] faunischeMaennlicheHufVornamen = { "Pan", "Frido", "Faunus" };
        //private static readonly string[] faunischeWeiblicheHufVornamen = { "Maia", "Cathy", "Serene" };

        private static readonly string[] faunischeNachnamen = { "Dachs", "Wolf", "Fuchs", "Igel", "Reh", "Eichhörnchen", "Adoler", "Falke", "Salamander", "Viper" };

        // Orkische Namen nach Geschlecht
        private static readonly string[] orkischeMaennlicheVornamen = { "Grom", "Thrall", "Garrosh" };
        private static readonly string[] orkischeWeiblicheVornamen = { "Draka", "Azuka", "Jaina" };
        private static readonly string[] orkischeNachnamen = { "Hellscream", "Doom" };


        public static string GenerateRandomName(string race, string gender)
        {
            string vorname = "";
            string nachname = "";

            // Rassenspezifische Namensgenerierung basierend auf Geschlecht
            switch (race)
            {
                case "Mensch":
                    vorname = GenerateVorname(gender, menschlicheMaennlicheVornamen, menschlicheWeiblicheVornamen);
                    nachname = menschlicheNachnamen[random.Next(menschlicheNachnamen.Length)];
                    break;

                case "Elf":
                    vorname = GenerateVorname(gender, elfischeMaennlicheVornamen, elfischeWeiblicheVornamen);
                    nachname = elfischeNachnamen[random.Next(elfischeNachnamen.Length)];
                    break;

                case "Faune":
                    vorname = GenerateVorname(gender, faunischeMaennlicheVornamen, faunischeWeiblicheVornamen);
                    nachname = faunischeNachnamen[random.Next(faunischeNachnamen.Length)];
                    break;

                case "Ork":
                    vorname = GenerateVorname(gender, orkischeMaennlicheVornamen, orkischeWeiblicheVornamen);
                    nachname = orkischeNachnamen[random.Next(orkischeNachnamen.Length)];
                    break;

                default:
                    vorname = "Unbekannt";
                    nachname = "";
                    break;
            }

            return vorname + " " + nachname;
        }

        // Hilfsmethode zur Geschlechterabfrage und Namensauswahl
        private static string GenerateVorname(string gender, string[] maennlich, string[] weiblich)
        {
            if (gender == "Männlich")
            {
                return maennlich[random.Next(maennlich.Length)];
            }
            else if (gender == "Weiblich")
            {
                return weiblich[random.Next(weiblich.Length)];
            }
            else
            {
                return "Unbekannt";
            }
        }
    }
}