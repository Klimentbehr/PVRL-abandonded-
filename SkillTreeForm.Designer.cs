namespace PVRL
{
    partial class SkillTreeForm
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel skillTreePanel;
        private Button buySkillButton;

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
            skillTreePanel = new FlowLayoutPanel();
            buySkillButton = new Button();
            SuspendLayout();
            // 
            // skillTreePanel
            // 
            skillTreePanel.AutoScroll = true;
            skillTreePanel.BackColor = SystemColors.ControlLight;
            skillTreePanel.BorderStyle = BorderStyle.FixedSingle;
            skillTreePanel.Location = new Point(12, 12);
            skillTreePanel.Name = "skillTreePanel";
            skillTreePanel.Size = new Size(360, 360);
            skillTreePanel.TabIndex = 0;
            // 
            // buySkillButton
            // 
            buySkillButton.Location = new Point(12, 378);
            buySkillButton.Name = "buySkillButton";
            buySkillButton.Size = new Size(360, 30);
            buySkillButton.TabIndex = 1;
            buySkillButton.Text = "Buy Skill";
            buySkillButton.UseVisualStyleBackColor = true;
            buySkillButton.Click += BuySkillButton_Click;
            // 
            // SkillTreeForm
            // 
            ClientSize = new Size(380, 420);
            Controls.Add(buySkillButton);
            Controls.Add(skillTreePanel);
            Name = "SkillTreeForm";
            Text = "Skill Tree";
            Load += SkillTreeForm_Load;
            ResumeLayout(false);
        }
    }
}
