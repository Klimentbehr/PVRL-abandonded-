namespace PVRL
{
    partial class CharacterSelection
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox characterListBox;
        private Button selectButton;
        private Button cancelButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            characterListBox = new ListBox();
            selectButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // characterListBox
            // 
            characterListBox.FormattingEnabled = true;
            characterListBox.ItemHeight = 15;
            characterListBox.Location = new Point(12, 12);
            characterListBox.Name = "characterListBox";
            characterListBox.Size = new Size(360, 154);
            characterListBox.TabIndex = 0;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(12, 180);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(100, 30);
            selectButton.TabIndex = 1;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += SelectButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(272, 180);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(100, 30);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // CharacterSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(384, 221);
            Controls.Add(cancelButton);
            Controls.Add(selectButton);
            Controls.Add(characterListBox);
            Name = "CharacterSelection";
            Text = "Select Character";
            ResumeLayout(false);
        }
    }
}
