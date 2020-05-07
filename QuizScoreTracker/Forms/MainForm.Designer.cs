namespace QuizScoreTracker.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoreTrackerTitle = new System.Windows.Forms.Label();
            this.AddTeam = new System.Windows.Forms.Button();
            this.TeamsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TeamsLabel = new System.Windows.Forms.Label();
            this.Teams = new System.Windows.Forms.Label();
            this.Totals = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.AboutMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuNew,
            this.FileMenuSeparator,
            this.FileMenuExit});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // FileMenuNew
            // 
            this.FileMenuNew.Name = "FileMenuNew";
            this.FileMenuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileMenuNew.Size = new System.Drawing.Size(168, 22);
            this.FileMenuNew.Text = "&New Quiz";
            this.FileMenuNew.Click += new System.EventHandler(this.FileMenuNew_Click);
            // 
            // FileMenuSeparator
            // 
            this.FileMenuSeparator.Name = "FileMenuSeparator";
            this.FileMenuSeparator.Size = new System.Drawing.Size(165, 6);
            // 
            // FileMenuExit
            // 
            this.FileMenuExit.Name = "FileMenuExit";
            this.FileMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.FileMenuExit.Size = new System.Drawing.Size(168, 22);
            this.FileMenuExit.Text = "E&xit";
            this.FileMenuExit.Click += new System.EventHandler(this.FileMenuExit_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMenuSettings});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditMenuItem.Text = "&Edit";
            // 
            // EditMenuSettings
            // 
            this.EditMenuSettings.Name = "EditMenuSettings";
            this.EditMenuSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.EditMenuSettings.Size = new System.Drawing.Size(156, 22);
            this.EditMenuSettings.Text = "&Settings";
            this.EditMenuSettings.Click += new System.EventHandler(this.EditMenuSettings_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutMenuItem.Text = "&About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // ScoreTrackerTitle
            // 
            this.ScoreTrackerTitle.AutoSize = true;
            this.ScoreTrackerTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTrackerTitle.Location = new System.Drawing.Point(12, 24);
            this.ScoreTrackerTitle.Name = "ScoreTrackerTitle";
            this.ScoreTrackerTitle.Size = new System.Drawing.Size(426, 64);
            this.ScoreTrackerTitle.TabIndex = 2;
            this.ScoreTrackerTitle.Text = "Score Tracker";
            // 
            // AddTeam
            // 
            this.AddTeam.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeam.Location = new System.Drawing.Point(23, 91);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(150, 39);
            this.AddTeam.TabIndex = 3;
            this.AddTeam.Text = "Add Team";
            this.AddTeam.UseVisualStyleBackColor = true;
            this.AddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // TeamsFlowPanel
            // 
            this.TeamsFlowPanel.AutoScroll = true;
            this.TeamsFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TeamsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TeamsFlowPanel.Location = new System.Drawing.Point(22, 136);
            this.TeamsFlowPanel.Name = "TeamsFlowPanel";
            this.TeamsFlowPanel.Size = new System.Drawing.Size(750, 638);
            this.TeamsFlowPanel.TabIndex = 4;
            this.TeamsFlowPanel.WrapContents = false;
            this.TeamsFlowPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.TeamsFlowPanel_ControlsChanged);
            this.TeamsFlowPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.TeamsFlowPanel_ControlsChanged);
            // 
            // TeamsLabel
            // 
            this.TeamsLabel.AutoSize = true;
            this.TeamsLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamsLabel.Location = new System.Drawing.Point(612, 36);
            this.TeamsLabel.Name = "TeamsLabel";
            this.TeamsLabel.Size = new System.Drawing.Size(78, 21);
            this.TeamsLabel.TabIndex = 5;
            this.TeamsLabel.Text = "Teams: ";
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.Teams.Location = new System.Drawing.Point(696, 36);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(21, 21);
            this.Teams.TabIndex = 6;
            this.Teams.Text = "0";
            // 
            // Totals
            // 
            this.Totals.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totals.Location = new System.Drawing.Point(179, 91);
            this.Totals.Name = "Totals";
            this.Totals.Size = new System.Drawing.Size(150, 39);
            this.Totals.TabIndex = 7;
            this.Totals.Text = "Totals";
            this.Totals.UseVisualStyleBackColor = true;
            this.Totals.Click += new System.EventHandler(this.Totals_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 813);
            this.Controls.Add(this.Totals);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.TeamsLabel);
            this.Controls.Add(this.TeamsFlowPanel);
            this.Controls.Add(this.AddTeam);
            this.Controls.Add(this.ScoreTrackerTitle);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Score Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileMenuNew;
        private System.Windows.Forms.ToolStripSeparator FileMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem FileMenuExit;
        private System.Windows.Forms.Label ScoreTrackerTitle;
        private System.Windows.Forms.Button AddTeam;
        private System.Windows.Forms.FlowLayoutPanel TeamsFlowPanel;
        private System.Windows.Forms.Label TeamsLabel;
        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.Button Totals;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuSettings;
    }
}

