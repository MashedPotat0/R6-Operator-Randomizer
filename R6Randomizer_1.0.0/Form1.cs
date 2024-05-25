namespace R6Randomizer_1._0._0
{
    public partial class Form1 : Form
    {
        private UserControlAttacker attackerView;
        private UserControlDefender defenderView;
        private bool isAttackerActive;
        public Form1()
        {
            InitializeComponent();
            attackerView= new UserControlAttacker();
            defenderView= new UserControlDefender();
            isAttackerActive= true;
            mainPanel.Controls.Add(attackerView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            if(isAttackerActive)
            {
                mainPanel.Controls.Add(defenderView);
                switchBtn.Text = "Defender";
                isAttackerActive= false;
            }
            else
            {
                mainPanel.Controls.Add(attackerView);
                switchBtn.Text = "Attacker";
                isAttackerActive = true;
            }
        }

        private void selectOpBtn_Click(object sender, EventArgs e)
        {
            var checkedCheckBoxes = new List<CheckBox>();
            if (isAttackerActive)
            {
                checkedCheckBoxes = attackerView.allCheckBoxes.Where(cb => cb.Checked).ToList();
            }
            else
            {
                checkedCheckBoxes = defenderView.allCheckBoxes.Where(cb => cb.Checked).ToList();
            }

            if(checkedCheckBoxes.Count() == 0)
            {
                MessageBox.Show("No opperators are selected");
            }
            else
            {
                // Select a random checked checkbox
                Random random = new Random();
                int index = random.Next(checkedCheckBoxes.Count);
                CheckBox selectedCheckBox = checkedCheckBoxes[index];

                // Display the selected checkbox's image and text
                presentIco.Image = selectedCheckBox.Image;
                presentName.Text = selectedCheckBox.Text;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAttackerActive)
            {
                attackerView.SaveSettings();
            }
            else
            {
                defenderView.SaveSettings();
            }
        }
    }
}