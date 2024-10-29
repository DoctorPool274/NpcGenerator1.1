using System;

namespace NpcGenerator1._1
{
    internal class NameGenerator
    {
        private static readonly Random random = new Random();

        // Menschliche Namen nach Geschlecht
        private static readonly string[] menschlicheMaennlicheVornamen = { "Hans", "Peter", "Karl", "Thomas", "Michael", "Johann", "Stefan", "Markus", "David", "Felix",
                                                                           "Lukas", "Jakob", "Daniel", "Christian", "Niklas", "Andreas", "Simon", "Jan", "Philipp", "Julius" };
        private static readonly string[] menschlicheWeiblicheVornamen = { "Maria", "Anna", "Lena", "Sophie", "Emilia", "Leonie", "Mia", "Laura", "Lisa", "Julia",
                                                                          "Sarah", "Nina", "Clara", "Lina", "Hannah", "Klara", "Marie", "Ella", "Stella", "Nora", "Paula" };
        private static readonly string[] menschlicheNachnamen = { "Mueller", "Schmidt", "Schneider", "Meier", "Fischer", "Weber", "Meyer", "Hoffmann", "Schulz", "Koch",
                                                                  "Richter", "Wolf", "Klein", "Schwarz", "Zimmermann", "Braun", "Krause", "Hartmann", "Lange", "Schmitt" };

        // Elfische Namen nach Geschlecht
        private static readonly string[] elfischeMaennlicheVornamen = { "Legolas", "Elrond", "Thranduil", "Fingolfin", "Gil-galad", "Haldir", "Galdor", "Círdan", "Erestor", "Beren",
                                                                        "Lúthien", "Glorfindel", "Finarfin", "Amroth", "Oropher", "Aldaron", "Thalion", "Amdir", "Finrod", "Eärendil" };
        private static readonly string[] elfischeWeiblicheVornamen = { "Arwen", "Galadriel", "Luthien", "Celebrimbor", "Nimrodel", "Elbereth", "Idril", "Yavanna", "Melian", "Nienna",
                                                                       "Varda", "Galathil", "Anaire", "Eärwen", "Silmariën", "Findis", "Nerwen", "Nimloth", "Morwen", "Ríanna" };
        private static readonly string[] elfischeNachnamen = { "Thranduilion", "Silmarien", "Eldamar", "Telcontar", "Finarfinion", "Círdanion", "Galathilion", "Galadhrion", "Lúthieniel", "Melianiel",
                                                               "Elentári", "Vanyarion", "Aldaronion", "Eärendillion", "Nimrodelion", "Anarion", "Celebrindor", "Finrodiel", "Fingolfinion", "Oropherion" };

        // Faunische Namen nach Geschlecht
        private static readonly string[] faunischeMaennlicheVornamen = { "Pan", "Frido", "Faunus", "Bram", "Rufus", "Finn", "Hugo", "Orin", "Milo", "Pip",
                                                                         "Talon", "Pax", "Zander", "Rico", "Marius", "Leo", "Sam", "Darius", "Jasper", "Lorenzo" };
        private static readonly string[] faunischeWeiblicheVornamen = { "Maia", "Cathy", "Serene", "Elara", "Lyra", "Flora", "Daphne", "Ivy", "Nina", "Rhea",
                                                                        "Vega", "Sienna", "Fiona", "Talia", "Luna", "Zara", "Faye", "Briony", "Kira", "Mira", "Astra" };
        private static readonly string[] faunischeNachnamen = { "Dachs", "Wolf", "Fuchs", "Igel", "Reh", "Eichhörnchen", "Adler", "Falke", "Salamander", "Viper",
                                                                "Bär", "Hirsch", "Luchs", "Ziege", "Eule", "Fasan", "Schnäbel", "Dohle", "Schwan", "Kranich" };

        // Orkische Namen nach Geschlecht
        private static readonly string[] orkischeMaennlicheVornamen = { "Grom", "Thrall", "Garrosh", "Durotan", "Gul'dan", "Kil'jaeden", "Nazgûl", "Kargath", "Orgrim", "Rokhan",
                                                                        "Grommash", "Zul'jin", "Kargath", "Ner'zhul", "Draka", "Drek'Thar", "Gul'dan", "Ogrim", "Blackhand", "Shadowsong" };
        private static readonly string[] orkischeWeiblicheVornamen = { "Draka", "Azuka", "Jaina", "Grimfang", "Saurfang", "Nazgûl", "Kil'jaeden", "Kargath", "Throne", "Ner'zhul",
                                                                       "Vermath", "Shadewalker", "Moonshadow", "Bladesong", "Talon", "Grommash", "Bloodfury", "Frostwolf", "Ironjaw", "Blackhand" };
        private static readonly string[] orkischeNachnamen = { "Hellscream", "Goebles", "Doom", "Bloodfist", "Ironclaw", "Shadowsong", "Warbreaker", "Wolfblood", "Steelbreaker", "Frostblade",
                                                               "Skullcrusher", "Deathblade", "Stonefist", "Ironjaw", "Thunderfury", "Blacksoul", "Ragefire", "Stonebreaker", "Soulrender", "Shadowbane" };


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
