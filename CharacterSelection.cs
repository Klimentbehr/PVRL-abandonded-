using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PVRL
{
    public partial class CharacterSelection : Form
    {
        public string SelectedCharacter { get; private set; }

        public CharacterSelection(List<string> characters)
        {
            InitializeComponent();
            characterListBox.Items.AddRange(characters.ToArray());
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (characterListBox.SelectedItem != null)
            {
                SelectedCharacter = characterListBox.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a character.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
