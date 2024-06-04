namespace PVRL
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DoubleBufferedPanel mapPanel;
        private Panel inventoryPanel;
        private Button fightButton;
        private Button itemButton;
        private Button fleeButton;
        private Button bargainButton;
        private ProgressBar healthBar;
        private Button skillsButton;
        private Label walletLabel;
        private Panel playerStatsPanel;
        private Button enterDungeonButton;
        private Button shopButton;
        private Button receiveQuestButton;
        private Panel equipmentPanel;
        private TextBox combatLogTextBox;
        private Button returnToMainMenuButton; // Add the button

        // Gear labels
        private Label helmetLabel;
        private Label chestLabel;
        private Label legsLabel;
        private Label armsLabel;
        private Label backLabel;
        private Label equippedWeaponLabel;

        // General inventory slots
        private ListBox inventoryListBox;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mapPanel = new DoubleBufferedPanel();
            inventoryPanel = new Panel();
            inventoryListBox = new ListBox();
            equipmentPanel = new Panel();
            helmetLabel = new Label();
            chestLabel = new Label();
            legsLabel = new Label();
            armsLabel = new Label();
            backLabel = new Label();
            equippedWeaponLabel = new Label();
            combatLogTextBox = new TextBox();
            fightButton = new Button();
            itemButton = new Button();
            fleeButton = new Button();
            bargainButton = new Button();
            healthBar = new ProgressBar();
            skillsButton = new Button();
            walletLabel = new Label();
            playerStatsPanel = new Panel();
            enterDungeonButton = new Button();
            shopButton = new Button();
            receiveQuestButton = new Button();
            returnToMainMenuButton = new Button();
            inventoryPanel.SuspendLayout();
            equipmentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mapPanel
            // 
            mapPanel.BackColor = SystemColors.ControlLight;
            mapPanel.BorderStyle = BorderStyle.FixedSingle;
            mapPanel.Location = new Point(178, 12);
            mapPanel.Name = "mapPanel";
            mapPanel.Size = new Size(410, 210);
            mapPanel.TabIndex = 0;
            mapPanel.Paint += MapPanel_Paint;
            // 
            // inventoryPanel
            // 
            inventoryPanel.BackColor = SystemColors.ControlLight;
            inventoryPanel.BorderStyle = BorderStyle.FixedSingle;
            inventoryPanel.Controls.Add(inventoryListBox);
            inventoryPanel.Location = new Point(12, 248);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(160, 336);
            inventoryPanel.TabIndex = 1;
            // 
            // inventoryListBox
            // 
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Location = new Point(10, 10);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(140, 289);
            inventoryListBox.TabIndex = 0;
            inventoryListBox.SelectedIndexChanged += inventoryListBox_SelectedIndexChanged;
            inventoryListBox.DoubleClick += InventoryListBox_DoubleClick;
            inventoryListBox.MouseHover += InventoryListBox_MouseHover;
            // 
            // equipmentPanel
            // 
            equipmentPanel.BackColor = SystemColors.ControlLight;
            equipmentPanel.BorderStyle = BorderStyle.FixedSingle;
            equipmentPanel.Controls.Add(helmetLabel);
            equipmentPanel.Controls.Add(chestLabel);
            equipmentPanel.Controls.Add(legsLabel);
            equipmentPanel.Controls.Add(armsLabel);
            equipmentPanel.Controls.Add(backLabel);
            equipmentPanel.Controls.Add(equippedWeaponLabel);
            equipmentPanel.Location = new Point(12, 12);
            equipmentPanel.Name = "equipmentPanel";
            equipmentPanel.Size = new Size(160, 230);
            equipmentPanel.TabIndex = 18;
            // 
            // helmetLabel
            // 
            helmetLabel.Location = new Point(10, 10);
            helmetLabel.Name = "helmetLabel";
            helmetLabel.Size = new Size(140, 30);
            helmetLabel.TabIndex = 0;
            helmetLabel.Text = "Helmet: None";
            // 
            // chestLabel
            // 
            chestLabel.Location = new Point(10, 50);
            chestLabel.Name = "chestLabel";
            chestLabel.Size = new Size(140, 30);
            chestLabel.TabIndex = 1;
            chestLabel.Text = "Chest: None";
            // 
            // legsLabel
            // 
            legsLabel.Location = new Point(10, 90);
            legsLabel.Name = "legsLabel";
            legsLabel.Size = new Size(140, 30);
            legsLabel.TabIndex = 2;
            legsLabel.Text = "Legs: None";
            // 
            // armsLabel
            // 
            armsLabel.Location = new Point(10, 130);
            armsLabel.Name = "armsLabel";
            armsLabel.Size = new Size(140, 30);
            armsLabel.TabIndex = 3;
            armsLabel.Text = "Arms: None";
            // 
            // backLabel
            // 
            backLabel.Location = new Point(10, 170);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(140, 30);
            backLabel.TabIndex = 4;
            backLabel.Text = "Back: None";
            // 
            // equippedWeaponLabel
            // 
            equippedWeaponLabel.Location = new Point(10, 210);
            equippedWeaponLabel.Name = "equippedWeaponLabel";
            equippedWeaponLabel.Size = new Size(140, 30);
            equippedWeaponLabel.TabIndex = 5;
            equippedWeaponLabel.Text = "Weapon: None";
            // 
            // combatLogTextBox
            // 
            combatLogTextBox.Location = new Point(178, 426);
            combatLogTextBox.Multiline = true;
            combatLogTextBox.Name = "combatLogTextBox";
            combatLogTextBox.ReadOnly = true;
            combatLogTextBox.ScrollBars = ScrollBars.Vertical;
            combatLogTextBox.Size = new Size(410, 158);
            combatLogTextBox.TabIndex = 23;
            // 
            // fightButton
            // 
            fightButton.BackColor = SystemColors.ControlLight;
            fightButton.Location = new Point(178, 264);
            fightButton.Name = "fightButton";
            fightButton.Size = new Size(91, 30);
            fightButton.TabIndex = 2;
            fightButton.Text = "Fight";
            fightButton.UseVisualStyleBackColor = false;
            fightButton.Click += FightButton_Click;
            // 
            // itemButton
            // 
            itemButton.BackColor = SystemColors.ControlLight;
            itemButton.Location = new Point(178, 228);
            itemButton.Name = "itemButton";
            itemButton.Size = new Size(91, 30);
            itemButton.TabIndex = 3;
            itemButton.Text = "Item";
            itemButton.UseVisualStyleBackColor = false;
            itemButton.Click += ItemButton_Click;
            // 
            // fleeButton
            // 
            fleeButton.BackColor = SystemColors.ControlLight;
            fleeButton.Location = new Point(275, 264);
            fleeButton.Name = "fleeButton";
            fleeButton.Size = new Size(91, 30);
            fleeButton.TabIndex = 4;
            fleeButton.Text = "Flee";
            fleeButton.UseVisualStyleBackColor = false;
            // 
            // bargainButton
            // 
            bargainButton.BackColor = SystemColors.ControlLight;
            bargainButton.Location = new Point(275, 228);
            bargainButton.Name = "bargainButton";
            bargainButton.Size = new Size(91, 30);
            bargainButton.TabIndex = 5;
            bargainButton.Text = "Bargain";
            bargainButton.UseVisualStyleBackColor = false;
            // 
            // healthBar
            // 
            healthBar.BackColor = SystemColors.ControlLight;
            healthBar.Location = new Point(178, 300);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(410, 30);
            healthBar.TabIndex = 6;
            // 
            // skillsButton
            // 
            skillsButton.BackColor = SystemColors.ControlLight;
            skillsButton.Location = new Point(372, 228);
            skillsButton.Name = "skillsButton";
            skillsButton.Size = new Size(91, 30);
            skillsButton.TabIndex = 7;
            skillsButton.Text = "Skills";
            skillsButton.UseVisualStyleBackColor = false;
            skillsButton.Click += skillsButton_Click;
            // 
            // walletLabel
            // 
            walletLabel.AutoSize = true;
            walletLabel.BackColor = Color.Transparent;
            walletLabel.BorderStyle = BorderStyle.FixedSingle;
            walletLabel.ForeColor = SystemColors.ButtonFace;
            walletLabel.Location = new Point(734, 602);
            walletLabel.Name = "walletLabel";
            walletLabel.Size = new Size(60, 17);
            walletLabel.TabIndex = 14;
            walletLabel.Text = "Wallet: $0";
            walletLabel.Click += walletLabel_Click;
            // 
            // playerStatsPanel
            // 
            playerStatsPanel.BackColor = SystemColors.ControlLight;
            playerStatsPanel.BorderStyle = BorderStyle.FixedSingle;
            playerStatsPanel.ForeColor = SystemColors.ActiveCaptionText;
            playerStatsPanel.Location = new Point(594, 12);
            playerStatsPanel.Name = "playerStatsPanel";
            playerStatsPanel.Size = new Size(249, 572);
            playerStatsPanel.TabIndex = 17;
            playerStatsPanel.Paint += playerStatsPanel_Paint;
            // 
            // enterDungeonButton
            // 
            enterDungeonButton.BackColor = SystemColors.ControlLight;
            enterDungeonButton.Location = new Point(468, 228);
            enterDungeonButton.Name = "enterDungeonButton";
            enterDungeonButton.Size = new Size(120, 30);
            enterDungeonButton.TabIndex = 20;
            enterDungeonButton.Text = "Enter Dungeon";
            enterDungeonButton.UseVisualStyleBackColor = false;
            enterDungeonButton.Click += EnterDungeonButton_Click;
            // 
            // shopButton
            // 
            shopButton.BackColor = SystemColors.ControlLight;
            shopButton.Location = new Point(468, 264);
            shopButton.Name = "shopButton";
            shopButton.Size = new Size(120, 30);
            shopButton.TabIndex = 21;
            shopButton.Text = "Shop";
            shopButton.UseVisualStyleBackColor = false;
            shopButton.Click += ShopButton_Click;
            // 
            // receiveQuestButton
            // 
            receiveQuestButton.BackColor = SystemColors.ControlLight;
            receiveQuestButton.Location = new Point(594, 589);
            receiveQuestButton.Name = "receiveQuestButton";
            receiveQuestButton.Size = new Size(120, 30);
            receiveQuestButton.TabIndex = 22;
            receiveQuestButton.Text = "Receive Quest";
            receiveQuestButton.UseVisualStyleBackColor = false;
            receiveQuestButton.Click += ReceiveQuestButton_Click;
            // 
            // returnToMainMenuButton
            // 
            returnToMainMenuButton.BackColor = SystemColors.ControlLight;
            returnToMainMenuButton.Location = new Point(372, 264);
            returnToMainMenuButton.Name = "returnToMainMenuButton";
            returnToMainMenuButton.Size = new Size(90, 30);
            returnToMainMenuButton.TabIndex = 24;
            returnToMainMenuButton.Text = "Main Menu";
            returnToMainMenuButton.UseVisualStyleBackColor = false;
            returnToMainMenuButton.Click += ReturnToMainMenuButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(921, 722);
            Controls.Add(returnToMainMenuButton);
            Controls.Add(combatLogTextBox);
            Controls.Add(equipmentPanel);
            Controls.Add(inventoryPanel);
            Controls.Add(receiveQuestButton);
            Controls.Add(shopButton);
            Controls.Add(enterDungeonButton);
            Controls.Add(playerStatsPanel);
            Controls.Add(walletLabel);
            Controls.Add(skillsButton);
            Controls.Add(healthBar);
            Controls.Add(bargainButton);
            Controls.Add(fleeButton);
            Controls.Add(itemButton);
            Controls.Add(fightButton);
            Controls.Add(mapPanel);
            Name = "Form1";
            Text = "PVRL";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            inventoryPanel.ResumeLayout(false);
            equipmentPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
