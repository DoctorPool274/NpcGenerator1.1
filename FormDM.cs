using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NpcGenerator1._1
{
    public partial class FormDM : Form
    {
        public static List<Npc> allNpcs = new List<Npc>();

        public FormDM()
        {
            InitializeComponent();
        }

        //-------------Player----------------------------------------------------------------------
        private void BtnPlayer_Click(object sender, EventArgs e)
        {
            FormPlayer fP = new FormPlayer();
            fP.Show();
        }
        //-------------Npc----------------------------------------------------------------------
        private void BtnNpc_Click(object sender, EventArgs e)
        {
            FormNpc fN = new FormNpc(null, null);
            fN.Show();
        }
        //-------------Sonstiges----------------------------------------------------------------------
        private void BtnThings_Click(object sender, EventArgs e)
        {
            FormThings fT = new FormThings();
            fT.Show();
        }
        //-------------Karte----------------------------------------------------------------------
        private void BtnMap_Click(object sender, EventArgs e)
        {
            FormMap fM = new FormMap();
            fM.Show();
        }


    }
}
