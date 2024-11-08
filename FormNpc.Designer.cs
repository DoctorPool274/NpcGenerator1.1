namespace NpcGenerator1._1
{
    partial class FormNpc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNpc));
            this.CbNNpc = new System.Windows.Forms.ComboBox();
            this.CbWeapon = new System.Windows.Forms.ComboBox();
            this.CbArmor = new System.Windows.Forms.ComboBox();
            this.CbMaterial = new System.Windows.Forms.ComboBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelSelectedEquipment = new System.Windows.Forms.Label();
            this.labelWerte = new System.Windows.Forms.Label();
            this.BtnCA = new System.Windows.Forms.Button();
            this.BtnCW = new System.Windows.Forms.Button();
            this.CbRace = new System.Windows.Forms.ComboBox();
            this.CbRaceType = new System.Windows.Forms.ComboBox();
            this.CbLevel = new System.Windows.Forms.ComboBox();
            this.CbClass = new System.Windows.Forms.ComboBox();
            this.RbW = new System.Windows.Forms.RadioButton();
            this.RbM = new System.Windows.Forms.RadioButton();
            this.BtnDeleteEquip = new System.Windows.Forms.Button();
            this.BtnDeleteNpc = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CbPotion = new System.Windows.Forms.ComboBox();
            this.BtnPotion = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbNNpc
            // 
            this.CbNNpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNNpc.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbNNpc.FormattingEnabled = true;
            this.CbNNpc.Location = new System.Drawing.Point(3, 311);
            this.CbNNpc.Name = "CbNNpc";
            this.CbNNpc.Size = new System.Drawing.Size(189, 30);
            this.CbNNpc.TabIndex = 4;
            this.CbNNpc.SelectedIndexChanged += new System.EventHandler(this.CbNNpc_SelectedIndexChanged);
            // 
            // CbWeapon
            // 
            this.CbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbWeapon.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbWeapon.FormattingEnabled = true;
            this.CbWeapon.Location = new System.Drawing.Point(3, 431);
            this.CbWeapon.Name = "CbWeapon";
            this.CbWeapon.Size = new System.Drawing.Size(189, 30);
            this.CbWeapon.TabIndex = 5;
            this.CbWeapon.SelectedIndexChanged += new System.EventHandler(this.CbWeapon_SelectedIndexChanged);
            // 
            // CbArmor
            // 
            this.CbArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbArmor.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbArmor.FormattingEnabled = true;
            this.CbArmor.Location = new System.Drawing.Point(3, 511);
            this.CbArmor.Name = "CbArmor";
            this.CbArmor.Size = new System.Drawing.Size(189, 30);
            this.CbArmor.TabIndex = 6;
            this.CbArmor.SelectedIndexChanged += new System.EventHandler(this.CbArmor_SelectedIndexChanged);
            // 
            // CbMaterial
            // 
            this.CbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMaterial.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbMaterial.FormattingEnabled = true;
            this.CbMaterial.Location = new System.Drawing.Point(3, 395);
            this.CbMaterial.Name = "CbMaterial";
            this.CbMaterial.Size = new System.Drawing.Size(189, 30);
            this.CbMaterial.TabIndex = 7;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(216, 24);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(162, 31);
            this.labelDetails.TabIndex = 11;
            this.labelDetails.Text = "Npc Ausgabe";
            // 
            // labelSelectedEquipment
            // 
            this.labelSelectedEquipment.AutoSize = true;
            this.labelSelectedEquipment.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedEquipment.Location = new System.Drawing.Point(456, 248);
            this.labelSelectedEquipment.Name = "labelSelectedEquipment";
            this.labelSelectedEquipment.Size = new System.Drawing.Size(145, 31);
            this.labelSelectedEquipment.TabIndex = 13;
            this.labelSelectedEquipment.Text = "Ausrüstung";
            // 
            // labelWerte
            // 
            this.labelWerte.AutoSize = true;
            this.labelWerte.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWerte.Location = new System.Drawing.Point(216, 248);
            this.labelWerte.Name = "labelWerte";
            this.labelWerte.Size = new System.Drawing.Size(157, 31);
            this.labelWerte.TabIndex = 12;
            this.labelWerte.Text = "Kampfwerte";
            // 
            // BtnCA
            // 
            this.BtnCA.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCA.Location = new System.Drawing.Point(3, 547);
            this.BtnCA.Name = "BtnCA";
            this.BtnCA.Size = new System.Drawing.Size(189, 36);
            this.BtnCA.TabIndex = 15;
            this.BtnCA.Text = "Rüstung";
            this.BtnCA.UseVisualStyleBackColor = true;
            this.BtnCA.Click += new System.EventHandler(this.BtnCA_Click);
            // 
            // BtnCW
            // 
            this.BtnCW.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCW.Location = new System.Drawing.Point(3, 467);
            this.BtnCW.Name = "BtnCW";
            this.BtnCW.Size = new System.Drawing.Size(189, 38);
            this.BtnCW.TabIndex = 14;
            this.BtnCW.Text = "Waffe";
            this.BtnCW.UseVisualStyleBackColor = true;
            this.BtnCW.Click += new System.EventHandler(this.BtnCW_Click);
            // 
            // CbRace
            // 
            this.CbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRace.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRace.FormattingEnabled = true;
            this.CbRace.Location = new System.Drawing.Point(3, 3);
            this.CbRace.Name = "CbRace";
            this.CbRace.Size = new System.Drawing.Size(189, 30);
            this.CbRace.TabIndex = 16;
            this.CbRace.SelectedIndexChanged += new System.EventHandler(this.CbRace_SelectedIndexChanged);
            // 
            // CbRaceType
            // 
            this.CbRaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRaceType.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRaceType.FormattingEnabled = true;
            this.CbRaceType.Location = new System.Drawing.Point(3, 39);
            this.CbRaceType.Name = "CbRaceType";
            this.CbRaceType.Size = new System.Drawing.Size(189, 30);
            this.CbRaceType.TabIndex = 17;
            this.CbRaceType.SelectedIndexChanged += new System.EventHandler(this.CbRaceType_SelectedIndexChanged);
            // 
            // CbLevel
            // 
            this.CbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLevel.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbLevel.FormattingEnabled = true;
            this.CbLevel.Location = new System.Drawing.Point(3, 111);
            this.CbLevel.Name = "CbLevel";
            this.CbLevel.Size = new System.Drawing.Size(189, 30);
            this.CbLevel.TabIndex = 18;
            // 
            // CbClass
            // 
            this.CbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbClass.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbClass.FormattingEnabled = true;
            this.CbClass.Location = new System.Drawing.Point(3, 75);
            this.CbClass.Name = "CbClass";
            this.CbClass.Size = new System.Drawing.Size(189, 30);
            this.CbClass.TabIndex = 19;
            // 
            // RbW
            // 
            this.RbW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RbW.AutoSize = true;
            this.RbW.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbW.Location = new System.Drawing.Point(4, 181);
            this.RbW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbW.Name = "RbW";
            this.RbW.Size = new System.Drawing.Size(95, 25);
            this.RbW.TabIndex = 21;
            this.RbW.TabStop = true;
            this.RbW.Text = "Weiblich";
            this.RbW.UseVisualStyleBackColor = true;
            // 
            // RbM
            // 
            this.RbM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RbM.AutoSize = true;
            this.RbM.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbM.Location = new System.Drawing.Point(4, 148);
            this.RbM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbM.Name = "RbM";
            this.RbM.Size = new System.Drawing.Size(101, 25);
            this.RbM.TabIndex = 20;
            this.RbM.TabStop = true;
            this.RbM.Text = "Männlich";
            this.RbM.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteEquip
            // 
            this.BtnDeleteEquip.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteEquip.Location = new System.Drawing.Point(3, 667);
            this.BtnDeleteEquip.Name = "BtnDeleteEquip";
            this.BtnDeleteEquip.Size = new System.Drawing.Size(189, 50);
            this.BtnDeleteEquip.TabIndex = 23;
            this.BtnDeleteEquip.Text = "Lösche Equip";
            this.BtnDeleteEquip.UseVisualStyleBackColor = true;
            this.BtnDeleteEquip.Click += new System.EventHandler(this.BtnDeleteEquip_Click);
            // 
            // BtnDeleteNpc
            // 
            this.BtnDeleteNpc.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteNpc.Location = new System.Drawing.Point(3, 347);
            this.BtnDeleteNpc.Name = "BtnDeleteNpc";
            this.BtnDeleteNpc.Size = new System.Drawing.Size(189, 42);
            this.BtnDeleteNpc.TabIndex = 22;
            this.BtnDeleteNpc.Text = "Lösche Npc";
            this.BtnDeleteNpc.UseVisualStyleBackColor = true;
            this.BtnDeleteNpc.Click += new System.EventHandler(this.BtnDeleteNpc_Click);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGenerate.AutoSize = true;
            this.BtnGenerate.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.Location = new System.Drawing.Point(4, 214);
            this.BtnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(188, 41);
            this.BtnGenerate.TabIndex = 24;
            this.BtnGenerate.Text = "Erstellen";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.AutoSize = true;
            this.BtnSave.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(4, 263);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(188, 41);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbPotion
            // 
            this.CbPotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPotion.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPotion.FormattingEnabled = true;
            this.CbPotion.Location = new System.Drawing.Point(3, 589);
            this.CbPotion.Name = "CbPotion";
            this.CbPotion.Size = new System.Drawing.Size(189, 30);
            this.CbPotion.TabIndex = 26;
            this.CbPotion.SelectedIndexChanged += new System.EventHandler(this.CbPotion_SelectedIndexChanged);
            // 
            // BtnPotion
            // 
            this.BtnPotion.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPotion.Location = new System.Drawing.Point(3, 625);
            this.BtnPotion.Name = "BtnPotion";
            this.BtnPotion.Size = new System.Drawing.Size(189, 36);
            this.BtnPotion.TabIndex = 28;
            this.BtnPotion.Text = "Trank";
            this.BtnPotion.UseVisualStyleBackColor = true;
            this.BtnPotion.Click += new System.EventHandler(this.BtnPotion_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CbRace);
            this.flowLayoutPanel1.Controls.Add(this.CbRaceType);
            this.flowLayoutPanel1.Controls.Add(this.CbClass);
            this.flowLayoutPanel1.Controls.Add(this.CbLevel);
            this.flowLayoutPanel1.Controls.Add(this.RbM);
            this.flowLayoutPanel1.Controls.Add(this.RbW);
            this.flowLayoutPanel1.Controls.Add(this.BtnGenerate);
            this.flowLayoutPanel1.Controls.Add(this.BtnSave);
            this.flowLayoutPanel1.Controls.Add(this.CbNNpc);
            this.flowLayoutPanel1.Controls.Add(this.BtnDeleteNpc);
            this.flowLayoutPanel1.Controls.Add(this.CbMaterial);
            this.flowLayoutPanel1.Controls.Add(this.CbWeapon);
            this.flowLayoutPanel1.Controls.Add(this.BtnCW);
            this.flowLayoutPanel1.Controls.Add(this.CbArmor);
            this.flowLayoutPanel1.Controls.Add(this.BtnCA);
            this.flowLayoutPanel1.Controls.Add(this.CbPotion);
            this.flowLayoutPanel1.Controls.Add(this.BtnPotion);
            this.flowLayoutPanel1.Controls.Add(this.BtnDeleteEquip);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 736);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // FormNpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 741);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelSelectedEquipment);
            this.Controls.Add(this.labelWerte);
            this.Controls.Add(this.labelDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNpc";
            this.Text = "FormNpc";
            this.Load += new System.EventHandler(this.FormNpc_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbNNpc;
        private System.Windows.Forms.ComboBox CbWeapon;
        private System.Windows.Forms.ComboBox CbArmor;
        private System.Windows.Forms.ComboBox CbMaterial;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelSelectedEquipment;
        private System.Windows.Forms.Label labelWerte;
        private System.Windows.Forms.Button BtnCA;
        private System.Windows.Forms.Button BtnCW;
        private System.Windows.Forms.ComboBox CbRace;
        private System.Windows.Forms.ComboBox CbRaceType;
        private System.Windows.Forms.ComboBox CbLevel;
        private System.Windows.Forms.ComboBox CbClass;
        private System.Windows.Forms.RadioButton RbW;
        private System.Windows.Forms.RadioButton RbM;
        private System.Windows.Forms.Button BtnDeleteEquip;
        private System.Windows.Forms.Button BtnDeleteNpc;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CbPotion;
        private System.Windows.Forms.Button BtnPotion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}