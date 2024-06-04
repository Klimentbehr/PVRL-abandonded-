using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace PVRL
{
    public partial class Form1 : Form
    {
        public int walletAmount = 0; // Change this to public

        private Point playerPosition;
        private string[] mapLines;
        private string characterName;
        private List<Enemy> enemies = new List<Enemy>();

        // Character stats
        public string CharacterRace { get; private set; }
        public int CharacterAge { get; private set; }
        public int CharacterStrength { get; set; }
        public int CharacterDexterity { get; set; }
        public int CharacterIntelligence { get; private set; }
        public int CharacterWisdom { get; set; }
        public int CharacterCharisma { get; private set; }
        public int PlayerLevel { get; private set; } = 1;
        public int ExperiencePoints { get; private set; } = 0;

        // Viewport size
        private const int viewportWidth = 40;
        private const int viewportHeight = 20;

        // Combat variables
        private Enemy currentEnemy;
        private int playerHealth;
        private string equippedWeapon;

        public Form1(string characterName)
        {
            this.characterName = characterName;
            InitializeComponent();
            SetDoubleBuffered(mapPanel);
            SetDoubleBuffered(inventoryPanel);
            SetDoubleBuffered(playerStatsPanel);
            LoadCharacterData();
            UpdateWalletDisplay();
            InitializeSkillTree();
            InitializePlayerStats();

            this.KeyPreview = true; // Allow the form to capture key presses
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
        }

        private void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        private void LoadCharacterData()
        {
            string filePath = $@"E:\Projectvara\CharacterSaves\{characterName}.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();

                            switch (key)
                            {
                                case "Name":
                                    characterName = value;
                                    break;
                                case "Race":
                                    CharacterRace = value;
                                    break;
                                case "Age":
                                    CharacterAge = int.Parse(value);
                                    break;
                                case "Strength":
                                    CharacterStrength = int.Parse(value);
                                    break;
                                case "Dexterity":
                                    CharacterDexterity = int.Parse(value);
                                    break;
                                case "Intelligence":
                                    CharacterIntelligence = int.Parse(value);
                                    break;
                                case "Wisdom":
                                    CharacterWisdom = int.Parse(value);
                                    break;
                                case "Charisma":
                                    CharacterCharisma = int.Parse(value);
                                    break;
                                case "Level":
                                    PlayerLevel = int.Parse(value);
                                    break;
                                case "Experience":
                                    ExperiencePoints = int.Parse(value);
                                    break;
                            }
                        }
                    }
                }
                playerHealth = 100; // Base health for player
            }
            else
            {
                MessageBox.Show($"Failed to load character data: {filePath} not found");
            }
        }

        public void SaveCharacterData()
        {
            string filePath = $@"E:\Projectvara\CharacterSaves\{characterName}.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Name: {characterName}");
                writer.WriteLine($"Race: {CharacterRace}");
                writer.WriteLine($"Age: {CharacterAge}");
                writer.WriteLine($"Strength: {CharacterStrength}");
                writer.WriteLine($"Dexterity: {CharacterDexterity}");
                writer.WriteLine($"Intelligence: {CharacterIntelligence}");
                writer.WriteLine($"Wisdom: {CharacterWisdom}");
                writer.WriteLine($"Charisma: {CharacterCharisma}");
                writer.WriteLine($"Level: {PlayerLevel}");
                writer.WriteLine($"Experience: {ExperiencePoints}");
            }
        }

        public void StartServer(int port, string playerSheet)
        {
            // Create a TcpListener to start listening for incoming connection requests.
            TcpListener server = new TcpListener(IPAddress.Any, port);
            server.Start();

            // Use a new thread to handle incoming connection requests.
            Thread serverThread = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        TcpClient client = server.AcceptTcpClient();
                        // Handle the connected client in a new thread.
                        Thread clientThread = new Thread(() => HandleClient(client));
                        clientThread.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Server encountered an error: {ex.Message}");
                }
                finally
                {
                    server.Stop();
                }
            });

            serverThread.IsBackground = true; // Ensure the thread will not prevent the application from exiting.
            serverThread.Start();
        }

        private void HandleClient(TcpClient client)
        {
            // Handle the connected client here.
            // For now, we just close the connection.
            client.Close();
        }

        private void LoadDungeon()
        {
            string directoryPath = @"E:\Projectvara\Generation engines\Vara_engine\Generated_files\Maps";
            string[] dungeonFiles = Directory.GetFiles(directoryPath, "dungeon_map*.txt");
            Random random = new Random();
            string filePath = dungeonFiles[random.Next(dungeonFiles.Length)];

            if (File.Exists(filePath))
            {
                mapLines = File.ReadAllLines(filePath);
                playerPosition = FindEmptyPosition(); // Find and set player position
                PlaceEnemies(); // Place enemies in the dungeon
                mapPanel.Invalidate(); // Trigger the Paint event to redraw the map and player
            }
            else
            {
                MessageBox.Show($"Failed to load dungeon: {filePath} not found");
            }
        }

        private void PlaceEnemies()
        {
            enemies.Clear();
            Random random = new Random();
            int numberOfEnemies = random.Next(5, 10); // Random number of enemies

            for (int i = 0; i < numberOfEnemies; i++)
            {
                int health = random.Next(100, 150) + (PlayerLevel * 10);
                int range = random.Next(1, 5);
                int damage = random.Next(5, 15);
                enemies.Add(new Enemy(FindEmptyPosition(), health, range, damage));
            }
        }

        private void MapPanel_Paint(object sender, PaintEventArgs e)
        {
            if (mapLines == null)
            {
                return;
            }

            // Calculate the viewport origin to center the player
            int viewportX = Math.Max(0, playerPosition.X - viewportWidth / 2);
            int viewportY = Math.Max(0, playerPosition.Y - viewportHeight / 2);

            // Ensure the viewport doesn't go out of bounds
            viewportX = Math.Min(viewportX, mapLines[0].Length - viewportWidth);
            viewportY = Math.Min(viewportY, mapLines.Length - viewportHeight);

            using (Font font = new Font("Courier New", 12))
            {
                for (int y = 0; y < viewportHeight; y++)
                {
                    for (int x = 0; x < viewportWidth; x++)
                    {
                        int mapX = viewportX + x;
                        int mapY = viewportY + y;

                        if (mapX < mapLines[0].Length && mapY < mapLines.Length)
                        {
                            char tile = mapLines[mapY][mapX];
                            e.Graphics.DrawString(tile.ToString(), font, Brushes.Black, new PointF(x * 10, y * 10));
                        }
                    }
                }

                // Draw the player
                int playerViewportX = playerPosition.X - viewportX;
                int playerViewportY = playerPosition.Y - viewportY;
                e.Graphics.DrawString("P", font, Brushes.Red, new PointF(playerViewportX * 10, playerViewportY * 10));

                // Draw enemies
                foreach (var enemy in enemies)
                {
                    int enemyViewportX = enemy.Position.X - viewportX;
                    int enemyViewportY = enemy.Position.Y - viewportY;
                    e.Graphics.DrawString("E", font, Brushes.Green, new PointF(enemyViewportX * 10, enemyViewportY * 10));
                }
            }
        }

        private Point FindEmptyPosition()
        {
            Random random = new Random();
            int x, y;
            do
            {
                x = random.Next(0, mapLines[0].Length);
                y = random.Next(0, mapLines.Length);
            } while (mapLines[y][x] == '#' || mapLines[y][x] == 'P' || enemies.Exists(e => e.Position.X == x && e.Position.Y == y));

            return new Point(x, y);
        }

        private void MovePlayer(int dx, int dy)
        {
            int newX = playerPosition.X + dx;
            int newY = playerPosition.Y + dy;

            if (newX >= 0 && newX < mapLines[0].Length && newY >= 0 && newY < mapLines.Length)
            {
                if (mapLines[newY][newX] != '#')
                {
                    playerPosition = new Point(newX, newY);
                    MoveEnemies(); // Move enemies when player moves
                    mapPanel.Invalidate(); // Redraw the map panel to update player position

                    // Check for interactions
                    HandleInteractions(newX, newY);
                }
            }
        }

        private void MoveEnemies()
        {
            foreach (var enemy in enemies)
            {
                enemy.MoveRandomly(mapLines);
            }
        }

        private void HandleInteractions(int x, int y)
        {
            // Check for enemy interactions
            foreach (var enemy in enemies)
            {
                if (Math.Abs(enemy.Position.X - playerPosition.X) <= enemy.AttackRange &&
                    Math.Abs(enemy.Position.Y - playerPosition.Y) <= enemy.AttackRange)
                {
                    // Initiate combat
                    currentEnemy = enemy;
                    InitiateCombat();
                    break;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    MovePlayer(0, -1);
                    break;
                case Keys.S:
                    MovePlayer(0, 1);
                    break;
                case Keys.A:
                    MovePlayer(-1, 0);
                    break;
                case Keys.D:
                    MovePlayer(1, 0);
                    break;
            }
        }

        private void InventoryListBox_DoubleClick(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedItem != null)
            {
                string selectedItem = inventoryListBox.SelectedItem.ToString();
                equippedWeapon = selectedItem;
                equippedWeaponLabel.Text = $"Weapon: {selectedItem}";
            }
        }

        public void UpdateWalletDisplay()
        {
            walletLabel.Text = $"Wallet: ${walletAmount}";
        }

        private void InitializeSkillTree()
        {
            // Placeholder for skill tree initialization
        }

        public void UpdatePlayerStats()
        {
            InitializePlayerStats();
        }

        private void InitializePlayerStats()
        {
            playerStatsPanel.Controls.Clear();

            Label roleLabel = new Label
            {
                Text = $"Role: {CharacterRace}",
                Location = new Point(10, 10),
                Size = new Size(200, 20)
            };

            Label healthLabel = new Label
            {
                Text = $"Health: {CharacterStrength * 10}", // Example calculation
                Location = new Point(10, 40),
                Size = new Size(200, 20)
            };

            Label dexterityLabel = new Label
            {
                Text = $"Dexterity: {CharacterDexterity}",
                Location = new Point(10, 70),
                Size = new Size(200, 20)
            };

            Label intelligenceLabel = new Label
            {
                Text = $"Intelligence: {CharacterIntelligence}",
                Location = new Point(10, 100),
                Size = new Size(200, 20)
            };

            Label wisdomLabel = new Label
            {
                Text = $"Wisdom: {CharacterWisdom}",
                Location = new Point(10, 130),
                Size = new Size(200, 20)
            };

            Label charismaLabel = new Label
            {
                Text = $"Charisma: {CharacterCharisma}",
                Location = new Point(10, 160),
                Size = new Size(200, 20)
            };

            Label strengthLabel = new Label
            {
                Text = $"Strength: {CharacterStrength}",
                Location = new Point(10, 190),
                Size = new Size(200, 20)
            };

            Label ageLabel = new Label
            {
                Text = $"Age: {CharacterAge}",
                Location = new Point(10, 220),
                Size = new Size(200, 20)
            };

            playerStatsPanel.Controls.Add(roleLabel);
            playerStatsPanel.Controls.Add(healthLabel);
            playerStatsPanel.Controls.Add(dexterityLabel);
            playerStatsPanel.Controls.Add(intelligenceLabel);
            playerStatsPanel.Controls.Add(wisdomLabel);
            playerStatsPanel.Controls.Add(charismaLabel);
            playerStatsPanel.Controls.Add(strengthLabel);
            playerStatsPanel.Controls.Add(ageLabel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Placeholder for Form1 load event logic
        }

        private void InventoryScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            inventoryPanel.AutoScrollPosition = new Point(0, e.NewValue);
        }

        private void SkillsScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // Placeholder for skills scroll bar logic
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            // Placeholder for item button click logic
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            if (equippedWeapon == null)
            {
                MessageBox.Show("No weapon equipped!");
                return;
            }

            if (currentEnemy == null)
            {
                MessageBox.Show("No enemy to fight!");
                return;
            }

            // Parse damage and accuracy from the equipped weapon
            int damage = ParseStatFromEquippedWeapon("Damage");
            int accuracy = ParseStatFromEquippedWeapon("Accuracy");

            Random random = new Random();
            if (random.Next(100) < accuracy)
            {
                currentEnemy.Health -= damage;
                combatLogTextBox.AppendText($"You attacked the enemy and dealt {damage} damage!\n");

                if (currentEnemy.Health <= 0)
                {
                    combatLogTextBox.AppendText("You defeated the enemy!\n");
                    enemies.Remove(currentEnemy);
                    EndCombat();
                    GainExperience();
                }
                else
                {
                    EnemyAttack();
                }
            }
            else
            {
                combatLogTextBox.AppendText("You missed!\n");
                EnemyAttack();
            }
        }

        private int ParseStatFromEquippedWeapon(string statName)
        {
            // Example implementation for parsing weapon stats
            // Placeholder implementation; replace with actual logic
            return 10; // Replace with actual stat value from the equipped weapon
        }

        private void EnemyAttack()
        {
            int enemyDamage = currentEnemy.Damage;
            playerHealth -= enemyDamage;
            combatLogTextBox.AppendText($"Enemy attacked you and dealt {enemyDamage} damage!\n");

            if (playerHealth <= 0)
            {
                combatLogTextBox.AppendText("You were defeated!\n");
                // Handle player defeat (e.g., game over or respawn)
            }

            healthBar.Value = Math.Max(0, playerHealth); // Update health bar dynamically
        }

        private void GainExperience()
        {
            int experienceGained = 50; // Example experience gain
            ExperiencePoints += experienceGained;
            combatLogTextBox.AppendText($"You gained {experienceGained} experience points!\n");

            if (ExperiencePoints >= PlayerLevel * 100) // Example level-up condition
            {
                ExperiencePoints -= PlayerLevel * 100;
                PlayerLevel++;
                combatLogTextBox.AppendText("You leveled up!\n");
                SaveCharacterData();
                InitializePlayerStats();
            }
        }

        private void EndCombat()
        {
            fightButton.Visible = false;
            fleeButton.Visible = false;
            itemButton.Visible = true;
            bargainButton.Visible = true;
            mapPanel.Invalidate(); // Redraw the map without combat UI
        }

        private void EnterDungeonButton_Click(object sender, EventArgs e)
        {
            combatLogTextBox.AppendText("Entering dungeon...\n");
            LoadDungeon();
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            combatLogTextBox.AppendText("Opening shop...\n");
            // Logic for opening shop can be implemented here
        }

        private void ReceiveQuestButton_Click(object sender, EventArgs e)
        {
            combatLogTextBox.AppendText("Receiving quest...\n");
            // Logic for receiving quest can be implemented here
        }

        private void walletLabel_Click(object sender, EventArgs e)
        {
            // Placeholder for wallet label click logic
        }

        private void InitiateCombat()
        {
            combatLogTextBox.AppendText("Combat initiated with an enemy!\n");
            fightButton.Visible = true;
            fleeButton.Visible = true;
            itemButton.Visible = false;
            bargainButton.Visible = false;

            healthBar.Visible = true;
            healthBar.Maximum = 100; // Example calculation for maximum health
            healthBar.Value = Math.Max(0, playerHealth);

            mapPanel.Invalidate(); // Redraw the map with combat UI
        }

        private void skillsButton_Click(object sender, EventArgs e)
        {
            SkillTreeForm skillTreeForm = new SkillTreeForm(this);
            skillTreeForm.ShowDialog();
        }

        private void playerStatsPanel_Paint(object sender, PaintEventArgs e)
        {
            // You can add code here to handle the painting of the player stats panel if needed
        }

        private void chestSlot_Click(object sender, EventArgs e)
        {

        }

        private void armsSlot_Click(object sender, EventArgs e)
        {

        }

        private void InventoryListBox_MouseHover(object sender, EventArgs e)
        {
            Point mousePosition = inventoryListBox.PointToClient(Control.MousePosition);
            int index = inventoryListBox.IndexFromPoint(mousePosition);
            if (index >= 0 && index < inventoryListBox.Items.Count)
            {
                string selectedItem = inventoryListBox.Items[index].ToString();
                //gunToolTip.SetToolTip(inventoryListBox, selectedItem); // Display selected item as tooltip
            }
        }

        private void ReturnToMainMenuButton_Click(object sender, EventArgs e)
        {
            // Save character data before returning to main menu
            SaveCharacterData();

            // Return to main menu
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
