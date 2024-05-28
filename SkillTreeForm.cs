using System;
using System.Windows.Forms;

namespace PVRL
{
    public partial class SkillTreeForm : Form
    {
        private Form1 mainForm;

        public SkillTreeForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void SkillTreeForm_Load(object sender, EventArgs e)
        {
            InitializeSkillTree();
        }

        private void InitializeSkillTree()
        {
            // Create labels for skill categories
            Label defenseLabel = new Label { Text = "Defense Skills", AutoSize = true };
            Label offenseLabel = new Label { Text = "Offense Skills", AutoSize = true };
            Label supportLabel = new Label { Text = "Support Skills", AutoSize = true };

            FlowLayoutPanel defensePanel = new FlowLayoutPanel { AutoSize = true, FlowDirection = FlowDirection.TopDown };
            FlowLayoutPanel offensePanel = new FlowLayoutPanel { AutoSize = true, FlowDirection = FlowDirection.TopDown };
            FlowLayoutPanel supportPanel = new FlowLayoutPanel { AutoSize = true, FlowDirection = FlowDirection.TopDown };

            skillTreePanel.Controls.Add(defenseLabel);
            skillTreePanel.Controls.Add(defensePanel);
            skillTreePanel.Controls.Add(offenseLabel);
            skillTreePanel.Controls.Add(offensePanel);
            skillTreePanel.Controls.Add(supportLabel);
            skillTreePanel.Controls.Add(supportPanel);

            // Load skills from the main form
            LoadSkills(defensePanel, "Defense");
            LoadSkills(offensePanel, "Offense");
            LoadSkills(supportPanel, "Support");
        }

        private void LoadSkills(FlowLayoutPanel panel, string skillType)
        {
            for (int i = 1; i <= 4; i++)
            {
                Button skillButton = new Button
                {
                    Text = $"{skillType} Skill {i}",
                    Tag = $"{skillType}Skill{i}",
                    AutoSize = true
                };
                panel.Controls.Add(skillButton);
            }
        }

        private void BuySkillButton_Click(object sender, EventArgs e)
        {
            if (mainForm.walletAmount >= 100) // Example cost
            {
                mainForm.walletAmount -= 100;

                // Add a random stat boost based on skill type
                Random random = new Random();
                int boostAmount = random.Next(1, 6);
                switch (random.Next(3))
                {
                    case 0:
                        mainForm.CharacterStrength += boostAmount;
                        break;
                    case 1:
                        mainForm.CharacterDexterity += boostAmount;
                        break;
                    case 2:
                        mainForm.CharacterWisdom += boostAmount;
                        break;
                }

                MessageBox.Show("Skill purchased!");

                mainForm.UpdateWalletDisplay();
                mainForm.UpdatePlayerStats();
                mainForm.SaveCharacterData();
            }
            else
            {
                MessageBox.Show("Not enough money to buy the skill!");
            }
        }
    }
}
