using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NpcGenerator1._1
{
    public partial class FormNpc : Form
    {
        private Npc currentNpc;
        private readonly string[] weaponMaterials = { "Eisen", "Stahl", "Orkisch", "Sonstige" };
        private readonly string[] armorMaterials = { "Leder", "Faunen-Leder", "Eisen", "Stahl", "Orkisch", "Sonstige" };
        public static List<Npc> allNpcs = new List<Npc>();
        private const string npcDataFile = "npcdata.json";

        public FormNpc(Npc currentNpc, Equipment selectedEquipment)
        {
            InitializeComponent();

            this.currentNpc = currentNpc;

            RbM.Checked = true;

            CbRace.Items.AddRange(new[] { "Mensch", "Elf", "Faune", "Ork" });
            CbRace.SelectedIndex = 0;

            CbClass.Items.AddRange(new[] { "Soldat", "Handwerker", "Bauer", "Händler", "Magier", "Zauberer" });
            CbClass.SelectedIndex = 0;

            CbLevel.Items.AddRange(new[] { "Lehrling", "Geselle", "Gelehrter" });
            CbLevel.SelectedIndex = 0;

            LoadNpcData();

            NpcManager.LoadAllNpcs();

            LoadSavedNPCs();

            InitializeComboBoxes();

            UpdateEquipmentDisplay();


            if (currentNpc != null)
            {
                this.currentNpc = currentNpc;
                LoadNpcDetails(currentNpc);
            }
            if (selectedEquipment != null)
            {
                labelSelectedEquipment.Text = selectedEquipment.Name;
            }
            UpdateCbNNpc();
        }
        private void InitializeComboBoxes()
        {
            // Waffenarten
            CbWeapon.Items.AddRange(new[] { "Schwert", "Axt", "Dolch", "Stumpfewaffe", "Bogen", "Wurfwaffe" });
            CbWeapon.SelectedIndex = 0;

            // Rüstungsarten (falls benötigt)
            CbArmor.Items.AddRange(new[] { "Leicht", "Mittel", "Schwer", "Sonstige" });
            CbArmor.SelectedIndex = 0;

            UpdateMatsComboBox(isWeaponSelected: true); // Da zuerst die Waffe ausgewählt ist

            // Füge Events hinzu, um zu reagieren, wenn die Auswahl geändert wird
            CbWeapon.SelectedIndexChanged += CbWeapon_SelectedIndexChanged;
            CbArmor.SelectedIndexChanged += CbArmor_SelectedIndexChanged;

            //// Zauberarten (falls benötigt)
            //comboBoxZauber.Items.AddRange(new[] { "Wiederherstellung", "Illusion", "Beschwörung", "Sonstige" });
            //comboBoxZauber.SelectedIndex = 0;

            //// Tranktypen (falls benötigt)
            //comboBoxTrank.Items.AddRange(new[] { "Wiederherstellung", "Verstärkung", "Schwächung", "Sonstige" });
            //comboBoxTrank.SelectedIndex = 0;
        }

        //--------Speichern&Löschen----------------------------------------------------------------------------------
        //private void SaveNpcData()
        //{
        //    if (this.newNpc != null)
        //    {
        //        string json = JsonConvert.SerializeObject(allNpcs, Formatting.Indented);
        //        File.WriteAllText(npcDataFile, json);
        //    }
        //}
        //--------Laden-------------------------------------------------------------------------------------------------
        private void LoadNpcDetails(Npc npc)
        {
            if (npc != null)
            {
                labelDetails.Text = npc.GetNpcDetails();
                labelWerte.Text = npc.GetNpcWerte();

                labelSelectedEquipment.Text = "Ausrüstung:\n";
                foreach (var item in npc.Equipment)
                {
                    labelSelectedEquipment.Text += $"{item.Name} ({item.Material}) Wert:{item.Werte}\n";
                }

                if (npc.Equipment.Count == 0)
                {
                    labelSelectedEquipment.Text += "Keine Ausrüstung.";
                }
            }
        }
        private void LoadNpcData()
        {
            try
            {
                if (File.Exists(npcDataFile))
                {
                    string json = File.ReadAllText(npcDataFile);
                    FormDM.allNpcs = JsonConvert.DeserializeObject<List<Npc>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading NPCs: " + ex.Message);
            }
        }

        private void LoadSavedNPCs()
        {
            NpcManager.LoadAllNpcs();
            if (File.Exists(npcDataFile))
            {
                try
                {
                    string json = File.ReadAllText(npcDataFile);
                    allNpcs.Clear();
                    allNpcs.AddRange(JsonConvert.DeserializeObject<List<Npc>>(json, new NpcConverter()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading NPCs: " + ex.Message);
                }
            }
        }
        //--------Buttons------------------------------------------------------------------------------------------------
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (currentNpc != null)
            {
                // Füge den NPC zur Liste hinzu, falls er noch nicht darin enthalten ist
                if (!allNpcs.Contains(currentNpc))
                {
                    allNpcs.Add(currentNpc);
                }

                // NPCs werden jetzt gespeichert
                NpcManager.SaveAllNpcs(allNpcs);
                UpdateCbNNpc();  // Aktualisiere die ComboBox nach dem Speichern
            }
        }

        private void BtnCW_Click(object sender, EventArgs e)
        {
            if (currentNpc == null)
            {
                MessageBox.Show("Bitte wählen Sie zuerst einen NPC aus.");
                return;
            }

            string selectedMaterial = CbMaterial.SelectedItem.ToString();
            string selectedWeapon = CbWeapon.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedMaterial) || string.IsNullOrEmpty(selectedWeapon))
            {
                MessageBox.Show("Bitte eine Waffe und ein Material auswählen.");
                return;
            }

            Weapon.WaffenArt art;
            switch (selectedWeapon)
            {
                case "Schwert":
                    art = Weapon.WaffenArt.Schwert;
                    break;
                case "Axt":
                    art = Weapon.WaffenArt.Axt;
                    break;
                case "Dolch":
                    art = Weapon.WaffenArt.Dolch;
                    break;
                case "Stumpfewaffe":
                    art = Weapon.WaffenArt.Stumpfewaffe;
                    break;
                case "Bogen":
                    art = Weapon.WaffenArt.Bogen;
                    break;
                case "Wurfwaffe":
                    art = Weapon.WaffenArt.Wurfwaffe;
                    break;
                default:
                    MessageBox.Show("Keine Waffe");
                    return;
            }

            Weapon newWeapon = new Weapon(selectedWeapon, selectedMaterial, art, 0);
            newWeapon.ApplyWeaponBonus();

            currentNpc.Equipment.Add(newWeapon);

            UpdateEquipmentDisplay();
        }

        private void BtnCA_Click(object sender, EventArgs e)
        {
            if (currentNpc == null)
            {
                MessageBox.Show("Bitte wählen Sie zuerst einen NPC aus.");
                return;
            }

            string selectedMaterial = CbMaterial.SelectedItem.ToString();
            string selectedArmor = CbArmor.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedMaterial) || string.IsNullOrEmpty(selectedArmor))
            {
                MessageBox.Show("Bitte eine Rüstung und ein Material auswählen.");
                return;
            }

            Armor.RüstungsArt art;
            switch (selectedArmor)
            {
                case "Leicht":
                    art = Armor.RüstungsArt.Leicht;
                    break;
                case "Mittel":
                    art = Armor.RüstungsArt.Mittel;
                    break;
                case "Schwer":
                    art = Armor.RüstungsArt.Schwer;
                    break;
                case "Sonstige":
                    art = Armor.RüstungsArt.Sonstige;
                    break;
                default:
                    MessageBox.Show("Keine Rüstung ausgewählt.");
                    return;
            }
            Armor newArmor = new Armor(selectedArmor, selectedMaterial, art, 0);
            newArmor.ApplyArmorBonus();
            currentNpc.Equipment.Add(newArmor);
            UpdateEquipmentDisplay();
        }
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string selectedRace = CbRace.SelectedItem.ToString();
            string selectedType = CbRaceType.SelectedItem.ToString();
            string selectedGender = GetSelectedGender();
            string selectedJob = CbClass.SelectedItem.ToString();
            string selectedLevel = CbLevel.SelectedItem.ToString();

            // Erstelle einen neuen NPC basierend auf der ausgewählten Rasse und Typ
            currentNpc = GenerateNpc(selectedRace, selectedType, selectedGender, selectedJob, selectedLevel);

            if (currentNpc != null)
            {
                LoadNpcDetails(currentNpc);  // Display the generated NPC
            }
        }

        private void BtnDeleteNpc_Click(object sender, EventArgs e)
        {
            if (currentNpc != null)
            {
                // Entferne den NPC aus der allNpcs-Liste und aktualisiere die JSON-Datei
                allNpcs.Remove(currentNpc);
                NpcManager.SaveAllNpcs(allNpcs);  // JSON-Datei aktualisieren

                // ComboBox und UI aktualisieren
                UpdateCbNNpc();
                labelDetails.Text = string.Empty;  // NPC-Details zurücksetzen
                labelSelectedEquipment.Text = "Keine Ausrüstung.";  // Ausrüstungsanzeige zurücksetzen
                currentNpc = null;  // Aktuellen NPC auf null setzen
            }
            else
            {
                MessageBox.Show("Kein NPC zum Löschen ausgewählt.");
            }
        }

        private void BtnDeleteEquip_Click(object sender, EventArgs e)
        {
            if (currentNpc != null && currentNpc.Equipment.Count > 0)
            {
                var selectedItem = currentNpc.Equipment.FirstOrDefault();  // Beispielhaft das erste Item
                if (selectedItem != null)
                {
                    currentNpc.Equipment.Remove(selectedItem);
                    UpdateEquipmentDisplay();  // Anzeige nach dem Entfernen aktualisieren
                }
                else
                {
                    MessageBox.Show("Kein Ausrüstungsteil zum Löschen vorhanden.");
                }
            }
            else
            {
                MessageBox.Show("Keine Ausrüstung vorhanden.");
            }
        }
        //--------Generieren-------------------------------------------------------------------------------------------------------------------------------------
        private Npc GenerateNpc(string selectedRace, string selectedType, string selectedGender, string selectedJob, string selectedLevel)
        {
            Npc newNpc;

            switch (selectedRace)
            {
                case "Mensch":
                    // Konvertiere den selectedType von string in MenschTyp
                    var menschTyp = (Mensch.MenschTyp)Enum.Parse(typeof(Mensch.MenschTyp), selectedType);
                    newNpc = new Mensch(NameGenerator.GenerateRandomName("Mensch", selectedGender), menschTyp, selectedGender, selectedJob, selectedLevel);
                    break;

                case "Elf":
                    // Konvertiere den selectedType von string in ElfTyp
                    var elfTyp = (Elf.ElfTyp)Enum.Parse(typeof(Elf.ElfTyp), selectedType);
                    newNpc = new Elf(NameGenerator.GenerateRandomName("Elf", selectedGender), elfTyp, selectedGender, selectedJob, selectedLevel);
                    break;

                case "Faune":
                    // Konvertiere den selectedType von string in FauneTyp
                    var fauneTyp = (Faune.FauneTyp)Enum.Parse(typeof(Faune.FauneTyp), selectedType);
                    newNpc = new Faune(NameGenerator.GenerateRandomName("Faune", selectedGender), fauneTyp, selectedGender, selectedJob, selectedLevel);
                    break;

                case "Ork":
                    // Konvertiere den selectedType von string in OrkTyp
                    var orkTyp = (Ork.OrkTyp)Enum.Parse(typeof(Ork.OrkTyp), selectedType);
                    newNpc = new Ork(NameGenerator.GenerateRandomName("Ork", selectedGender), orkTyp, selectedGender, selectedJob, selectedLevel);
                    break;

                default:
                    MessageBox.Show("Ungültige Rasse ausgewählt!");
                    return null;
            }
            currentNpc = newNpc;
            LoadNpcDetails(currentNpc);
            return currentNpc;
        }
        //--------Updates---------------------------------------------------------------------------------------------------------------
        private void UpdateCbNNpc()
        {
            CbNNpc.DataSource = null; // Setze die DataSource auf null, um die ComboBox zu aktualisieren
            CbNNpc.DataSource = allNpcs; // Fülle die ComboBox mit der neuen Liste
            CbNNpc.DisplayMember = "Name"; // Zeige den Namen in der ComboBox an
        }
        private void UpdateMatsComboBox(bool isWeaponSelected)
        {
            CbMaterial.Items.Clear(); // Leere zuerst die ComboBox

            if (isWeaponSelected)
            {
                CbMaterial.Items.AddRange(weaponMaterials); // Füge nur Waffen-Materialien hinzu
            }
            else
            {
                CbMaterial.Items.AddRange(armorMaterials); // Füge alle Rüstungsmaterialien hinzu
            }

            CbMaterial.SelectedIndex = 0; // Wähle das erste Material aus
        }
        private void UpdateEquipmentDisplay()
        {
            labelSelectedEquipment.Text = "Ausrüstung:\n";

            if (currentNpc?.Equipment != null && currentNpc.Equipment.Count > 0)
            {
                foreach (var item in currentNpc.Equipment)
                {
                    labelSelectedEquipment.Text += $"{item.Name} ({item.Material}) Wert: {item.Werte}\n";
                }
            }
            else
            {
                labelSelectedEquipment.Text += "Keine Ausrüstung vorhanden.";
            }
        }
        //--------Cb&Rb--------------------------------------------------------------------
        private void CbWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMatsComboBox(isWeaponSelected: true);
        }
        private void CbArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMatsComboBox(isWeaponSelected: false);
        }

        private void CbRaceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbRaceType.Items.Clear();
            switch (CbRace.SelectedItem.ToString())
            {
                case "Mensch":
                    CbRaceType.Items.AddRange(Enum.GetNames(typeof(Mensch.MenschTyp)));
                    break;
                case "Elf":
                    CbRaceType.Items.AddRange(Enum.GetNames(typeof(Elf.ElfTyp)));
                    break;
                case "Faune":
                    CbRaceType.Items.AddRange(Enum.GetNames(typeof(Faune.FauneTyp)));
                    break;
                case "Ork":
                    CbRaceType.Items.AddRange(Enum.GetNames(typeof(Ork.OrkTyp)));
                    break;
            }
            CbRaceType.SelectedIndex = 0;
        }
        private void CbNNpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbNNpc.SelectedItem is Npc selectedNpc)
            {
                currentNpc = selectedNpc;
                LoadNpcDetails(selectedNpc);
            }
        }
        private string GetSelectedGender()
        {
            if (RbM.Checked)
                return "Männlich";
            else
                return "Weiblich";
        }
        //--------Ende---------------------------------------------------------------------
        private void FormNpc_Load(object sender, EventArgs e)
        {

        }


    }
}
