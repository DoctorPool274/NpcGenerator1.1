using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace NpcGenerator1._1
{
    public class NpcConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Npc).IsAssignableFrom(objectType);
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            string race = jsonObject["Race"]?.Value<string>();
            string type = jsonObject["Type"]?.Value<string>();
            string name = jsonObject["Name"]?.Value<string>();
            string gender = jsonObject["Gender"]?.Value<string>();
            string job = jsonObject["Job"]?.Value<string>();
            string level = jsonObject["Level"]?.Value<string>();

            Npc npc = CreateNpcByRace(race, type, name, gender, job, level);

            // Load Attributes
            npc.Stärke = jsonObject["Stärke"]?.Value<int>() ?? 0;
            npc.Geschicklichkeit = jsonObject["Geschicklichkeit"]?.Value<int>() ?? 0;
            npc.Ausdauer = jsonObject["Ausdauer"]?.Value<int>() ?? 0;
            npc.Intelligenz = jsonObject["Intelligenz"]?.Value<int>() ?? 0;
            npc.Willenskraft = jsonObject["Willenskraft"]?.Value<int>() ?? 0;
            npc.Charisma = jsonObject["Charisma"]?.Value<int>() ?? 0;

            // Load Equipment
            var equipmentArray = jsonObject["Equipment"]?.ToObject<List<JObject>>();
            if (equipmentArray != null)
            {
                foreach (var equipment in equipmentArray)
                {
                    string equipmentType = equipment["Type"]?.Value<string>();
                    string itemName = equipment["Name"]?.Value<string>();
                    string itemMaterial = equipment["Material"]?.Value<string>();
                    int itemWerte = equipment["Werte"]?.Value<int>() ?? 0; // Werte-Wert aus JSON extrahieren
                    string itemArt = equipment["Art"]?.Value<string>();

                    if (equipmentType == nameof(Weapon))
                    {
                        if (Enum.TryParse(itemArt, out Weapon.WaffenArt weaponArt))
                        {
                            var newWeapon = new Weapon(itemName, itemMaterial, weaponArt, itemWerte); // Setze den extrahierten Werte-Wert
                            npc.Equipment.Add(newWeapon);
                        }
                    }
                    else if (equipmentType == nameof(Armor))
                    {
                        if (Enum.TryParse(itemArt, out Armor.RüstungsArt armorArt))
                        {
                            var newArmor = new Armor(itemName, itemMaterial, armorArt, itemWerte); // Setze den extrahierten Werte-Wert
                            npc.Equipment.Add(newArmor);
                        }
                    }
                }
            }

            return npc;
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var npc = (Npc)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Race");
            writer.WriteValue(npc.Race);
            writer.WritePropertyName("Type");
            writer.WriteValue(npc.Type);
            writer.WritePropertyName("Name");
            writer.WriteValue(npc.Name);
            writer.WritePropertyName("Gender");
            writer.WriteValue(npc.Gender);
            writer.WritePropertyName("Job");
            writer.WriteValue(npc.Job);
            writer.WritePropertyName("Level");
            writer.WriteValue(npc.Level);

            writer.WritePropertyName("Stärke");
            writer.WriteValue(npc.Stärke);
            writer.WritePropertyName("Geschicklichkeit");
            writer.WriteValue(npc.Geschicklichkeit);
            writer.WritePropertyName("Ausdauer");
            writer.WriteValue(npc.Ausdauer);
            writer.WritePropertyName("Intelligenz");
            writer.WriteValue(npc.Intelligenz);
            writer.WritePropertyName("Willenskraft");
            writer.WriteValue(npc.Willenskraft);
            writer.WritePropertyName("Charisma");
            writer.WriteValue(npc.Charisma);

            writer.WritePropertyName("Equipment");
            writer.WriteStartArray();
            foreach (var equipment in npc.Equipment)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("Type");
                writer.WriteValue(equipment.GetType().Name);
                writer.WritePropertyName("Name");
                writer.WriteValue(equipment.Name);
                writer.WritePropertyName("Material");
                writer.WriteValue(equipment.Material);
                writer.WritePropertyName("Werte");
                writer.WriteValue(equipment.Werte);

                if (equipment is Weapon weapon)
                {
                    writer.WritePropertyName("Art");
                    writer.WriteValue(weapon.Art.ToString());
                }
                else if (equipment is Armor armor)
                {
                    writer.WritePropertyName("Art");
                    writer.WriteValue(armor.Art.ToString());
                }

                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            writer.WriteEndObject();
        }
        private Npc CreateNpcByRace(string race, string type, string name, string gender, string job, string level)
        {
            switch (race)
            {
                case "Mensch":
                    if (!string.IsNullOrEmpty(type) && Enum.TryParse<Mensch.MenschTyp>(type, out var menschType))
                    {
                        return new Mensch(name, menschType, gender, job, level);
                    }
                    break;

                case "Elf":
                    if (!string.IsNullOrEmpty(type) && Enum.TryParse<Elf.ElfTyp>(type, out var elfType))
                    {
                        return new Elf(name, elfType, gender, job, level);
                    }
                    break;

                case "Faune":
                    if (!string.IsNullOrEmpty(type) && Enum.TryParse<Faune.FauneTyp>(type, out var fauneType))
                    {
                        return new Faune(name, fauneType, gender, job, level);
                    }
                    break;

                case "Ork":
                    if (!string.IsNullOrEmpty(type) && Enum.TryParse<Ork.OrkTyp>(type, out var orkType))
                    {
                        return new Ork(name, orkType, gender, job, level);
                    }
                    break;
            }
            throw new Exception("Unknown race or invalid type.");
        }
    }
}
