using System.Collections.Generic;
using System.Linq;

namespace NpcGenerator1._1
{
    public class Mensch : Npc
    {
        public enum MenschTyp { Himaden, Vanaden, Kamiden, Hjaden }
        public new MenschTyp Type { get; set; }
        public Mensch(string name, MenschTyp typ, string gender, string job, string level) : base(name, "Mensch", typ.ToString(), gender, job, level)
        {
            Type = typ;
            Level = level;
            Equipment = new List<Equipment>();
            ApplyRacialBonus();
        }

        public override void ApplyRacialBonus()
        {
            switch (Type)
            {
                case MenschTyp.Himaden:
                    Geschicklichkeit += 3;
                    Ausdauer += 1;
                    Charisma -= 2;
                    break;
                case MenschTyp.Vanaden:
                    Geschicklichkeit += 3;
                    Charisma += 1;
                    Willenskraft -= 2;
                    break;
                case MenschTyp.Kamiden:
                    Willenskraft += 3;
                    Ausdauer += 1;
                    Charisma -= 2;
                    break;
                case MenschTyp.Hjaden:
                    Charisma += 3;
                    Intelligenz += 1;
                    Stärke -= 2;
                    break;
            }
        }
        public override string GetEquipment()
        {
            if (Equipment != null && Equipment.Count > 0)
            {
                return string.Join(", ", Equipment.Select(item => $"{item.Name} ({item.Material}) - Werte:{item.Werte}"));
            }
            return "Keine Ausrüstung";
        }
    }
}

