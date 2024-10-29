namespace NpcGenerator1._1
{
    public class Armor : Equipment
    {
        // Enum für Rüstungsarten
        public enum RüstungsArt { Leicht, Mittel, Schwer, Sonstige }

        public RüstungsArt Art { get; set; }

        // Konstruktor
        public Armor(string name, string material, RüstungsArt art, int werte) : base(name, material, werte)
        {
            Art = art;
            ApplyArmorBonus(); 
        }

        public override void ApplyArmorBonus()
        {
            switch (Material)
            {
                case "Leder":
                    Werte = 1;
                    break;
                case "Faunen-Leder":
                    Werte = 2;
                    break;
                case "Eisen":
                    Werte = 3;
                    break;
                case "Stahl":
                    Werte = 4;
                    break;
                case "Orkisch":
                    Werte = 5;
                    break;
                case "Sonstige":
                default:
                    Werte = 0;
                    break;
            }

            switch (Art)
            {
                case RüstungsArt.Leicht:
                    Werte += 3;
                    break;
                case RüstungsArt.Mittel:
                    Werte += 5;
                    break;
                case RüstungsArt.Schwer:
                    Werte += 7; 
                    break;
            }
        }
    }
}
