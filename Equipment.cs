using Newtonsoft.Json;

namespace NpcGenerator1._1
{
    public class Equipment
    {
        public Equipment(string name, string material, int werte)
        {
            Name = name;
            Material = material;
            Werte = werte;
        }
        //Ausrüstungen
        public string Name { get; set; }
        public string Material { get; set; }
        public int Werte { get; set; }

        public virtual void ApplyWeaponBonus() { }
        public virtual void ApplyArmorBonus() { }
    }
}
