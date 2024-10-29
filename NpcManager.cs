using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NpcGenerator1._1
{
    internal class NpcManager
    {
        private const string npcDataFile = "npcdata.json";

        public static void LoadAllNpcs()
        {
            if (File.Exists(npcDataFile))
            {
                try
                {
                    string json = File.ReadAllText(npcDataFile);
                    FormNpc.allNpcs.Clear();  // Leere die Liste zuerst
                    FormNpc.allNpcs.AddRange(JsonConvert.DeserializeObject<List<Npc>>(json, new NpcConverter()));  // Fülle die Liste
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Laden der NPCs: " + ex.Message);
                }
            }
        }

        public static void SaveAllNpcs(List<Npc> npcs)
        {
            string json = JsonConvert.SerializeObject(npcs, Formatting.Indented, new NpcConverter());
            File.WriteAllText("npcdata.json", json);
        }
    }
}
