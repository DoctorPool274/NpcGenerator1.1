using System;
using System.Collections.Generic;
using System.Text;

namespace NpcGenerator1._1
{
    public class Npc
    {
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();
        public string Name { get; set; }
        public string Race { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public string Level { get; set; }

        // Attributes
        public int Stärke { get; set; }
        public int Geschicklichkeit { get; set; }
        public int Ausdauer { get; set; }
        public int Intelligenz { get; set; }
        public int Willenskraft { get; set; }
        public int Charisma { get; set; }

        // Combat stats
        public int HP => 30 + Ausdauer;
        // !!// MP Bitte nur bei Kamiden, Nythari, Sylvari und Morvani anzeigen.
        public int Magica => (int)Math.Floor(2 * Intelligenz + 1.5 * Willenskraft);
        public int INI => (int)Math.Floor((Geschicklichkeit + Ausdauer + Intelligenz) * 0.2);
        public int PA => (int)Math.Floor(0.7 * Geschicklichkeit + 0.1 * Ausdauer);
        public int ATN => (int)Math.Floor(0.6 * Stärke + 0.3 * Geschicklichkeit);
        public int ATF => (int)Math.Floor(0.7 * Geschicklichkeit + 0.2 * Stärke);
        public int DEF => (int)Math.Floor(0.6 * Ausdauer + 0.2 * Stärke);
        public int ATM => (int)Math.Floor(0.7 * Willenskraft + 0.3 * Intelligenz);
        public int DFM => (int)Math.Floor(0.6 * Ausdauer + 0.3 * Willenskraft);

        //Ausrüstung

        public Npc(string name, string race, string type, string gender, string job, string level)
        {
            Name = name;
            Race = race;
            Type = type;
            Gender = gender;
            Job = job;
            InitializeAttributes(level, job);
        }
        private void InitializeAttributes(string level, string job)
        {
            switch (level)
            {
                case "Lehrling":
                    Stärke = 6;
                    Geschicklichkeit = 6;
                    Ausdauer = 6;
                    Intelligenz = 6;
                    Willenskraft = 6;
                    Charisma = 6;
                    break;
                case "Geselle":
                    Stärke = 8;
                    Geschicklichkeit = 8;
                    Ausdauer = 8;
                    Intelligenz = 8;
                    Willenskraft = 8;
                    Charisma = 8;
                    break;
                case "Gelehrter":
                    Stärke = 11;
                    Geschicklichkeit = 11;
                    Ausdauer = 11;
                    Intelligenz = 11;
                    Willenskraft = 11;
                    Charisma = 11;
                    break;
                default:
                    throw new ArgumentException("Unbekanntes Level.");
            }
            switch (job)
            {
                case "Soldat":
                    Stärke += 3;
                    Ausdauer += 1;
                    Intelligenz -= 2;
                    break;
                case "Handwerker":
                    Geschicklichkeit += 3;
                    Charisma += 1;
                    Willenskraft -= 2;
                    break;
                case "Bauer":
                    Ausdauer += 3;
                    Stärke += 1;
                    Charisma -= 2;
                    break;
                case "Händler":
                    Charisma += 3;
                    Intelligenz += 1;
                    Stärke -= 2;
                    break;
                case "Magier":
                    Intelligenz += 3;
                    Willenskraft += 1;
                    Geschicklichkeit -= 2;
                    break;
                case "Zauberer":
                    Willenskraft += 3;
                    Intelligenz += 1;
                    Stärke -= 2;
                    break;
            }
        }
        // Methode zum hinzufügen der Rassenbonis
        public virtual void ApplyRacialBonus() { }
        public string GetNpcDetails()
        {
            return $"Typ: {Type}\n" +
                   $"Name: {Name}\n" +
                   $"Geschlecht: {Gender}\n" +
                   $"Klasse: {Job}\n" +
                   $"Level: {Level}";
        }
        public string GetNpcWerte()
        {
            // Beginne die Werteanzeige mit HP
            StringBuilder npcWerte = new StringBuilder();
            npcWerte.AppendLine($"Kampfwerte:\nHP: {HP}");

            // Zeige Magica nur an, wenn die Rasse Kamiden, Nythari, Sylvari oder Morvani ist
            if (Type == "Kamiden" || Type == "Nythari" || Type == "Sylvari" || Type == "Morvani")
            {
                npcWerte.AppendLine($"Magica: {Magica}");
            }

            // Den Rest der Kampfwerte hinzufügen
            npcWerte.AppendLine($"\nINI: {INI}\n" +
                                $"PA: {PA}\n" +
                                $"ATN: {ATN}\n" +
                                $"ATF: {ATF}\n" +
                                $"DEF: {DEF}\n" +
                                $"ATM: {ATM}\n" +
                                $"DFM: {DFM}");

            return npcWerte.ToString();
        }

        public virtual string GetEquipment()
        {
            if (Equipment == null || Equipment.Count == 0)
                return "Keine Ausrüstung.";

            StringBuilder sb = new StringBuilder();
            foreach (var item in Equipment)
            {
                sb.AppendLine($"{item.Name} ({item.Material}) - Werte: {item.Werte}");
            }
            return sb.ToString();
        }
    }
}

