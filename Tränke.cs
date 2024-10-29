using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpcGenerator1._1
{
    public class Tränke : Equipment
    {
        public enum TränkeArt { Wiederherstellung, Verstärkung, Schwächung, Sonstige }
        public TränkeArt Art { get; set; } // Use the enum type directly
        public int Werte { get; set; }

        // Constructor needs to match the base class constructor if required
        public Tränke(TränkeArt art, int werte) : base("Trank", art.ToString(), werte)
        {
            Art = art; 
            ApplyPotionBonus();
        }
        //todo eine möglichkeit finden um werte auszugeben!!!!
        public override void ApplyPotionBonus()
        {

            switch (Art)
            {
                case TränkeArt.Wiederherstellung:
                    Werte += 6;
                    break;
                case TränkeArt.Verstärkung:
                    Werte += 7;
                    break;
                case TränkeArt.Schwächung:
                    Werte -= 5;
                    break;
                case TränkeArt.Sonstige:
                    Werte += 4;
                    break;
                default:
                    Werte = Math.Max(1, Werte);
                    break;
            }
        }
    }
}
