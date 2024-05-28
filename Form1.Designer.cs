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
        private Button loadGunButton;
        private Label walletLabel;
        private ToolTip gunToolTip;
        private Panel playerStatsPanel;
        private Button enterDungeonButton;
        private Button shopButton;
        private Button receiveQuestButton;

        // Gear slots
        private Button helmetSlot;
        private Button chestSlot;
        private Button legsSlot;
        private Button armsSlot;
        private Button backSlot;
        private Panel stickFigurePanel;

        // General inventory slots
        private Button[] inventorySlots;

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
            helmetSlot = new Button();
            chestSlot = new Button();
            legsSlot = new Button();
            armsSlot = new Button();
            backSlot = new Button();
            stickFigurePanel = new Panel();
            fightButton = new Button();
            itemButton = new Button();
            fleeButton = new Button();
            bargainButton = new Button();
            healthBar = new ProgressBar();
            skillsButton = new Button();
            loadGunButton = new Button();
            walletLabel = new Label();
            playerStatsPanel = new Panel();
            enterDungeonButton = new Button();
            shopButton = new Button();
            receiveQuestButton = new Button();
            stickFigurePanel.SuspendLayout();
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
            inventoryPanel.AutoScroll = true;
            inventoryPanel.BackColor = SystemColors.ControlLight;
            inventoryPanel.BorderStyle = BorderStyle.FixedSingle;
            inventoryPanel.Location = new Point(12, 248);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(160, 327);
            inventoryPanel.TabIndex = 1;
            // 
            // helmetSlot
            // 
            helmetSlot.AllowDrop = true;
            helmetSlot.Location = new Point(55, 14);
            helmetSlot.Name = "helmetSlot";
            helmetSlot.Size = new Size(50, 38);
            helmetSlot.TabIndex = 0;
            helmetSlot.Text = "Helmet";
            helmetSlot.DragDrop += GearSlot_DragDrop;
            helmetSlot.DragEnter += GearSlot_DragEnter;
            helmetSlot.MouseDown += GearSlot_MouseDown;
            // 
            // chestSlot
            // 
            chestSlot.AllowDrop = true;
            chestSlot.Location = new Point(55, 71);
            chestSlot.Name = "chestSlot";
            chestSlot.Size = new Size(50, 38);
            chestSlot.TabIndex = 1;
            chestSlot.Text = "Chest";
            chestSlot.Click += chestSlot_Click;
            chestSlot.DragDrop += GearSlot_DragDrop;
            chestSlot.DragEnter += GearSlot_DragEnter;
            chestSlot.MouseDown += GearSlot_MouseDown;
            // 
            // legsSlot
            // 
            legsSlot.AllowDrop = true;
            legsSlot.Location = new Point(55, 121);
            legsSlot.Name = "legsSlot";
            legsSlot.Size = new Size(50, 36);
            legsSlot.TabIndex = 2;
            legsSlot.Text = "Legs";
            legsSlot.DragDrop += GearSlot_DragDrop;
            legsSlot.DragEnter += GearSlot_DragEnter;
            legsSlot.MouseDown += GearSlot_MouseDown;
            // 
            // armsSlot
            // 
            armsSlot.AllowDrop = true;
            armsSlot.Location = new Point(3, 79);
            armsSlot.Name = "armsSlot";
            armsSlot.Size = new Size(50, 36);
            armsSlot.TabIndex = 3;
            armsSlot.Text = "Arms";
            armsSlot.Click += armsSlot_Click;
            armsSlot.DragDrop += GearSlot_DragDrop;
            armsSlot.DragEnter += GearSlot_DragEnter;
            armsSlot.MouseDown += GearSlot_MouseDown;
            // 
            // backSlot
            // 
            backSlot.AllowDrop = true;
            backSlot.Location = new Point(105, 79);
            backSlot.Name = "backSlot";
            backSlot.Size = new Size(50, 36);
            backSlot.TabIndex = 4;
            backSlot.Text = "Back";
            backSlot.DragDrop += GearSlot_DragDrop;
            backSlot.DragEnter += GearSlot_DragEnter;
            backSlot.MouseDown += GearSlot_MouseDown;
            // 
            // stickFigurePanel
            // 
            stickFigurePanel.BackColor = SystemColors.ControlLight;
            stickFigurePanel.BorderStyle = BorderStyle.FixedSingle;
            stickFigurePanel.Controls.Add(helmetSlot);
            stickFigurePanel.Controls.Add(chestSlot);
            stickFigurePanel.Controls.Add(legsSlot);
            stickFigurePanel.Controls.Add(armsSlot);
            stickFigurePanel.Controls.Add(backSlot);
            stickFigurePanel.Location = new Point(12, 12);
            stickFigurePanel.Name = "stickFigurePanel";
            stickFigurePanel.Size = new Size(160, 230);
            stickFigurePanel.TabIndex = 18;
            stickFigurePanel.Paint += StickFigurePanel_Paint;
            // 
            // fightButton
            // 
            fightButton.BackColor = SystemColors.ControlLight;
            fightButton.Location = new Point(178, 264);
            fightButton.Name = "fightButton";
            fightButton.Size = new Size(120, 30);
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
            itemButton.Size = new Size(120, 30);
            itemButton.TabIndex = 3;
            itemButton.Text = "Item";
            itemButton.UseVisualStyleBackColor = false;
            itemButton.Click += ItemButton_Click;
            // 
            // fleeButton
            // 
            fleeButton.BackColor = SystemColors.ControlLight;
            fleeButton.Location = new Point(303, 264);
            fleeButton.Name = "fleeButton";
            fleeButton.Size = new Size(120, 30);
            fleeButton.TabIndex = 4;
            fleeButton.Text = "Flee";
            fleeButton.UseVisualStyleBackColor = false;
            // 
            // bargainButton
            // 
            bargainButton.BackColor = SystemColors.ControlLight;
            bargainButton.Location = new Point(303, 228);
            bargainButton.Name = "bargainButton";
            bargainButton.Size = new Size(120, 30);
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
            skillsButton.Location = new Point(429, 228);
            skillsButton.Name = "skillsButton";
            skillsButton.Size = new Size(120, 30);
            skillsButton.TabIndex = 7;
            skillsButton.Text = "Skills";
            skillsButton.UseVisualStyleBackColor = false;
            skillsButton.Click += skillsButton_Click;
            // 
            // loadGunButton
            // 
            loadGunButton.BackColor = SystemColors.ControlLight;
            loadGunButton.Location = new Point(429, 264);
            loadGunButton.Name = "loadGunButton";
            loadGunButton.Size = new Size(120, 30);
            loadGunButton.TabIndex = 9;
            loadGunButton.Text = "Load Gun";
            loadGunButton.UseVisualStyleBackColor = false;
            loadGunButton.Click += LoadGunButton_Click;
            // 
            // walletLabel
            // 
            walletLabel.AutoSize = true;
            walletLabel.BackColor = Color.Transparent;
            walletLabel.BorderStyle = BorderStyle.FixedSingle;
            walletLabel.ForeColor = SystemColors.ButtonFace;
            walletLabel.Location = new Point(500, 344);
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
            enterDungeonButton.Location = new Point(178, 336);
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
            shopButton.Location = new Point(304, 336);
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
            receiveQuestButton.Location = new Point(178, 372);
            receiveQuestButton.Name = "receiveQuestButton";
            receiveQuestButton.Size = new Size(120, 30);
            receiveQuestButton.TabIndex = 22;
            receiveQuestButton.Text = "Receive Quest";
            receiveQuestButton.UseVisualStyleBackColor = false;
            receiveQuestButton.Click += ReceiveQuestButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(858, 596);
            Controls.Add(stickFigurePanel);
            Controls.Add(inventoryPanel);
            Controls.Add(receiveQuestButton);
            Controls.Add(shopButton);
            Controls.Add(enterDungeonButton);
            Controls.Add(playerStatsPanel);
            Controls.Add(walletLabel);
            Controls.Add(loadGunButton);
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
            stickFigurePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void StickFigurePanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw a stick figure
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Head
                e.Graphics.DrawEllipse(pen, 55, 10, 50, 50);
                // Body
                e.Graphics.DrawLine(pen, 80, 60, 80, 140);
                // Arms
                e.Graphics.DrawLine(pen, 30, 80, 130, 80);
                // Legs
                e.Graphics.DrawLine(pen, 80, 140, 50, 200);
                e.Graphics.DrawLine(pen, 80, 140, 110, 200);
            }
        }

        private void InventorySlot_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button button && button.Tag != null)
            {
                button.DoDragDrop(button, DragDropEffects.Move);
            }
        }

        private void InventorySlot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void InventorySlot_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                Button draggedButton = (Button)e.Data.GetData(typeof(Button));
                Button targetButton = (Button)sender;

                // Swap items between slots
                object tempTag = targetButton.Tag;
                targetButton.Tag = draggedButton.Tag;
                draggedButton.Tag = tempTag;

                string tempText = targetButton.Text;
                targetButton.Text = draggedButton.Text;
                draggedButton.Text = tempText;
            }
        }

        private void GearSlot_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button button && button.Tag != null)
            {
                button.DoDragDrop(button, DragDropEffects.Move);
            }
        }

        private void GearSlot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void GearSlot_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                Button draggedButton = (Button)e.Data.GetData(typeof(Button));
                Button targetButton = (Button)sender;

                // Move item to gear slot
                targetButton.Tag = draggedButton.Tag;
                targetButton.Text = draggedButton.Text;
                draggedButton.Tag = null;
                draggedButton.Text = "";
            }
        }

        private void AddToInventory(Button itemButton)
        {
            for (int i = 0; i < inventorySlots.Length; i++)
            {
                if (inventorySlots[i].Tag == null)
                {
                    inventorySlots[i].Tag = itemButton.Tag;
                    inventorySlots[i].Text = itemButton.Text;
                    break;
                }
            }
        }
    }
}