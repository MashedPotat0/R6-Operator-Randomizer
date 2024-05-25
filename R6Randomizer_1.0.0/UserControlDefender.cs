using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6Randomizer_1._0._0
{
    public partial class UserControlDefender : UserControl
    {
        public List<CheckBox> allCheckBoxes;
        public UserControlDefender()
        {
            InitializeComponent();
        }

        private void UserControlDefender_Load(object sender, EventArgs e)
        {
            allCheckBoxes = this.Controls.OfType<CheckBox>().ToList();
            LoadSettings();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                // Change background color based on checked state
                if (checkBox.Checked)
                {
                    checkBox.BackColor = Color.LightGreen; // Color when checked
                }
                else
                {
                    checkBox.BackColor = Color.Transparent; // Color when unchecked
                }
            }
        }

        private void LoadSettings()
        {
            allCheckBoxes[0].Checked = Properties.Settings.Default.box2Checked1;
            allCheckBoxes[1].Checked = Properties.Settings.Default.box2Checked2;
            allCheckBoxes[2].Checked = Properties.Settings.Default.box2Checked3;
            allCheckBoxes[3].Checked = Properties.Settings.Default.box2Checked4;
            allCheckBoxes[4].Checked = Properties.Settings.Default.box2Checked5;
            allCheckBoxes[5].Checked = Properties.Settings.Default.box2Checked6;
            allCheckBoxes[6].Checked = Properties.Settings.Default.box2Checked7;
            allCheckBoxes[7].Checked = Properties.Settings.Default.box2Checked8;
            allCheckBoxes[8].Checked = Properties.Settings.Default.box2Checked9;
            allCheckBoxes[9].Checked = Properties.Settings.Default.box2Checked10;
            allCheckBoxes[10].Checked = Properties.Settings.Default.box2Checked11;
            allCheckBoxes[11].Checked = Properties.Settings.Default.box2Checked12;
            allCheckBoxes[12].Checked = Properties.Settings.Default.box2Checked13;
            allCheckBoxes[13].Checked = Properties.Settings.Default.box2Checked14;
            allCheckBoxes[14].Checked = Properties.Settings.Default.box2Checked15;
            allCheckBoxes[15].Checked = Properties.Settings.Default.box2Checked16;
            allCheckBoxes[16].Checked = Properties.Settings.Default.box2Checked17;
            allCheckBoxes[17].Checked = Properties.Settings.Default.box2Checked18;
            allCheckBoxes[18].Checked = Properties.Settings.Default.box2Checked19;
            allCheckBoxes[19].Checked = Properties.Settings.Default.box2Checked20;
            allCheckBoxes[20].Checked = Properties.Settings.Default.box2Checked21;
            allCheckBoxes[21].Checked = Properties.Settings.Default.box2Checked22;
            allCheckBoxes[22].Checked = Properties.Settings.Default.box2Checked23;
            allCheckBoxes[23].Checked = Properties.Settings.Default.box2Checked24;
            allCheckBoxes[24].Checked = Properties.Settings.Default.box2Checked25;
            allCheckBoxes[25].Checked = Properties.Settings.Default.box2Checked26;
            allCheckBoxes[26].Checked = Properties.Settings.Default.box2Checked27;
            allCheckBoxes[27].Checked = Properties.Settings.Default.box2Checked28;
            allCheckBoxes[28].Checked = Properties.Settings.Default.box2Checked29;
            allCheckBoxes[29].Checked = Properties.Settings.Default.box2Checked30;
            allCheckBoxes[30].Checked = Properties.Settings.Default.box2Checked31;
            allCheckBoxes[31].Checked = Properties.Settings.Default.box2Checked32;
            allCheckBoxes[32].Checked = Properties.Settings.Default.box2Checked33;
            allCheckBoxes[33].Checked = Properties.Settings.Default.box2Checked34;
            allCheckBoxes[34].Checked = Properties.Settings.Default.box2Checked35;
        }
        public void SaveSettings()
        {
            Properties.Settings.Default.box2Checked1 = allCheckBoxes[0].Checked;
            Properties.Settings.Default.box2Checked2 = allCheckBoxes[1].Checked;
            Properties.Settings.Default.box2Checked3 = allCheckBoxes[2].Checked;
            Properties.Settings.Default.box2Checked4 = allCheckBoxes[3].Checked;
            Properties.Settings.Default.box2Checked5 = allCheckBoxes[4].Checked;
            Properties.Settings.Default.box2Checked6 = allCheckBoxes[5].Checked;
            Properties.Settings.Default.box2Checked7 = allCheckBoxes[6].Checked;
            Properties.Settings.Default.box2Checked8 = allCheckBoxes[7].Checked;
            Properties.Settings.Default.box2Checked9 = allCheckBoxes[8].Checked;
            Properties.Settings.Default.box2Checked10 = allCheckBoxes[9].Checked;
            Properties.Settings.Default.box2Checked11 = allCheckBoxes[10].Checked;
            Properties.Settings.Default.box2Checked12 = allCheckBoxes[11].Checked;
            Properties.Settings.Default.box2Checked13 = allCheckBoxes[12].Checked;
            Properties.Settings.Default.box2Checked14 = allCheckBoxes[13].Checked;
            Properties.Settings.Default.box2Checked15 = allCheckBoxes[14].Checked;
            Properties.Settings.Default.box2Checked16 = allCheckBoxes[15].Checked;
            Properties.Settings.Default.box2Checked17 = allCheckBoxes[16].Checked;
            Properties.Settings.Default.box2Checked18 = allCheckBoxes[17].Checked;
            Properties.Settings.Default.box2Checked19 = allCheckBoxes[18].Checked;
            Properties.Settings.Default.box2Checked20 = allCheckBoxes[19].Checked;
            Properties.Settings.Default.box2Checked21 = allCheckBoxes[20].Checked;
            Properties.Settings.Default.box2Checked22 = allCheckBoxes[21].Checked;
            Properties.Settings.Default.box2Checked23 = allCheckBoxes[22].Checked;
            Properties.Settings.Default.box2Checked24 = allCheckBoxes[23].Checked;
            Properties.Settings.Default.box2Checked25 = allCheckBoxes[24].Checked;
            Properties.Settings.Default.box2Checked26 = allCheckBoxes[25].Checked;
            Properties.Settings.Default.box2Checked27 = allCheckBoxes[26].Checked;
            Properties.Settings.Default.box2Checked28 = allCheckBoxes[27].Checked;
            Properties.Settings.Default.box2Checked29 = allCheckBoxes[28].Checked;
            Properties.Settings.Default.box2Checked30 = allCheckBoxes[29].Checked;
            Properties.Settings.Default.box2Checked31 = allCheckBoxes[30].Checked;
            Properties.Settings.Default.box2Checked32 = allCheckBoxes[31].Checked;
            Properties.Settings.Default.box2Checked33 = allCheckBoxes[32].Checked;
            Properties.Settings.Default.box2Checked34 = allCheckBoxes[33].Checked;
            Properties.Settings.Default.box2Checked35 = allCheckBoxes[34].Checked;

            Properties.Settings.Default.Save();
        }
    }
}
