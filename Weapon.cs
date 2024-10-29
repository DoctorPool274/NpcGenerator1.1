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
            ApplyWeaponBonus(); 
        }

        public override void ApplyWeaponBonus()
        {
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
                    Werte += 6; 
                    break;
                case WaffenArt.Axt:
                    Werte += 7; 
                    break;
                case WaffenArt.Stumpfewaffe:
                    Werte += 5;
                    break;
                case WaffenArt.Dolch:
                    Werte += 4;
                    break;
                case WaffenArt.Bogen:
                    Werte += 4;
                    break;
                case WaffenArt.Wurfwaffe:
                    Werte += 3;
                    break;
            }
        }
    }
}
