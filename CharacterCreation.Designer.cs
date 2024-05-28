namespace PVRL
{
    partial class CharacterCreation
    {
        private System.ComponentModel.IContainer components = null;
        private Label titleLabel;
        private Label raceLabel;
        private ComboBox raceComboBox;
        private Label ageLabel;
        private NumericUpDown ageNumericUpDown;
        private Label pointsLabel;
        private Label pointsLeftLabel;
        private Button confirmButton;
        private Button backButton;
        private Label nameLabel;
        private TextBox nameTextBox;

        // Stat labels and numeric up-down controls
        private Label strengthLabel;
        private NumericUpDown strengthNumericUpDown;
        private Label dexterityLabel;
        private NumericUpDown dexterityNumericUpDown;
        private Label intelligenceLabel;
        private NumericUpDown intelligenceNumericUpDown;
        private Label wisdomLabel;
        private NumericUpDown wisdomNumericUpDown;
        private Label charismaLabel;
        private NumericUpDown charismaNumericUpDown;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreation));
            titleLabel = new Label();
            raceLabel = new Label();
            raceComboBox = new ComboBox();
            ageLabel = new Label();
            ageNumericUpDown = new NumericUpDown();
            pointsLabel = new Label();
            pointsLeftLabel = new Label();
            confirmButton = new Button();
            backButton = new Button();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            strengthLabel = new Label();
            strengthNumericUpDown = new NumericUpDown();
            dexterityLabel = new Label();
            dexterityNumericUpDown = new NumericUpDown();
            intelligenceLabel = new Label();
            intelligenceNumericUpDown = new NumericUpDown();
            wisdomLabel = new Label();
            wisdomNumericUpDown = new NumericUpDown();
            charismaLabel = new Label();
            charismaNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dexterityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intelligenceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wisdomNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)charismaNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ButtonFace;
            titleLabel.Location = new Point(150, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(299, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Character Creation";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.BackColor = Color.Transparent;
            raceLabel.ForeColor = SystemColors.ButtonFace;
            raceLabel.Location = new Point(50, 120);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(35, 15);
            raceLabel.TabIndex = 1;
            raceLabel.Text = "Race:";
            // 
            // raceComboBox
            // 
            raceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            raceComboBox.FormattingEnabled = true;
            raceComboBox.Items.AddRange(new object[] { "Human (Caucasian)", "Human (African)", "Human (Asian)", "Human (Hispanic)" });
            raceComboBox.Location = new Point(150, 117);
            raceComboBox.Name = "raceComboBox";
            raceComboBox.Size = new Size(200, 23);
            raceComboBox.TabIndex = 2;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.ForeColor = SystemColors.ButtonFace;
            ageLabel.Location = new Point(50, 160);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(31, 15);
            ageLabel.TabIndex = 3;
            ageLabel.Text = "Age:";
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(150, 158);
            ageNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            ageNumericUpDown.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(50, 23);
            ageNumericUpDown.TabIndex = 4;
            ageNumericUpDown.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.BackColor = Color.Transparent;
            pointsLabel.ForeColor = SystemColors.ButtonFace;
            pointsLabel.Location = new Point(50, 200);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(43, 15);
            pointsLabel.TabIndex = 5;
            pointsLabel.Text = "Points:";
            // 
            // pointsLeftLabel
            // 
            pointsLeftLabel.AutoSize = true;
            pointsLeftLabel.Location = new Point(150, 200);
            pointsLeftLabel.Name = "pointsLeftLabel";
            pointsLeftLabel.Size = new Size(19, 15);
            pointsLeftLabel.TabIndex = 6;
            pointsLeftLabel.Text = "10";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(150, 450);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(100, 30);
            confirmButton.TabIndex = 17;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(270, 450);
            backButton.Name = "backButton";
            backButton.Size = new Size(100, 30);
            backButton.TabIndex = 18;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += BackButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.ForeColor = SystemColors.ButtonFace;
            nameLabel.Location = new Point(50, 80);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(150, 77);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 23);
            nameTextBox.TabIndex = 20;
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.BackColor = Color.Transparent;
            strengthLabel.ForeColor = SystemColors.ButtonFace;
            strengthLabel.Location = new Point(50, 240);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(55, 15);
            strengthLabel.TabIndex = 7;
            strengthLabel.Text = "Strength:";
            // 
            // strengthNumericUpDown
            // 
            strengthNumericUpDown.Location = new Point(150, 238);
            strengthNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            strengthNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            strengthNumericUpDown.Name = "strengthNumericUpDown";
            strengthNumericUpDown.Size = new Size(50, 23);
            strengthNumericUpDown.TabIndex = 8;
            strengthNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            strengthNumericUpDown.ValueChanged += StatNumericUpDown_ValueChanged;
            // 
            // dexterityLabel
            // 
            dexterityLabel.AutoSize = true;
            dexterityLabel.BackColor = Color.Transparent;
            dexterityLabel.ForeColor = SystemColors.ButtonFace;
            dexterityLabel.Location = new Point(50, 280);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new Size(57, 15);
            dexterityLabel.TabIndex = 9;
            dexterityLabel.Text = "Dexterity:";
            // 
            // dexterityNumericUpDown
            // 
            dexterityNumericUpDown.Location = new Point(150, 278);
            dexterityNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            dexterityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            dexterityNumericUpDown.Name = "dexterityNumericUpDown";
            dexterityNumericUpDown.Size = new Size(50, 23);
            dexterityNumericUpDown.TabIndex = 10;
            dexterityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            dexterityNumericUpDown.ValueChanged += StatNumericUpDown_ValueChanged;
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.BackColor = Color.Transparent;
            intelligenceLabel.ForeColor = SystemColors.ButtonFace;
            intelligenceLabel.Location = new Point(50, 320);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(71, 15);
            intelligenceLabel.TabIndex = 11;
            intelligenceLabel.Text = "Intelligence:";
            // 
            // intelligenceNumericUpDown
            // 
            intelligenceNumericUpDown.Location = new Point(150, 318);
            intelligenceNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            intelligenceNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            intelligenceNumericUpDown.Name = "intelligenceNumericUpDown";
            intelligenceNumericUpDown.Size = new Size(50, 23);
            intelligenceNumericUpDown.TabIndex = 12;
            intelligenceNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            intelligenceNumericUpDown.ValueChanged += StatNumericUpDown_ValueChanged;
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.BackColor = Color.Transparent;
            wisdomLabel.ForeColor = SystemColors.ButtonFace;
            wisdomLabel.Location = new Point(50, 360);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new Size(54, 15);
            wisdomLabel.TabIndex = 13;
            wisdomLabel.Text = "Wisdom:";
            // 
            // wisdomNumericUpDown
            // 
            wisdomNumericUpDown.Location = new Point(150, 358);
            wisdomNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            wisdomNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            wisdomNumericUpDown.Name = "wisdomNumericUpDown";
            wisdomNumericUpDown.Size = new Size(50, 23);
            wisdomNumericUpDown.TabIndex = 14;
            wisdomNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            wisdomNumericUpDown.ValueChanged += StatNumericUpDown_ValueChanged;
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.BackColor = Color.Transparent;
            charismaLabel.ForeColor = SystemColors.ButtonFace;
            charismaLabel.Location = new Point(50, 400);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new Size(60, 15);
            charismaLabel.TabIndex = 15;
            charismaLabel.Text = "Charisma:";
            // 
            // charismaNumericUpDown
            // 
            charismaNumericUpDown.Location = new Point(150, 398);
            charismaNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            charismaNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            charismaNumericUpDown.Name = "charismaNumericUpDown";
            charismaNumericUpDown.Size = new Size(50, 23);
            charismaNumericUpDown.TabIndex = 16;
            charismaNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            charismaNumericUpDown.ValueChanged += StatNumericUpDown_ValueChanged;
            // 
            // CharacterCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 500);
            Controls.Add(backButton);
            Controls.Add(confirmButton);
            Controls.Add(charismaNumericUpDown);
            Controls.Add(charismaLabel);
            Controls.Add(wisdomNumericUpDown);
            Controls.Add(wisdomLabel);
            Controls.Add(intelligenceNumericUpDown);
            Controls.Add(intelligenceLabel);
            Controls.Add(dexterityNumericUpDown);
            Controls.Add(dexterityLabel);
            Controls.Add(strengthNumericUpDown);
            Controls.Add(strengthLabel);
            Controls.Add(pointsLeftLabel);
            Controls.Add(pointsLabel);
            Controls.Add(ageNumericUpDown);
            Controls.Add(ageLabel);
            Controls.Add(raceComboBox);
            Controls.Add(raceLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(titleLabel);
            Name = "CharacterCreation";
            Text = "Character Creation";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dexterityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)intelligenceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)wisdomNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)charismaNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
