namespace PVRL
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private Button characterCreationButton;
        private Button joinGameButton;
        private Button exitButton;
        private Label titleLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            characterCreationButton = new Button();
            joinGameButton = new Button();
            exitButton = new Button();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // characterCreationButton
            // 
            characterCreationButton.Location = new Point(100, 150);
            characterCreationButton.Name = "characterCreationButton";
            characterCreationButton.Size = new Size(200, 50);
            characterCreationButton.TabIndex = 0;
            characterCreationButton.Text = "Create Character";
            characterCreationButton.UseVisualStyleBackColor = true;
            characterCreationButton.Click += CharacterCreationButton_Click;
            // 
            // joinGameButton
            // 
            joinGameButton.Enabled = false;
            joinGameButton.Location = new Point(100, 210);
            joinGameButton.Name = "joinGameButton";
            joinGameButton.Size = new Size(200, 50);
            joinGameButton.TabIndex = 1;
            joinGameButton.Text = "Join Game";
            joinGameButton.UseVisualStyleBackColor = true;
            joinGameButton.Click += JoinGameButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(100, 270);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 50);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ButtonFace;
            titleLabel.Location = new Point(150, 82);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(100, 37);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "PVRL";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 400);
            Controls.Add(titleLabel);
            Controls.Add(exitButton);
            Controls.Add(joinGameButton);
            Controls.Add(characterCreationButton);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
