using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NpcGenerator1._1
{
    public class Elf : Npc
    {
        public enum ElfTyp { Aesther, Nythari, Sylvari, Morvani }
        public new ElfTyp Type { get; set; }

        public Elf(string name, ElfTyp typ, string gender, string job, string level) : base(name, "Elf", typ.ToString(), gender, job, level)
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
                case ElfTyp.Aesther:
                    Geschicklichkeit += 3;
                    Ausdauer += 1;
                    Charisma -= 2;
                    break;
                case ElfTyp.Nythari:
                    Geschicklichkeit += 3;
                    Charisma += 1;
                    Willenskraft -= 2;
                    break;
                case ElfTyp.Sylvari:
                    Willenskraft += 3;
                    Ausdauer += 1;
                    Charisma -= 2;
                    break;
                case ElfTyp.Morvani:
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
