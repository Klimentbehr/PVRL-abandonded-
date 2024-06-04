namespace PVRL
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private Button characterCreationButton;
        private Button joinGameButton;
        private Button hostGameButton; // Add Host Game button
        private Button exitButton;
        private Button pveButton; // Add PVE button
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
            hostGameButton = new Button(); // Add Host Game button
            exitButton = new Button();
            pveButton = new Button(); // Add PVE button
            titleLabel = new Label();
            SuspendLayout();
            // 
            // characterCreationButton
            // 
            characterCreationButton.Location = new Point(100, 100);
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
            joinGameButton.Location = new Point(100, 160);
            joinGameButton.Name = "joinGameButton";
            joinGameButton.Size = new Size(200, 50);
            joinGameButton.TabIndex = 1;
            joinGameButton.Text = "Join Game";
            joinGameButton.UseVisualStyleBackColor = true;
            joinGameButton.Click += JoinGameButton_Click;
            // 
            // hostGameButton
            // 
            hostGameButton.Enabled = false;
            hostGameButton.Location = new Point(100, 220);
            hostGameButton.Name = "hostGameButton";
            hostGameButton.Size = new Size(200, 50);
            hostGameButton.TabIndex = 2;
            hostGameButton.Text = "Host Game";
            hostGameButton.UseVisualStyleBackColor = true;
            hostGameButton.Click += HostGameButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(100, 340);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 50);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // pveButton
            // 
            pveButton.Enabled = false;
            pveButton.Location = new Point(100, 280);
            pveButton.Name = "pveButton";
            pveButton.Size = new Size(200, 50);
            pveButton.TabIndex = 4;
            pveButton.Text = "PVE";
            pveButton.UseVisualStyleBackColor = true;
            pveButton.Click += PveButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ButtonFace;
            titleLabel.Location = new Point(150, 50);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(100, 37);
            titleLabel.TabIndex = 5;
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
            Controls.Add(pveButton); // Add PVE button
            Controls.Add(exitButton);
            Controls.Add(hostGameButton); // Add Host Game button
            Controls.Add(joinGameButton);
            Controls.Add(characterCreationButton);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
