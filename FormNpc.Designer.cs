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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CbNNpc = new System.Windows.Forms.ComboBox();
            this.CbWeapon = new System.Windows.Forms.ComboBox();
            this.CbArmor = new System.Windows.Forms.ComboBox();
            this.CbMaterial = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(50, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Name:";
            // 
            // CbNNpc
            // 
            this.CbNNpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNNpc.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbNNpc.FormattingEnabled = true;
            this.CbNNpc.Location = new System.Drawing.Point(50, 179);
            this.CbNNpc.Name = "CbNNpc";
            this.CbNNpc.Size = new System.Drawing.Size(269, 33);
            this.CbNNpc.TabIndex = 4;
            this.CbNNpc.SelectedIndexChanged += new System.EventHandler(this.CbNNpc_SelectedIndexChanged);
            // 
            // CbWeapon
            // 
            this.CbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbWeapon.FormattingEnabled = true;
            this.CbWeapon.Location = new System.Drawing.Point(178, 273);
            this.CbWeapon.Name = "CbWeapon";
            this.CbWeapon.Size = new System.Drawing.Size(121, 24);
            this.CbWeapon.TabIndex = 5;
            this.CbWeapon.SelectedIndexChanged += new System.EventHandler(this.CbWeapon_SelectedIndexChanged);
            // 
            // CbArmor
            // 
            this.CbArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbArmor.FormattingEnabled = true;
            this.CbArmor.Location = new System.Drawing.Point(309, 272);
            this.CbArmor.Name = "CbArmor";
            this.CbArmor.Size = new System.Drawing.Size(121, 24);
            this.CbArmor.TabIndex = 6;
            this.CbArmor.SelectedIndexChanged += new System.EventHandler(this.CbArmor_SelectedIndexChanged);
            // 
            // CbMaterial
            // 
            this.CbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMaterial.FormattingEnabled = true;
            this.CbMaterial.Location = new System.Drawing.Point(51, 273);
            this.CbMaterial.Name = "CbMaterial";
            this.CbMaterial.Size = new System.Drawing.Size(121, 24);
            this.CbMaterial.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(309, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Rüstungen:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(178, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Waffen:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(51, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Material:";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(44, 401);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(162, 31);
            this.labelDetails.TabIndex = 11;
            this.labelDetails.Text = "Npc Ausgabe";
            // 
            // labelSelectedEquipment
            // 
            this.labelSelectedEquipment.AutoSize = true;
            this.labelSelectedEquipment.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedEquipment.Location = new System.Drawing.Point(45, 593);
            this.labelSelectedEquipment.Name = "labelSelectedEquipment";
            this.labelSelectedEquipment.Size = new System.Drawing.Size(145, 31);
            this.labelSelectedEquipment.TabIndex = 13;
            this.labelSelectedEquipment.Text = "Ausrüstung";
            // 
            // labelWerte
            // 
            this.labelWerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWerte.AutoSize = true;
            this.labelWerte.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWerte.Location = new System.Drawing.Point(399, 401);
            this.labelWerte.Name = "labelWerte";
            this.labelWerte.Size = new System.Drawing.Size(157, 31);
            this.labelWerte.TabIndex = 12;
            this.labelWerte.Text = "Kampfwerte";
            // 
            // BtnCA
            // 
            this.BtnCA.Location = new System.Drawing.Point(309, 302);
            this.BtnCA.Name = "BtnCA";
            this.BtnCA.Size = new System.Drawing.Size(101, 23);
            this.BtnCA.TabIndex = 15;
            this.BtnCA.Text = "Rüstung";
            this.BtnCA.UseVisualStyleBackColor = true;
            this.BtnCA.Click += new System.EventHandler(this.BtnCA_Click);
            // 
            // BtnCW
            // 
            this.BtnCW.Location = new System.Drawing.Point(178, 303);
            this.BtnCW.Name = "BtnCW";
            this.BtnCW.Size = new System.Drawing.Size(101, 23);
            this.BtnCW.TabIndex = 14;
            this.BtnCW.Text = "Waffe";
            this.BtnCW.UseVisualStyleBackColor = true;
            this.BtnCW.Click += new System.EventHandler(this.BtnCW_Click);
            // 
            // CbRace
            // 
            this.CbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRace.FormattingEnabled = true;
            this.CbRace.Location = new System.Drawing.Point(50, 14);
            this.CbRace.Name = "CbRace";
            this.CbRace.Size = new System.Drawing.Size(121, 24);
            this.CbRace.TabIndex = 16;
            this.CbRace.SelectedIndexChanged += new System.EventHandler(this.CbRace_SelectedIndexChanged);
            // 
            // CbRaceType
            // 
            this.CbRaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRaceType.FormattingEnabled = true;
            this.CbRaceType.Location = new System.Drawing.Point(181, 14);
            this.CbRaceType.Name = "CbRaceType";
            this.CbRaceType.Size = new System.Drawing.Size(121, 24);
            this.CbRaceType.TabIndex = 17;
            this.CbRaceType.SelectedIndexChanged += new System.EventHandler(this.CbRaceType_SelectedIndexChanged);
            // 
            // CbLevel
            // 
            this.CbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLevel.FormattingEnabled = true;
            this.CbLevel.Location = new System.Drawing.Point(435, 14);
            this.CbLevel.Name = "CbLevel";
            this.CbLevel.Size = new System.Drawing.Size(121, 24);
            this.CbLevel.TabIndex = 18;
            // 
            // CbClass
            // 
            this.CbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbClass.FormattingEnabled = true;
            this.CbClass.Location = new System.Drawing.Point(308, 14);
            this.CbClass.Name = "CbClass";
            this.CbClass.Size = new System.Drawing.Size(121, 24);
            this.CbClass.TabIndex = 19;
            // 
            // RbW
            // 
            this.RbW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RbW.AutoSize = true;
            this.RbW.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbW.Location = new System.Drawing.Point(183, 76);
            this.RbW.Margin = new System.Windows.Forms.Padding(4);
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
            this.RbM.Location = new System.Drawing.Point(51, 76);
            this.RbM.Margin = new System.Windows.Forms.Padding(4);
            this.RbM.Name = "RbM";
            this.RbM.Size = new System.Drawing.Size(101, 25);
            this.RbM.TabIndex = 20;
            this.RbM.TabStop = true;
            this.RbM.Text = "Männlich";
            this.RbM.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteEquip
            // 
            this.BtnDeleteEquip.Location = new System.Drawing.Point(51, 303);
            this.BtnDeleteEquip.Name = "BtnDeleteEquip";
            this.BtnDeleteEquip.Size = new System.Drawing.Size(101, 26);
            this.BtnDeleteEquip.TabIndex = 23;
            this.BtnDeleteEquip.Text = "Lösche Equip";
            this.BtnDeleteEquip.UseVisualStyleBackColor = true;
            this.BtnDeleteEquip.Click += new System.EventHandler(this.BtnDeleteEquip_Click);
            // 
            // BtnDeleteNpc
            // 
            this.BtnDeleteNpc.Location = new System.Drawing.Point(328, 179);
            this.BtnDeleteNpc.Name = "BtnDeleteNpc";
            this.BtnDeleteNpc.Size = new System.Drawing.Size(105, 33);
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
            this.BtnGenerate.Location = new System.Drawing.Point(308, 76);
            this.BtnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(158, 51);
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
            this.BtnSave.Location = new System.Drawing.Point(474, 75);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(157, 53);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FormNpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 756);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.BtnDeleteEquip);
            this.Controls.Add(this.BtnDeleteNpc);
            this.Controls.Add(this.RbW);
            this.Controls.Add(this.RbM);
            this.Controls.Add(this.CbClass);
            this.Controls.Add(this.CbLevel);
            this.Controls.Add(this.CbRaceType);
            this.Controls.Add(this.CbRace);
            this.Controls.Add(this.BtnCA);
            this.Controls.Add(this.BtnCW);
            this.Controls.Add(this.labelSelectedEquipment);
            this.Controls.Add(this.labelWerte);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CbMaterial);
            this.Controls.Add(this.CbArmor);
            this.Controls.Add(this.CbWeapon);
            this.Controls.Add(this.CbNNpc);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNpc";
            this.Text = "FormNpc";
            this.Load += new System.EventHandler(this.FormNpc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CbNNpc;
        private System.Windows.Forms.ComboBox CbWeapon;
        private System.Windows.Forms.ComboBox CbArmor;
        private System.Windows.Forms.ComboBox CbMaterial;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
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
    }
}