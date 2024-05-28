using System;
using System.IO;
using System.Windows.Forms;

namespace PVRL
{
    public partial class CharacterCreation : Form
    {
        private const int totalPoints = 10;
        private int pointsLeft = totalPoints;

        public event EventHandler CharacterCreated;

        public CharacterCreation()
        {
            InitializeComponent();
            UpdatePointsLeft();
        }

        public void StatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Calculate the points used
            int usedPoints = (int)(strengthNumericUpDown.Value +
                                   dexterityNumericUpDown.Value +
                                   intelligenceNumericUpDown.Value +
                                   wisdomNumericUpDown.Value +
                                   charismaNumericUpDown.Value);

            // Calculate the remaining points
            pointsLeft = totalPoints - usedPoints;

            // If the points left are negative, reset the value to the previous one
            if (pointsLeft < 0)
            {
                NumericUpDown nud = (NumericUpDown)sender;
                nud.Value -= 1;
                pointsLeft = totalPoints - (int)(strengthNumericUpDown.Value +
                                                 dexterityNumericUpDown.Value +
                                                 intelligenceNumericUpDown.Value +
                                                 wisdomNumericUpDown.Value +
                                                 charismaNumericUpDown.Value);
            }

            pointsLeftLabel.Text = pointsLeft.ToString();
            confirmButton.Enabled = pointsLeft == 0;
        }

        public void UpdatePointsLeft()
        {
            pointsLeft = totalPoints -
                         (int)(strengthNumericUpDown.Value +
                               dexterityNumericUpDown.Value +
                               intelligenceNumericUpDown.Value +
                               wisdomNumericUpDown.Value +
                               charismaNumericUpDown.Value);

            pointsLeftLabel.Text = pointsLeft.ToString();
            confirmButton.Enabled = pointsLeft == 0;
        }

        public void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (pointsLeft != 0)
            {
                MessageBox.Show("Please allocate all points.");
                return;
            }

            // Check for name
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a name for your character.");
                return;
            }

            // Save character data
            SaveCharacter();

            MessageBox.Show("Character created successfully!");

            // Trigger the CharacterCreated event
            CharacterCreated?.Invoke(this, EventArgs.Empty);

            // Optionally, transition to the main menu
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            Close();
        }

        public void SaveCharacter()
        {
            string characterDirectory = @"E:\Projectvara\CharacterSaves";
            Directory.CreateDirectory(characterDirectory);

            string filePath = Path.Combine(characterDirectory, $"{nameTextBox.Text}.txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Name: {nameTextBox.Text}");
                writer.WriteLine($"Race: {raceComboBox.SelectedItem}");
                writer.WriteLine($"Age: {ageNumericUpDown.Value}");
                writer.WriteLine($"Strength: {strengthNumericUpDown.Value}");
                writer.WriteLine($"Dexterity: {dexterityNumericUpDown.Value}");
                writer.WriteLine($"Intelligence: {intelligenceNumericUpDown.Value}");
                writer.WriteLine($"Wisdom: {wisdomNumericUpDown.Value}");
                writer.WriteLine($"Charisma: {charismaNumericUpDown.Value}");
            }
        }

        public void BackButton_Click(object sender, EventArgs e)
        {
            // Go back to the main menu
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            Close();
        }
    }
}
