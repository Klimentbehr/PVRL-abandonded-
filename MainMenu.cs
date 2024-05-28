using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PVRL
{
    public partial class MainMenu : Form
    {
        private List<string> savedCharacters = new List<string>();

        public MainMenu()
        {
            InitializeComponent();
            LoadSavedCharacters();
        }

        private void LoadSavedCharacters()
        {
            string savesPath = @"E:\Projectvara\CharacterSaves";

            if (Directory.Exists(savesPath))
            {
                string[] characterFiles = Directory.GetFiles(savesPath, "*.txt");

                foreach (string file in characterFiles)
                {
                    string characterName = Path.GetFileNameWithoutExtension(file);
                    savedCharacters.Add(characterName);
                }

                if (savedCharacters.Count > 0)
                {
                    joinGameButton.Enabled = true;
                }
                else
                {
                    joinGameButton.Enabled = false;
                }
            }
            else
            {
                Directory.CreateDirectory(savesPath);
                joinGameButton.Enabled = false;
            }
        }

        private void CharacterCreationButton_Click(object sender, EventArgs e)
        {
            CharacterCreation characterCreation = new CharacterCreation();
            characterCreation.CharacterCreated += CharacterCreation_CharacterCreated;
            characterCreation.Show();
        }

        private void CharacterCreation_CharacterCreated(object sender, EventArgs e)
        {
            LoadSavedCharacters();
        }

        private void JoinGameButton_Click(object sender, EventArgs e)
        {
            // Check if there are saved characters
            if (savedCharacters.Count > 0)
            {
                // Show the character selection dialog
                using (CharacterSelection characterSelection = new CharacterSelection(savedCharacters))
                {
                    if (characterSelection.ShowDialog() == DialogResult.OK)
                    {
                        // Get the selected character's name
                        string selectedCharacter = characterSelection.SelectedCharacter;

                        // Open the Form1 with the selected character
                        Form1 gameForm = new Form1(selectedCharacter);
                        gameForm.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("No saved characters found. Please create a character first.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
