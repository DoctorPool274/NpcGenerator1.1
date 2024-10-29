using System.Collections.Generic;
using System.Linq;

namespace NpcGenerator1._1
{
    public class Ork : Npc
    {
        public enum OrkTyp { Shiba, Numa }
        public new OrkTyp Type { get; set; }

        public Ork(string name, OrkTyp typ, string gender, string job, string level) : base(name, "Ork", typ.ToString(), gender, job, level)
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
                case OrkTyp.Shiba:
                    Stärke += 3;
                    Ausdauer += 2;
                    Charisma -= 2;
                    break;
                case OrkTyp.Numa:
                    Intelligenz += 3;
                    Willenskraft += 2;
                    Charisma -= 2;
                    break;
            }
        }
        public override string GetEquipment()
        {
            if (Equipment != null && Equipment.Count > 0)
            {
                return string.Join(", ", Equipment.Select(item => $"{item.Name} ({item.Material} ) - Werte: {item.Werte}"));
            }
            return "Keine Ausrüstung";
        }
    }
}
