namespace NpcGenerator1._1
{
    partial class FormDM
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPlayer = new System.Windows.Forms.Button();
            this.BtnMap = new System.Windows.Forms.Button();
            this.BtnThings = new System.Windows.Forms.Button();
            this.BtnNpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlayer
            // 
            this.BtnPlayer.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayer.Location = new System.Drawing.Point(39, 37);
            this.BtnPlayer.Name = "BtnPlayer";
            this.BtnPlayer.Size = new System.Drawing.Size(131, 93);
            this.BtnPlayer.TabIndex = 0;
            this.BtnPlayer.Text = "Spieler";
            this.BtnPlayer.UseVisualStyleBackColor = true;
            this.BtnPlayer.Click += new System.EventHandler(this.BtnPlayer_Click);
            // 
            // BtnMap
            // 
            this.BtnMap.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMap.Location = new System.Drawing.Point(209, 191);
            this.BtnMap.Name = "BtnMap";
            this.BtnMap.Size = new System.Drawing.Size(131, 93);
            this.BtnMap.TabIndex = 2;
            this.BtnMap.Text = "Map";
            this.BtnMap.UseVisualStyleBackColor = true;
            this.BtnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // BtnThings
            // 
            this.BtnThings.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThings.Location = new System.Drawing.Point(39, 191);
            this.BtnThings.Name = "BtnThings";
            this.BtnThings.Size = new System.Drawing.Size(131, 93);
            this.BtnThings.TabIndex = 3;
            this.BtnThings.Text = "Sonstiges";
            this.BtnThings.UseVisualStyleBackColor = true;
            this.BtnThings.Click += new System.EventHandler(this.BtnThings_Click);
            // 
            // BtnNpc
            // 
            this.BtnNpc.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNpc.Location = new System.Drawing.Point(209, 37);
            this.BtnNpc.Name = "BtnNpc";
            this.BtnNpc.Size = new System.Drawing.Size(131, 93);
            this.BtnNpc.TabIndex = 4;
            this.BtnNpc.Text = "Npc";
            this.BtnNpc.UseVisualStyleBackColor = true;
            this.BtnNpc.Click += new System.EventHandler(this.BtnNpc_Click);
            // 
            // FormDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 469);
            this.Controls.Add(this.BtnNpc);
            this.Controls.Add(this.BtnThings);
            this.Controls.Add(this.BtnMap);
            this.Controls.Add(this.BtnPlayer);
            this.Name = "FormDM";
            this.Text = "DM Oberfläche";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPlayer;
        private System.Windows.Forms.Button BtnMap;
        private System.Windows.Forms.Button BtnThings;
        private System.Windows.Forms.Button BtnNpc;
    }
}

