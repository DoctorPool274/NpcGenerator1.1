using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NpcGenerator1._1
{
    public class Faune : Npc
    {
        public enum FauneTyp { Huf, Sammel, Ur, Fell, Feder, Schuppen }
        public new FauneTyp Type { get; set; }

        public Faune(string name, FauneTyp typ, string gender, string job, string level) : base(name, "Faune", typ.ToString(), gender, job, level)
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
                case FauneTyp.Huf:
                    Geschicklichkeit += 3;
                    Ausdauer += 1;
                    Charisma -= 2;
                    break;
                case FauneTyp.Sammel:
                    Geschicklichkeit += 3;
                    Charisma += 1;
                    Willenskraft -= 2;
                    break;
                case FauneTyp.Fell:
                    Willenskraft += 3;
                    Ausdauer += 1;
                    Charisma -= 2;
                    break;
                case FauneTyp.Ur:
                    Charisma += 3;
                    Intelligenz += 1;
                    Stärke -= 2;
                    break;
                case FauneTyp.Feder:
                    Ausdauer += 3;
                    Geschicklichkeit += 2;
                    Stärke -= 2;
                    break;
                case FauneTyp.Schuppen:
                    Geschicklichkeit += 3;
                    Willenskraft += 1;
                    Intelligenz -= 2;
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
