namespace NpcGenerator1._1
{
    public class Weapon : Equipment
    {
        // Enum für Waffentypen
        public enum WaffenArt { Schwert, Axt, Stumpfewaffe, Dolch, Bogen, Wurfwaffe }

        public WaffenArt Art { get; set; }


        // Konstruktor
        public Weapon(string name, string material, WaffenArt art, int werte) : base(name, material, werte)
        {
            Art = art;
            ApplyWeaponBonus(); // Waffenvorteil anwenden
        }

        // Methode zur Anwendung von Waffenvorteilen
        public override void ApplyWeaponBonus()
        {


            // Berechne den Materialbonus direkt
            switch (Material)
            {
                case "Eisen":
                    Werte = 1;
                    break;
                case "Stahl":
                    Werte = 2;
                    break;
                case "Orkisch":
                    Werte = 3;
                    break;
                case "Sonstige":
                default:
                    Werte = 0;
                    break;
            }

            switch (Art)
            {
                case WaffenArt.Schwert:
                    Werte += 6; // Bonus für Schwert: hier einfach mit +6 hinter materialBonus zb
                    break;
                case WaffenArt.Axt:
                    Werte += 7; // Bonus für Axt
                    break;
                case WaffenArt.Stumpfewaffe:
                    Werte += 5; // Bonus für stumpfe Waffe
                    break;
                case WaffenArt.Dolch:
                    Werte += 4; // Bonus für Dolch
                    break;
                case WaffenArt.Bogen:
                    Werte += 4; // Bonus für Bogen
                    break;
                case WaffenArt.Wurfwaffe:
                    Werte += 3; // Bonus für Wurfwaffe
                    break;
            }
        }

        public override void ApplyArmorBonus()
        {
            // Leere Methode, da Waffen keinen Rüstungsbonus haben.
        }
    }
}
