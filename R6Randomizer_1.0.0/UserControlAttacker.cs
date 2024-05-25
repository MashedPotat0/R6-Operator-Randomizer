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
    public partial class UserControlAttacker : UserControl
    {
        public List<CheckBox> allCheckBoxes;
        public UserControlAttacker()
        {
            InitializeComponent();
        }

        private void UserControlAttacker_Load(object sender, EventArgs e)
        {
            allCheckBoxes = this.Controls.OfType<CheckBox>().ToList();
            LoadSettings();
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                // Change background color based on checked state
                if (checkBox.Checked)
                {
                    checkBox.BackColor = Color.LightGreen; // Color when checked
                    checkBox.Checked = true;
                }
                else
                {
                    checkBox.BackColor = Color.Transparent; // Color when unchecked
                    checkBox.Checked = false;
                }
            }
        }
        private void LoadSettings()
        {
            allCheckBoxes[0].Checked = Properties.Settings.Default.boxChecked1;
            allCheckBoxes[1].Checked = Properties.Settings.Default.boxChecked2;
            allCheckBoxes[2].Checked = Properties.Settings.Default.boxChecked3;
            allCheckBoxes[3].Checked = Properties.Settings.Default.boxChecked4;
            allCheckBoxes[4].Checked = Properties.Settings.Default.boxChecked5;
            allCheckBoxes[5].Checked = Properties.Settings.Default.boxChecked6;
            allCheckBoxes[6].Checked = Properties.Settings.Default.boxChecked7;
            allCheckBoxes[7].Checked = Properties.Settings.Default.boxChecked8;
            allCheckBoxes[8].Checked = Properties.Settings.Default.boxChecked9;
            allCheckBoxes[9].Checked = Properties.Settings.Default.boxChecked10;
            allCheckBoxes[10].Checked = Properties.Settings.Default.boxChecked11;
            allCheckBoxes[11].Checked = Properties.Settings.Default.boxChecked12;
            allCheckBoxes[12].Checked = Properties.Settings.Default.boxChecked13;
            allCheckBoxes[13].Checked = Properties.Settings.Default.boxChecked14;
            allCheckBoxes[14].Checked = Properties.Settings.Default.boxChecked15;
            allCheckBoxes[15].Checked = Properties.Settings.Default.boxChecked16;
            allCheckBoxes[16].Checked = Properties.Settings.Default.boxChecked17;
            allCheckBoxes[17].Checked = Properties.Settings.Default.boxChecked18;
            allCheckBoxes[18].Checked = Properties.Settings.Default.boxChecked19;
            allCheckBoxes[19].Checked = Properties.Settings.Default.boxChecked20;
            allCheckBoxes[20].Checked = Properties.Settings.Default.boxChecked21;
            allCheckBoxes[21].Checked = Properties.Settings.Default.boxChecked22;
            allCheckBoxes[22].Checked = Properties.Settings.Default.boxChecked23;
            allCheckBoxes[23].Checked = Properties.Settings.Default.boxChecked24;
            allCheckBoxes[24].Checked = Properties.Settings.Default.boxChecked25;
            allCheckBoxes[25].Checked = Properties.Settings.Default.boxChecked26;
            allCheckBoxes[26].Checked = Properties.Settings.Default.boxChecked27;
            allCheckBoxes[27].Checked = Properties.Settings.Default.boxChecked28;
            allCheckBoxes[28].Checked = Properties.Settings.Default.boxChecked29;
            allCheckBoxes[29].Checked = Properties.Settings.Default.boxChecked30;
            allCheckBoxes[30].Checked = Properties.Settings.Default.boxChecked31;
            allCheckBoxes[31].Checked = Properties.Settings.Default.boxChecked32;
            allCheckBoxes[32].Checked = Properties.Settings.Default.boxChecked33;
            allCheckBoxes[33].Checked = Properties.Settings.Default.boxChecked34;
            allCheckBoxes[34].Checked = Properties.Settings.Default.boxChecked35;
            allCheckBoxes[35].Checked = Properties.Settings.Default.boxChecked36;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.boxChecked1 = allCheckBoxes[0].Checked;
            Properties.Settings.Default.boxChecked2 = allCheckBoxes[1].Checked;
            Properties.Settings.Default.boxChecked3 = allCheckBoxes[2].Checked;
            Properties.Settings.Default.boxChecked4 = allCheckBoxes[3].Checked;
            Properties.Settings.Default.boxChecked5 = allCheckBoxes[4].Checked;
            Properties.Settings.Default.boxChecked6 = allCheckBoxes[5].Checked;
            Properties.Settings.Default.boxChecked7 = allCheckBoxes[6].Checked;
            Properties.Settings.Default.boxChecked8 = allCheckBoxes[7].Checked;
            Properties.Settings.Default.boxChecked9 = allCheckBoxes[8].Checked;
            Properties.Settings.Default.boxChecked10 = allCheckBoxes[9].Checked;
            Properties.Settings.Default.boxChecked11 = allCheckBoxes[10].Checked;
            Properties.Settings.Default.boxChecked12 = allCheckBoxes[11].Checked;
            Properties.Settings.Default.boxChecked13 = allCheckBoxes[12].Checked;
            Properties.Settings.Default.boxChecked14 = allCheckBoxes[13].Checked;
            Properties.Settings.Default.boxChecked15 = allCheckBoxes[14].Checked;
            Properties.Settings.Default.boxChecked16 = allCheckBoxes[15].Checked;
            Properties.Settings.Default.boxChecked17 = allCheckBoxes[16].Checked;
            Properties.Settings.Default.boxChecked18 = allCheckBoxes[17].Checked;
            Properties.Settings.Default.boxChecked19 = allCheckBoxes[18].Checked;
            Properties.Settings.Default.boxChecked20 = allCheckBoxes[19].Checked;
            Properties.Settings.Default.boxChecked21 = allCheckBoxes[20].Checked;
            Properties.Settings.Default.boxChecked22 = allCheckBoxes[21].Checked;
            Properties.Settings.Default.boxChecked23 = allCheckBoxes[22].Checked;
            Properties.Settings.Default.boxChecked24 = allCheckBoxes[23].Checked;
            Properties.Settings.Default.boxChecked25 = allCheckBoxes[24].Checked;
            Properties.Settings.Default.boxChecked26 = allCheckBoxes[25].Checked;
            Properties.Settings.Default.boxChecked27 = allCheckBoxes[26].Checked;
            Properties.Settings.Default.boxChecked28 = allCheckBoxes[27].Checked;
            Properties.Settings.Default.boxChecked29 = allCheckBoxes[28].Checked;
            Properties.Settings.Default.boxChecked30 = allCheckBoxes[29].Checked;
            Properties.Settings.Default.boxChecked31 = allCheckBoxes[30].Checked;
            Properties.Settings.Default.boxChecked32 = allCheckBoxes[31].Checked;
            Properties.Settings.Default.boxChecked33 = allCheckBoxes[32].Checked;
            Properties.Settings.Default.boxChecked34 = allCheckBoxes[33].Checked;
            Properties.Settings.Default.boxChecked35 = allCheckBoxes[34].Checked;
            Properties.Settings.Default.boxChecked36 = allCheckBoxes[35].Checked;
            Properties.Settings.Default.Save();
        }
    }
}
