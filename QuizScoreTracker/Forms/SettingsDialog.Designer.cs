namespace QuizScoreTracker.Forms
{
    partial class SettingsDialog
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
            this.GeneralSettings = new System.Windows.Forms.GroupBox();
            this.ShowNumericalScore = new System.Windows.Forms.CheckBox();
            this.UpdateSettings = new System.Windows.Forms.GroupBox();
            this.LastCheck = new System.Windows.Forms.Label();
            this.UpdateChannelLabel = new System.Windows.Forms.Label();
            this.UpdateChannel = new System.Windows.Forms.ComboBox();
            this.CheckNow = new System.Windows.Forms.Button();
            this.CheckFrequency = new System.Windows.Forms.ComboBox();
            this.CheckOnStartup = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ScorePerQuestion = new System.Windows.Forms.ComboBox();
            this.GeneralSettings.SuspendLayout();
            this.UpdateSettings.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralSettings
            // 
            this.GeneralSettings.Controls.Add(this.ScorePerQuestion);
            this.GeneralSettings.Controls.Add(this.ShowNumericalScore);
            this.GeneralSettings.Location = new System.Drawing.Point(3, 3);
            this.GeneralSettings.Name = "GeneralSettings";
            this.GeneralSettings.Size = new System.Drawing.Size(429, 100);
            this.GeneralSettings.TabIndex = 0;
            this.GeneralSettings.TabStop = false;
            this.GeneralSettings.Text = "General";
            // 
            // ShowNumericalScore
            // 
            this.ShowNumericalScore.AutoSize = true;
            this.ShowNumericalScore.Location = new System.Drawing.Point(9, 17);
            this.ShowNumericalScore.Name = "ShowNumericalScore";
            this.ShowNumericalScore.Size = new System.Drawing.Size(292, 15);
            this.ShowNumericalScore.TabIndex = 0;
            this.ShowNumericalScore.Text = "Show a numerical value for the score on the main screen";
            this.ShowNumericalScore.UseVisualStyleBackColor = true;
            this.ShowNumericalScore.CheckedChanged += new System.EventHandler(this.ShowNumericalScore_CheckedChanged);
            // 
            // UpdateSettings
            // 
            this.UpdateSettings.Controls.Add(this.LastCheck);
            this.UpdateSettings.Controls.Add(this.UpdateChannelLabel);
            this.UpdateSettings.Controls.Add(this.UpdateChannel);
            this.UpdateSettings.Controls.Add(this.CheckNow);
            this.UpdateSettings.Controls.Add(this.CheckFrequency);
            this.UpdateSettings.Controls.Add(this.CheckOnStartup);
            this.UpdateSettings.Location = new System.Drawing.Point(3, 109);
            this.UpdateSettings.Name = "UpdateSettings";
            this.UpdateSettings.Size = new System.Drawing.Size(429, 174);
            this.UpdateSettings.TabIndex = 1;
            this.UpdateSettings.TabStop = false;
            this.UpdateSettings.Text = "Updates";
            // 
            // LastCheck
            // 
            this.LastCheck.AutoSize = true;
            this.LastCheck.Location = new System.Drawing.Point(6, 89);
            this.LastCheck.Name = "LastCheck";
            this.LastCheck.Size = new System.Drawing.Size(134, 11);
            this.LastCheck.TabIndex = 5;
            this.LastCheck.Text = "Last Checked: 1970-01-01";
            // 
            // UpdateChannelLabel
            // 
            this.UpdateChannelLabel.AutoSize = true;
            this.UpdateChannelLabel.Location = new System.Drawing.Point(6, 135);
            this.UpdateChannelLabel.Name = "UpdateChannelLabel";
            this.UpdateChannelLabel.Size = new System.Drawing.Size(80, 11);
            this.UpdateChannelLabel.TabIndex = 4;
            this.UpdateChannelLabel.Text = "Update Channel:";
            // 
            // UpdateChannel
            // 
            this.UpdateChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateChannel.FormattingEnabled = true;
            this.UpdateChannel.Location = new System.Drawing.Point(6, 149);
            this.UpdateChannel.Name = "UpdateChannel";
            this.UpdateChannel.Size = new System.Drawing.Size(134, 19);
            this.UpdateChannel.TabIndex = 3;
            this.UpdateChannel.SelectedIndexChanged += new System.EventHandler(this.UpdateChannel_SelectedIndexChanged);
            // 
            // CheckNow
            // 
            this.CheckNow.Location = new System.Drawing.Point(6, 63);
            this.CheckNow.Name = "CheckNow";
            this.CheckNow.Size = new System.Drawing.Size(134, 23);
            this.CheckNow.TabIndex = 2;
            this.CheckNow.Text = "Check now";
            this.CheckNow.UseVisualStyleBackColor = true;
            this.CheckNow.Click += new System.EventHandler(this.CheckNow_Click);
            // 
            // CheckFrequency
            // 
            this.CheckFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckFrequency.FormattingEnabled = true;
            this.CheckFrequency.Items.AddRange(new object[] {
            "Every day",
            "Every 7 days",
            "Every 14 days",
            "Every 30 days"});
            this.CheckFrequency.Location = new System.Drawing.Point(6, 38);
            this.CheckFrequency.Name = "CheckFrequency";
            this.CheckFrequency.Size = new System.Drawing.Size(134, 19);
            this.CheckFrequency.TabIndex = 1;
            this.CheckFrequency.SelectedIndexChanged += new System.EventHandler(this.CheckFrequency_SelectedIndexChanged);
            // 
            // CheckOnStartup
            // 
            this.CheckOnStartup.AutoSize = true;
            this.CheckOnStartup.Location = new System.Drawing.Point(6, 17);
            this.CheckOnStartup.Name = "CheckOnStartup";
            this.CheckOnStartup.Size = new System.Drawing.Size(157, 15);
            this.CheckOnStartup.TabIndex = 0;
            this.CheckOnStartup.Text = "Check for updates at startup";
            this.CheckOnStartup.UseVisualStyleBackColor = true;
            this.CheckOnStartup.CheckedChanged += new System.EventHandler(this.CheckOnStartup_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-8, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 2);
            this.panel1.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(346, 422);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(254, 422);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(86, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GeneralSettings);
            this.flowLayoutPanel1.Controls.Add(this.UpdateSettings);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(444, 406);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // ScorePerQuestion
            // 
            this.ScorePerQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScorePerQuestion.FormattingEnabled = true;
            this.ScorePerQuestion.Items.AddRange(new object[] {
            "1 point per question",
            "2 points per question",
            "3 points per question",
            "4 points per question",
            "5 points per question"});
            this.ScorePerQuestion.Location = new System.Drawing.Point(6, 38);
            this.ScorePerQuestion.Name = "ScorePerQuestion";
            this.ScorePerQuestion.Size = new System.Drawing.Size(134, 19);
            this.ScorePerQuestion.TabIndex = 2;
            this.ScorePerQuestion.SelectedIndexChanged += new System.EventHandler(this.ScorePerQuestion_SelectedIndexChanged);
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(444, 457);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.GeneralSettings.ResumeLayout(false);
            this.GeneralSettings.PerformLayout();
            this.UpdateSettings.ResumeLayout(false);
            this.UpdateSettings.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GeneralSettings;
        private System.Windows.Forms.GroupBox UpdateSettings;
        private System.Windows.Forms.Label UpdateChannelLabel;
        private System.Windows.Forms.ComboBox UpdateChannel;
        private System.Windows.Forms.Button CheckNow;
        private System.Windows.Forms.ComboBox CheckFrequency;
        private System.Windows.Forms.CheckBox CheckOnStartup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LastCheck;
        private System.Windows.Forms.CheckBox ShowNumericalScore;
        private System.Windows.Forms.ComboBox ScorePerQuestion;
    }
}